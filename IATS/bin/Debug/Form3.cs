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
    public partial class AboneKayit : Form
    {
        public AboneKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //doğru girişleri sağlamak için kontroller.
            if (comboBox1.SelectedIndex == -1 || textBox1.TextLength == 0 || textBox2.TextLength == 0
                   || textBox3.TextLength < 11 || textBox4.TextLength == 0 || textBox5.TextLength < 10
                   || textBox6.TextLength == 0 || radioButton1.Checked == false && radioButton2.Checked == false
                   || radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "Hata!");
            }
            else {
                //connString her pcde konumuna göre güncellenmelidir.
                string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deniz\source\repos\IATS\IATS\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

                //textbox3teki tc girişinin önceden kayıtlı olup olmadığını kontrol ediyor.kayıtlıysa hata mesajı veriyor.
                //değilse insert ile kullanıcı girdilerini alıp yeni abone kaydı oluşturuyor.
            SqlCommand command = new SqlCommand("select tc from aboneler where tc=@tc",conn);
            command.Parameters.AddWithValue("@tc", Convert.ToDecimal(textBox3.Text));

            conn.Open();

                if (command.ExecuteReader().HasRows)
                {
                    MessageBox.Show("Bu Abone Zaten Mevcut!", "Hata!");
                }

                else
                {
                    conn.Close();

                    SqlCommand cmd = new SqlCommand("INSERT INTO ABONELER(AD,SOYAD,TC,ANNE_KIZLIK,TEL,ADRES,BAGLANTI_YER,ABONE_TIP,NET_PAKET) VALUES (@AD,@SOYAD,@TC,@ANNE_KIZLIK,@TEL,@ADRES,@BAGLANTI_YER,@ABONE_TIP,@NET_PAKET)", conn);
                    cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                    cmd.Parameters.AddWithValue("@soyad", textBox2.Text);
                    cmd.Parameters.AddWithValue("@tc", Convert.ToDecimal(textBox3.Text));
                    cmd.Parameters.AddWithValue("@anne_kizlik", textBox4.Text);
                    cmd.Parameters.AddWithValue("@tel", Convert.ToDecimal(textBox5.Text));
                    cmd.Parameters.AddWithValue("@adres", textBox6.Text);
                    if (radioButton1.Checked) cmd.Parameters.AddWithValue("@baglanti_yer", radioButton1.Text);
                    else cmd.Parameters.AddWithValue("@baglanti_yer", radioButton2.Text);
                    if (radioButton3.Checked) cmd.Parameters.AddWithValue("@abone_tip", radioButton3.Text);
                    else cmd.Parameters.AddWithValue("@abone_tip", radioButton4.Text);
                    cmd.Parameters.AddWithValue("@net_paket", comboBox1.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //kayıt ettikten sonra bilgilendirme ekranı verip formu yeni kayıt girişine hazır hale getiriyor.

                    MessageBox.Show("Abone Kayıdı Başarıyla Eklendi!", "Bilgi");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    comboBox1.Text = " ";
                }
            }
        }

        private void AboneKayit_Load(object sender, EventArgs e)
        {
            //connString her pcde konumuna göre güncellenmelidir.
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deniz\source\repos\IATS\IATS\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            //kayıt formu yüklenirken combobox paketler tablosundan dolduruluyor.
            //bu sayede kullanıcı mevcut olan istediği paketi seçiyor.
            SqlCommand cmd = new SqlCommand("select p_ad from paketler", conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
            comboBox1.ValueMember = "p_ad";
            comboBox1.DisplayMember = "p_ad";
            conn.Close();
        }
        //doğru girişleri sağlamak için özel kısıtlamalar.
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("T.C. Kimlik Numarası Harf İçeremez!", "Hata!");

            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Telefon Numarası Harf İçeremez!", "Hata!");

            }
        }
    }
}
