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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.btnAddStudent = new Krypton.Toolkit.KryptonButton();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.pnlUC = new System.Windows.Forms.Panel();
            this.dataLstViewPanel = new System.Windows.Forms.Panel();
            this.dataGridViewStudents = new Krypton.Toolkit.KryptonDataGridView();
            this.Id = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.StudentId = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.kryptonDataGridViewTextBoxColumn1 = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Birthdate = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.Hometown = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Address = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.PhoneNumber = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Department = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Majors = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Class = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.GraduationYear = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Rank = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.CurrentJob = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.txtSearchTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.dataLstViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.labelTitle);
            this.pnlMain.Controls.Add(this.labelClose);
            this.pnlMain.Controls.Add(this.btnAddStudent);
            this.pnlMain.Controls.Add(this.txtSearch);
            this.pnlMain.Controls.Add(this.pnlUC);
            this.pnlMain.Controls.Add(this.dataLstViewPanel);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1400, 800);
            this.pnlMain.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(17, 29);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(212, 32);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Quản lý sinh viên";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Location = new System.Drawing.Point(1371, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(17, 17);
            this.labelClose.TabIndex = 10;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.LabelClose_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(1205, 91);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnAddStudent.Size = new System.Drawing.Size(175, 39);
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
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Values.Text = "Thêm sinh viên";
            this.btnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.CueHint.CueHintText = "Tìm kiếm...";
            this.txtSearch.CueHint.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSearch.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSearch.Location = new System.Drawing.Point(20, 92);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(273, 38);
            this.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.txtSearch.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 6F;
            this.txtSearch.StateCommon.Border.Width = 1;
            this.txtSearch.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // pnlUC
            // 
            this.pnlUC.Location = new System.Drawing.Point(339, 118);
            this.pnlUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUC.Name = "pnlUC";
            this.pnlUC.Size = new System.Drawing.Size(580, 574);
            this.pnlUC.TabIndex = 2;
            // 
            // dataLstViewPanel
            // 
            this.dataLstViewPanel.Controls.Add(this.dataGridViewStudents);
            this.dataLstViewPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataLstViewPanel.Location = new System.Drawing.Point(0, 148);
            this.dataLstViewPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dataLstViewPanel.Name = "dataLstViewPanel";
            this.dataLstViewPanel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.dataLstViewPanel.Size = new System.Drawing.Size(1400, 652);
            this.dataLstViewPanel.TabIndex = 3;
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
            this.dataGridViewStudents.Location = new System.Drawing.Point(20, 0);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1360, 652);
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.Visible = false;
            this.Id.Width = 58;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StudentId.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentId.HeaderText = "MSSV";
            this.StudentId.MinimumWidth = 6;
            this.StudentId.Name = "StudentId";
            this.StudentId.Width = 100;
            // 
            // kryptonDataGridViewTextBoxColumn1
            // 
            this.kryptonDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kryptonDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.kryptonDataGridViewTextBoxColumn1.HeaderText = "Tên";
            this.kryptonDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kryptonDataGridViewTextBoxColumn1.Name = "kryptonDataGridViewTextBoxColumn1";
            this.kryptonDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewTextBoxColumn1.Width = 150;
            // 
            // Birthdate
            // 
            this.Birthdate.CalendarTodayDate = new System.DateTime(2022, 4, 7, 0, 0, 0, 0);
            this.Birthdate.Checked = false;
            this.Birthdate.DataPropertyName = "Birthdate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Birthdate.DefaultCellStyle = dataGridViewCellStyle4;
            this.Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthdate.HeaderText = "Ngày sinh";
            this.Birthdate.MinimumWidth = 6;
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Birthdate.Width = 100;
            // 
            // Hometown
            // 
            this.Hometown.DataPropertyName = "Hometown";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Hometown.DefaultCellStyle = dataGridViewCellStyle5;
            this.Hometown.HeaderText = "Quê quán";
            this.Hometown.MinimumWidth = 6;
            this.Hometown.Name = "Hometown";
            this.Hometown.Width = 100;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Address.DefaultCellStyle = dataGridViewCellStyle6;
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 100;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PhoneNumber.DefaultCellStyle = dataGridViewCellStyle7;
            this.PhoneNumber.HeaderText = "SĐT";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneNumber.Width = 100;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Department.DefaultCellStyle = dataGridViewCellStyle8;
            this.Department.HeaderText = "Khoa";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.Width = 100;
            // 
            // Majors
            // 
            this.Majors.DataPropertyName = "Majors";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Majors.DefaultCellStyle = dataGridViewCellStyle9;
            this.Majors.HeaderText = "Ngành";
            this.Majors.MinimumWidth = 6;
            this.Majors.Name = "Majors";
            this.Majors.Width = 100;
            // 
            // Class
            // 
            this.Class.DataPropertyName = "Class";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Class.DefaultCellStyle = dataGridViewCellStyle10;
            this.Class.HeaderText = "Lớp";
            this.Class.MinimumWidth = 6;
            this.Class.Name = "Class";
            this.Class.Width = 100;
            // 
            // GraduationYear
            // 
            this.GraduationYear.DataPropertyName = "GraduationYear";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GraduationYear.DefaultCellStyle = dataGridViewCellStyle11;
            this.GraduationYear.HeaderText = "Năm tốt nghiệp";
            this.GraduationYear.MinimumWidth = 6;
            this.GraduationYear.Name = "GraduationYear";
            this.GraduationYear.Width = 150;
            // 
            // Rank
            // 
            this.Rank.DataPropertyName = "Rank";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Rank.DefaultCellStyle = dataGridViewCellStyle12;
            this.Rank.HeaderText = "Xếp loại";
            this.Rank.MinimumWidth = 6;
            this.Rank.Name = "Rank";
            this.Rank.Width = 100;
            // 
            // CurrentJob
            // 
            this.CurrentJob.DataPropertyName = "CurrentJob";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CurrentJob.DefaultCellStyle = dataGridViewCellStyle13;
            this.CurrentJob.HeaderText = "Công việc hiện tại";
            this.CurrentJob.MinimumWidth = 6;
            this.CurrentJob.Name = "CurrentJob";
            this.CurrentJob.Width = 150;
            // 
            // txtSearchTimer
            // 
            this.txtSearchTimer.Interval = 500;
            this.txtSearchTimer.Tick += new System.EventHandler(this.TxtSearchTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quản lý thông tin sinh viên";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.dataLstViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlUC;

        private System.Windows.Forms.Panel pnlMain;

        #endregion
        private Krypton.Toolkit.KryptonDataGridView dataGridViewStudents;
        private System.Windows.Forms.Panel dataLstViewPanel;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonButton btnAddStudent;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Timer txtSearchTimer;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Id;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn StudentId;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn kryptonDataGridViewTextBoxColumn1;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn Birthdate;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Hometown;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Address;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn PhoneNumber;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Department;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Majors;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Class;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn GraduationYear;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Rank;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn CurrentJob;
        private System.Windows.Forms.Label labelTitle;
    }
}