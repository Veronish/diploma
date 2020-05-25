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
            dataGridView1.AutoGenerateColumns = true;

        }
    }
}
