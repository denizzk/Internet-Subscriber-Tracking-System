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

namespace IATS
{
    public partial class PaketSil : Form
    {
        public PaketSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connString her pcde konumuna göre güncellenmelidir.
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deniz\source\repos\IATS\IATS\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            //silinecek paket texbox1den girilen paket adı ile databaseden olup olmadığı kontrol ediliyor.  
            //bulunamazsa hata mesajı veriliyor.bulunursa ama hali hazırda o paketi kullanan aboneler 
            //mevcutsa silme işlemi gerçekleşmiyor.eğer kullanan abone mevcut değilse paket bilgileri siliniyor
            SqlCommand command = new SqlCommand("select p_ad from paketler where p_ad=@p_ad", conn);
            command.Parameters.AddWithValue("@p_ad", textBox1.Text);

            conn.Open();

            if (command.ExecuteReader().HasRows)
            {
                conn.Close();
                
                DialogResult secenek = MessageBox.Show("Emin misiniz?", "Dikkat!", MessageBoxButtons.OKCancel);
                if (DialogResult.OK == secenek)
                {
                    SqlCommand cmd1 = new SqlCommand("select * from aboneler where net_paket=@p_ad", conn);
                    cmd1.Parameters.AddWithValue("@p_ad", textBox1.Text);

                    conn.Open();
                    if (cmd1.ExecuteReader().HasRows)
                    {
                        MessageBox.Show("Paketi Kullanan Aboneler Mevcut!", "Hata!");

                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd2 = new SqlCommand("delete from paketler where p_ad=@p_ad", conn);
                        cmd2.Parameters.AddWithValue("@p_ad", textBox1.Text);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Paket Kayıdı Başarıyla Silindi!", "Bilgi");
                    }
                }
                
            }

            else MessageBox.Show("Bu Paket Mevcut Değil!", "Hata!");
            conn.Close();
            
        }
    }
}
