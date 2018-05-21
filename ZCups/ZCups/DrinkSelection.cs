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
        }
    }
}
