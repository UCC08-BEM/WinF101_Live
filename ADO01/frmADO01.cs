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
    public partial class frmADO01 : Form
    {
        // Global Kısım
        // Aşağıdaki değişgen VT bağlanabilmek için gerekli olan bağlantı cümleciğidir. Şu makinaya..şu database e bağlanmak istiyorum gibi
        //string constring = @"Data Source=DESKTOP-AD6B5QM\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        string constring = @"Data Source=PHOKAIA;Initial Catalog=Northwind;User id = sa;password=Doga251200";

        string vs_SQLText = "";

        public frmADO01()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmADO01_Load(object sender, EventArgs e)
        {
            // form ilk ekrana geldiğinde DG otomatik dolu gelsin
            PrepareGrid(); // DG mi hazırlıyorum...
            BindGrid(); // DG yi doldur ve ekrana gelsin...

        }


        // 

        private void PrepareGrid()
        {
            // datagridin otomatik olarak db tablosuna bakıp gridin kolonlarını yaratmasını istemiyorum. Ben yapcam...manuel
            dgrdCustomers.AutoGenerateColumns = true;

            // Eğer GD nin en baş tarafındaki kolonu "RowHeader" görmek istemiyorsam
            dgrdCustomers.RowHeadersVisible = false;

            // DG deki kolonları tek tek dolaşmak yerine tek bir satırı ayrıştırma
            dgrdCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // DG deki kolonları DGnin genişliğine göre ayarlama
            dgrdCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // DG nin üzerinde elle oynamayı yasaklama
            dgrdCustomers.ReadOnly = true;

            // DGnin üzerinde kullanıcının satır/kayıt eklemesini ve silmesini yasaklama
            dgrdCustomers.AllowUserToAddRows = false;
            dgrdCustomers.AllowUserToDeleteRows = false;

            // DGnin satırlarının yüklekliğini değiştirmeyi yasaklama
            dgrdCustomers.AllowUserToResizeRows = false;

        }

        private void BindGrid()
        {
            // DG yi dolduran bölüm

            using (SqlConnection con=new SqlConnection(constring))
            {
                using (SqlCommand cmd= new SqlCommand("SELECT CustomerID,CompanyName,ContactName,Country FROM Customers",con)) // con nesnesini kullanarak SQL komutunu oluştur..
                {
                    cmd.CommandType = CommandType.Text;

                    // aşağıda cmd nesnesini kullanabileciğim veri  geliş/gidişini ayarlayan bir DA oluşturuyorum.
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dset=new DataSet())
                        {
                            sda.Fill(dset); // Adaptörüm yarattığı DS i doldursun
                            dgrdCustomers.DataSource = dset.Tables[0]; // DS oluştu ..içine tablo taşındı ve DG in içi,nde görülebilir hale geldi.
                        }
                    }
                }
            }
        }

        private void btonAdd_Click(object sender, EventArgs e)
        {
            ShowData("I"); // metoduma Insert işlemi yapabilmek için I parametresini gönderiyorum

            BindGrid(); // Refresh Re-Bind...

            
        }

        private void btonUpdate_Click(object sender, EventArgs e)
        {
            ShowData("U");// metoduma Update işlemi yapabilmek için U parametresini gönderiyorum

            BindGrid();

        }

        private void btonDelete_Click(object sender, EventArgs e)
        {
            // delete

            DialogResult dialogResult = MessageBox.Show("Veriyi gerçekten silmek istiyor musunuz?", "İşlem Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection con=new SqlConnection(constring))
                {
                    vs_SQLText = "DELETE FROM Customers WHERE CustomerID='" + dgrdCustomers.CurrentRow.Cells[0].Value.ToString() + "'"; // seçili satırdaki 0. kolonda bulunan değeri alarak silme işlemini yapar...

                    using (SqlCommand cmd = new SqlCommand(vs_SQLText, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        try
                        {
                            con.Open();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("bilgileriniz silindi....");

                            BindGrid(); // refresh
                        }
                        catch (Exception message)
                        {
                            MessageBox.Show("Hata : "+message.ToString());
                        }

                    }

                }


            }
        }

        private void ShowData(string prmMode)
        {
            // Bu metod üzerine aldığı parametreye göre 2. bir form açacak. 2. form istenilen işlemin (I,U) değerine göre ekrana gelecek. I/U işlemini bu yeni form üzerin yapacak. D işlemi şu an bulunulan formdan yapacak.


            ADO01_Detail frmADO01_Detail = new ADO01_Detail();

            frmADO01_Detail.Mode = prmMode; // gelen parametreyi direkt olarak detay formuna pasladım.


            // gelen parametreye göre diğer detay formun elemanlarını ayarlıyorum

            switch (prmMode)
            {
                case "I":
                    // Initial değerler veriliyor...
                    frmADO01_Detail.tboxCustomerID.Enabled = true;
                    frmADO01_Detail.tboxCompanyName.Text = "";
                    frmADO01_Detail.tboxContactName.Text = "";
                    frmADO01_Detail.tboxCountry.Text = "";

                    frmADO01_Detail.tboxCustomerID.Select();
                    break;

                case "U":
                    // Initial değerler veriliyor...
                    frmADO01_Detail.tboxCustomerID.Enabled = false;

                    frmADO01_Detail.tboxCustomerID.Text = dgrdCustomers.CurrentRow.Cells[0].Value.ToString();
                    frmADO01_Detail.tboxCompanyName.Text = dgrdCustomers.CurrentRow.Cells[1].Value.ToString();
                    frmADO01_Detail.tboxContactName.Text = dgrdCustomers.CurrentRow.Cells[2].Value.ToString(); ;
                    frmADO01_Detail.tboxCountry.Text = dgrdCustomers.CurrentRow.Cells[3].Value.ToString(); ;

                    frmADO01_Detail.tboxCompanyName.Select();
                    break;




                default:
                    break;
            }



            frmADO01_Detail.ShowDialog();


        }

        private void dgrdCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // aynı sanki Update butonuna basılmış gibi davranacak...
            ShowData("U");
            // döndü..tekrardan gridi doldurması lazım...Refresh...
            BindGrid();

        }
    }
}
