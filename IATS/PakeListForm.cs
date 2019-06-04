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

        private void bulButton_Click(object sender, EventArgs e)
        {
            //girilen paket adına sahip paketi arayıp datagridviewde belirtme.
            paketListDataGridView.ClearSelection();
            bool exist = false;
            foreach (DataGridViewRow row in paketListDataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString() == paketAdTextBox.Text)
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
            SqlConnection conn = DatabaseConnection.GetConnection();

            //select sorgusuyla databaseden veriler çekilip datagridviewe aktarılıyor.
            string cmdString = "SELECT * FROM PAKETLER";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdString, conn);

            conn.Open();

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            paketListDataGridView.ReadOnly = true;
            paketListDataGridView.DataSource = ds.Tables[0];

            conn.Close();

            paketListDataGridView.Columns[0].HeaderText = "Paket Adı";
            paketListDataGridView.Columns[1].HeaderText = "Fiyat (₺)";
            paketListDataGridView.Columns[2].HeaderText = "Adil Kullanım Kotası (AKK)";
            paketListDataGridView.Columns[3].HeaderText = "Taahhüt (Ay)";
        }
    }
}
