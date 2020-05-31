using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HightApp
{
    public partial class PartsListForm : Form
    {
        BindingSource bindingSource;
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

        }

        private void DelitePartBtn_Click(object sender, EventArgs e)
        {
            int check = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString());

            try
            {
                foreach (Part part in StatClass.parts)
                {
                    if (check == part.PartId)  // || check == part.Model || check == part.Mark || check == part.Description || check == part.Prise.ToString() || check == part.Remains.ToString())
                    {
                        MessageBox.Show("FFFFFFFFFFFFFFFFFFFFFFFFF");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Для изменения конкретной детали выберите ее инвентарный номер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               
        }
    }
}
