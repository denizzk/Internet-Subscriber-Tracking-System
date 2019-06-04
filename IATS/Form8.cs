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

        private void button2_Click(object sender, EventArgs e)
        {
            //connString her pcde konumuna göre güncellenmelidir.
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deniz\source\repos\IATS\IATS\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //güncellenecek paket texbox5den girilen paket adı ile databaseden paket bilgileri getiriliyor 
            //ve form dolduruluyor.bulunamazsa hata mesajı veriliyor.
            SqlCommand command = new SqlCommand("select * from paketler where p_ad=@p_ad", conn);
            command.Parameters.AddWithValue("@p_ad", textBox5.Text);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            if(reader.HasRows)
            {
                if (reader.Read())
                {
                    label5.Text = reader[0].ToString();
                    textBox2.Text = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                    textBox4.Text = reader[3].ToString();

                    conn.Close();
                }
            }else MessageBox.Show("Paket Bulunamadı!", "Hata!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hatalı giriş önlemek için spesifik kurallar.
            if (label5.Text.Length == 0 || textBox2.TextLength == 0
                    || textBox3.TextLength == 0 || textBox4.TextLength == 0)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "Hata!");
            }
            else
            {

                //connString her pcde konumuna göre güncellenmelidir.
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deniz\source\repos\IATS\IATS\Database1.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                //label5teki tc girişinin önceden kayıtlı olup olmadığını kontrol ediyor.
                //update ile kullanıcı girdilerini alıp abone kaydını güncelliyor.
                //SqlCommand command = new SqlCommand("select * from paketler where p_ad=@p_ad", conn);
                //command.Parameters.AddWithValue("@p_ad", label5.Text);

                //conn.Open();
                //SqlDataReader reader = command.ExecuteReader();
                
                //if (label5.Text.ToUpper() != textBox5.Text.ToUpper() && reader.HasRows)
                //{

                //    MessageBox.Show("Bu Paket Zaten Var!", "Hata!");
                //}
                //else
                //{

                    SqlCommand cmd = new SqlCommand("UPDATE PAKETLER SET P_AD=@P_AD,FIYAT=@FIYAT,AKK=@AKK,TAAHHUT=@TAAHHUT WHERE P_AD=@P_AD1", conn);
                    cmd.Parameters.AddWithValue("@p_ad1", textBox5.Text);
                    cmd.Parameters.AddWithValue("@p_ad", label5.Text);
                    cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(textBox2.Text));
                    cmd.Parameters.AddWithValue("@akk", Convert.ToDecimal(textBox3.Text));
                    cmd.Parameters.AddWithValue("@taahhut", Convert.ToDecimal(textBox4.Text));

                    //conn.Close();
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //kayıt ettikten sonra bilgilendirme ekranı verip formu yeni kayıt girişine hazır hale getiriyor.
                    MessageBox.Show("Paket Kayıdı Başarıyla Güncellendi!", "Bilgi");
                    label5.Text="";
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                
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
