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
    public partial class PaketList : Form
    {
        public PaketList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //girilen paket adına sahip paketi arayıp datagridviewde belirtme.
            dataGridView1.ClearSelection();
            bool exist = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == textBox1.Text)
                {
                    row.Selected = true;
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                MessageBox.Show("Paket Bulunamadı!", "Hata!");
            }
        }

        private void PaketList_Load(object sender, EventArgs e)
        {
            //connString her pcde konumuna göre güncellenmelidir.
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deniz\source\repos\IATS\IATS\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            //select sorgusuyla databaseden veriler çekilip datagridviewe aktarılıyor.
            string cmdString = "SELECT * FROM PAKETLER";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdString, conn);

            conn.Open();

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            conn.Close();

            dataGridView1.Columns[0].HeaderText = "Paket Adı";
            dataGridView1.Columns[1].HeaderText = "Fiyat (₺)";
            dataGridView1.Columns[2].HeaderText = "Adil Kullanım Kotası (AKK)";
            dataGridView1.Columns[3].HeaderText = "Taahhüt (Ay)";
        }
    }
}
