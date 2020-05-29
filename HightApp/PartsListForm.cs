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
          //  Part part = new Part();
          //  part.Prise; master1
            // dataGridView1.AutoGenerateColumns = true;

            //int i = 1;
            //int j = 1;
            //foreach (Part part in StatClass.parts)
            //{                
            //    dataGridView1.Rows[j].Cells[i].Value = part.PartId; j++;
            //    dataGridView1.Rows[j].Cells[i].Value = part.Mark; j++;
            //    dataGridView1.Rows[j].Cells[i].Value = part.Model; j++;
            //    dataGridView1.Rows[j].Cells[i].Value = part.Description; j++;
            //    dataGridView1.Rows[j].Cells[i].Value = part.Remains; j++;
            //    dataGridView1.Rows[j].Cells[i].Value = part.Prise; j++;
            //    i++;
            //    // dataGrid.Rows[i].Cells[j].Value = arr[i, j];
            //}

        }
    }
}
