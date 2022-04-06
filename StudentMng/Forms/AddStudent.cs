using System;
using System.Windows.Forms;
using StudentMng.Models;
using StudentMng.Persistence;

namespace StudentMng.Forms
{
    public partial class AddStudent : UserControl
    {
        private Func<bool> onClose;

        public AddStudent(Func<bool> onClose)
        {
            InitializeComponent();
            this.onClose = onClose;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            onClose();
        }

        private Student FormValidate()
        {
            Student student = new Student();
            if (txtMSSV.Text.Length > 0) student.StudentId = txtMSSV.Text;
            else
            {
                ShowMessageBox(@"Bạn chưa nhập mã số sinh viên!");
                return null;
            }

            if (dtBirthdate.Value != DateTime.MinValue) student.Birthdate = dtBirthdate.Value;
            else
            {
                ShowMessageBox(@"Bạn chưa nhập ngày sinh");
                return null;
            }

            if (txtHometown.Text.Length > 0) student.Hometown = txtHometown.Text;
            else
            {
                ShowMessageBox(@"Bạn chưa nhập quê quán!");
                return null;
            }

            if (txtAddress.Text.Length > 0) student.Address = txtAddress.Text;
            else
            {
                ShowMessageBox(@"Bạn chưa nhập đia chỉ!");
                return null;
            }

            if (txtPhoneNumber.Text.Length > 0) student.PhoneNumber = txtPhoneNumber.Text;
            else
            {
                ShowMessageBox(@"Bạn chưa nhập số điện thoại!");
                return null;
            }

            if (txtDepartment.Text.Length > 0) student.Department = txtDepartment.Text;
            else
            {
                ShowMessageBox(@"Bạn chưa nhập khoa/viện!");
                return null;
            }

            if (txtMajors.Text.Length > 0) student.Majors = txtMajors.Text;
            else
            {
                ShowMessageBox(@"Bạn chưa nhập chuyên ngành!");
                return null;
            }

            if (txtClass.Text.Length > 0) student.Class = txtClass.Text;
            else
            {
                ShowMessageBox(@"Bạn chưa nhập lớp!");
                return null;
            }

            if (txtGraduationYear.Text.Length > 0) student.GraduationYear = Int32.Parse(txtGraduationYear.Text);
            else
            {
                ShowMessageBox(@"Bạn chưa nhập năm tốt nghiệp!");
                return null;
            }

            if (txtRank.Text.Length > 0) student.Rank = txtRank.Text;
            else
            {
                ShowMessageBox(@"Bạn chưa nhập hạng!");
                return null;
            }

            if (txtCurrentJob.Text.Length > 0) student.CurrentJob = txtCurrentJob.Text;
            else
            {
                ShowMessageBox(@"Bạn chưa nhập công việc hiện tại!");
                return null;
            }

            return student;
        }

        private void ShowMessageBox(String message)
        {
            MessageBox.Show(message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCreate_Click(object sender, EventArgs e)
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
    }
}