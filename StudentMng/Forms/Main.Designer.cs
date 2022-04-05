using System.ComponentModel;

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
            this.lstStudents = new System.Windows.Forms.DataGridView();
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
            this.lstStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStudents.Location = new System.Drawing.Point(0, 0);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.RowTemplate.Height = 24;
            this.lstStudents.Size = new System.Drawing.Size(1262, 553);
            this.lstStudents.TabIndex = 0;
            this.lstStudents.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstStudents_CellEndEdit);
            this.lstStudents.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.lstStudents_UserDeletingRow);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colStudentId
            // 
            this.colStudentId.DataPropertyName = "StudentId";
            this.colStudentId.HeaderText = "MSSV";
            this.colStudentId.Name = "colStudentId";
            // 
            // colBirthdate
            // 
            this.colBirthdate.DataPropertyName = "Birthdate";
            this.colBirthdate.HeaderText = "Ngày sinh";
            this.colBirthdate.Name = "colBirthdate";
            // 
            // colHometown
            // 
            this.colHometown.DataPropertyName = "Hometown";
            this.colHometown.HeaderText = "Quê quáng";
            this.colHometown.Name = "colHometown";
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Địa chỉ";
            this.colAddress.Name = "colAddress";
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.DataPropertyName = "PhoneNumber";
            this.colPhoneNumber.HeaderText = "SĐT";
            this.colPhoneNumber.Name = "colPhoneNumber";
            // 
            // colDepartment
            // 
            this.colDepartment.DataPropertyName = "Department";
            this.colDepartment.HeaderText = "Khoa";
            this.colDepartment.Name = "colDepartment";
            // 
            // colMajors
            // 
            this.colMajors.DataPropertyName = "Majors";
            this.colMajors.HeaderText = "Chuyên ngành";
            this.colMajors.Name = "colMajors";
            // 
            // colClass
            // 
            this.colClass.DataPropertyName = "Class";
            this.colClass.HeaderText = "Lớp";
            this.colClass.Name = "colClass";
            // 
            // colGraduationYear
            // 
            this.colGraduationYear.DataPropertyName = "GraduationYear";
            this.colGraduationYear.HeaderText = "Năm tốt nghiệp";
            this.colGraduationYear.Name = "colGraduationYear";
            // 
            // colRank
            // 
            this.colRank.DataPropertyName = "Rank";
            this.colRank.HeaderText = "Hạng";
            this.colRank.Name = "colRank";
            // 
            // colCurrentJob
            // 
            this.colCurrentJob.DataPropertyName = "CurrentJob";
            this.colCurrentJob.HeaderText = "Công việc hiện tại";
            this.colCurrentJob.Name = "colCurrentJob";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 553);
            this.Controls.Add(this.pnlMain);
            this.Name = "Main";
            this.Text = "Chương trình quản lý thông tin sinh viên";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.lstStudents)).EndInit();
            this.ResumeLayout(false);
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

        private System.Windows.Forms.DataGridView lstStudents;

        private System.Windows.Forms.ColumnHeader oder;

        private System.Windows.Forms.Panel pnlMain;

        #endregion
    }
}