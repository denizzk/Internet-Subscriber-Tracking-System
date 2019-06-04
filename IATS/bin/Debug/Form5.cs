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
    public partial class AboneUpdate : Form
    {
        public AboneUpdate()
        {
            InitializeComponent();
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            //connString her pcde konumuna göre güncellenmelidir.
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deniz\source\repos\IATS\IATS\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            //güncellenecek abone texbox7den girilen tc ile databasede abone bilgileri getiriliyor 
            //ve form dolduruluyor.bulunamazsa hata mesajı veriliyor.
            SqlCommand command = new SqlCommand("select * from aboneler where tc=@tc", conn);
            command.Parameters.AddWithValue("@tc", Convert.ToDecimal(textBox7.Text));

            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    textBox1.Text = reader.GetString(0);
                    textBox2.Text = reader.GetString(1);
                    textBox3.Text = reader[2].ToString();
                    textBox4.Text = reader.GetString(3);
                    textBox5.Text = reader[4].ToString();
                    textBox6.Text = reader.GetString(5);
                    if (radioButton1.Text == reader.GetString(6)) radioButton1.Checked = true;
                    else radioButton2.Checked = true;
                    if (radioButton3.Text == reader.GetString(7)) radioButton3.Checked = true;
                    else radioButton4.Checked = true;
                    comboBox1.SelectedText = reader.GetString(8);

                    conn.Close();
                }
            }else MessageBox.Show("Abone Bulunamadı!", "Hata!");            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hatalı giriş önlemek için spesifik kurallar.
            if ( textBox1.TextLength == 0 || textBox2.TextLength == 0
                  || textBox3.TextLength < 11 || textBox4.TextLength == 0 || textBox5.TextLength < 10
                  || textBox6.TextLength == 0 || radioButton1.Checked == false && radioButton2.Checked == false
                  || radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "Hata!");
            }
            else
            {
                //connString her pcde konumuna göre güncellenmelidir.
                string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deniz\source\repos\IATS\IATS\Database1.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);

                //textbox3teki tc girişinin önceden kayıtlı olup olmadığını kontrol ediyor.o tcye sahip bir abone hali hazırda 
                //kayıtlıysa hata mesajı veriyor.değilse update ile kullanıcı girdilerini alıp abone kaydını güncelliyor.
                SqlCommand command = new SqlCommand("select tc from aboneler where tc=@tc", conn);
                command.Parameters.AddWithValue("@tc", Convert.ToDecimal(textBox3.Text));

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
               
                if (reader.HasRows && textBox7.Text!=textBox3.Text)
                {
                    
                    MessageBox.Show("Bu Abone Zaten Mevcut!", "Hata!");
                }

                else
                {       
                    SqlCommand cmd = new SqlCommand("UPDATE ABONELER SET AD=@AD,SOYAD=@SOYAD,TC=@TC,ANNE_KIZLIK=@ANNE_KIZLIK,TEL=@TEL,ADRES=@ADRES,BAGLANTI_YER=@BAGLANTI_YER,ABONE_TIP=@ABONE_TIP,NET_PAKET=@NET_PAKET WHERE TC=@TC1", conn);
                    cmd.Parameters.AddWithValue("@tc1", Convert.ToDecimal(textBox7.Text));
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

                    conn.Close();
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //kayıt ettikten sonra bilgilendirme ekranı verip formu yeni kayıt girişine hazır hale getiriyor.
                    MessageBox.Show("Abone Kayıdı Başarıyla Güncellendi!", "Bilgi");

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
           
     

        private void AboneUpdate_Load(object sender, EventArgs e)
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
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("T.C. Kimlik Numarası Harf İçeremez!", "Hata!");

            }
        }
    }
}
