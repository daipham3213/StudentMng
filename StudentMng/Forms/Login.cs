using System;
using System.Windows.Forms;

namespace StudentMng.Forms
{
    public partial class Login : Form
    {
        private static string username = "admin";
        private static string password = "admin";
        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usr = txtUsername.Text;
            string pwd = txtPassword.Text;

            if (usr.Equals(username) && pwd.Equals(password))
            {
                var main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}