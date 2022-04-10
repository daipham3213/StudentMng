
namespace StudentMng.UserControls
{
    partial class Statistic
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
            this.lbYearFilter = new System.Windows.Forms.Label();
            this.cbbYearFilter = new Krypton.Toolkit.KryptonComboBox();
            this.lbConditionFilter = new System.Windows.Forms.Label();
            this.cbbCondition = new Krypton.Toolkit.KryptonComboBox();
            this.cbbConditionFilter = new Krypton.Toolkit.KryptonComboBox();
            this.panelListStudent = new System.Windows.Forms.Panel();
            this.dataGridViewStudents = new Krypton.Toolkit.KryptonDataGridView();
            this.IdColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.StudentIdColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.NameColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.BirthdateColumn = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.HometownColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.AddressColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.PhoneNumberColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.DepartmentColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.MajorsColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.ClassColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.GraduationYearColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.RankColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.CurrentJobColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.btnConditionFilter = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbbYearFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbConditionFilter)).BeginInit();
            this.panelListStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lbYearFilter
            // 
            this.lbYearFilter.AutoSize = true;
            this.lbYearFilter.Location = new System.Drawing.Point(15, 17);
            this.lbYearFilter.Name = "lbYearFilter";
            this.lbYearFilter.Size = new System.Drawing.Size(69, 17);
            this.lbYearFilter.TabIndex = 0;
            this.lbYearFilter.Text = "Theo Năm";
            // 
            // cbbYearFilter
            // 
            this.cbbYearFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbYearFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYearFilter.DropDownWidth = 188;
            this.cbbYearFilter.IntegralHeight = false;
            this.cbbYearFilter.Location = new System.Drawing.Point(149, 17);
            this.cbbYearFilter.Name = "cbbYearFilter";
            this.cbbYearFilter.Size = new System.Drawing.Size(188, 27);
            this.cbbYearFilter.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbbYearFilter.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbbYearFilter.StateCommon.ComboBox.Border.Rounding = 6F;
            this.cbbYearFilter.StateCommon.ComboBox.Border.Width = 1;
            this.cbbYearFilter.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbYearFilter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbbYearFilter.TabIndex = 12;
            // 
            // lbConditionFilter
            // 
            this.lbConditionFilter.AutoSize = true;
            this.lbConditionFilter.Location = new System.Drawing.Point(15, 60);
            this.lbConditionFilter.Name = "lbConditionFilter";
            this.lbConditionFilter.Size = new System.Drawing.Size(117, 17);
            this.lbConditionFilter.TabIndex = 0;
            this.lbConditionFilter.Text = "Lọc theo điều kiện:";
            // 
            // cbbCondition
            // 
            this.cbbCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCondition.DropDownWidth = 151;
            this.cbbCondition.IntegralHeight = false;
            this.cbbCondition.Items.AddRange(new object[] {
            "Lớp",
            "Khoa",
            "Ngành"});
            this.cbbCondition.Location = new System.Drawing.Point(149, 60);
            this.cbbCondition.Name = "cbbCondition";
            this.cbbCondition.Size = new System.Drawing.Size(109, 27);
            this.cbbCondition.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbbCondition.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbbCondition.StateCommon.ComboBox.Border.Rounding = 6F;
            this.cbbCondition.StateCommon.ComboBox.Border.Width = 1;
            this.cbbCondition.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCondition.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbbCondition.TabIndex = 12;
            this.cbbCondition.SelectedIndexChanged += new System.EventHandler(this.cbbCondition_SelectedIndexChanged);
            // 
            // cbbConditionFilter
            // 
            this.cbbConditionFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbConditionFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbConditionFilter.DropDownWidth = 211;
            this.cbbConditionFilter.IntegralHeight = false;
            this.cbbConditionFilter.Location = new System.Drawing.Point(280, 60);
            this.cbbConditionFilter.Name = "cbbConditionFilter";
            this.cbbConditionFilter.Size = new System.Drawing.Size(301, 27);
            this.cbbConditionFilter.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbbConditionFilter.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbbConditionFilter.StateCommon.ComboBox.Border.Rounding = 6F;
            this.cbbConditionFilter.StateCommon.ComboBox.Border.Width = 1;
            this.cbbConditionFilter.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbConditionFilter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbbConditionFilter.TabIndex = 12;
            // 
            // panelListStudent
            // 
            this.panelListStudent.Controls.Add(this.dataGridViewStudents);
            this.panelListStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelListStudent.Location = new System.Drawing.Point(0, 125);
            this.panelListStudent.Name = "panelListStudent";
            this.panelListStudent.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.panelListStudent.Size = new System.Drawing.Size(1400, 675);
            this.panelListStudent.TabIndex = 14;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.StudentIdColumn,
            this.NameColumn,
            this.BirthdateColumn,
            this.HometownColumn,
            this.AddressColumn,
            this.PhoneNumberColumn,
            this.DepartmentColumn,
            this.MajorsColumn,
            this.ClassColumn,
            this.GraduationYearColumn,
            this.RankColumn,
            this.CurrentJobColumn});
            this.dataGridViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudents.Location = new System.Drawing.Point(15, 0);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1380, 675);
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
            this.dataGridViewStudents.TabIndex = 4;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            this.IdColumn.Width = 100;
            // 
            // StudentIdColumn
            // 
            this.StudentIdColumn.DataPropertyName = "StudentId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StudentIdColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentIdColumn.HeaderText = "MSSV";
            this.StudentIdColumn.Name = "StudentIdColumn";
            this.StudentIdColumn.ReadOnly = true;
            this.StudentIdColumn.Width = 100;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.NameColumn.HeaderText = "Họ Tên";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 150;
            // 
            // BirthdateColumn
            // 
            this.BirthdateColumn.CalendarTodayDate = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            this.BirthdateColumn.Checked = false;
            this.BirthdateColumn.DataPropertyName = "Birthdate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BirthdateColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.BirthdateColumn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdateColumn.HeaderText = "Ngày sinh";
            this.BirthdateColumn.Name = "BirthdateColumn";
            this.BirthdateColumn.ReadOnly = true;
            this.BirthdateColumn.Width = 100;
            // 
            // HometownColumn
            // 
            this.HometownColumn.DataPropertyName = "Hometown";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HometownColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.HometownColumn.HeaderText = "Quê quán";
            this.HometownColumn.Name = "HometownColumn";
            this.HometownColumn.ReadOnly = true;
            this.HometownColumn.Width = 100;
            // 
            // AddressColumn
            // 
            this.AddressColumn.DataPropertyName = "Address";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AddressColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.AddressColumn.HeaderText = "Địa chỉ";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            this.AddressColumn.Width = 100;
            // 
            // PhoneNumberColumn
            // 
            this.PhoneNumberColumn.DataPropertyName = "PhoneNumber";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PhoneNumberColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.PhoneNumberColumn.HeaderText = "SĐT";
            this.PhoneNumberColumn.Name = "PhoneNumberColumn";
            this.PhoneNumberColumn.ReadOnly = true;
            this.PhoneNumberColumn.Width = 100;
            // 
            // DepartmentColumn
            // 
            this.DepartmentColumn.DataPropertyName = "Department";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DepartmentColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.DepartmentColumn.HeaderText = "Khoa";
            this.DepartmentColumn.Name = "DepartmentColumn";
            this.DepartmentColumn.ReadOnly = true;
            this.DepartmentColumn.Width = 100;
            // 
            // MajorsColumn
            // 
            this.MajorsColumn.DataPropertyName = "Majors";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MajorsColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.MajorsColumn.HeaderText = "Ngành";
            this.MajorsColumn.Name = "MajorsColumn";
            this.MajorsColumn.ReadOnly = true;
            this.MajorsColumn.Width = 100;
            // 
            // ClassColumn
            // 
            this.ClassColumn.DataPropertyName = "Class";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClassColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.ClassColumn.HeaderText = "Lớp";
            this.ClassColumn.Name = "ClassColumn";
            this.ClassColumn.ReadOnly = true;
            this.ClassColumn.Width = 100;
            // 
            // GraduationYearColumn
            // 
            this.GraduationYearColumn.DataPropertyName = "GraduationYear";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GraduationYearColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.GraduationYearColumn.HeaderText = "Năm tốt nghiệp";
            this.GraduationYearColumn.Name = "GraduationYearColumn";
            this.GraduationYearColumn.ReadOnly = true;
            this.GraduationYearColumn.Width = 150;
            // 
            // RankColumn
            // 
            this.RankColumn.DataPropertyName = "Rank";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RankColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.RankColumn.HeaderText = "Xếp loại";
            this.RankColumn.Name = "RankColumn";
            this.RankColumn.ReadOnly = true;
            this.RankColumn.Width = 100;
            // 
            // CurrentJobColumn
            // 
            this.CurrentJobColumn.DataPropertyName = "CurrentJob";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CurrentJobColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.CurrentJobColumn.HeaderText = "Công việc hiện tại";
            this.CurrentJobColumn.Name = "CurrentJobColumn";
            this.CurrentJobColumn.ReadOnly = true;
            this.CurrentJobColumn.Width = 150;
            // 
            // btnConditionFilter
            // 
            this.btnConditionFilter.Location = new System.Drawing.Point(602, 55);
            this.btnConditionFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnConditionFilter.Name = "btnConditionFilter";
            this.btnConditionFilter.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConditionFilter.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnConditionFilter.OverrideDefault.Border.Rounding = 6F;
            this.btnConditionFilter.OverrideDefault.Border.Width = 1;
            this.btnConditionFilter.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConditionFilter.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnConditionFilter.OverrideFocus.Border.Rounding = 6F;
            this.btnConditionFilter.OverrideFocus.Border.Width = 1;
            this.btnConditionFilter.Size = new System.Drawing.Size(61, 32);
            this.btnConditionFilter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConditionFilter.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnConditionFilter.StateCommon.Border.Rounding = 6F;
            this.btnConditionFilter.StateCommon.Border.Width = 1;
            this.btnConditionFilter.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConditionFilter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConditionFilter.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConditionFilter.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnConditionFilter.StateNormal.Border.Rounding = 6F;
            this.btnConditionFilter.StateNormal.Border.Width = 1;
            this.btnConditionFilter.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConditionFilter.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnConditionFilter.StatePressed.Border.Rounding = 6F;
            this.btnConditionFilter.StatePressed.Border.Width = 1;
            this.btnConditionFilter.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConditionFilter.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConditionFilter.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnConditionFilter.StateTracking.Border.Rounding = 6F;
            this.btnConditionFilter.StateTracking.Border.Width = 1;
            this.btnConditionFilter.TabIndex = 15;
            this.btnConditionFilter.Values.Text = "Lọc";
            this.btnConditionFilter.Click += new System.EventHandler(this.btnConditionFilter_Click);
            // 
            // Statistic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnConditionFilter);
            this.Controls.Add(this.panelListStudent);
            this.Controls.Add(this.cbbConditionFilter);
            this.Controls.Add(this.cbbCondition);
            this.Controls.Add(this.lbConditionFilter);
            this.Controls.Add(this.cbbYearFilter);
            this.Controls.Add(this.lbYearFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Statistic";
            this.Size = new System.Drawing.Size(1400, 800);
            ((System.ComponentModel.ISupportInitialize)(this.cbbYearFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbConditionFilter)).EndInit();
            this.panelListStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbYearFilter;
        private Krypton.Toolkit.KryptonComboBox cbbYearFilter;
        private System.Windows.Forms.Label lbConditionFilter;
        private Krypton.Toolkit.KryptonComboBox cbbCondition;
        private Krypton.Toolkit.KryptonComboBox cbbConditionFilter;
        private System.Windows.Forms.Panel panelListStudent;
        private Krypton.Toolkit.KryptonDataGridView dataGridViewStudents;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn IdColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn StudentIdColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn NameColumn;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn BirthdateColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn HometownColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn AddressColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn PhoneNumberColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn DepartmentColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn MajorsColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn ClassColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn GraduationYearColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn RankColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn CurrentJobColumn;
        private Krypton.Toolkit.KryptonButton btnConditionFilter;
    }
}
