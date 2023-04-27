using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class frmTabControl : Form
    {
        public frmTabControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sayfano=tabcMain.SelectedIndex;

            MessageBox.Show("Burası " + tabcMain.SelectedTab.Text);
        }

        private void btonEkle_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage("Yeni Sayfa");

            tabcMain.Controls.Add(tabPage);
        }

        private void btonSil_Click(object sender, EventArgs e)
        {
            //TabPage tabPage = new TabPage("Yeni Sayfa");

            tabcMain.Controls.Remove(tabcMain.SelectedTab);

        }
    }
}
