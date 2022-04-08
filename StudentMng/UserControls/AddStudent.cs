using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using StudentMng.Models;
using StudentMng.Persistence;

namespace StudentMng.Forms
{
    public partial class AddStudent : UserControl
    {
        private readonly Func<bool> onClose;

        public AddStudent(Func<bool> onClose)
        {
            InitializeComponent();
            this.onClose = onClose;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            onClose();
        }

        private Student FormValidate()
        {
            Student student = new Student();
            var errors = new List<string>();

            if (txtMSSV.Text.Length <= 0)
            {
                errors.Add("Bạn chưa nhập mã số sinh viên!");
            }
            else
            {
                if (!IsValidStudentId(txtMSSV.Text))
                    errors.Add("Mã số sinh viên đã tồn tại!");
            }

            if (txtName.Text.Length <= 0)
            {
                errors.Add("Bạn chưa nhập tên sinh viên!");
            }

            if (dtBirthdate.Value == DateTime.MinValue)
            {
                errors.Add("Bạn chưa nhập ngày sinh!");
            }

            if (txtHometown.Text.Length <= 0)
            {
                errors.Add("Bạn chưa nhập quê quán!");
            }

            if (txtAddress.Text.Length <= 0)
            {
                errors.Add("Bạn chưa nhập địa chỉ!");
            }

            if (txtPhoneNumber.Text.Length <= 0)
            {
                errors.Add("Bạn chưa nhập số điện thoại!");
            }
            else
            {
                string regex = "^(0)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$";
                if (!Regex.IsMatch(txtPhoneNumber.Text, regex))
                {
                    errors.Add("Định dạng số điện thoại không đúng!");
                }
            }

            if (txtDepartment.Text.Length <= 0)
            {
                errors.Add("Bạn chưa nhập khoa/viện!");
            }

            if (txtMajors.Text.Length <= 0)
            {
                errors.Add("Bạn chưa nhập chuyên ngành!");
            }

            if (txtClass.Text.Length <= 0)
            {
                errors.Add("Bạn chưa nhập lớp!");
            }

            if (txtGraduationYear.Text.Length <= 0)
            {
                errors.Add("Bạn chưa nhập năm tốt nghiệp!");
            }

            if (cbbRank.Text.Length <= 0)
            {
                errors.Add("Bạn chưa chọn hạng!");
            }

            if (txtCurrentJob.Text.Length <= 0)
            {
                errors.Add("Bạn chưa nhập công việc hiện tại!");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors.ToArray()), @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            student.StudentId = txtMSSV.Text;
            student.Name = txtName.Text;
            student.Hometown = txtHometown.Text;
            student.Birthdate = dtBirthdate.Value;
            student.Address = txtAddress.Text;
            student.PhoneNumber = txtPhoneNumber.Text;
            student.Department = txtDepartment.Text;
            student.Majors = txtMajors.Text;
            student.Class = txtClass.Text;
            student.GraduationYear = int.Parse(txtGraduationYear.Text);
            student.Rank = cbbRank.Text;
            student.CurrentJob = txtCurrentJob.Text;

            return student;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                Student student = FormValidate();
                if (student != null)
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                    onClose();
                }
            }

        }

        private void TxtGraduationYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            onClose();
        }

        private bool IsValidStudentId(string id)
        {
            using (var _context = new AppDbContext())
            {
                if (_context.Students.Any(s => s.StudentId == id))
                    return false;
            }

            return true;
        }
    }
}