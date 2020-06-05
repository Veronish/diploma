using System;
using System.Data.SQLite;
using System.Windows.Forms;


namespace HightApp
{
    public partial class JobAssignmentEditForm : Form
    {

        int technicID;
        int masterID;
        int executorID;
        int columnIndex;

        public JobAssignmentEditForm()
        {
            InitializeComponent();

            LoadUsers.LoadUser();
            LoadParts.Load();
            LoadTechnic.Load();

            foreach (Technic technic in StatClass.technics)
            {
                technicIdComboBox.Items.Add(technic.Mark);
            }
            foreach (User user in StatClass.users)
            {
                if (user.AssesLvl == 1) masterComboBox.Items.Add(user.Fio);
            }
            foreach (User user1 in StatClass.users)
            {
                if (user1.AssesLvl != 1) executorComboBox.Items.Add(user1.Fio);
            }

            foreach (JobAssignment jobAssignment in StatClass.jobAssignments)
            {
                if (jobAssignment.JobId == StatClass.jobToEditId)
                {
                    plaseTextBox.Text = jobAssignment.Plase;

                    dateAppointmentTextBox.Text = jobAssignment.DateAppointment;

                    foreach (Technic technic in StatClass.technics)
                    {
                        if (technic.TechnicId == jobAssignment.TechnicId)
                            technicIdComboBox.SelectedItem = technic.Mark;
                    }
                    foreach (User user in StatClass.users)
                    {
                        if (user.UserId == jobAssignment.MasterId & user.AssesLvl == 1) masterComboBox.SelectedItem = user.Fio;
                        if (user.UserId == jobAssignment.ExecutorId & user.AssesLvl != 1) executorComboBox.SelectedItem = user.Fio;

                    }
                }
            }
        }

        private void EditJobBtn_Click(object sender, EventArgs e)
        {
            foreach (Technic technic in StatClass.technics){
                if (technicIdComboBox.SelectedItem.ToString() == technic.Mark) technicID = technic.TechnicId;}
            foreach (User user in StatClass.users){
                if (masterComboBox.SelectedItem.ToString() == user.Fio) masterID = user.UserId;}
            foreach (User user1 in StatClass.users){
                if (executorComboBox.SelectedItem.ToString() == user1.Fio) executorID = user1.UserId;}

            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {
                try
                {
                    Connect.Open();

                    SQLiteCommand command = new SQLiteCommand($"UPDATE dbJobAssignments SET plase = '{plaseTextBox.Text}',technicId ={technicID}, dateAppointment='{dateAppointmentTextBox.Text}',master={masterID},executor={executorID} WHERE jobId = {StatClass.jobToEditId};", Connect);/*{StatClass.prtToEditId}*/

                    command.ExecuteNonQuery();
                    Connect.Close();

                    MessageBox.Show("Деталь обновлена");
                    LoadParts.Load();
                }
                catch (Exception exp){
                    MessageBox.Show("Ошибка при подключении к базе данных! Проверьте правильность пути к базе данных в файле ConnectPath.txt и перезапустите программу." + exp);
                }
                finally
                {
                    JobAssignmentForm jobAssignmentForm = new JobAssignmentForm();
                    jobAssignmentForm.Show();
                    this.Close();
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            JobAssignmentForm jobAssignmentForm = new JobAssignmentForm();
            jobAssignmentForm.Show();
            this.Close();
        }
    }
}
