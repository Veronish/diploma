using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Windows.Forms;


namespace HightApp
{
    public partial class TechnicList : Form
    {
      
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
                   // labelDefectSet.Text = technic.defect;
                    labelMarkSet.Text = technic.Mark;
                    labelModelSet.Text = technic.Model;
                    textBoxDefectSet.Text = technic.Defect;

                }


            }
        }
    }
}
