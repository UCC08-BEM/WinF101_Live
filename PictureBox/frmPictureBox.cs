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
    public partial class frmPictureBox : Form
    {
        int fg, fy; // form genişlik yükseklik
        int pbg, pby; // picture boxın genişliği yüksekliği

        public frmPictureBox()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // form açıldığında 0,0 lokasyonuna taşıyorum.

            pboxPicture.Location = new Point(0, 0);

            frmPictureBox frmPictureBox = new frmPictureBox();

            fg = frmPictureBox.Width - 10;
            fy = frmPictureBox.Height - 10;

            pbg = pboxPicture.Width;
            pby = pboxPicture.Height;

            //MessageBox.Show("Form Genişlik : " + frmPictureBox.Width.ToString() + " Yükseklik : " + frmPictureBox.Height.ToString());

            pboxPicture.ImageLocation = lbelFileName.Text;

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x, y;

            x = pboxPicture.Location.X; // imagein ekrandaki X koordinatı

            y = pboxPicture.Location.Y; // Y koordinatı

            //MessageBox.Show("Koordinatlar : x " + x.ToString() + "y " + y.ToString());


            // klavyeden hangi tuşa basıldığını KeyEventArgs dan gelen e parametresine göre anlıyorum.
            switch (e.KeyCode)
            {
                case Keys.Left: // Sol ok tuşu

                    x = x - 10; // 10 piksel 

                    if (x < 0)
                    {
                        x = x + 10;
                    }

                    break;

                case Keys.Right: // Sağ ok tuşu

                    x = x + 10;

                    if (pbg + x > fg )
                    {
                        x = x - 10;
                    }


                    break;

                case Keys.Up:

                    if (y < 0)
                    {
                        y = y + 10;
                    }
                    else
                    {
                        y = y - 10;
                    }

                    break;

                case Keys.Down:

                    y = y + 10;

                    if (pby + y > fy)
                    {
                        y = y - 10;
                    }

                    break;

            }

            pboxPicture.Location = new Point(x, y); 
        }


    }
}
