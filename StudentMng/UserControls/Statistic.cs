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

        public void LoadData()
        {
            cbbYearFilter.Items.Clear();
            cbbConditionFilter.Items.Clear();
            cbbCondition.SelectedItem = null;
            _source = new BindingSource();
            dataGridViewStudents.DataSource = _source;

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

        private void btnConditionFilter_Click(object sender, EventArgs e)
        {
            var filter = cbbConditionFilter.SelectedItem;
            var year = cbbYearFilter.SelectedItem;
            if (filter == null && year == null)
            {
                MessageBox.Show("Chưa chọn giá trị lọc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var students = _context.Students.ToList();
            if (year != null)
            {
                students = _context.Students.Where(s => s.GraduationYear.ToString() == year.ToString()).ToList();
            }

            if (filter != null)
            {
                switch (cbbCondition.SelectedIndex)
                {
                    case 0:
                        students = students.Where(s => s.Class == filter.ToString()).ToList();
                        break;
                    case 1:
                        students = students.Where(s => s.Department == filter.ToString()).ToList();
                        break;
                    case 2:
                        students = students.Where(s => s.Majors == filter.ToString()).ToList();
                        break;
                    default:
                        break;
                }
            }

            _source.DataSource = EnumerableExtensions.ToDataTable(students);
        }
    }
}
