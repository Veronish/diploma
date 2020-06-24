using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HightApp
{
    public partial class MasterMainMenu : Form
    {
       
        public MasterMainMenu()
        {
            InitializeComponent();
            labelUserName.Text = StatClass.global_Name;            
        }  
        private void jobAssignmentBtn_Click(object sender, EventArgs e)
        {
            JobAssignmentForm jobAssignment = new JobAssignmentForm();
            jobAssignment.Show();
        }

        private void availableTechnicBtn_Click(object sender, EventArgs e)
        {
            TechnicList technicList = new TechnicList();
            technicList.Show();
        }

        private void emploeeListBtn_Click(object sender, EventArgs e)
        {
            EmploeeList emploeeList = new EmploeeList();
            emploeeList.ShowDialog();
        }

        private void partsBtn_Click(object sender, EventArgs e)
        {
            PartsListForm partsListForm = new PartsListForm();
            partsListForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }
    }
}
