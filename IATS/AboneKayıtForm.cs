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

        private void addButton_Click(object sender, EventArgs e)
        {
            //doğru girişleri sağlamak için kontroller.
            if (paketComboBox.SelectedIndex == -1 || adTextBox.TextLength == 0 || soyadTextBox.TextLength == 0
                   || tcTextBox.TextLength < 11 || anneKizlikTextBox.TextLength == 0 || telTextBox.TextLength < 10
                   || adresTextBox.TextLength == 0 || baglantiEvRadioButton.Checked == false && baglantiIsRadioButton.Checked == false
                   || abTypeBireyRadioButton.Checked == false && abtypeKurumRadioButton.Checked == false)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "Hata!");
            }
            else {
               
            SqlConnection conn = DatabaseConnection.GetConnection();

             //textbox3teki tc girişinin önceden kayıtlı olup olmadığını kontrol ediyor.kayıtlıysa hata mesajı veriyor.
             //değilse insert ile kullanıcı girdilerini alıp yeni abone kaydı oluşturuyor.
            SqlCommand command = new SqlCommand("select tc from aboneler where tc=@tc",conn);
            command.Parameters.AddWithValue("@tc", Convert.ToDecimal(tcTextBox.Text));

            conn.Open();

                if (command.ExecuteReader().HasRows)
                {
                    MessageBox.Show("Bu Abone Zaten Mevcut!", "Hata!");
                }

                else
                {
                    conn.Close();

                    SqlCommand cmd = new SqlCommand("INSERT INTO ABONELER(AD,SOYAD,TC,ANNE_KIZLIK,TEL,ADRES,BAGLANTI_YER,ABONE_TIP,NET_PAKET) VALUES (@AD,@SOYAD,@TC,@ANNE_KIZLIK,@TEL,@ADRES,@BAGLANTI_YER,@ABONE_TIP,@NET_PAKET)", conn);
                    cmd.Parameters.AddWithValue("@ad", adTextBox.Text);
                    cmd.Parameters.AddWithValue("@soyad", soyadTextBox.Text);
                    cmd.Parameters.AddWithValue("@tc", Convert.ToDecimal(tcTextBox.Text));
                    cmd.Parameters.AddWithValue("@anne_kizlik", anneKizlikTextBox.Text);
                    cmd.Parameters.AddWithValue("@tel", Convert.ToDecimal(telTextBox.Text));
                    cmd.Parameters.AddWithValue("@adres", adresTextBox.Text);
                    if (baglantiEvRadioButton.Checked) cmd.Parameters.AddWithValue("@baglanti_yer", baglantiEvRadioButton.Text);
                    else cmd.Parameters.AddWithValue("@baglanti_yer", baglantiIsRadioButton.Text);
                    if (abTypeBireyRadioButton.Checked) cmd.Parameters.AddWithValue("@abone_tip", abTypeBireyRadioButton.Text);
                    else cmd.Parameters.AddWithValue("@abone_tip", abtypeKurumRadioButton.Text);
                    cmd.Parameters.AddWithValue("@net_paket", paketComboBox.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //kayıt ettikten sonra bilgilendirme ekranı verip formu yeni kayıt girişine hazır hale getiriyor.

                    MessageBox.Show("Abone Kayıdı Başarıyla Eklendi!", "Bilgi");

                    adTextBox.Clear();
                    soyadTextBox.Clear();
                    tcTextBox.Clear();
                    anneKizlikTextBox.Clear();
                    telTextBox.Clear();
                    adresTextBox.Clear();
                    baglantiEvRadioButton.Checked = false;
                    baglantiIsRadioButton.Checked = false;
                    abTypeBireyRadioButton.Checked = false;
                    abtypeKurumRadioButton.Checked = false;
                    paketComboBox.Text = " ";
                }
            }
        }

        private void AboneKayit_Load(object sender, EventArgs e)
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
