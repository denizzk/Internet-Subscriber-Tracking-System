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

        private void addButton_Click(object sender, EventArgs e)
        {
            //hatalı giriş önlemek için spesifik kurallar.
            if (paketAdTextBox.TextLength == 0 || paketFiyatTextBox.TextLength == 0
                   || paketAkkTextBox.TextLength == 0 || taahhutTextBox.TextLength == 0 )
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "Hata!");
            }
            else
            {
                SqlConnection conn = DatabaseConnection.GetConnection();

                //textbox1deki paket adının önceden kayıtlı olup olmadığını kontrol ediyor.kayıtlıysa hata mesajı veriyor.
                //değilse insert ile kullanıcı girdilerini alıp yeni paket kaydını ekliyor.
                SqlCommand command = new SqlCommand("select p_ad from paketler where p_ad=@p_ad", conn);
                command.Parameters.AddWithValue("@p_ad", paketAdTextBox.Text);

                conn.Open();

                if (command.ExecuteReader().HasRows)
                {
                    MessageBox.Show("Bu Paket Zaten Mevcut!", "Hata!");
                }

                else
                {
                    conn.Close();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Paketler(p_ad,fiyat,akk,taahhut) VALUES (@p_ad,@fiyat,@akk,@taahhut)", conn);
                    cmd.Parameters.AddWithValue("@p_ad", paketAdTextBox.Text);
                    cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(paketFiyatTextBox.Text));
                    cmd.Parameters.AddWithValue("@akk", Convert.ToDecimal(paketAkkTextBox.Text));
                    cmd.Parameters.AddWithValue("@taahhut", Convert.ToDecimal(taahhutTextBox.Text));
                    
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Paket Kayıdı Başarıyla Eklendi!", "Bilgi");

                    paketAdTextBox.Clear();
                    paketFiyatTextBox.Clear();
                    paketAkkTextBox.Clear();
                    taahhutTextBox.Clear();
                
                }
            }
        }

        //doğru girişleri sağlamak için özel kısıtlamalar.
        private void paketFiyatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Fiyat Harf İçeremez!", "Hata!");

            }
        }

        private void paketAkkTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Adil Kullanım Kotası Harf İçeremez!", "Hata!");

            }
        }

        private void taahhutTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Taahhüt Süresi Harf İçeremez!", "Hata!");

            }
        }
    }
}
