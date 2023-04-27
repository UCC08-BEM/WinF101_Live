using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LİstBox01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tboxAdet.Select();
        }

        private void btonSayilar_Click(object sender, EventArgs e)
        {
            lboxSayilar.Items.Clear(); // listbox içini temizliyor.

            int adet = Convert.ToInt32(tboxAdet.Text);

            for (int i = 1; i <= adet; i++)
            {
                string sayitext = i.ToString() + ". sayı";

                lboxSayilar.Items.Add(sayitext);

            }

            lboxSayilar.SelectedIndex = 0;
            tboxAdet.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
