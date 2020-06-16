using System;
using System.Windows.Forms;

using System.Data.SQLite;

namespace HightApp
{
    public partial class EditEmploeeForm : Form
    {
        public EditEmploeeForm()
        {
            InitializeComponent();
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);

            LoadUsers.LoadUser();

            foreach (User user in StatClass.users)
            {
                if (StatClass.empleToEditId == user.UserId)
                {
                    textBox1.Text = user.Logins;
                    textBox2.Text = user.Fio;
                    comboBox1.SelectedItem = user.AssesLvl;
                }
            }

        }

        private void EditEmploeeForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {
                try
                {
                    Connect.Open();

                    SQLiteCommand command = new SQLiteCommand($"UPDATE dbUsers SET login = '{textBox1.Text}',fio ='{textBox2.Text}', assesLvl={comboBox1.SelectedItem} WHERE userId = {StatClass.empleToEditId};", Connect);/*{StatClass.prtToEditId}*/

                    command.ExecuteNonQuery();
                    Connect.Close();

                    MessageBox.Show("Пользователь обновлен");
                    LoadUsers.LoadUser();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Ошибка при подключении к базе данных! Проверьте правильность пути к базе данных в файле ConnectPath.txt и перезапустите программу.\nКод ошибки: \n" + exp);
                }
                finally
                {
                    EmploeeList emploeeList = new EmploeeList();
                    emploeeList.Show();
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmploeeList emploeeList = new EmploeeList();
            emploeeList.Show();
            this.Close();
        }
    }
}
