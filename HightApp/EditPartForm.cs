using System;
using System.Windows.Forms;

using System.Data.SQLite;

namespace HightApp
{
    public partial class EditPartForm : Form
    {
        public EditPartForm()
        {
            InitializeComponent();
            foreach(Part part in StatClass.parts)
            {
                if(part.PartId == StatClass.prtToEditId)
                {
                    markTextBox.Text =part.Mark;
                    modelTextBox.Text =part.Model;
                    descriptionTextBox.Text =part.Description;
                    remainsTextBox.Text =part.Remains.ToString();
                    priseTextBox.Text =part.Prise.ToString();
                    break;
                }

            }
           
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {
                try
                {
                    Connect.Open();

                    SQLiteCommand command = new SQLiteCommand($"UPDATE dbParts SET mark = '{markTextBox.Text}',model ='{modelTextBox.Text}',description='{ descriptionTextBox.Text}',remains={remainsTextBox.Text},prise={priseTextBox.Text} WHERE partsId = {StatClass.prtToEditId};", Connect);/*{StatClass.prtToEditId}*/

                    command.ExecuteNonQuery();
                    Connect.Close();

                    MessageBox.Show("Деталь обновлена");
                    LoadParts.Load();

                    PartsListForm partsListForm = new PartsListForm();
                    partsListForm.Show();
                    this.Close();
                }

                catch(Exception exp)
                {

                    MessageBox.Show("Ошибка при подключении к базе данных! Проверьте правильность пути к базе данных в файле ConnectPath.txt и перезапустите программу." + exp);

                }
            }
        }
        private void canselBtn_Click(object sender, EventArgs e)
        {
            PartsListForm partsListForm = new PartsListForm();
            partsListForm.Show();
            this.Close();
        }
    }
}
