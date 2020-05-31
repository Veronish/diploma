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

namespace HightApp
{
    public partial class EditPartForm : Form
    {
        public EditPartForm()
        {
            InitializeComponent();
            markTextBox.Text = StatClass.parts[StatClass.prtToEditId].Mark;
            modelTextBox.Text = StatClass.parts[StatClass.prtToEditId].Model;
            descriptionTextBox.Text = StatClass.parts[StatClass.prtToEditId].Description;
            remainsTextBox.Text = StatClass.parts[StatClass.prtToEditId].Remains.ToString();
            priseTextBox.Text = StatClass.parts[StatClass.prtToEditId].Prise.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {
                try
                {
                    Connect.Open();

                    SQLiteCommand command = new SQLiteCommand($"DELETE FROM dbParts WHERE  partsId= {StatClass.prtToEditId};", Connect);
                    
                    SQLiteDataReader reader = command.ExecuteReader();
                    command = new SQLiteCommand($"INSERT INTO 'dbParts' ('partsId', 'mark', 'model', 'description', 'remains', 'prise') VALUES ('{StatClass.prtToEditId}','{markTextBox.Text}', '{modelTextBox.Text}', '{descriptionTextBox.Text}', '{remainsTextBox.Text}', '{priseTextBox.Text}');", Connect);

                    // command = new SQLiteCommand($"UPDATE dbParts SET mark = '{markTextBox.Text}',model ='{modelTextBox.Text}',description='{ descriptionTextBox.Text}',remains='{remainsTextBox.Text}',prise='{priseTextBox.Text}' WHERE partsId = '{StatClass.prtToEditId}';", Connect);/*{StatClass.prtToEditId}*/


                    //SQLiteDataReader reader = command.ExecuteReader();
                   // command.ExecuteReader();
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
