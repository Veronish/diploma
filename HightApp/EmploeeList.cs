using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HightApp
{
    public partial class EmploeeList : Form
    {

        public EmploeeList()
        {

            InitializeComponent();
            GeberateListbox();
            LoadUsers.LoadUser();

        }

        private void GeberateListbox()
        {
            foreach (User user in StatClass.users)
            {
                listBox1.ClearSelected();
                listBox1.Items.Add(user.Logins);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (User user in StatClass.users)
            {
                if (listBox1.SelectedItem.ToString() == user.Logins)
                {
                    labelLoginSet.Text = user.Logins;
                    labelFioSet.Text = user.Fio;
                    if (user.AssesLvl == 1) labelPositionSet.Text = "Мастер";
                    else if (user.AssesLvl == 2) labelPositionSet.Text = "Рабочий";
                    else if (user.AssesLvl == 3) labelPositionSet.Text = "Другое";
                    // StatClass.empleToEditId = user.UserId;
                    break;
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Дейтвительно удалить пользователя {listBox1.SelectedItem.ToString()}?\nЭто действие невозможно обратить", "Подтвердите действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
                {

                    SQLiteCommand command = new SQLiteCommand($"DELETE FROM dbUsers WHERE login = '{listBox1.SelectedItem}';", Connect);

                    Connect.Open();

                    SQLiteDataReader reader = command.ExecuteReader();

                    Connect.Close();
                    LoadUsers.LoadUser();
                    listBox1.Items.Clear();
                    GeberateListbox();

                }
            }
            else if (result == DialogResult.Cancel)
            {
                // какое-то действие при нажатии на НЕТ
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            foreach(User user in StatClass.users)
            {
                if(listBox1.SelectedItem.ToString() == user.Logins)
                {
                    StatClass.empleToEditId = user.UserId;
                   // user.UserId = StatClass.empleToEditId;
                }
            }

            EditEmploeeForm editEmploeeForm = new EditEmploeeForm();
            editEmploeeForm.Show();

            Hide();
        }
    }
}
