using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox01
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Application.ExitThread();
        }

        private void btonSayilar_Click(object sender, EventArgs e)
        {
            cboxSayiLİst.Items.Clear(); // combobox içini temizliyor.

            int adet = Convert.ToInt32(tboxAdet.Text);

            for (int i = 1; i <= adet; i++)
            {
                string sayitext = i.ToString() + ". sayı";

                cboxSayiLİst.Items.Add(sayitext);

            }

            cboxSayiLİst.SelectedIndex = 0;
            tboxAdet.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tboxAdet.Select();
        }
    }


}
