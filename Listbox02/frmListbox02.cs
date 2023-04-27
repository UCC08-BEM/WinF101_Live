using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox02
{
    public partial class frmListbox02 : Form
    {
        Random rnd = new Random();
        int toplam;
        int ilksayi, sonsayi;


        public frmListbox02()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btıonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmListbox02_Load(object sender, EventArgs e)
        {

            EkranTemizle(); // ekrana ilk gelirken önce "EkranTemizle" isimli metoda gidecek...sonra yine buraya dönecek

            //lbelMessage.Visible = false;


        }

        private void btonUret_Click(object sender, EventArgs e)
        {
            // anca ve anca
            if (tboxAdet.Text != "")
            {
                // İşleme girsin
                if (tboxIlk.Text != "" && tboxSon.Text != "")
                {
                    ilksayi= int.Parse(tboxIlk.Text);
                    sonsayi = int.Parse(tboxSon.Text);

                    lboxSonuc.Items.Clear(); // Yeni değerler için eski yazdıklarını bir temizlesin.


                    for (int i = 0; i <= int.Parse(tboxAdet.Text); i++)
                    {


                        int rastgelesayi = rnd.Next(ilksayi,sonsayi);

                        lboxSonuc.Items.Add(rastgelesayi.ToString());

                        toplam += rastgelesayi;


                    }



                    lbelMessage.Visible = true;

                    lbelMessage.Text = $"{ilksayi} ile {sonsayi} arasında {int.Parse(tboxAdet.Text)} adet sayı üretilmiştir....Toplamları = {toplam}";

                    EkranTemizle();

                }

            }
            else
            {
                lbelMessage.Visible = true;
                lbelMessage.Text= "Adet bilgisini giriniz...";

                tboxAdet.Focus();
            }
            



        }

        // Her defasında buradaki durum için mesela ekranı temizlemek gerekebilir
        // bu yüzden ekranı ilk haline getiren bir geridönüşsüz bir metot tanımlarım

        private void EkranTemizle()
        {
            // ekrana ilk geldiğinde....textboxları boşaltır ..adet kısmına focuslanır.

            tboxAdet.Text = "";
            tboxIlk.Clear();
            tboxSon.Clear();

            tboxAdet.Focus();
        }
    }

}
