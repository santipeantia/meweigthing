using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meweigthing
{
    public partial class frmMainLogin : Form
    {
       
        public frmMainLogin()
        {
            InitializeComponent();
        }

       
        private void frmMainLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากระบบใช่หรือไม่", "ยืนยันการทำรายการ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //do something
                Application.Exit();
                Dispose();
            }
        }

        private void lnkSetup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmSetupCompany = new frmSetupCompany();
            frmSetupCompany.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var frmMainmenu = new frmMainmenu();
            frmMainmenu.Show();

            this.Hide();

        }
    }
}
