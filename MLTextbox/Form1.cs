using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLTextbox
{

    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int rsTam;
        double rsOndalik;

        double gerceksayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void btonIslem_Click(object sender, EventArgs e)
        {
            tboxSonuc.Text = tboxSonuc.Text + SayiUret().ToString() + "\r\n"; // /r textbox içine yazılacak olan bilginin bittiğini belirtmek için 
        }

        private void MesajVer(string prmMesaj)
        {
            // mesajların verildiği yer (parametrik)

        }

        private double SayiUret()
        {
            // rastgele ondalıklı sayıların oluşturulduğu yer

            rsTam = rnd.Next(1, 10); // 1..10 arası tam sayı üret
            rsOndalik = rnd.NextDouble(); // sadece 0 ila 1 arasında değer üretiyor

            return gerceksayi=rsTam+rsOndalik;
        }
    }
}
