using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Data.SQLite;

using System.Data.Common;

namespace HightApp
{
    public partial class RegisterForm : Form
    {
        public string login = string.Empty;
        public string password = string.Empty;
       // private Users user = new Users(); // Экземпляр класса пользователей.
       // List<User> users = new List<User>();
        public RegisterForm()
        {
            InitializeComponent();
          
        }

        private void AddUser() // Регистрируем нового пользователя.
        {
            string selectedState;
            int role;
            try
            {
                selectedState = comboBox1.SelectedItem.ToString();

                if (selectedState == "master") role = 1;
                else if (selectedState == "worker") role = 2;
                else role = 3;
            }
            catch { MessageBox.Show("Запoлните все поля!"); return; }

            if (loginTextBox.Text == "" || passwordTextBox.Text == "" || fioTextBox.Text == "") { MessageBox.Show("Заплните все поля!"); return; }
            
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {
                try {
                    Connect.Open(); 
                    SQLiteCommand command = new SQLiteCommand($"INSERT INTO 'dbUsers' ('login', 'password', 'fio', 'assesLvl') VALUES ('{loginTextBox.Text}', '{Hash.GetMD5Hash(passwordTextBox.Text)}', '{fioTextBox.Text}', '{Convert.ToString(role)}');", Connect);

                    command.ExecuteNonQuery();
                    Connect.Close();

                    MessageBox.Show("пользователь зарегистрирован");
                    LoadUsers.LoadUser();
                }

                catch {

                    MessageBox.Show("Ошибка при подключении к базе данных! Проверьте правильность пути к базе данных в файле ConnectPath.txt и перезапустите программу.");
                                        
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp = 0;

            foreach (User user in StatClass.users)
            {
                if (user.Logins == loginTextBox.Text)
                {
                    temp++;
                }
                
                
            }

            if (temp == 0)
            {
                DialogResult result = MessageBox.Show($"Дейтвительно зарегистрировать нового пользователя?", "Подтвердите действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    AddUser();
                }
                else if (result == DialogResult.Cancel)
                {
                    // какое-то действие при нажатии на НЕТ
                }
            }
            else MessageBox.Show("Такой логин уже используется!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void button_cansel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainMenu adminMainMenu = new AdminMainMenu();
            adminMainMenu.ShowDialog();
           
           
        }

       
    }
}
