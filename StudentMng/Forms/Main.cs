using StudentMng.Persistence;
using StudentMng.UserControls;
using System;
using System.Windows.Forms;

namespace StudentMng.Forms
{
    public partial class Main : Form
    {
        private AppDbContext _context;
        private readonly Home _home;
        private readonly StudentList _studentList;
        private readonly Statistic _statisic;
        private readonly AdminInfo _adminInfo;

        public Main()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _home = new Home();
            _studentList = new StudentList(_context);
            _statisic = new Statistic(_context);
            _adminInfo = new AdminInfo(_context);
            
            pnlUC.Controls.Clear();
            pnlUC.Controls.Add(_studentList);
            _studentList.BringToFront();

            pnlUC.Show();
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            pnlUC.Show();
            pnlUC.Controls.Clear();
            pnlUC.Controls.Add(_studentList);
            _studentList.BringToFront();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            pnlUC.Show();
            pnlUC.Controls.Clear();
            pnlUC.Controls.Add(_statisic);
            _statisic.LoadData();

            pnlUC.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlUC.Controls.Clear();
            pnlUC.Controls.Add(_home);

            pnlUC.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pnlUC.Show();
            pnlUC.Controls.Clear();
            pnlUC.Controls.Add(_adminInfo);
            _adminInfo.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }
    }
}