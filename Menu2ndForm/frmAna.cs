using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComboBox01; // referans ile projeye dahil edilen diğer proje...Öncesinde projeye Add..Reference ile atanıyor....
using LİstBox01;

// Çağırdığı alt programdan çıkış yapıldığında sadece close yapsın  ana progranmıda sonlandırmasın....???


namespace Menu2ndForm
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            SystemExit();
        }

        private void SystemExit()
        {
            Application.Exit();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemExit();
        }

        private void mnuiExit_Click(object sender, EventArgs e)
        {
            SystemExit();
        }

        private void form2AçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Formlarda aslında bir class

            // İkinci formu açabilmek için yapmam gereken şey açmak istediğim formu örneklemek olacaktır.

            frmForm2 frmForm2=new frmForm2(); // Örnekledim

            frmForm2.ShowDialog(); // ekranda açtım..
            
        }

        private void form3AçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmForm3 frmForm3 = new frmForm3(); // Örnekledim

            frmForm3.ShowDialog(); // ekranda açtım..
        }

        private void comboBox1ProjesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboBox01.frmListBox frmList = new frmListBox();
            
            frmList.ShowDialog();
        }

        private void listbox01ProjesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LİstBox01.Form1 form1= new Form1();

            form1.ShowDialog();

        }

        private void frmAna_Load(object sender, EventArgs e)
        {

        }
    }
}
