using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO01
{
    public partial class frmProducts : Form
    {
        // Global Kısım
        // Aşağıdaki değişgen VT bağlanabilmek için gerekli olan bağlantı cümleciğidir. Şu makinaya..şu database e bağlanmak istiyorum gibi
        string constring = @"Data Source=DESKTOP-AD6B5QM\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        

        string vs_SQLCommandAna = ""; // SQL komutlarımı içerecek
        string vs_SQLCommand = ""; // combo için
        string vs_SQLQuery = ""; // Query text i içerecek
        string vs_SQLUpdate = ""; // Update işlemi için
        string Mode="";

        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            PrepareGrid();

            vs_SQLCommandAna = "SELECT ProductID, ProductName,Products.CategoryID, Categories.CategoryName,Products.SupplierID,Suppliers.CompanyName,UnitsInStock,Discontinued FROM Products ";
            vs_SQLCommandAna = vs_SQLCommandAna + "INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID ";
            vs_SQLCommandAna += "INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID ";
            vs_SQLCommandAna += "WHERE ProductID > 0 ";

            BindGrid(vs_SQLCommandAna);

            GetCategory();
            GetSupplier();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrepareGrid()
        {
            // datagridin otomatik olarak db tablosuna bakıp gridin kolonlarını yaratmasını istemiyorum. Ben yapcam...manuel
            dgrdProducts.AutoGenerateColumns = true;

            // Eğer GD nin en baş tarafındaki kolonu "RowHeader" görmek istemiyorsam
            dgrdProducts.RowHeadersVisible = false;

            // DG deki kolonları tek tek dolaşmak yerine tek bir satırı ayrıştırma
            dgrdProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // DG deki kolonları DGnin genişliğine göre ayarlama
            dgrdProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // DG nin üzerinde elle oynamayı yasaklama
            dgrdProducts.ReadOnly = true;

            // DGnin üzerinde kullanıcının satır/kayıt eklemesini ve silmesini yasaklama
            dgrdProducts.AllowUserToAddRows = false;
            dgrdProducts.AllowUserToDeleteRows = false;

            // DGnin satırlarının yüklekliğini değiştirmeyi yasaklama
            dgrdProducts.AllowUserToResizeRows = false;
        }

        private void BindGrid(string prmSQLText)
        {
            // DG yi dolduran bölüm

            using (SqlConnection con = new SqlConnection(constring))
            {

                using (SqlCommand cmd = new SqlCommand(prmSQLText, con)) // con nesnesini kullanarak SQL komutunu oluştur..
                {
                    cmd.CommandType = CommandType.Text; // text şeklinde

                    // aşağıda cmd nesnesini kullanabileciğim veri  geliş/gidişini ayarlayan bir DA oluşturuyorum.
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset); // Adaptörüm yarattığı DS i doldursun
                            dgrdProducts.DataSource = dset.Tables[0]; // DS oluştu ..içine tablo taşındı ve DG in içi,nde görülebilir hale geldi.
                        }
                    }
                }
            }
        }

        private void GetCategory()
        {
            // SQL tarafındaki Category tablosundan sorgulamada kullanabilmek için sadece CategoryID ve CategoryName alanlarını almalıyım.

            using (SqlConnection con = new SqlConnection(constring))
            {

                vs_SQLCommand = "SELECT CategoryID,CategoryName FROM Categories";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con)) // con nesnesini kullanarak SQL komutunu oluştur..
                {
                    cmd.CommandType = CommandType.Text; // text şeklinde

                    // aşağıda cmd nesnesini kullanabileciğim veri  geliş/gidişini ayarlayan bir DA oluşturuyorum.
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset); // Adaptörüm yarattığı DS i doldursun

                            // comboboxın ilk satırı -- Hepsi -- yazsın

                            // Data tablolarında olmayan bir satırı oluşturmak için kullanılan bir class var(DataRow classı). combo içine ilk olarak onunn gözükmesini sağlıyacağım
                            DataRow newRow = dset.Tables[0].NewRow(); //  yeni bir satır açıyorum.
                            newRow["CategoryID"] = 0;
                            newRow["CategoryName"] = "--- Hepsi ---";
                            dset.Tables[0].Rows.InsertAt(newRow, 0); // hazırlamış oluğum aslın db tablosunda olmayan kayıdı combo boxın 0.indeksine koyuyorum ki ilk o gözüksün...


                            cboxQCategory.DataSource = dset.Tables[0];
                            cboxQCategory.ValueMember = "CategoryID";
                            cboxQCategory.DisplayMember = "CategoryName";

                            // Detay sayfasındaki kategori comboboxı
                            cboxCategory.DataSource = dset.Tables[0];
                            cboxCategory.ValueMember = "CategoryID";
                            cboxCategory.DisplayMember = "CategoryName";

                        }
                    }
                }
            }


        }

        private void GetSupplier()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {

                vs_SQLCommand = "SELECT SupplierID,CompanyName FROM Suppliers";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con)) // con nesnesini kullanarak SQL komutunu oluştur..
                {
                    cmd.CommandType = CommandType.Text; // text şeklinde

                    // aşağıda cmd nesnesini kullanabileciğim veri  geliş/gidişini ayarlayan bir DA oluşturuyorum.
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset); // Adaptörüm yarattığı DS i doldursun

                            // comboboxın ilk satırı -- Hepsi -- yazsın

                            // Data tablolarında olmayan bir satırı oluşturmak için kullanılan bir class var(DataRow classı). combo içine ilk olarak onunn gözükmesini sağlıyacağım
                            DataRow newRow = dset.Tables[0].NewRow(); //  yeni bir satır açıyorum.
                            newRow["SupplierID"] = 0;
                            newRow["CompanyName"] = "--- Hepsi ---";
                            dset.Tables[0].Rows.InsertAt(newRow, 0); // hazırlamış oluğum aslın db tablosunda olmayan kayıdı combo boxın 0.indeksine koyuyorum ki ilk o gözüksün...


                            cboxQSupplier.DataSource = dset.Tables[0];
                            cboxQSupplier.ValueMember = "SupplierID";
                            cboxQSupplier.DisplayMember = "CompanyName";

                            // detay sayfasındaki supplier combobox ı
                            cboxSupplier.DataSource = dset.Tables[0];
                            cboxSupplier.ValueMember = "SupplierID";
                            cboxSupplier.DisplayMember = "CompanyName";

                        }
                    }
                }
            }

        }

        private void btonQuery_Click(object sender, EventArgs e)
        {
            vs_SQLQuery = "";

            if (tboxQProductName.Text != "") // adam textboxa bişi girmişmi
            {
                vs_SQLQuery += "AND ProductName LIKE '%" + tboxQProductName.Text + "%' ";
            }
            // Not : category combosundaki değişimi - ne seçilmiş olduğunu - selectedindex propertysi vasıtasıyla öğrenebilirsiniz.
            if (cboxQCategory.SelectedIndex > 0)
            {
                vs_SQLQuery += "AND Products.CategoryID =" + cboxQCategory.SelectedValue;
            }

            if (cboxQSupplier.SelectedIndex > 0)
            {
                vs_SQLQuery += "AND Products.SupplierID =" + cboxQSupplier.SelectedValue;
            }




            BindGrid(vs_SQLCommandAna + vs_SQLQuery);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btonUpdate_Click(object sender, EventArgs e)
        {
            ShowData("U");
        }

        //private void cboxQSupplier_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show(cboxQSupplier.SelectedValue.ToString());
        //}

        private void ShowData(string prmMode)
        {
            // bu metod parametrik olacak. üzerine gelen parametreye göre (I veya U) detay sayfasında boş duran yerleri datagridden okuyarak dolduracak.

            switch (prmMode)
            {
                case "I":

                    // elemanların Initial değerleri

                    tboxProductName.Text = "";
                    cboxCategory.SelectedIndex = 0; // Hepsi
                    cboxSupplier.SelectedIndex = 0;
                    nudStockQty.Value = 0;
                    chkbDiscontinued.Checked = false;






                        break;

                case "U":
                    tboxProductName.Text = dgrdProducts.CurrentRow.Cells[1].Value.ToString(); // ürün adı

                    cboxCategory.SelectedValue = dgrdProducts.CurrentRow.Cells[2].Value; // 2. DG indexinde CategoryID duruyor

                    cboxSupplier.SelectedValue = dgrdProducts.CurrentRow.Cells[4].Value; // 4. DG indexinde SupplierID duruyor.

                    nudStockQty.Value= Convert.ToInt32(dgrdProducts.CurrentRow.Cells[6].Value); // 6. DG indexinde quantity duruyor.

                    chkbDiscontinued.Checked = (bool)dgrdProducts.CurrentRow.Cells[7].Value;

 // 7. DG indexinde discontinued değeri duruyor.


                    break;

                default:
                    break;
            }

            tabcProducts.SelectedTab = tabcProducts.TabPages[1]; // Details tabbed sayfasını seçiyorum...

        }

        private void dgrdProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Mode = "U";
            ShowData("U"); // grid üzerine çift tıklamaylada update moda girsin
        }

        private void btonSave_Click(object sender, EventArgs e)
        {

            switch (Mode)

            {
                case "U":// Buraya U parametresi(Mode değişgenindeki değer) ile geliyorsam sql cümleciğimi UPDATE li olarak hazırla....

                    vs_SQLUpdate = $"UPDATE Products SET ProductName='{tboxProductName.Text}',CategoryID={cboxCategory.SelectedValue},SupplierID={cboxSupplier.SelectedValue},UnitsInStock={nudStockQty.Value},Discontinued={((byte)chkbDiscontinued.CheckState)} WHERE ProductID={dgrdProducts.CurrentRow.Cells[0].Value}";


                    break;

                case "I": // Buraya I parametresi ile geliyorsam sql cümleciğimi INSERT lü olarak hazırla....

                    vs_SQLUpdate = $"INSERT INTO Products(ProductName,CategoryID,SupplierID,UnitsInStock,Discontinued) VALUES ('{tboxProductName.Text}',{cboxCategory.SelectedValue},{cboxSupplier.SelectedValue},{nudStockQty.Value},{((byte)chkbDiscontinued.CheckState)}";


                    break;


                default:
                    break;
            }

            // sql cümleciklerini aynı değişgende tuttuğum için (vs_SQLUpdate) aslın kayıt yazma kısmı ortak dolayısı ile ayrı ayrı yazmama gerek yok. tek bir blok-aşadaki- olması yeterli..

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(vs_SQLUpdate, con))
                {
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open(); // tanımlanan connection açılıyor..

                        cmd.ExecuteNonQuery(); // çalıştırıyor..vs_sqlupdate stringimi sql server tarafına gönderiyorum

                        con.Close(); // connectionı kapatmak için

                        MessageBox.Show("Bilgileriniz başarıyla kaydedilmiştir...");

                        BindGrid(vs_SQLCommandAna); // DG yi tekrardan dolduruyorum.

                        tabcProducts.SelectedTab = tabcProducts.TabPages[0]; // General tabbed sayfasını seçiyorum.
                    }
                    catch (Exception message)
                    {
                        MessageBox.Show(message.ToString());

                    }

                }
            }

        }

        private void btonAdd_Click(object sender, EventArgs e)
        {
            Mode = "I";
            ShowData("I"); // Insert --> I Parametresi ile çağırıyorum
        }
    }
}
