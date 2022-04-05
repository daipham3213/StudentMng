using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using StudentMng.Models;
using StudentMng.Persistence;

namespace StudentMng.Forms
{
    public partial class Main : Form
    {
        private AppDbContext _context;
        private BindingSource source;

        public Main()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            source = new BindingSource();
            lstStudents.DataSource = source;
            PopulateData();
        }

        private void lstStudents_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Student student = GetRowValue(e.RowIndex);
            using (_context = new AppDbContext())
            {
                _context.Students.AddOrUpdate(student);
                _context.SaveChanges();
            }

            PopulateData();
        }

        private void PopulateData()
        {
            using (_context = new AppDbContext())
            {
                List<Student> students = _context.Students.ToList();
                source.DataSource = students;
            }
        }

        private Student GetRowValue(int row)
        {
            Student student = new Student();
            try
            {
                student.Id = Int32.Parse(lstStudents[0, row].Value.ToString());
                student.Birthdate = DateTime.Parse(lstStudents[2, row].Value.ToString());
                student.StudentId = lstStudents[1, row].Value.ToString();
                student.Hometown = lstStudents[3, row].Value.ToString();
                student.Address = lstStudents[4, row].Value.ToString();
                student.PhoneNumber = lstStudents[5, row].Value.ToString();
                student.Department = lstStudents[6, row].Value.ToString();
                student.Majors = lstStudents[7, row].Value.ToString();
                student.Class = lstStudents[8, row].Value.ToString();
                student.GraduationYear = Int32.Parse(lstStudents[9, row].Value.ToString());
                student.Rank = lstStudents[10, row].Value.ToString();
                student.CurrentJob = lstStudents[11, row].Value.ToString();
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
    }
}