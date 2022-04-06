using System.ComponentModel;
using Zuby.ADGV;

namespace StudentMng.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lstStudents = new Zuby.ADGV.AdvancedDataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHometown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGraduationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbSearch = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.lstStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lstStudents);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1262, 553);
            this.pnlMain.TabIndex = 0;
            // 
            // lstStudents
            // 
            this.lstStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lstStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.colId, this.colStudentId, this.colBirthdate, this.colHometown, this.colAddress, this.colPhoneNumber, this.colDepartment, this.colMajors, this.colClass, this.colGraduationYear, this.colRank, this.colCurrentJob});
            this.lstStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstStudents.FilterAndSortEnabled = true;
            this.lstStudents.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.lstStudents.Location = new System.Drawing.Point(0, 30);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstStudents.RowTemplate.Height = 24;
            this.lstStudents.Size = new System.Drawing.Size(1262, 523);
            this.lstStudents.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.lstStudents.TabIndex = 0;
            this.lstStudents.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.lstStudents_SortStringChanged);
            this.lstStudents.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.lstStudents_FilterStringChanged);
            this.lstStudents.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstStudents_CellEndEdit);
            this.lstStudents.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.lstStudents_DataError);
            this.lstStudents.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.lstStudents_UserDeletingRow);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 22;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colId.Visible = false;
            // 
            // colStudentId
            // 
            this.colStudentId.DataPropertyName = "StudentId";
            this.colStudentId.HeaderText = "MSSV";
            this.colStudentId.MinimumWidth = 22;
            this.colStudentId.Name = "colStudentId";
            this.colStudentId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colBirthdate
            // 
            this.colBirthdate.DataPropertyName = "Birthdate";
            this.colBirthdate.HeaderText = "Ngày sinh";
            this.colBirthdate.MinimumWidth = 22;
            this.colBirthdate.Name = "colBirthdate";
            this.colBirthdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colHometown
            // 
            this.colHometown.DataPropertyName = "Hometown";
            this.colHometown.HeaderText = "Quê quáng";
            this.colHometown.MinimumWidth = 22;
            this.colHometown.Name = "colHometown";
            this.colHometown.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Địa chỉ";
            this.colAddress.MinimumWidth = 22;
            this.colAddress.Name = "colAddress";
            this.colAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.DataPropertyName = "PhoneNumber";
            this.colPhoneNumber.HeaderText = "SĐT";
            this.colPhoneNumber.MinimumWidth = 22;
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colDepartment
            // 
            this.colDepartment.DataPropertyName = "Department";
            this.colDepartment.HeaderText = "Khoa";
            this.colDepartment.MinimumWidth = 22;
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colMajors
            // 
            this.colMajors.DataPropertyName = "Majors";
            this.colMajors.HeaderText = "Chuyên ngành";
            this.colMajors.MinimumWidth = 22;
            this.colMajors.Name = "colMajors";
            this.colMajors.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colClass
            // 
            this.colClass.DataPropertyName = "Class";
            this.colClass.HeaderText = "Lớp";
            this.colClass.MinimumWidth = 22;
            this.colClass.Name = "colClass";
            this.colClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colGraduationYear
            // 
            this.colGraduationYear.DataPropertyName = "GraduationYear";
            this.colGraduationYear.HeaderText = "Năm tốt nghiệp";
            this.colGraduationYear.MinimumWidth = 22;
            this.colGraduationYear.Name = "colGraduationYear";
            this.colGraduationYear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colRank
            // 
            this.colRank.DataPropertyName = "Rank";
            this.colRank.HeaderText = "Hạng";
            this.colRank.MinimumWidth = 22;
            this.colRank.Name = "colRank";
            this.colRank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colCurrentJob
            // 
            this.colCurrentJob.DataPropertyName = "CurrentJob";
            this.colCurrentJob.HeaderText = "Công việc hiện tại";
            this.colCurrentJob.MinimumWidth = 22;
            this.colCurrentJob.Name = "colCurrentJob";
            this.colCurrentJob.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tlbSearch
            // 
            this.tlbSearch.AllowMerge = false;
            this.tlbSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlbSearch.Location = new System.Drawing.Point(0, 0);
            this.tlbSearch.MaximumSize = new System.Drawing.Size(0, 27);
            this.tlbSearch.MinimumSize = new System.Drawing.Size(0, 27);
            this.tlbSearch.Name = "tlbSearch";
            this.tlbSearch.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tlbSearch.Size = new System.Drawing.Size(1262, 27);
            this.tlbSearch.TabIndex = 1;
            this.tlbSearch.Text = "Search Bar";
            this.tlbSearch.Search += new Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventHandler(this.tlbSearch_Search);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 553);
            this.Controls.Add(this.tlbSearch);
            this.Controls.Add(this.pnlMain);
            this.Name = "Main";
            this.Text = "Chương trình quản lý thông tin sinh viên";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.lstStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHometown;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajors;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGraduationYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentJob;

        private Zuby.ADGV.AdvancedDataGridView lstStudents;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar tlbSearch;

        private System.Windows.Forms.ColumnHeader oder;

        private System.Windows.Forms.Panel pnlMain;

        #endregion
    }
}