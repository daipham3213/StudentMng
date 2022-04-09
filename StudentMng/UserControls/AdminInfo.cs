﻿using System;
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
        private readonly BindingSource _source;
        private User _user;

        public AdminInfo(AppDbContext context)
        {
            InitializeComponent();
            _source = new BindingSource();
            _context = context;
        }

        private void AdminInfo_Load(object sender, EventArgs e)
        {
            var users = _context.Users.ToList();
            dataGridViewStudents.DataSource = EnumerableExtensions.ToDataTable(users);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridViewStudents.CurrentRow;
            if (currentRow != null)
            {
                int id = int.Parse(currentRow.Cells[0].Value.ToString());
                _user = _context.Users.FirstOrDefault(u => u.Id == id);
                panelChangePasswowrd.Visible = true;
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
                bnConfirm.Enabled = errors.Count <= 0;
            }
            else
            {
                bnConfirm.Enabled = false;
            }

            if (errors.Count > 0)
            {
                cbxStrength.Text = errors.FirstOrDefault();
                cbxStrength.Checked = false;
            }
            else
            {
                cbxStrength.Checked = true;
                cbxStrength.Text = string.Empty;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            cbxMatch.Visible = txtNewPassword.Text.Length > 0;
            cbxMatch.Checked = txtConfirmPassword.Text.Equals(txtNewPassword.Text);
            bnConfirm.Enabled = cbxMatch.Checked && cbxStrength.Checked;
            if (!txtConfirmPassword.Text.Equals(txtNewPassword.Text))
            {
                cbxMatch.Text = "Xác nhận mật khẩu sai";
            }
            else
            {
                cbxMatch.Text = string.Empty;
            }
        }

        private void bnConfirm_Click(object sender, EventArgs e)
        {
            if (cbxMatch.Checked && cbxStrength.Checked)
            {
                _user.Password = User.EncryptPassword(txtNewPassword.Text);
                _context.Users.AddOrUpdate(_user);
                _context.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công", "Thành công", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtConfirmPassword.Text = string.Empty;
                txtNewPassword.Text = string.Empty;

                cbxMatch.Visible = false;
                cbxMatch.Visible = false;
            }

        }

        private void labelClosePanel_Click(object sender, EventArgs e)
        {
            panelChangePasswowrd.Hide();
            txtConfirmPassword.Clear();
            txtNewPassword.Clear();
        }

        public void CloseChangePassword()
        {
            panelChangePasswowrd.Hide();
        }
    }
}