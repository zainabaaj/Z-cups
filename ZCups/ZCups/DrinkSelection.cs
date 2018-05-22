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
    public partial class DrinkSelection : Form
    {
        public string Branch { get; set; }
         Sube sube;
        
        public DrinkSelection()
        {
            InitializeComponent();
            

        }
        
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DrinkSelection_Load(object sender, EventArgs e)
        {
            
            BranchLbl.Text = Branch;
            if (Branch.Equals("Yalova"))
            {
                sube = new YalovaSube();
            }
            else sube = new BursaSube();

            foreach(Esspresso o in sube.EsspressoType)
            {
                CoffeeSelectCB.Items.Add(o.ToString());
            }
            foreach (FilteredCoffee o in sube.FilteredCoffeeType)
            {
                CoffeeSelectCB.Items.Add(o.ToString());
            }
            foreach (Frappuccino o in sube.FrappuccinoType)
            {
                CoffeeSelectCB.Items.Add(o.ToString());
            }

        }

        private void AddBeverageBtn_Click(object sender, EventArgs e)
        {

        }

        private void CoffeeSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DecoratorCB.Items.Clear();
            string o = CoffeeSelectCB.SelectedItem.ToString();
            
                if( o == "Americano")
                {
                    DecoratorCB.Items.Add("Iced");
                }
                else if ( o == "Caffe")
                {
                      DecoratorCB.Items.Add("Latte");
                      DecoratorCB.Items.Add("Mocha");
                   
                }

                else if (o == "White Chocolate")
                {
                      DecoratorCB.Items.Add("Iced");
                      DecoratorCB.Items.Add("Mocha");

                }

                else if (o == "Filtered Coffee")
                {
                    DecoratorCB.Items.Add("Iced");
                }
                else if ( o == "Misto"|| o == "Brew")
                {
                    DecoratorCB.Items.Add("Latte");
                    DecoratorCB.Items.Add("Iced");

                }
                                        
                else if (o == "Frappuccino")
                {
                    DecoratorCB.Items.Add("Mocha");
                    DecoratorCB.Items.Add("Caramel");

                }
               

            
        }
    }
}
