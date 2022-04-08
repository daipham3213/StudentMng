using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using StudentMng.Models;
using StudentMng.Persistence;

namespace StudentMng.UserControls
{
    public partial class AdminInfo : UserControl
    {
        private readonly AppDbContext _context;
        private User _user;
        public AdminInfo(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void AdminInfo_Load(object sender, EventArgs e)
        {
            _user = _context.Users.FirstOrDefault();
            if (_user != null)
            {
                txtFullname.Text = _user.FullName;
                txtUsername.Text = _user.Username;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && !txtUsername.Text.Equals(_user.Username))
            {
                btnUpdate.Enabled = true;
            }
        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {
            if (txtFullname.Text.Length > 0 && !txtFullname.Text.Equals(_user.FullName))
            {
                btnUpdate.Enabled = true;
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            var errors = new List<string>();
            var newPassword = txtNewPassword.Text;
            cbxStrength.Visible = newPassword.Length > 0;
            if (newPassword.Length > 0)
            {
                if (User.EncryptPassword(newPassword).Equals(_user.Password)) errors.Add("Không thể đặt trùng mật khẩu cũ");
                if (newPassword.Length < 8) errors.Add("Mật khẩu quá ngắn");
                if (txtConfirmPassword.Text.Length > 0) cbxMatch.Checked = txtConfirmPassword.Text.Equals(txtNewPassword.Text);
                btnChangePassword.Enabled = errors.Count <= 0;
            }
            else
            {
                btnChangePassword.Enabled = false;
            }

            if (errors.Count > 0)
            {
                cbxStrength.Text = errors.FirstOrDefault();
                cbxStrength.Checked = false;
            }
            else
            {
                cbxStrength.Checked = true;
                cbxStrength.Text = String.Empty;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            cbxMatch.Visible = txtNewPassword.Text.Length > 0;
            cbxMatch.Checked = txtConfirmPassword.Text.Equals(txtNewPassword.Text);
            btnChangePassword.Enabled = cbxMatch.Checked && cbxStrength.Checked;
            if (!txtConfirmPassword.Text.Equals(txtNewPassword.Text))
            {
                cbxMatch.Text = "Xác nhận mật khẩu sai";
            }
            else
            {
                cbxMatch.Text = String.Empty;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (cbxMatch.Checked && cbxStrength.Checked)
            {
                _user.Password = User.EncryptPassword(txtNewPassword.Text);
                _context.Users.AddOrUpdate(_user);
                _context.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công", "Thành công", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtConfirmPassword.Text = String.Empty;
                txtNewPassword.Text = String.Empty;
                txtCurrentPassword.Text = String.Empty;
                cbxMatch.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Enabled)
            {
                _user.FullName = txtFullname.Text;
                _user.Username = txtUsername.Text;
                _context.Users.AddOrUpdate(_user);
                _context.SaveChanges();
                MessageBox.Show("Đổi thông tin thành công", "Thành công", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}