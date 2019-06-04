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
    public partial class total : Form
    {
        public total()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //connString her pcde konumuna göre güncellenmelidir.
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deniz\source\repos\IATS\IATS\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            //cmd1 komutuyla paket sayısı databaseden elde ediliyor ve label5e veriliyor.
            SqlCommand cmd1 = new SqlCommand("select count(*) from paketler", conn);
            //cmd2 komutuyla abone sayısı databaseden elde ediliyor ve label3e veriliyor.
            SqlCommand cmd2 = new SqlCommand("select count(*) from aboneler", conn);
            //cmd3 komutuyla toplam fatura geliri databaseden hesaplanıyor ve label4e veriliyor.
            SqlCommand cmd3 = new SqlCommand("select sum(fiyat) from paketler,aboneler where p_ad=net_paket", conn);


            conn.Open();
            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
                label3.Text = reader[0].ToString();
            conn.Close();
            conn.Open();
            reader = cmd1.ExecuteReader();
            if (reader.Read())
                label5.Text = reader[0].ToString();
            conn.Close();
            conn.Open();
            reader = cmd3.ExecuteReader();
            if (reader.Read())
                label4.Text = reader[0].ToString() + "₺";
            conn.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //tab2 yüklenirken labeller ve textbox sıfırlanıyor.
            label7.Text = "0";
            label9.Text = "0₺";
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connString her pcde konumuna göre güncellenmelidir.
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deniz\source\repos\IATS\IATS\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            //cmd1 komutuyla textbox1den girilen paket adına göre o paketi kullanan
            //abone sayısı databaseden elde ediliyor ve label7e veriliyor.
            SqlCommand cmd1 = new SqlCommand("select count(*) from aboneler where net_paket=@net_paket", conn);
            cmd1.Parameters.AddWithValue("@net_paket", textBox1.Text);
            //cmd2 komutuyla textbox1den girilen paket adına göre o paketten
            //ne kadar gelir elde edildiği databaseden elde ediliyor ve label9e veriliyor.
            SqlCommand cmd2 = new SqlCommand("select sum(fiyat) from aboneler,paketler where net_paket=p_ad and p_ad=@p_ad ", conn);
            cmd2.Parameters.AddWithValue("@p_ad", textBox1.Text);
            conn.Open();
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
                label7.Text = reader[0].ToString();
            conn.Close();
            conn.Open();
            reader = cmd2.ExecuteReader();
            if (reader.Read())
                label9.Text = reader[0].ToString() + "₺";
            conn.Close();
            
            //textbox sıfırlanıyor.
            textBox1.Clear();
        }
    }
}
