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
    public partial class frmSetupCompany : Form
    {
        public frmSetupCompany()
        {
            InitializeComponent();
        }

       
        private void frmSetupCompany_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากระบบใช่หรือไม่", "ยืนยันการทำรายการ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //do something
                this.Close();
                Dispose();
            }
        }

    }
}
