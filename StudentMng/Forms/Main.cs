using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using StudentMng.Models;
using StudentMng.Persistence;
using Zuby.ADGV;

namespace StudentMng.Forms
{
    public partial class Main : Form
    {
        private AppDbContext _context;
        private BindingSource _source;

        private AddStudent _addStudent;

        public Main()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _addStudent = new AddStudent(ClosePanel);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _source = new BindingSource();
            lstStudents.DataSource = _source;
            PopulateData();
        }

        private void lstStudents_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (IsAddable(e.RowIndex))
            {
                Student student = GetRowValue(e.RowIndex);
                using (_context = new AppDbContext())
                {
                    _context.Students.AddOrUpdate(student);
                    _context.SaveChanges();
                }

                PopulateData();
            }
        }

        private bool ClosePanel()
        {
            pnlUC.Hide();
            PopulateData();
            return true;
        }
        private bool IsAddable(int row)
        {
            for (int i = 1; i < lstStudents.Rows[row].Cells.Count; i++)
            {
                if (lstStudents[i, row].Value == DBNull.Value || lstStudents[i, row].Value == null) return false;
            }

            return true;
        }

        private void PopulateData()
        {
            using (_context = new AppDbContext())
            {
                List<Student> students = _context.Students.ToList();
                _source.DataSource = EnumerableExtensions.ToDataTable(students);
            }
        }

        private Student GetRowValue(int row)
        {
            Student student = new Student();
            try
            {
                if (lstStudents[0, row].Value != null && lstStudents[0, row].Value != DBNull.Value)
                {
                    student.Id = Int32.Parse(lstStudents[0, row].Value.ToString());
                }
                student.Birthdate = lstStudents[2, row].Value != null
                    ? DateTime.Parse(lstStudents[2, row].Value.ToString())
                    : DateTime.Today;
                student.StudentId = lstStudents[1, row].Value?.ToString();
                student.Hometown = lstStudents[3, row].Value?.ToString();
                student.Address = lstStudents[4, row].Value?.ToString();
                student.PhoneNumber = lstStudents[5, row].Value?.ToString();
                student.Department = lstStudents[6, row].Value?.ToString();
                student.Majors = lstStudents[7, row].Value?.ToString();
                student.Class = lstStudents[8, row].Value?.ToString();
                student.GraduationYear = lstStudents[9, row].Value != null
                    ? Int32.Parse(lstStudents[9, row].Value.ToString())
                    : DateTime.Today.Year;
                student.Rank = lstStudents[10, row].Value?.ToString();
                student.CurrentJob = lstStudents[11, row].Value?.ToString();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

            return student;
        }

        private void lstStudents_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show(@"Are you sure to delete this item?", @"Confirm Delete!!",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                using (_context = new AppDbContext())
                {
                    int id = Int32.Parse(lstStudents[0, e.Row.Index].Value.ToString());
                    Student student = _context.Students.FirstOrDefault(p => p.Id == id);
                    if (student != null) _context.Students.Remove(student);
                    _context.SaveChanges();
                }
            }
        }

        private void lstStudents_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 2:
                    MessageBox.Show(@"Sai định dạng ngày tháng năm", @"Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    break;
                case 9:
                    MessageBox.Show(@"Sai định dạng năm", @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void lstStudents_FilterStringChanged(object sender, AdvancedDataGridView.FilterEventArgs e)
        {
            _source.Filter = e.FilterString;
        }

        private void lstStudents_SortStringChanged(object sender, AdvancedDataGridView.SortEventArgs e)
        {
            _source.Sort = e.SortString;
        }

        private void tlbSearch_Search(object sender, AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            String value = e.ValueToSearch;
            
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
                        o.Address.Contains(value) || o.Birthdate.ToString().Contains(value) || o.Class.Contains(value) ||
                        o.Department.Contains(value) || o.Hometown.Contains((value)) || o.Majors.Contains(value) ||
                        o.CurrentJob.Contains(value) || o.PhoneNumber.Contains(value) || o.StudentId.Contains(value)).ToList();
                }
                _source.DataSource = EnumerableExtensions.ToDataTable(students);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            pnlUC.Visible = true;
            if (!pnlUC.Contains(_addStudent))
            {
                pnlUC.Controls.Add(_addStudent);
                _addStudent.Dock = DockStyle.Fill;
            }
            _addStudent.BringToFront();
        }
    }
}