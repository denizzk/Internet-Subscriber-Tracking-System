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

        private void genelToplamPanel_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();

            //cmd1 komutuyla paket sayısı databaseden elde ediliyor ve label5e veriliyor.
            SqlCommand cmd1 = new SqlCommand("select count(*) from paketler", conn);
            //cmd2 komutuyla abone sayısı databaseden elde ediliyor ve label3e veriliyor.
            SqlCommand cmd2 = new SqlCommand("select count(*) from aboneler", conn);
            //cmd3 komutuyla toplam fatura geliri databaseden hesaplanıyor ve label4e veriliyor.
            SqlCommand cmd3 = new SqlCommand("select sum(fiyat) from paketler,aboneler where p_ad=net_paket", conn);


            conn.Open();
            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
                totalAboneLabel.Text = reader[0].ToString();
            conn.Close();
            conn.Open();
            reader = cmd1.ExecuteReader();
            if (reader.Read())
                totalPaketLabel.Text = reader[0].ToString();
            conn.Close();
            conn.Open();
            reader = cmd3.ExecuteReader();
            if (reader.Read())
                totalGelirLabel.Text = reader[0].ToString() + "₺";
            conn.Close();
        }

        private void paketToplamTabPage_Click(object sender, EventArgs e)
        {
            //tab2 yüklenirken labeller ve textbox sıfırlanıyor.
            paketTotalAboneLabel.Text = "0";
            paketTotalGelirLabel.Text = "0₺";
            paketAdTextBox.Clear();
        }

        private void getirButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();

            //cmd1 komutuyla textbox1den girilen paket adına göre o paketi kullanan
            //abone sayısı databaseden elde ediliyor ve label7e veriliyor.
            SqlCommand cmd1 = new SqlCommand("select count(*) from aboneler where net_paket=@net_paket", conn);
            cmd1.Parameters.AddWithValue("@net_paket", paketAdTextBox.Text);
            //cmd2 komutuyla textbox1den girilen paket adına göre o paketten
            //ne kadar gelir elde edildiği databaseden elde ediliyor ve label9e veriliyor.
            SqlCommand cmd2 = new SqlCommand("select sum(fiyat) from aboneler,paketler where net_paket=p_ad and p_ad=@p_ad ", conn);
            cmd2.Parameters.AddWithValue("@p_ad", paketAdTextBox.Text);
            conn.Open();
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
                paketTotalAboneLabel.Text = reader[0].ToString();
            conn.Close();
            conn.Open();
            reader = cmd2.ExecuteReader();
            if (reader.Read())
                paketTotalGelirLabel.Text = reader[0].ToString() + "₺";
            conn.Close();
            
            //textbox sıfırlanıyor.
            paketAdTextBox.Clear();
        }
    }
}
