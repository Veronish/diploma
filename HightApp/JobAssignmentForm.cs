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
                   // jobAssignment.MasterId = jobAssignment.User.Fio.ToString();
                    jobAssignment.ExecutorId = Int32.Parse(record["executor"].ToString());
                   // jobAssignment.User = jobAssignment.User.Fio.ToString();
                   // jobAssignment.User = ;??


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
    }
}
