﻿using StudentMng.Persistence;
using StudentMng.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMng.Forms
{
    public partial class Main : Form
    {
        private AppDbContext _context;
        private readonly StudentList _studentList;
        private readonly Statistic _statisic;

        public Main()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _studentList = new StudentList(_context);
            _statisic = new Statistic(_context);

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
            _studentList.BringToFront();
        }
    }
}
