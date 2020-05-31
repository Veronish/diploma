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
    public partial class PartsListForm : Form
    {
        BindingSource bindingSource;
        int columnIndex;
        int rowIndex;
        public PartsListForm()
        {
            InitializeComponent();

            LoadParts.Load();
            DataGreedFill();


        }
        public void DataGreedFill()
        {

            dataGridView1.Rows.Clear();
            bindingSource = new BindingSource();
            bindingSource.DataSource = StatClass.parts;
            dataGridView1.DataSource = bindingSource;
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.Show();
            this.Close();

        }

        private void EditPartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (columnIndex == 0)//e.ColumnIndex == 0)//dataGridView1.CellClick == dataGridView1.SelectedCells[0])//.SelectedColumns.Contains(PartId))
                {
                    foreach (Part part in StatClass.parts)
                    {
                        if (Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString()) == part.PartId)  // || check == part.Model || check == part.Mark || check == part.Description || check == part.Prise.ToString() || check == part.Remains.ToString())
                        {
                            StatClass.prtToEditId = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                            
                            EditPartForm editPartForm = new EditPartForm();
                            editPartForm.Show();
                            this.Close();
                           
                            break;
                            // MessageBox.Show("FFFFFFFFFFFFFFFFFFFFFFFFF");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Для изменения конкретной детали выберите ее номер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("Для изменения конкретной детали выберите ее номер"+ exp, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DelitePartBtn_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {
                try
                {
                    
                    SQLiteCommand command = new SQLiteCommand($"DELETE FROM dbParts WHERE  partsId= {Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString())};", Connect);
                    Connect.Open();
                    SQLiteDataReader reader = command.ExecuteReader();

                    //command.ExecuteNonQuery();
                    Connect.Close();

                    MessageBox.Show("Деталь удалена");
                    LoadParts.Load();

                    PartsListForm partsListForm = new PartsListForm();
                    partsListForm.Show();
                    this.Close();
                }

                catch (Exception exp)
                {

                    MessageBox.Show("Ошибка при подключении к базе данных! Проверьте правильность пути к базе данных в файле ConnectPath.txt и перезапустите программу." + exp);

                }
            }


        }

        public void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            columnIndex = e.ColumnIndex;
            rowIndex = e.RowIndex;
        }
    }
}
