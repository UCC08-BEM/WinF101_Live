using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{



    public partial class frmCheckedListBox : Form
    {
        public frmCheckedListBox()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chlbCars_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //int checkedOptionIndex; // Tıklanılan ve check haline gelen seçeneğin indexi
            //string checkedContentText; // içeriğindeki text bilgi

            //// Öncelikle seçilen elemanın indexini öğrenmem lazım...
            //checkedOptionIndex = e.Index;

            //// Ondan sonrada içindeki yazan texti öğreneyim
            //checkedContentText = chlbCars.Items[checkedOptionIndex].ToString();

            //// listboxda elemanın var olup olmadığı kontrolü

            //if (lboxSelectedCars.Items.IndexOf(checkedContentText) > -1)
            //    return; // >-1 kontrolü burada araştırdığım textin olduğunu gösterir. Bu yüzden hiçbir işlemm yapmadan metotdan çık git

            //// eğer listbox ımda seçili değer yoksa demekki ekleycem
            //// checked list box ın calışma prensibine göre acaba seçtiğim satırın checkini işaretledi mi kontrolunu yapmam lazım..

            //bool contentChecked = chlbCars.GetItemChecked(checkedOptionIndex);
            //// yukardaki açıklama ışığında bir lojik değişgenle bunu anlayacağım.
            //// yani üzerinde durduğum satırı seçip seçmediğimi (check boxını) anlayacağım

            //if (contentChecked == false) // eğer seçilmemişse ve tıklanmışsa checkbox a
            //{
            //    lboxSelectedCars.Items.Add(checkedContentText); // listbox a checkedlistbox daki texti yerleştiriyorum
            //}
            //else
            //{
            //    lboxSelectedCars.Items.RemoveAt(checkedOptionIndex);
            //}


        }

        private void btonAktar_Click(object sender, EventArgs e)
        {
            lboxSelectedCars.Items.Clear(); // Öncelikle listbox ı içeriğini siliyor

            // daha sonra checkhedlistbox ın seçili elemanlarını listbox a ekliyor..
            for (int i = 0; i < chlbCars.CheckedItems.Count ; i++)
            {
                lboxSelectedCars.Items.Add(chlbCars.CheckedItems[i].ToString());

            }
        }
    }
}
