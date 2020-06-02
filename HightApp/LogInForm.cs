
using System;
using System.Windows.Forms;

namespace HightApp
{
    public partial class LogInForm : Form
    {
        /* Переменные, которые будут хранить на протяжение работы программы логин и пароль. */
        public string login = string.Empty;
        public string password = string.Empty;
        

        public LogInForm()
        {
            InitializeComponent();

            try
            {
                SqlConnect.Connect();
                SqlConnect.CreateTableForDB();
            }
            catch { MessageBox.Show("Error: " + StatClass.error); }

            LoadUsers.LoadUser();
           

        }

        private void EnterToForm()
        {

            for (int i = 0; i <= StatClass.users.Count; i++) // Ищем пользователя и проверяем правильность пароля.
            {
                try {
                if (loginTextBox.Text == "1" && passwordTextBox.Text == "1")
                {
                    StatClass.global_Name = "admin";
                    this.Hide();
                    AdminMainMenu adminMain = new AdminMainMenu();
                    adminMain.Show();
                    break;
                }

                else if (StatClass.users[i].Logins == loginTextBox.Text && Hash.GetMD5Hash(passwordTextBox.Text) != StatClass.users[i].Passwords)

                {
                    login = StatClass.users[i].Logins;

                    MessageBox.Show("Неверный пароль!");

                }
                else if (StatClass.users[i].Logins == loginTextBox.Text && StatClass.users[i].Passwords == Hash.GetMD5Hash(passwordTextBox.Text))

                {
                    login = StatClass.users[i].Logins;
                    password = StatClass.users[i].Passwords;

                    MessageBox.Show("Вы вошли в систему!");
                    StatClass.global_Name = login;

                    this.Hide();
                    if (StatClass.users[i].AssesLvl == 1)
                    {
                        MasterMainMenu userMainMenu = new MasterMainMenu();
                        userMainMenu.Show();
                        break;
                    }
                    else if (StatClass.users[i].AssesLvl == 2)
                    {
                        WorkerMainMenu workerMainMenu = new WorkerMainMenu();
                        workerMainMenu.Show();
                        break;
                    }
                    break;
                }
                else if (StatClass.users.Count == i) { MessageBox.Show("Пользователь " + loginTextBox.Text + " не найден!"); }
                // i++;
            }
                catch { MessageBox.Show("Ошибка! Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);  }
            }

            
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закрываем программу.
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            EnterToForm();
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (login == "" | password == "") { Application.Exit(); }
        }
    }
}