using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Windows.Forms;


using System.Data.SQLite;
using System.Data.Common;

namespace HightApp
{
    public partial class TechnicList : Form
    {

        string SelectName = "";
        string name;
        public TechnicList()
        {

            InitializeComponent();
            UpdateTechnicListBox();
            LoadTechnic.Load();
        }

        public void UpdateTechnicListBox()
        {

            using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
            {

                SQLiteCommand command = new SQLiteCommand("SELECT * FROM dbTechnic;", Connect);

                Connect.Open();

                SQLiteDataReader reader = command.ExecuteReader();

                foreach (DbDataRecord record in reader)
                {
                    name = record["technicId"].ToString();
                    listBox1.Items.Add("Инв. № " + name);
                }
                Connect.Close();
            }

        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Technic technic in StatClass.technics)
            {
                if (listBox1.SelectedIndex + 1 == technic.TechnicId)
                {
                    labelAvailSet.Text = technic.Availability;
                    labelDatePrepairSet.Text = technic.DateLastRepair;
                    //labelDefectSet.Text = technic.defect;
                    labelMarkSet.Text = technic.Mark;
                    labelModelSet.Text = technic.Model;
                    textBoxDefectSet.Text = technic.Defect;

                }

            }

            SelectName = listBox1.SelectedItem.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show($"Дейтвительно удалить запись о {SelectName}?\nЭто действие невозможно обратить", "Подтвердите действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                using (SQLiteConnection Connect = new SQLiteConnection($@"{StatClass.textFromFile}")) // в строке указывается к какой базе подключаемся
                {

                    SQLiteCommand command = new SQLiteCommand($"DELETE FROM dbTechnic WHERE technicId = '{name}';", Connect);

                    Connect.Open();

                    SQLiteDataReader reader = command.ExecuteReader();

                    Connect.Close();
                    listBox1.Items.Clear();
                    UpdateTechnicListBox();

                }
            }
            else if (result == DialogResult.Cancel)
            {
                // какое-то действие при нажатии на НЕТ
            }
        }

       

        private void EditBtn_Click(object sender, EventArgs e)
        {
            StatClass.technivToEditId = Convert.ToInt32(name);
            EditTechnicForm editTechnicForm = new EditTechnicForm();
            editTechnicForm.Show();
            Hide();
        }
    }
}
