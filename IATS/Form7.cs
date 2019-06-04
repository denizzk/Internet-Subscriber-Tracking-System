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
using System.Xml;

namespace IATS
{
    public partial class PaketEkle : Form
    {
        public PaketEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hatalı giriş önlemek için spesifik kurallar.
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0
                   || textBox3.TextLength == 0 || textBox4.TextLength == 0 )
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "Hata!");
            }
            else
            {
                //connString her pcde konumuna göre güncellenmelidir.
                string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deniz\source\repos\IATS\IATS\Database1.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);

                //textbox1deki paket adının önceden kayıtlı olup olmadığını kontrol ediyor.kayıtlıysa hata mesajı veriyor.
                //değilse insert ile kullanıcı girdilerini alıp yeni paket kaydını ekliyor.
                SqlCommand command = new SqlCommand("select p_ad from paketler where p_ad=@p_ad", conn);
                command.Parameters.AddWithValue("@p_ad", textBox1.Text);

                conn.Open();

                if (command.ExecuteReader().HasRows)
                {
                    MessageBox.Show("Bu Paket Zaten Mevcut!", "Hata!");
                }

                else
                {
                    conn.Close();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Paketler(p_ad,fiyat,akk,taahhut) VALUES (@p_ad,@fiyat,@akk,@taahhut)", conn);
                    cmd.Parameters.AddWithValue("@p_ad", textBox1.Text);
                    cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(textBox2.Text));
                    cmd.Parameters.AddWithValue("@akk", Convert.ToDecimal(textBox3.Text));
                    cmd.Parameters.AddWithValue("@taahhut", Convert.ToDecimal(textBox4.Text));
                    
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Paket Kayıdı Başarıyla Eklendi!", "Bilgi");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                
                }
            }
        }

        //doğru girişleri sağlamak için özel kısıtlamalar.
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Fiyat Harf İçeremez!", "Hata!");

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Adil Kullanım Kotası Harf İçeremez!", "Hata!");

            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Taahhüt Süresi Harf İçeremez!", "Hata!");

            }
        }
    }
}
