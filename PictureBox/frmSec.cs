using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class frmSec : Form
    {
        public frmSec()
        {
            InitializeComponent();
        }

        private void btonSelect_Click(object sender, EventArgs e)
        {
            ofdSec.Title = "Lütfen resim dosyasını seçiniz...";

            if (ofdSec.ShowDialog() == DialogResult.OK) // ofd diyalogu açıldı ve opk tuşuyla geri dönüldü ise

            {
                frmPictureBox frmPictureBox = new frmPictureBox();

                // frmPictureBox isimli formdaki bulunan tüm kontrolleri dolaş...ismi lbelFileName olanı bulursan text değerini .... yap
                foreach(Control c in frmPictureBox.Controls)
                {
                    if(c.Name== "lbelFileName")
                        c.Text= ofdSec.FileName;
                }
                // ??  Gidilecek olan formdaki düzenlemesini yapacağım kontrolu direkt olarak nasıl öğrenebilirim..






                frmPictureBox.ShowDialog();

            }
        }
    }
}
