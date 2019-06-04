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
    public partial class AboneSil : Form
    {
        public AboneSil()
        {
            InitializeComponent();
        }

        private void aboneDeleteButton_Click(object sender, EventArgs e)
        {
            //tc numarasının düzgün girilip girilmediğini kontrol ediyor.
            if (tcTextBox.TextLength < 11)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "Hata!");
            }
            else
            {
                SqlConnection conn = DatabaseConnection.GetConnection();
                
                //textbox1deki tc girişinin önceden kayıtlı olup olmadığını kontrol ediyor.kayıtlı değilse hata mesajı veriyor.
                //kayıtlıysa delete ile abone kaydını siliyor.
                SqlCommand command = new SqlCommand("select tc from aboneler where tc=@tc", conn);
                command.Parameters.AddWithValue("@tc", Convert.ToDecimal(tcTextBox.Text));

                conn.Open();

                if (command.ExecuteReader().HasRows)
                {
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from aboneler where tc=@tc", conn);
                    cmd.Parameters.AddWithValue("@tc", tcTextBox.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Abone Kayıdı Başarıyla Silindi!", "Bilgi");
                }
                else MessageBox.Show("Bu Abone Mevcut Değil!", "Hata!");
                conn.Close();
            }
        }

        //doğru girişleri sağlamak için özel kısıtlamalar.
        private void aboneTcGetirTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("T.C. Kimlik Numarası Harf İçeremez!", "Hata!");
            }
        }
    }
}
