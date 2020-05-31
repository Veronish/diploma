using System;
using System.Windows.Forms;

namespace HightApp
{
    public partial class EmploeeList : Form
    {
       
        public EmploeeList()
        {

            InitializeComponent();
            GeberateListbox();

        }

        private void GeberateListbox()
        {
            foreach (User user in StatClass.users)
            {
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
                }


            }
           

        }
    }
}
