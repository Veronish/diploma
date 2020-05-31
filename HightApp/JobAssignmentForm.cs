using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HightApp
{
    public partial class JobAssignmentForm : Form
    {
        List<JobAssignment> jobAssignments = new List<JobAssignment>();
        BindingSource bindingSource;
        public JobAssignmentForm()
        {
            InitializeComponent();
            JobAssignment jobAssignments = new JobAssignment();
            // jobAssignments.Technic.Model;
            LoadJob();
            DataGreedFill();
        }
        public void LoadJob()
        {
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {

                SQLiteCommand command = new SQLiteCommand("SELECT * FROM dbJobAssignments;", Connect);

                Connect.Open();

                SQLiteDataReader reader = command.ExecuteReader();

                foreach (DbDataRecord record in reader)
                {
                    JobAssignment jobAssignment = new JobAssignment();
                    jobAssignment.JobId = Int32.Parse(record["jobId"].ToString());
                    jobAssignment.Plase = record["plase"].ToString();
                    jobAssignment.TechnicId = Int32.Parse(record["technicId"].ToString());
                    jobAssignment.DateAppointment = record["dateAppointment"].ToString();
                    jobAssignment.MasterId = Int32.Parse(record["master"].ToString());
                    jobAssignment.ExecutorId = Int32.Parse(record["executor"].ToString());


                    jobAssignments.Add(jobAssignment);

                }
                Connect.Close();
            }

        }

        public void DataGreedFill()
        {
            dataGridView1.Rows.Clear();
            bindingSource = new BindingSource();
            bindingSource.DataSource = jobAssignments;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.AutoGenerateColumns = true;

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Дейтвительно удалить запись?\nЭто действие невозможно обратить", "Подтвердите действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
                {
                    try
                    {

                        SQLiteCommand command = new SQLiteCommand($"DELETE FROM dbJobAssignments WHERE  jobId = {Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString())};", Connect);
                        Connect.Open();
                        SQLiteDataReader reader = command.ExecuteReader();

                        //command.ExecuteNonQuery();
                        Connect.Close();

                        MessageBox.Show("Запись удалена");
                        LoadParts.Load();

                        JobAssignmentForm jobAssignmentForm = new JobAssignmentForm();
                        jobAssignmentForm.Show();
                        this.Close();
                    }

                    catch (Exception exp)
                    {

                        MessageBox.Show("Ошибка при подключении к базе данных! Проверьте правильность пути к базе данных в файле ConnectPath.txt и перезапустите программу." + exp);

                    }
                }
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Удаление отменено", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }

        private void addJobBtn_Click(object sender, EventArgs e)
        {
            JobAssignmentAddForm jobAssignmentAddForm = new JobAssignmentAddForm();
            jobAssignmentAddForm.Show();
            this.Close();
        }

        private void backForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
