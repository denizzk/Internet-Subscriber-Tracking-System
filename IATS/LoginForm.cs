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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(idTextBox.Text=="system" && passTextBox.Text == "system")
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
