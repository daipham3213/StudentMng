using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using StudentMng.Models;
using StudentMng.Persistence;

namespace StudentMng.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Authenticate(string username, string password)
        {
            using (var context = new AppDbContext())
            {
                if (context.Users.Any(u => u.Username.Equals(username)))
                {
                    User user = context.Users.FirstOrDefault(u => u.Username == username);
                    var sha = new SHA512CryptoServiceProvider();
                    byte[] hash = sha.ComputeHash(Encoding.Default.GetBytes(password));
                    if (Convert.ToBase64String(hash) == user.Password)
                    {
                        var main = new Main();
                        this.Hide();
                        main.Show();
                    }
                    else
                    {
                        // Invalid password
                        MessageBox.Show(@"Sai thông tin đăng nhập!", @"Lỗi đăng nhập", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    // Invalid username
                    MessageBox.Show(@"Không tìm thấy người dùng này!", @"Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
              
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string usr = txtUsername.Text;
            string pwd = txtPassword.Text;

            var errors = new List<string>();
            
            if (usr.Length <= 0) errors.Add(@"Bạn chưa nhập tên đăng nhập");
            if (pwd.Length <= 0) errors.Add(@"Bạn chưa nhập mật khẩu");
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors), @"Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Authenticate(usr, pwd);
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}