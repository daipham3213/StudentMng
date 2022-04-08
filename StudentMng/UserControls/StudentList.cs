using StudentMng.Forms;
using StudentMng.Models;
using StudentMng.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMng.UserControls
{
    public partial class StudentList : UserControl
    {
        private BindingSource _source;

        private AppDbContext _context;
        private readonly AddStudent _addStudent;


        public StudentList(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            _addStudent = new AddStudent(ClosePanel);
            pnlUC.Hide();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            _source = new BindingSource();
            dataGridViewStudents.DataSource = _source;
            PopulateData();
        }

        private void LstStudents_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var isAddable = IsAddable(e.RowIndex, e.ColumnIndex);
            if (string.IsNullOrEmpty(isAddable))
            {
                var id = int.Parse(dataGridViewStudents[e.ColumnIndex, e.RowIndex].OwningRow.Cells["Id"].Value.ToString());
                var dataPropertyName = dataGridViewStudents[e.ColumnIndex, e.RowIndex].OwningColumn.DataPropertyName;
                var value = dataGridViewStudents[e.ColumnIndex, e.RowIndex].Value.ToString();

                using (_context = new AppDbContext())
                {
                    Student student = _context.Students.FirstOrDefault(s => s.Id == id);
                    foreach (var prop in student.GetType().GetProperties())
                    {
                        if (prop.Name == dataPropertyName)
                        {
                            student
                                .GetType()
                                .GetProperty(dataPropertyName)
                                .SetValue(student, Convert.ChangeType(value, prop.PropertyType), null);
                        }
                    }

                    _context.Students.AddOrUpdate(student);
                    _context.SaveChanges();
                }

                PopulateData();
            }
            else
            {
                MessageBox.Show(isAddable, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewStudents[e.ColumnIndex, e.RowIndex].Value = dataGridViewStudents.Tag;
            }
        }

        private bool ClosePanel()
        {
            pnlUC.Hide();
            PopulateData();
            return true;
        }
        private string IsAddable(int row, int col)
        {
            var value = dataGridViewStudents[col, row].Value.ToString();
            if (string.IsNullOrEmpty(value))
                return "Không được để trống ô";

            if (dataGridViewStudents.Columns[col].DataPropertyName == "PhoneNumber")
            {
                string regex = "^(0)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$";
                if (!Regex.IsMatch(value, regex))
                    return "Định dạng số điện thoại không đúng";
            }

            if (dataGridViewStudents.Columns[col].DataPropertyName == "StudentId")
            {
                using (_context = new AppDbContext())
                {
                    var id = int.Parse(value);
                    if (_context.Students.Any(s => s.StudentId == value))
                        return "Mã số sinh viên đã tồn tại";
                }
            }

            return "";
        }

        private void PopulateData()
        {
            using (_context = new AppDbContext())
            {
                List<Student> students = _context.Students.ToList();
                _source.DataSource = EnumerableExtensions.ToDataTable(students);
            }
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            pnlUC.Show();
            if (!pnlUC.Contains(_addStudent))
            {
                pnlUC.Controls.Add(_addStudent);
            }
            _addStudent.BringToFront();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearchTimer.Stop();
            txtSearchTimer.Start();
        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtSearchTimer_Tick(object sender, EventArgs e)
        {
            string value = txtSearch.Text;
            using (_context = new AppDbContext())
            {
                List<Student> students;
                if (value.Length == 0)
                {
                    students = _context.Students.ToList();
                }
                else
                {
                    students = _context.Students.Where(o =>
                        o.Name.Contains(value) || o.Address.Contains(value) || o.Birthdate.ToString().Contains(value) ||
                        o.Class.Contains(value) || o.Department.Contains(value) || o.Hometown.Contains((value)) ||
                        o.Majors.Contains(value) || o.CurrentJob.Contains(value) || o.PhoneNumber.Contains(value) ||
                        o.StudentId.Contains(value) || o.Rank.Contains(value) || o.GraduationYear.ToString().Contains(value)).ToList();
                }
                _source.DataSource = EnumerableExtensions.ToDataTable(students);
            }
            txtSearchTimer.Stop();
        }

        private void DataGridViewStudents_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Custom_KeyPress);
            var dataPropertyName = dataGridViewStudents.CurrentCell.OwningColumn.DataPropertyName;
            if (dataPropertyName == "PhoneNumber" || dataPropertyName == "GraduationYear")
            {
                e.Control.KeyPress += new KeyPressEventHandler(Custom_KeyPress);
            }
        }

        private void Custom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DataGridViewStudents_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGridViewStudents.Tag = dataGridViewStudents.CurrentCell.Value;
        }

        private void DataGridViewStudents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var currentRow = dataGridViewStudents.CurrentRow;

                DialogResult confirmResult = MessageBox.Show("Bạn có muốn xoá sinh viên này không?", "Xoá sinh viên",
                MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    using (_context = new AppDbContext())
                    {
                        int id = int.Parse(currentRow.Cells[0].Value.ToString());
                        Student student = _context.Students.FirstOrDefault(p => p.Id == id);
                        if (student != null) _context.Students.Remove(student);
                        _context.SaveChanges();
                    }

                    PopulateData();
                }
            }
        }
    }
}
