using System;
using System.Windows.Forms;
using System.Data.SQLite;


namespace HightApp
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddPart();
        }

        private void AddPart()
        {
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {
                try
                {
                    Connect.Open();
                    SQLiteCommand command = new SQLiteCommand($"INSERT INTO 'dbParts' ('mark', 'model', 'description', 'remains', 'prise') VALUES ('{markTextBox.Text}', '{modelTextBox.Text}', '{descriptionTextBox.Text}', '{remainsTextBox.Text}', '{priseTextBox.Text}');", Connect);

                    command.ExecuteNonQuery();
                    Connect.Close();

                    MessageBox.Show("Деталь добавлена");
                    LoadUsers.LoadUser();

                   // this.DialogResult = DialogResult.OK;
                    PartsListForm partsListForm = new PartsListForm();
                    partsListForm.Show();
                    this.Close();
                }

                catch
                {

                    MessageBox.Show("Ошибка при подключении к базе данных! Проверьте правильность пути к базе данных в файле ConnectPath.txt и перезапустите программу.");

                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            PartsListForm partsListForm = new PartsListForm();
            partsListForm.Show();
            this.Close();
        }
    }
}
