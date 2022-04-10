using StudentMng.Models;
using StudentMng.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMng.UserControls
{
    public partial class AddAccount : UserControl
    {
        private readonly Func<bool> onClose;
        public AddAccount(Func<bool> onClose)
        {
            InitializeComponent();
            this.onClose = onClose;
        }

        private void labelClosePanel_Click(object sender, EventArgs e)
        {
            onClose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                string usr = txtUsername.Text,
                        pwd = txtPassword.Text,
                        fn = txtFullname.Text;

                cbxPassword.Checked = false;
                cbxUsername.Checked = false;
                cbxFullname.Checked = false;

                if (string.IsNullOrEmpty(usr))
                {
                    cbxUsername.Visible = true;
                    cbxUsername.Text = "Không được để trống";
                    return;
                } else
                {
                    var isExisted = context.Users.Any(u => u.Username == txtUsername.Text);
                    if (isExisted)
                    {
                        cbxUsername.Visible = true;
                        cbxUsername.Text = "Tên tài khoản đã tồn tại";
                        return;
                    }

                    cbxUsername.Visible = false;
                }

                if (string.IsNullOrEmpty(pwd))
                {
                    cbxPassword.Visible = true;
                    cbxPassword.Text = "Không được để trống";
                    return;
                } else
                {
                    if (pwd.Length < 8)
                    {
                        cbxPassword.Visible = true;
                        cbxPassword.Text = "Mật khẩu quá ngắn";
                        return;
                    }
                    cbxPassword.Visible = false;
                }

                if (string.IsNullOrEmpty(fn))
                {
                    cbxFullname.Visible = true;
                    cbxFullname.Text = "Không được để trống";
                    return;
                } else
                {
                    cbxFullname.Visible = false;
                }

                var user = new User() { Username = usr, FullName = fn, Password = User.EncryptPassword(pwd) };
                context.Users.Add(user);
                context.SaveChanges();

                cbxFullname.Text = "";
                cbxPassword.Text = "";
                cbxUsername.Text = "";

                txtFullname.Clear();
                txtPassword.Clear();
                txtUsername.Clear();

                onClose();
            }
        }
    }
}
