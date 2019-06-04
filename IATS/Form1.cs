using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IATS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="system" && textBox2.Text == "system")
            {
                ActiveForm.Hide();
                Form Container = new Container();
                Container.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı ad ve şifresi uyumsuz!", "Hatalı Giriş!");
            }
        }
    }
}
