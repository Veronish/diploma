﻿//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace HightApp
//{
//    public partial class LogInForm : Form
//    {
//        public LogInForm()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            if(textBox1.Text == "admin" || textBox2.Text == "admin")
//            {
//                this.Hide();
//                MainForm mainForm = new MainForm();
//                mainForm.ShowDialog();
//            }
//            else
//            {
//                MessageBox.Show("Try agin                       ","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
//            }
//        }
//    }
//}


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
                    adminMain.ShowDialog();
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
                        userMainMenu.ShowDialog();
                        break;
                    }
                    else if (StatClass.users[i].AssesLvl == 2)
                    {
                        WorkerMainMenu workerMainMenu = new WorkerMainMenu();
                        workerMainMenu.ShowDialog();
                        break;
                    }
                    break;
                }
                else if (StatClass.users.Count == i) { MessageBox.Show("Пользователь " + loginTextBox.Text + " не найден!"); }
                // i++;
            }
                catch { MessageBox.Show("Неверный пароль!");  }
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