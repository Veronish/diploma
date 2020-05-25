using System;
using System.Windows.Forms;

namespace HightApp
{
    public partial class AdminMainMenu : Form
    {
        public AdminMainMenu()
        {
            InitializeComponent();
            userName.Text = StatClass.global_Name;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_reg_new_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();

        }

        private void button_delete_user_Click(object sender, EventArgs e)
        {
            // this.Hide();
            DeleteUserForm deleteUserForm = new DeleteUserForm();
            deleteUserForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmploeeList emploeeList = new EmploeeList();
            emploeeList.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }
    }
}
