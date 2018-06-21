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
        Coffee coffee;
        Sube sube;
        static int id =0;
        public static double bill= 0.0;
        User user;
        
        public DrinkSelection()
        {
            InitializeComponent();
            if (sube == null)
            {
                if (Globals.Branch.Equals("Yalova"))
                {
                    sube = new YalovaSube();
                }
                else sube = new BursaSube();

            }

        }
        public DrinkSelection(object sube)
        {
            InitializeComponent();
            this.sube = (Sube)sube;

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void DrinkSelection_Load(object sender, EventArgs e)
        {
            user = new User();
            BranchLbl.Text = Globals.Branch;
            
            BillTB.Text = "************************************************************ \n\n ";
            BillTB.Text += $"                 Welcome To Z Cups  ({Globals.Branch})  \n\n";
            BillTB.Text += "************************************************************ \n\n\n ";

            foreach (Esspresso o in sube.EsspressoType)
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
            button2.Enabled = true; 
            switch (DecoratorCB.SelectedItem)
            {
                case "Mocha":
                  coffee=new Mocha(coffee);
                  break;
                case "Latte":
                  coffee= new Milk(coffee);
                  break;
                case "Caramel":
                    coffee = new Caramel(coffee);
                    break;
                case "Iced":
                    coffee = new Ice(coffee);
                    break;
                
            }
            double x = coffee.Cost();
            user.Compute(this,BillTB.Text, bill);
            bill += x;
            string BillText = $"\n {coffee.GetDescription()}\t\t{x} tl \n ";
            BillTB.Text += BillText;
            
        }

        private void CoffeeSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DecoratorCB.Items.Clear();
            string o = CoffeeSelectCB.SelectedItem.ToString();

            if (o == "Americano")
            {
                coffee = new Americano();
                DecoratorCB.Items.Add("Iced");
            }
            else if (o == "Caffe")
            {
                coffee = new Caffe();
                DecoratorCB.Items.Add("Latte");
                DecoratorCB.Items.Add("Mocha");

            }

            else if (o == "White Chocolate")
            {
                coffee = new WhiteChocolate();
                DecoratorCB.Items.Add("Iced");
                DecoratorCB.Items.Add("Mocha");

            }

            else if (o == "Filtered Coffee")
            {
                coffee = new FilteredCoffee();
                DecoratorCB.Items.Add("Iced");
            }
            else if (o == "Misto")
            {
                coffee = new Misto();
                DecoratorCB.Items.Add("Latte");
                DecoratorCB.Items.Add("Iced");

            }
            else if (o == "Brew")
            {

                coffee = new Brew();
                DecoratorCB.Items.Add("Latte");
                DecoratorCB.Items.Add("Iced");

            }

            else if (o == "Frappuccino")
            {
                coffee = new Frappuccino();
                DecoratorCB.Items.Add("Mocha");
                DecoratorCB.Items.Add("Caramel");

            }
            else if (o == "Esspresso") coffee = new Esspresso();
            else if (o == "Cappuccino") coffee = new Cappuccino();
            else if (o == "Vanilla Frap") coffee = new VanillaFrap();
            else if (o == "Strawberry Frap") coffee = new StrawberryFrap();
            else if (o == "chocolate Frap") coffee = new ChocolateFrap();
               

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            singleton.Instance.Id.Add(id);
            id++;
            singleton.Instance.Price.Add(bill);
            singleton.Instance.TotalPrice += bill;
            PriceLbl.Visible = true;
            PriceLbl.Text = $"{bill} tl";
            AddBeverageBtn.Enabled = false;
            NewOrderBtn.Visible = true;
        }

        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            bill = .0;
            DrinkSelection_Load( sender,  e);
            AddBeverageBtn.Enabled = true;
            NewOrderBtn.Visible = false;
            PriceLbl.Visible = false;
            CoffeeSelectCB.ResetText();
            DecoratorCB.ResetText();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control)
            {
                user.Undo();
                
            }
                
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.Undo();
        }
        public  void undo(string text) => BillTB.Text = text;

        private void reportBtn_Click(object sender, EventArgs e)
        {
            BillTB.Text = "************************************************************ \n\n ";
            BillTB.Text += $"                 Welcome To Z Cups  ({Globals.Branch})  \n\n";
            BillTB.Text += "************************************************************ \n\n\n ";
            foreach (var i in singleton.Instance.Id)
            {
                BillTB.Text += $"{singleton.Instance.Id[i]} : \t {singleton.Instance.Price[i]}\n";
            }
            PriceLbl.Text = $"{singleton.Instance.TotalPrice} tl";
        }

        private void DrinkSelection_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminEntry ae = new AdminEntry();
            this.Close();
            ae.Show();
           
        }
        
    }
}
