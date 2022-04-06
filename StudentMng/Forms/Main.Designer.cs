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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlUC = new System.Windows.Forms.Panel();
            this.tlbSearch = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            this.btnAddStudent = new System.Windows.Forms.ToolStripButton();
            this.lstStudents = new Zuby.ADGV.AdvancedDataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthdate = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.colHometown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGraduationYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.tlbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.lstStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlUC);
            this.pnlMain.Controls.Add(this.tlbSearch);
            this.pnlMain.Controls.Add(this.lstStudents);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1262, 753);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlUC
            // 
            this.pnlUC.Location = new System.Drawing.Point(338, 118);
            this.pnlUC.Name = "pnlUC";
            this.pnlUC.Size = new System.Drawing.Size(580, 510);
            this.pnlUC.TabIndex = 2;
            // 
            // tlbSearch
            // 
            this.tlbSearch.AllowMerge = false;
            this.tlbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tlbSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlbSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.btnAddStudent});
            this.tlbSearch.Location = new System.Drawing.Point(0, 0);
            this.tlbSearch.MaximumSize = new System.Drawing.Size(0, 40);
            this.tlbSearch.MinimumSize = new System.Drawing.Size(0, 40);
            this.tlbSearch.Name = "tlbSearch";
            this.tlbSearch.Padding = new System.Windows.Forms.Padding(5);
            this.tlbSearch.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tlbSearch.Size = new System.Drawing.Size(1262, 40);
            this.tlbSearch.TabIndex = 1;
            this.tlbSearch.Text = "Search Bar";
            this.tlbSearch.Search += new Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventHandler(this.tlbSearch_Search);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (255)))));
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddStudent.Image = ((System.Drawing.Image) (resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.btnAddStudent.Size = new System.Drawing.Size(124, 27);
            this.btnAddStudent.Text = "Thêm sinh viên";
            this.btnAddStudent.ToolTipText = "Thêm sinh viên";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lstStudents
            // 
            this.lstStudents.AllowUserToAddRows = false;
            this.lstStudents.AllowUserToResizeColumns = false;
            this.lstStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lstStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.colId, this.colStudentId, this.colBirthdate, this.colHometown, this.colAddress, this.colPhoneNumber, this.colDepartment, this.colMajors, this.colClass, this.colGraduationYear, this.colRank, this.colCurrentJob});
            this.lstStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstStudents.FilterAndSortEnabled = true;
            this.lstStudents.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.lstStudents.Location = new System.Drawing.Point(0, 43);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstStudents.RowTemplate.Height = 24;
            this.lstStudents.Size = new System.Drawing.Size(1262, 710);
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
            this.colBirthdate.Checked = false;
            this.colBirthdate.DataPropertyName = "Birthdate";
            this.colBirthdate.HeaderText = "Ngày sinh";
            this.colBirthdate.MinimumWidth = 22;
            this.colBirthdate.Name = "colBirthdate";
            this.colBirthdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBirthdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colBirthdate.Width = 111;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.pnlMain);
            this.Name = "Main";
            this.Text = "Chương trình quản lý thông tin sinh viên";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tlbSearch.ResumeLayout(false);
            this.tlbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.lstStudents)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlUC;

        private System.Windows.Forms.ToolStripButton btnAddStudent;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentId;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn colBirthdate;
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

        private System.Windows.Forms.Panel pnlMain;

        #endregion
    }
}