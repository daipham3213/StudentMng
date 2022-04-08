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
        private AppDbContext _context;
        public Statistic(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var yearFilter = _context.Students.Select(s => s.GraduationYear).Distinct().ToList();
            foreach(var year in yearFilter)
            {
                cbbYearFilter.Items.Add(year);
            }
        }

        private void cbbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbbYearFilter.SelectedIndex.ToString());
        }
    }
}
