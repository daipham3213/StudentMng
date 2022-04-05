using System;
using System.Windows.Forms;

namespace StudentMng.Forms
{
    public partial class Login : Form
    {
        private static String username = "admin";
        private static String password = "admin";
        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            String usr = txtUsername.Text;
            String pwd = txtPassword.Text;

            if (usr.Equals(Login.username) && pwd.Equals(Login.password))
            {
                MessageBox.Show(@"Chào mừng Admin!", @"Welcome!",MessageBoxButtons.OK);
                this.Hide();
                var main = new Main();
                main.Show();
            }
        }
    }
}