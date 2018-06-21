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
    public static class Globals
    {
        public static string Branch;

    }
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
            Globals.Branch = YalovaSube.Text;
            DrinkSelection ds = new DrinkSelection();
            ds.ShowDialog();
            
        }

        private void BursaSubesi_Click(object sender, EventArgs e)
        {
            Globals.Branch = BursaSubesi.Text;
            DrinkSelection ds = new DrinkSelection();
            ds.ShowDialog();
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
