
namespace StudentMng.UserControls
{
    partial class StudentList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle287 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle288 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle289 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle290 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle291 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle292 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle293 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle294 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle295 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle296 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle297 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle298 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle299 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearchTimer = new System.Windows.Forms.Timer(this.components);
            this.Rank = new Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            this.GraduationYear = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Class = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Majors = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Department = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.PhoneNumber = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Address = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Hometown = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Birthdate = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.kryptonDataGridViewTextBoxColumn1 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.StudentId = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Id = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.dataGridViewStudents = new Krypton.Toolkit.KryptonDataGridView();
            this.CurrentJob = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.pnlUC = new System.Windows.Forms.Panel();
            this.dataLstViewPanel = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnAddStudent = new Krypton.Toolkit.KryptonButton();
            this.topPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.dataLstViewPanel.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchTimer
            // 
            this.txtSearchTimer.Interval = 500;
            this.txtSearchTimer.Tick += new System.EventHandler(this.TxtSearchTimer_Tick);
            // 
            // Rank
            // 
            this.Rank.DataPropertyName = "Rank";
            this.Rank.DataSource = null;
            dataGridViewCellStyle287.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Rank.DefaultCellStyle = dataGridViewCellStyle287;
            this.Rank.DropDownWidth = 121;
            this.Rank.HeaderText = "Xếp loại";
            this.Rank.Items.Add("Xuất sắc");
            this.Rank.Items.Add("Giỏi");
            this.Rank.Items.Add("Khá");
            this.Rank.Items.Add("Trung bình");
            this.Rank.Items.Add("Yếu");
            this.Rank.MinimumWidth = 6;
            this.Rank.Name = "Rank";
            this.Rank.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Rank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Rank.Width = 100;
            // 
            // GraduationYear
            // 
            this.GraduationYear.DataPropertyName = "GraduationYear";
            dataGridViewCellStyle288.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GraduationYear.DefaultCellStyle = dataGridViewCellStyle288;
            this.GraduationYear.HeaderText = "Năm tốt nghiệp";
            this.GraduationYear.MinimumWidth = 6;
            this.GraduationYear.Name = "GraduationYear";
            this.GraduationYear.Width = 150;
            // 
            // Class
            // 
            this.Class.DataPropertyName = "Class";
            dataGridViewCellStyle289.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Class.DefaultCellStyle = dataGridViewCellStyle289;
            this.Class.HeaderText = "Lớp";
            this.Class.MinimumWidth = 6;
            this.Class.Name = "Class";
            this.Class.Width = 100;
            // 
            // Majors
            // 
            this.Majors.DataPropertyName = "Majors";
            dataGridViewCellStyle290.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Majors.DefaultCellStyle = dataGridViewCellStyle290;
            this.Majors.HeaderText = "Ngành";
            this.Majors.MinimumWidth = 6;
            this.Majors.Name = "Majors";
            this.Majors.Width = 100;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            dataGridViewCellStyle291.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Department.DefaultCellStyle = dataGridViewCellStyle291;
            this.Department.HeaderText = "Khoa";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.Width = 100;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            dataGridViewCellStyle292.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PhoneNumber.DefaultCellStyle = dataGridViewCellStyle292;
            this.PhoneNumber.HeaderText = "SĐT";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneNumber.Width = 100;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            dataGridViewCellStyle293.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Address.DefaultCellStyle = dataGridViewCellStyle293;
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 100;
            // 
            // Hometown
            // 
            this.Hometown.DataPropertyName = "Hometown";
            dataGridViewCellStyle294.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Hometown.DefaultCellStyle = dataGridViewCellStyle294;
            this.Hometown.HeaderText = "Quê quán";
            this.Hometown.MinimumWidth = 6;
            this.Hometown.Name = "Hometown";
            this.Hometown.Width = 100;
            // 
            // Birthdate
            // 
            this.Birthdate.CalendarTodayDate = new System.DateTime(2022, 4, 7, 0, 0, 0, 0);
            this.Birthdate.Checked = false;
            this.Birthdate.DataPropertyName = "Birthdate";
            dataGridViewCellStyle295.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Birthdate.DefaultCellStyle = dataGridViewCellStyle295;
            this.Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthdate.HeaderText = "Ngày sinh";
            this.Birthdate.MinimumWidth = 6;
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Birthdate.Width = 100;
            // 
            // kryptonDataGridViewTextBoxColumn1
            // 
            this.kryptonDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewCellStyle296.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kryptonDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle296;
            this.kryptonDataGridViewTextBoxColumn1.HeaderText = "Tên";
            this.kryptonDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kryptonDataGridViewTextBoxColumn1.Name = "kryptonDataGridViewTextBoxColumn1";
            this.kryptonDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewTextBoxColumn1.Width = 150;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            dataGridViewCellStyle297.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StudentId.DefaultCellStyle = dataGridViewCellStyle297;
            this.StudentId.HeaderText = "MSSV";
            this.StudentId.MinimumWidth = 6;
            this.StudentId.Name = "StudentId";
            this.StudentId.Width = 100;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.DefaultCellStyle = dataGridViewCellStyle298;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.Visible = false;
            this.Id.Width = 58;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StudentId,
            this.kryptonDataGridViewTextBoxColumn1,
            this.Birthdate,
            this.Hometown,
            this.Address,
            this.PhoneNumber,
            this.Department,
            this.Majors,
            this.Class,
            this.GraduationYear,
            this.Rank,
            this.CurrentJob});
            this.dataGridViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudents.Location = new System.Drawing.Point(15, 0);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1370, 675);
            this.dataGridViewStudents.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dataGridViewStudents.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dataGridViewStudents.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewStudents.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewStudents.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, 5);
            this.dataGridViewStudents.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.dataGridViewStudents.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.dataGridViewStudents.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dataGridViewStudents.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dataGridViewStudents.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewStudents.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridViewStudents.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridViewStudents.TabIndex = 3;
            this.dataGridViewStudents.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridViewStudents_CellBeginEdit);
            this.dataGridViewStudents.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.LstStudents_CellEndEdit);
            this.dataGridViewStudents.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataGridViewStudents_EditingControlShowing);
            this.dataGridViewStudents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewStudents_KeyDown);
            // 
            // CurrentJob
            // 
            this.CurrentJob.DataPropertyName = "CurrentJob";
            dataGridViewCellStyle299.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CurrentJob.DefaultCellStyle = dataGridViewCellStyle299;
            this.CurrentJob.HeaderText = "Công việc hiện tại";
            this.CurrentJob.MinimumWidth = 6;
            this.CurrentJob.Name = "CurrentJob";
            this.CurrentJob.Width = 150;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(10, 24);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(163, 25);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Quản lý sinh viên";
            // 
            // txtSearch
            // 
            this.txtSearch.CueHint.CueHintText = "Tìm kiếm...";
            this.txtSearch.CueHint.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSearch.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSearch.Location = new System.Drawing.Point(15, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 34);
            this.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearch.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 6F;
            this.txtSearch.StateCommon.Border.Width = 1;
            this.txtSearch.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearch.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearch.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearch.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateNormal.Border.Rounding = 6F;
            this.txtSearch.StateNormal.Border.Width = 1;
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // pnlUC
            // 
            this.pnlUC.Location = new System.Drawing.Point(500, 0);
            this.pnlUC.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUC.Name = "pnlUC";
            this.pnlUC.Size = new System.Drawing.Size(430, 430);
            this.pnlUC.TabIndex = 2;
            // 
            // dataLstViewPanel
            // 
            this.dataLstViewPanel.Controls.Add(this.dataGridViewStudents);
            this.dataLstViewPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataLstViewPanel.Location = new System.Drawing.Point(0, 125);
            this.dataLstViewPanel.Name = "dataLstViewPanel";
            this.dataLstViewPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.dataLstViewPanel.Size = new System.Drawing.Size(1400, 675);
            this.dataLstViewPanel.TabIndex = 3;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlUC);
            this.pnlMain.Controls.Add(this.topPanel);
            this.pnlMain.Controls.Add(this.dataLstViewPanel);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1400, 800);
            this.pnlMain.TabIndex = 1;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(239, 70);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddStudent.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddStudent.OverrideDefault.Border.Rounding = 6F;
            this.btnAddStudent.OverrideDefault.Border.Width = 1;
            this.btnAddStudent.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddStudent.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddStudent.OverrideFocus.Border.Rounding = 6F;
            this.btnAddStudent.OverrideFocus.Border.Width = 1;
            this.btnAddStudent.Size = new System.Drawing.Size(131, 32);
            this.btnAddStudent.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddStudent.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddStudent.StateCommon.Border.Rounding = 6F;
            this.btnAddStudent.StateCommon.Border.Width = 1;
            this.btnAddStudent.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddStudent.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddStudent.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddStudent.StateNormal.Border.Rounding = 6F;
            this.btnAddStudent.StateNormal.Border.Width = 1;
            this.btnAddStudent.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddStudent.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddStudent.StatePressed.Border.Rounding = 6F;
            this.btnAddStudent.StatePressed.Border.Width = 1;
            this.btnAddStudent.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddStudent.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddStudent.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddStudent.StateTracking.Border.Rounding = 6F;
            this.btnAddStudent.StateTracking.Border.Width = 1;
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Values.Text = "Thêm sinh viên";
            this.btnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.txtSearch);
            this.topPanel.Controls.Add(this.btnAddStudent);
            this.topPanel.Controls.Add(this.labelTitle);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1400, 119);
            this.topPanel.TabIndex = 12;
            // 
            // StudentList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentList";
            this.Size = new System.Drawing.Size(1400, 800);
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.dataLstViewPanel.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer txtSearchTimer;
        private Krypton.Toolkit.KryptonDataGridViewComboBoxColumn Rank;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn GraduationYear;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Class;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Majors;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Department;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn PhoneNumber;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Address;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Hometown;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn Birthdate;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn1;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn StudentId;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Id;
        private Krypton.Toolkit.KryptonDataGridView dataGridViewStudents;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn CurrentJob;
        private System.Windows.Forms.Label labelTitle;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private System.Windows.Forms.Panel pnlUC;
        private System.Windows.Forms.Panel dataLstViewPanel;
        private System.Windows.Forms.Panel pnlMain;
        private Krypton.Toolkit.KryptonButton btnAddStudent;
        private System.Windows.Forms.Panel topPanel;
    }
}
