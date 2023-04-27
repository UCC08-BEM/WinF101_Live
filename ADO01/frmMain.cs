using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuiCustomers_Click(object sender, EventArgs e)
        {
            frmADO01 frmADO01=new frmADO01();

            frmADO01.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts= new frmProducts();

            frmProducts.ShowDialog();
        }
    }
}
