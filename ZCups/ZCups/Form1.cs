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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void YalovaSube_Click(object sender, EventArgs e)
        {
            DrinkSelection ds = new DrinkSelection();
            ds.Branch = YalovaSube.Text;
            ds.Location = this.Location;
            ds.ShowDialog();
            
        }

        private void BursaSubesi_Click(object sender, EventArgs e)
        {
            DrinkSelection ds = new DrinkSelection();
            ds.Branch = BursaSubesi.Text;
            ds.ShowDialog();
           
        }
    }
}
