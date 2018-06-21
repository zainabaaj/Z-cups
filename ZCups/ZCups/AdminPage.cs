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
            string added = "";
            string deleted = "";
            if (AddBeverageCB.SelectedItem != null) added = AddBeverageCB.SelectedItem.ToString();
            if (DeleteBeverageCB.SelectedItem != null) deleted = DeleteBeverageCB.SelectedItem.ToString();
            List<Coffee> raisedCoffee = new List<Coffee>();
            if(EsspressoChB.Checked == true)
            {
                raisedCoffee.Add(new Esspresso());
            }
            if (FilteredCoffeeChB.Checked == true)
            {
                raisedCoffee.Add(new FilteredCoffee());
            }
            if(FrappuccinoChB.Checked == true)
            {
                raisedCoffee.Add(new Frappuccino());
            }
            if (Globals.Branch== "Yalova")
            {
                YalovaSube ys = new YalovaSube();
                ys.RegisterRaisedCoffee(raisedCoffee);
                ys.TemplateMethod(added, deleted, (double)RaiseUD.Value);
                this.Close();
                DrinkSelection ds = new DrinkSelection(ys);
                ds.ShowDialog();
            }
            else if (Globals.Branch== "Bursa")
            {
                BursaSube bs = new BursaSube();
                bs.RegisterRaisedCoffee(raisedCoffee);
                bs.TemplateMethod(added, deleted, (double)RaiseUD.Value);
                this.Close();
                DrinkSelection ds = new DrinkSelection(bs);
                ds.ShowDialog();

            }

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
