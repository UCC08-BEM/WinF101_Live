using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthDays
{
    public partial class frmMonthDays : Form
    {
        DateTimeFormatInfo formatTR = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat; // yani bu değişgene türkçe tarih formatı atandı.

        public frmMonthDays()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMonthDays_Load(object sender, EventArgs e)
        {
            // Form ekrana gelirken;
            // 1. nudYil kontrolunun içindeki gösterilecek bilgiyi günümüzün yılı olarak göstersin
            // 2. cboxAy isimli comboboxın otomatik olarak ay adlarıyla doldurulsun...Ay adları değiştirilemesin..
            //
            //

            int yil = Convert.ToInt32(DateTime.Now.Year); // default tarihin yıl yıl bilgisine ulaştım.

            nudYil.Value= yil;

            for (int i = 0; i < 12; i++)
            {
                cboxAy.Items.Add(formatTR.MonthNames[i]); // Türkçe
            }

        }

        private void btonListele_Click(object sender, EventArgs e)
        {
            lboxGunler.Items.Clear();

            int yil = Convert.ToInt32(nudYil.Value);

            int ay = cboxAy.SelectedIndex + 1;

            // nud dan ve cbox dan seçilen opsiyonlara göre benim bir tarih bilgisi olarak programa söylemem lazım
            DateTime tarih = new DateTime(yil, ay, 1); // diyelim Ocak 2023 için 1.Ocak.2023 diye bellekte bir tarih bilgisi oluşturdu.elimde artık tarih türünde bir bilgi var..

            //seçilen ayda kaç gün var onu öğrenmem lazım.
            int totalDaysCount= DateTime.DaysInMonth(yil, ay);

            for (int i = 1; i <= totalDaysCount; i++)
            {
                lboxGunler.Items.Add(tarih.Day + " " + cboxAy.Text + " " + formatTR.DayNames[(int)tarih.DayOfWeek]);

                tarih=tarih.AddDays(1); // birer gün olarak ilk tarihten son güne kadar dönmesi için AddDays(1) yapıldı.
            }

        }
    }
}
