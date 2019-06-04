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
    public partial class AboneSil : Form
    {
        public AboneSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tc numarasının düzgün girilip girilmediğini kontrol ediyor.
            if (textBox1.TextLength < 11)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "Hata!");
            }
            else
            {
                //connString her pcde konumuna göre güncellenmelidir.
                string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deniz\source\repos\IATS\IATS\Database1.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);

                //textbox1deki tc girişinin önceden kayıtlı olup olmadığını kontrol ediyor.kayıtlı değilse hata mesajı veriyor.
                //kayıtlıysa delete ile abone kaydını siliyor.
                SqlCommand command = new SqlCommand("select tc from aboneler where tc=@tc", conn);
                command.Parameters.AddWithValue("@tc", Convert.ToDecimal(textBox1.Text));

                conn.Open();

                if (command.ExecuteReader().HasRows)
                {
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from aboneler where tc=@tc", conn);
                    cmd.Parameters.AddWithValue("@tc", textBox1.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Abone Kayıdı Başarıyla Silindi!", "Bilgi");
                }

                else MessageBox.Show("Bu Abone Mevcut Değil!", "Hata!");
                conn.Close();

            }
        }

        //doğru girişleri sağlamak için özel kısıtlamalar.
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("T.C. Kimlik Numarası Harf İçeremez!", "Hata!");

            }
        }
    }
}
