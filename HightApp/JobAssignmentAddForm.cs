using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Windows.Forms;

namespace HightApp
{
    public partial class JobAssignmentAddForm : Form
    {

        int technicID;
        int masterID;
        int executorID;

        public JobAssignmentAddForm()
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
        }


        public void AddJobBtn_Click(object sender, EventArgs e)
        {
            foreach (Technic technic in StatClass.technics)
            {
                if (technicIdComboBox.SelectedItem.ToString() == technic.Mark) technicID = technic.TechnicId;
                //technicIdComboBox.Items.Add(technic.Mark);
            }
            foreach (User user in StatClass.users)
            {
                if (masterComboBox.SelectedItem.ToString() == user.Fio) masterID = user.UserId;
            }
            foreach (User user1 in StatClass.users)
            {
                if (executorComboBox.SelectedItem.ToString() == user1.Fio) executorID = user1.UserId;
            }
            AddJob();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            JobAssignmentForm jobAssignmentForm = new JobAssignmentForm();
            jobAssignmentForm.Show();
            this.Close();
        }


        private void AddJob()
        {
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {
                try
                {
                    Connect.Open();
                    SQLiteCommand command = new SQLiteCommand($"INSERT INTO 'dbJobAssignments' ('plase', 'technicId', 'dateAppointment', 'master', 'executor') VALUES ('{plaseTextBox.Text}', {technicID}, '{dateAppointmentTextBox.Text}', {masterID}, {executorID});", Connect);

                    command.ExecuteNonQuery();
                    Connect.Close();

                    MessageBox.Show("Запись добавлена");
                    LoadUsers.LoadUser();

                    // this.DialogResult = DialogResult.OK;
                    JobAssignmentForm jobAssignmentForm = new JobAssignmentForm();
                    jobAssignmentForm.Show();
                    this.Close();
                }

                catch
                {
                    MessageBox.Show("Ошибка при подключении к базе данных! Проверьте правильность пути к базе данных в файле ConnectPath.txt и перезапустите программу.");
                }
            }
        }

    }
}
