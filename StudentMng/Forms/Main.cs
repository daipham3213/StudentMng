using StudentMng.Models;
using StudentMng.Persistence;
using StudentMng.UserControls;
using System;
using System.Linq;
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
        private readonly AccountInfo _accountInfo;
        private Login _login;
        private string _username;

        public Main(Login login, string username)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _home = new Home();
            _studentList = new StudentList(_context);
            _statisic = new Statistic(_context);
            _adminInfo = new AdminInfo(_context);
            _accountInfo = new AccountInfo(_context);
            _login = login;
            _username = username;

            pnlUC.Hide();
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            pnlUC.Controls.Clear();
            pnlUC.Controls.Add(_studentList);

            pnlUC.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
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
            pnlUC.Controls.Clear();
            if (_username == "admin")
            {
                pnlUC.Controls.Add(_adminInfo);
            }
            else
            {
                pnlUC.Controls.Add(_accountInfo);
                _accountInfo.LoadData(_username);
            }

            pnlUC.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _login.Show();
            _adminInfo.CloseChangePassword();
            this.Close();
        }
    }
}
