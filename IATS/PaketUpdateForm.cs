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
    public partial class PaketUpdate : Form
    {
        public PaketUpdate()
        {
            InitializeComponent();
        }

        private void getirButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();

            //güncellenecek paket texbox5den girilen paket adı ile databaseden paket bilgileri getiriliyor 
            //ve form dolduruluyor.bulunamazsa hata mesajı veriliyor.
            SqlCommand command = new SqlCommand("select * from paketler where p_ad=@p_ad", conn);
            command.Parameters.AddWithValue("@p_ad", getirPaketTextBox.Text);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            if(reader.HasRows)
            {
                if (reader.Read())
                {
                    paketAdLabel.Text = reader[0].ToString();
                    paketFiyatTextBox.Text = reader[1].ToString();
                    paketAkkTextBox.Text = reader[2].ToString();
                    taahhutTextBox.Text = reader[3].ToString();

                    conn.Close();
                }
            }else MessageBox.Show("Paket Bulunamadı!", "Hata!");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //hatalı giriş önlemek için spesifik kurallar.
            if (paketAdLabel.Text.Length == 0 || paketFiyatTextBox.TextLength == 0
                    || paketAkkTextBox.TextLength == 0 || taahhutTextBox.TextLength == 0)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "Hata!");
            }
            else
            {

                SqlConnection conn = DatabaseConnection.GetConnection();

                //update ile kullanıcı girdilerini alıp abone kaydını güncelliyor.
                    SqlCommand cmd = new SqlCommand("UPDATE PAKETLER SET P_AD=@P_AD,FIYAT=@FIYAT,AKK=@AKK,TAAHHUT=@TAAHHUT WHERE P_AD=@P_AD1", conn);
                    cmd.Parameters.AddWithValue("@p_ad1", getirPaketTextBox.Text);
                    cmd.Parameters.AddWithValue("@p_ad", paketAdLabel.Text);
                    cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(paketFiyatTextBox.Text));
                    cmd.Parameters.AddWithValue("@akk", Convert.ToDecimal(paketAkkTextBox.Text));
                    cmd.Parameters.AddWithValue("@taahhut", Convert.ToDecimal(taahhutTextBox.Text));

     
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //kayıt ettikten sonra bilgilendirme ekranı verip formu yeni kayıt girişine hazır hale getiriyor.
                    MessageBox.Show("Paket Kayıdı Başarıyla Güncellendi!", "Bilgi");
                    paketAdLabel.Text="";
                    paketFiyatTextBox.Clear();
                    paketAkkTextBox.Clear();
                    taahhutTextBox.Clear();

                
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

        private void taahhutTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Taahhüt Süresi Harf İçeremez!", "Hata!");

            }
        }
    }
}
