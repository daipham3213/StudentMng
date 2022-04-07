using System;
using System.Windows.Forms;

namespace StudentMng.Forms
{
    public partial class Login : Form
    {
        private static readonly string username = "admin";
        private static readonly string password = "admin";
        public Login()
        {
            InitializeComponent();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string usr = txtUsername.Text;
            string pwd = txtPassword.Text;

            if (usr.Equals(username) && pwd.Equals(password))
            {
                var main = new Main();
                this.Hide();
                main.Show();
            }
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}