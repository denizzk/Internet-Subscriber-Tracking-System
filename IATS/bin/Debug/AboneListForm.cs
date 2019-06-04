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
            SqlConnection conn = DatabaseConnection.GetConnection();

            //select sorgusuyla databaseden veriler çekilip datagridviewe aktarılıyor.
            string cmdString = "SELECT AD,SOYAD,TC,ANNE_KIZLIK,TEL,ADRES,BAGLANTI_YER,ABONE_TIP,P_AD,FIYAT,AKK,TAAHHUT FROM ABONELER ,PAKETLER WHERE ABONELER.NET_PAKET=PAKETLER.P_AD";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdString,conn);

            conn.Open();

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            aboneListDataGridView.ReadOnly = true;
            aboneListDataGridView.DataSource = ds.Tables[0];

            conn.Close();           
           
            aboneListDataGridView.Columns[0].HeaderText = "Ad";
            aboneListDataGridView.Columns[1].HeaderText = "Soyad";
            aboneListDataGridView.Columns[2].HeaderText = "T.C. Kimlik No";
            aboneListDataGridView.Columns[3].HeaderText = "Anne Kızlık Soyadı";
            aboneListDataGridView.Columns[4].HeaderText = "Telefon No";
            aboneListDataGridView.Columns[5].HeaderText = "Adres";
            aboneListDataGridView.Columns[6].HeaderText = "Bağlantı Yeri";
            aboneListDataGridView.Columns[7].HeaderText = "Abonelik Tipi";
            aboneListDataGridView.Columns[8].HeaderText = "İnternet Paketi";
            aboneListDataGridView.Columns[9].HeaderText = "Paket Fiyatı(₺)";
            aboneListDataGridView.Columns[10].HeaderText = "Akk(Gb)";
            aboneListDataGridView.Columns[11].HeaderText = "Taahhüt Süresi(Ay)";
        }

        //girilen tc numarasına sahip aboneyi arayıp datagridviewde belirtiyor.
        private void aboneBulButton_Click(object sender, EventArgs e)
        {
            aboneListDataGridView.ClearSelection();
            bool exist = false;
            foreach(DataGridViewRow row in aboneListDataGridView.Rows)
            {
                if (row.Cells[2].Value.ToString() == aboneTcTextBox.Text)
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
        private void aboneTcTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("T.C. Kimlik Numarası Harf İçeremez!", "Hata!");

            }
        }
    }

}

