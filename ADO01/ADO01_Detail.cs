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

    public partial class ADO01_Detail : Form
    {
        public string Mode; // bu değişgen public yani başka bir formdan değeri belirlenecek türden
        //string constring = @"Data Source=DESKTOP-AD6B5QM\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        string constring = @"Data Source=PHOKAIA;Initial Catalog=Northwind;User id = sa;password=Doga251200";


        public ADO01_Detail()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close(); // formu kapatacak

        }

        private void btonSave_Click(object sender, EventArgs e)
        {
            string vs_SQLText="";

            // bu form her iki işe de yarayacağı için hangi modda olduğumu anlamam lazım

            switch (Mode)
            {
                // Bazı SQL injectionları engellemek açısından ve daha sade bir komut satırı olması için parametrik kullanım tercih edildi.
                case "U":
                    vs_SQLText = "UPDATE Customers SET ";
                    /* vs_SQLText += "CompanyName='" + tboxCompanyName.Text + "' ";*/
                    vs_SQLText += "CompanyName=@CompanyName,";
                    vs_SQLText += "ContactName=@ContactName,";
                    vs_SQLText += "Country=@Country ";
                    vs_SQLText += "WHERE CustomerID=@CustomerID";
                    // SQL Text oluşturuldu...Parametreli...
                    break;

                case "I":
                    vs_SQLText = "INSERT INTO Customers (CustomerID,CompanyName,ContactName,Country) VALUES (@CustomerID,@CompanyName,@ContactName,@Country)";
                        break;
                default:
                    break;
            }

            using(SqlConnection con= new SqlConnection(constring)) 
            {
                using (SqlCommand cmd = new SqlCommand(vs_SQLText, con))
                {
                    // şimdi sıra parametreleri doldurmada...
                    cmd.Parameters.AddWithValue("CustomerID", tboxCustomerID.Text);
                    cmd.Parameters.AddWithValue("CompanyName", tboxCompanyName.Text);
                    cmd.Parameters.AddWithValue("ContactName", tboxContactName.Text);
                    cmd.Parameters.AddWithValue("Country", tboxCountry.Text);

                    cmd.CommandType = CommandType.Text;


                    // **************************
                    // Parametreli kullanımdan ve güvenlik nedenlerinden dolayı hazırlanan SQL cümlesinin içeriği debug modda tam olarak izlenemiyor. Bu durumda adım adım izlemek gerektiğinde aşağıdaki kod bloğunu kullanabilirsiniz..
                    //
                    // string tmp = cmd.CommandText.ToString();
                    // foreach (SqlParameter param in cmd.Parameters)
                    // {
                    //    tmp = tmp.Replace(param.ParameterName.ToString(), "'" + param.Value.ToString() + "'");
                    // }



                    try
                    {
                        con.Open(); // tanımlanan connection açılıyor..
                        cmd.ExecuteNonQuery(); // çalıştırıyor..sqltextimi sql server tarafına gönderiyor

                        MessageBox.Show("Bilgileriniz başarıyla kaydedilmiştir...");
                        this.Close();

                    }
                    catch (Exception message)
                    {
                        MessageBox.Show(message.ToString());
                        
                    }

                }




            }

        }

        private void ADO01_Detail_Load(object sender, EventArgs e)
        {

        }
    }
}
