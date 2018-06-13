using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZCups
{
    public partial class AdminPage : Form
    {
        public string AdminName ;
        public AdminPage()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            BranchLbl.Text = Globals.Branch;
            WelcomeLbl.Text += AdminName;
            if(Globals.Branch == "Yalova")
            {
                foreach (KeyValuePair<string,bool> item in singleton.Instance.YalovaBeveragesTypes)
                {
                    if (item.Value == false)
                    {
                        AddBeverageCB.Items.Add(item.Key);
                    }
                    else if (item.Value == true)
                    {
                        DeleteBeverageCB.Items.Add(item.Key);
                    }
                }

            }
            else if (Globals.Branch == "Bursa")
            {
                foreach (KeyValuePair<string, bool> item in singleton.Instance.BursaBeveragesTypes)
                {
                    if (item.Value == false)
                    {
                        AddBeverageCB.Items.Add(item.Key);
                    }
                    else if (item.Value == true)
                    {
                        DeleteBeverageCB.Items.Add(item.Key);
                    }
                }

            }
        }

        private void BranchLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
