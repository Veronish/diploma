using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using System.Data.Common;

namespace HightApp
{
    public partial class DeleteUserForm : Form
    {
        string SelectUserName="";
        string name = "";
        public DeleteUserForm()
        {
            InitializeComponent();
            UpdateListBox();

        }
                     
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Дейтвительно удалить пользователя {SelectUserName}?\nЭто действие невозможно обратить", "Подтвердите действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
                {

                    SQLiteCommand command = new SQLiteCommand($"DELETE FROM dbUsers WHERE login = '{SelectUserName}';", Connect);

                    Connect.Open();

                    SQLiteDataReader reader = command.ExecuteReader();

                    Connect.Close();
                    listBox1.Items.Clear();
                    UpdateListBox();

                }
            }
            else if (result == DialogResult.Cancel)
            {
                // какое-то действие при нажатии на НЕТ
            }
           
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectUserName = listBox1.SelectedItem.ToString();
        }

        public void UpdateListBox()
        {

            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {

                SQLiteCommand command = new SQLiteCommand("SELECT * FROM dbUsers;", Connect);

                Connect.Open();

                SQLiteDataReader reader = command.ExecuteReader();

                foreach (DbDataRecord record in reader)
                {
                    name = record["login"].ToString();
                    listBox1.Items.Add(name);
                }
                Connect.Close();
            }

        }
    }
}
