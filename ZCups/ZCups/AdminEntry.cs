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
    public partial class AdminEntry : Form
    {
        public AdminEntry()
        {
            InitializeComponent();
        }
        
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if(Globals.Branch == "Yalova")
            {
                if (singleton.Instance.YalovaAdmins.ContainsKey(UsernameTB.Text) && singleton.Instance.YalovaAdmins[UsernameTB.Text].Equals(PasswordTB.Text))
                {
                    AdminPage ap = new AdminPage();
                    ap.AdminName = UsernameTB.Text;
                    this.Close();
                    ap.ShowDialog();
                }
                else { incorrectLbl.Visible = true; }
            }
            else if (Globals.Branch == "Bursa")
            {
                if (singleton.Instance.BursaAdmins.ContainsKey(UsernameTB.Text) && singleton.Instance.BursaAdmins[UsernameTB.Text].Equals(PasswordTB.Text))
                {
                    AdminPage ap = new AdminPage();
                    this.Close();
                    ap.AdminName = UsernameTB.Text;
                    ap.ShowDialog();
                }
                else { incorrectLbl.Visible = true; }
            }
        }
    }
}
