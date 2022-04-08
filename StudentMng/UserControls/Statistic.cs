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
    public partial class Statistic : UserControl
    {
        private BindingSource _source;
        private AppDbContext _context;
        public Statistic(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            _source = new BindingSource();
            dataGridViewStudents.DataSource = _source;
        }

        public void LoadData()
        {
            cbbYearFilter.Items.Clear();
            cbbConditionFilter.Items.Clear();
            cbbCondition.SelectedItem = null;

            var yearFilter = _context.Students.Select(s => s.GraduationYear).Distinct().ToList();
            foreach(var year in yearFilter)
            {
                cbbYearFilter.Items.Add(year);
            }
        }

        private void cbbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbConditionFilter.Items.Clear();

            switch (cbbCondition.SelectedIndex)
            {
                case 0:
                    LoadClassFilter();
                    break;
                case 1:
                    LoadDepartmentFilter();
                    break;
                case 2:
                    LoadMajorFilter();
                    break;
                default:
                    break;
            }
        }

        private void LoadClassFilter()
        {
            var classes = _context.Students.Select(s => s.Class).Distinct().ToList();
            foreach (var classFilter in classes) {
                cbbConditionFilter.Items.Add(classFilter);
            }
        }

        private void LoadDepartmentFilter()
        {
            var departments = _context.Students.Select(s => s.Department).Distinct().ToList();
            foreach (var department in departments)
            {
                cbbConditionFilter.Items.Add(department);
            }
        }

        private void LoadMajorFilter()
        {
            var majors = _context.Students.Select(s => s.Majors).Distinct().ToList();
            foreach (var major in majors)
            {
                cbbConditionFilter.Items.Add(major);
            }
        }

        private void ClassFilter(string filter)
        {
            var students = _context.Students.Where(s => s.Class == filter).ToList();
            _source.DataSource = EnumerableExtensions.ToDataTable(students);
        }

        private void DepartmentFilter(string filter)
        {
            var students = _context.Students.Where(s => s.Department == filter).ToList();
            _source.DataSource = EnumerableExtensions.ToDataTable(students);
        }

        private void MajorsFilter(string filter)
        {
            var students = _context.Students.Where(s => s.Majors == filter).ToList();
            _source.DataSource = EnumerableExtensions.ToDataTable(students);
        }

        private void btnYearFilter_Click(object sender, EventArgs e)
        {
            var year = cbbYearFilter.SelectedItem;
            if (year == null)
            {
                MessageBox.Show("Chưa chọn năm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var students = _context.Students.Where(s => s.GraduationYear.ToString() == year.ToString()).ToList();
            _source.DataSource = EnumerableExtensions.ToDataTable(students);
        }

        private void btnConditionFilter_Click(object sender, EventArgs e)
        {
            var filter = cbbConditionFilter.SelectedItem;
            if (filter == null)
            {
                MessageBox.Show("Chưa chọn giá trị lọc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (cbbCondition.SelectedIndex)
            {
                case 0:
                    ClassFilter(filter.ToString());
                    break;
                case 1:
                    DepartmentFilter(filter.ToString());
                    break;
                case 2:
                    MajorsFilter(filter.ToString());
                    break;
                default:
                    break;
            }
        }
    }
}
