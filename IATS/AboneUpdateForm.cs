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

        private void getirButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();

            //güncellenecek abone texbox7den girilen tc ile databasede abone bilgileri getiriliyor 
            //ve form dolduruluyor.bulunamazsa hata mesajı veriliyor.
            SqlCommand command = new SqlCommand("select * from aboneler where tc=@tc", conn);
            command.Parameters.AddWithValue("@tc", Convert.ToDecimal(aboneTcGetirTextBox.Text));
           
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    adTextBox.Text = reader.GetString(0);
                    soyadTextBox.Text = reader.GetString(1);
                    tcTextBox.Text = reader[2].ToString();
                    anneKizlikTextBox.Text = reader.GetString(3);
                    telTextBox.Text = reader[4].ToString();
                    adresTextBox.Text = reader.GetString(5);
                    if (baglantiEvRadioButton.Text == reader.GetString(6)) baglantiEvRadioButton.Checked = true;
                    else baglantiIsRadioButton.Checked = true;
                    if (abTypeBireyRadioButton.Text == reader.GetString(7)) abTypeBireyRadioButton.Checked = true;
                    else abTypeKurumRadioButton.Checked = true;
                    paketComboBox.SelectedText = reader.GetString(8);

                    conn.Close();
                }
            }else MessageBox.Show("Abone Bulunamadı!", "Hata!");            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //hatalı giriş önlemek için spesifik kurallar.
            if ( adTextBox.TextLength == 0 || soyadTextBox.TextLength == 0
                  || tcTextBox.TextLength < 11 || anneKizlikTextBox.TextLength == 0 || telTextBox.TextLength < 10
                  || adresTextBox.TextLength == 0 || baglantiEvRadioButton.Checked == false && baglantiIsRadioButton.Checked == false
                  || abTypeBireyRadioButton.Checked == false && abTypeKurumRadioButton.Checked == false)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "Hata!");
            }
            else
            {
                SqlConnection conn = DatabaseConnection.GetConnection();

                //textbox3teki tc girişinin önceden kayıtlı olup olmadığını kontrol ediyor.o tcye sahip bir abone hali hazırda 
                //kayıtlıysa hata mesajı veriyor.değilse update ile kullanıcı girdilerini alıp abone kaydını güncelliyor.
                SqlCommand command = new SqlCommand("select tc from aboneler where tc=@tc", conn);
                command.Parameters.AddWithValue("@tc", Convert.ToDecimal(tcTextBox.Text));

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
               
                if (reader.HasRows && aboneTcGetirTextBox.Text!=tcTextBox.Text)
                {
                    
                    MessageBox.Show("Bu Abone Zaten Mevcut!", "Hata!");
                }

                else
                {       
                    SqlCommand cmd = new SqlCommand("UPDATE ABONELER SET AD=@AD,SOYAD=@SOYAD,TC=@TC,ANNE_KIZLIK=@ANNE_KIZLIK,TEL=@TEL,ADRES=@ADRES,BAGLANTI_YER=@BAGLANTI_YER,ABONE_TIP=@ABONE_TIP,NET_PAKET=@NET_PAKET WHERE TC=@TC1", conn);
                    cmd.Parameters.AddWithValue("@tc1", Convert.ToDecimal(aboneTcGetirTextBox.Text));
                    cmd.Parameters.AddWithValue("@ad", adTextBox.Text);
                    cmd.Parameters.AddWithValue("@soyad", soyadTextBox.Text);
                    cmd.Parameters.AddWithValue("@tc", Convert.ToDecimal(tcTextBox.Text));
                    cmd.Parameters.AddWithValue("@anne_kizlik", anneKizlikTextBox.Text);
                    cmd.Parameters.AddWithValue("@tel", Convert.ToDecimal(telTextBox.Text));
                    cmd.Parameters.AddWithValue("@adres", adresTextBox.Text);
                    if (baglantiEvRadioButton.Checked) cmd.Parameters.AddWithValue("@baglanti_yer", baglantiEvRadioButton.Text);
                    else cmd.Parameters.AddWithValue("@baglanti_yer", baglantiIsRadioButton.Text);
                    if (abTypeBireyRadioButton.Checked) cmd.Parameters.AddWithValue("@abone_tip", abTypeBireyRadioButton.Text);
                    else cmd.Parameters.AddWithValue("@abone_tip", abTypeKurumRadioButton.Text);
                    cmd.Parameters.AddWithValue("@net_paket", paketComboBox.Text);

                    conn.Close();
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //kayıt ettikten sonra bilgilendirme ekranı verip formu yeni kayıt girişine hazır hale getiriyor.
                    MessageBox.Show("Abone Kayıdı Başarıyla Güncellendi!", "Bilgi");

                    adTextBox.Clear();
                    soyadTextBox.Clear();
                    tcTextBox.Clear();
                    anneKizlikTextBox.Clear();
                    telTextBox.Clear();
                    adresTextBox.Clear();
                    baglantiEvRadioButton.Checked = false;
                    baglantiIsRadioButton.Checked = false;
                    abTypeBireyRadioButton.Checked = false;
                    abTypeKurumRadioButton.Checked = false;
                    paketComboBox.Text = " ";
                }
            }

        }
           
     

        private void AboneUpdate_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();

            //kayıt formu yüklenirken combobox paketler tablosundan dolduruluyor.
            //bu sayede kullanıcı mevcut olan istediği paketi seçiyor.
            SqlCommand cmd = new SqlCommand("select p_ad from paketler", conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                paketComboBox.Items.Add(reader[0].ToString());
            }
            paketComboBox.ValueMember = "p_ad";
            paketComboBox.DisplayMember = "p_ad";
            conn.Close();
        }

        //doğru girişleri sağlamak için özel kısıtlamalar.
        private void tcTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("T.C. Kimlik Numarası Harf İçeremez!", "Hata!");

            }
        }

        private void telTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Telefon Numarası Harf İçeremez!", "Hata!");

            }
        }

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
