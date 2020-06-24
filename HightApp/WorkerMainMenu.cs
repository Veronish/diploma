using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HightApp
{
    public partial class WorkerMainMenu : Form
    {
        public WorkerMainMenu()
        {
            InitializeComponent();
            userName.Text = StatClass.global_Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JobAssignmentForm jobAssignment = new JobAssignmentForm();
            jobAssignment.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TechnicList technicList = new TechnicList();
            technicList.Show();
        }
    }
}
