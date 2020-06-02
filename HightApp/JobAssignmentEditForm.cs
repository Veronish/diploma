using System;
using System.Windows.Forms;
using System.Data.SQLite;


namespace HightApp
{
    public partial class JobAssignmentEditForm : Form
    {
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

            foreach( JobAssignment jobAssignment in StatClass.jobAssignments)
            {
                if(jobAssignment.JobId == StatClass.jobToEditId)
                {
                    plaseTextBox.Text = jobAssignment.Plase;
                   
                    dateAppointmentTextBox.Text = jobAssignment.DateAppointment;

                    foreach (Technic technic in StatClass.technics)
                    {
                        if(technic.TechnicId == jobAssignment.TechnicId)
                        technicIdComboBox.SelectedItem = technic.Mark;
                    }

                    foreach (User user in StatClass.users)
                    {
                        if(user.UserId == jobAssignment.MasterId & user.AssesLvl == 1) masterComboBox.SelectedItem = user.Fio;
                        if (user.UserId == jobAssignment.ExecutorId & user.AssesLvl != 1) executorComboBox.SelectedItem = user.Fio;

                    }
                }
            }


        }

        private void EditJobBtn_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {
                try
                {
                    Connect.Open();

                    SQLiteCommand command = new SQLiteCommand($"UPDATE dbJobAssignments SET plase = '{plaseTextBox.Text}',technicId ={technicIdComboBox.SelectedItem}, dateAppointment='{dateAppointmentTextBox.Text}',master={masterComboBox.SelectedItem},executor={executorComboBox.SelectedItem} WHERE jobId = {StatClass.jobToEditId};", Connect);/*{StatClass.prtToEditId}*/

                    command.ExecuteNonQuery();
                    Connect.Close();

                    MessageBox.Show("Деталь обновлена");
                    LoadParts.Load();

                    PartsListForm partsListForm = new PartsListForm();
                    partsListForm.Show();
                    this.Close();
                }

                catch (Exception exp)
                {

                    MessageBox.Show("Ошибка при подключении к базе данных! Проверьте правильность пути к базе данных в файле ConnectPath.txt и перезапустите программу." + exp);

                }
            }
            JobAssignmentForm jobAssignmentForm = new JobAssignmentForm();
            jobAssignmentForm.Show();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

            JobAssignmentForm jobAssignmentForm = new JobAssignmentForm();
            jobAssignmentForm.Show();
            this.Close();
        }
    }
}
