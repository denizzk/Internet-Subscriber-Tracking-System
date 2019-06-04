using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace IATS
{
    public partial class AboneList : Form
    {
        public AboneList()
        {
            InitializeComponent();
        }

        private void AboneList_Load(object sender, EventArgs e)
        {
            //connString her pcde konumuna göre güncellenmelidir.
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deniz\source\repos\IATS\IATS\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            //select sorgusuyla databaseden veriler çekilip datagridviewe aktarılıyor.
            string cmdString = "SELECT AD,SOYAD,TC,ANNE_KIZLIK,TEL,ADRES,BAGLANTI_YER,ABONE_TIP,P_AD,FIYAT,AKK,TAAHHUT FROM ABONELER ,PAKETLER WHERE ABONELER.NET_PAKET=PAKETLER.P_AD";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdString,conn);

            conn.Open();

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            conn.Close();           
           
            dataGridView1.Columns[0].HeaderText = "Ad";
            dataGridView1.Columns[1].HeaderText = "Soyad";
            dataGridView1.Columns[2].HeaderText = "T.C. Kimlik No";
            dataGridView1.Columns[3].HeaderText = "Anne Kızlık Soyadı";
            dataGridView1.Columns[4].HeaderText = "Telefon No";
            dataGridView1.Columns[5].HeaderText = "Adres";
            dataGridView1.Columns[6].HeaderText = "Bağlantı Yeri";
            dataGridView1.Columns[7].HeaderText = "Abonelik Tipi";
            dataGridView1.Columns[8].HeaderText = "İnternet Paketi";
            dataGridView1.Columns[9].HeaderText = "Paket Fiyatı(₺)";
            dataGridView1.Columns[10].HeaderText = "Akk(Gb)";
            dataGridView1.Columns[11].HeaderText = "Taahhüt Süresi(Ay)";
        }

        //girilen tc numarasına sahip aboneyi arayıp datagridviewde belirtiyor.
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            bool exist = false;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value.ToString() == textBox1.Text)
                {
                    row.Selected = true;
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                MessageBox.Show("Abone Bulunamadı!", "Hata!");
            }
        }

        //hatalı girişi önlemek için spesifik şartlar.
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

