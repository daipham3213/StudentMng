using System.ComponentModel;

namespace StudentMng.UserControls
{
    partial class AddStudent
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTille = new Krypton.Toolkit.KryptonLabel();
            this.lblStudent1 = new Krypton.Toolkit.KryptonLabel();
            this.txtMSSV = new Krypton.Toolkit.KryptonTextBox();
            this.lblBirhdate = new Krypton.Toolkit.KryptonLabel();
            this.txtHometown = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtAddress = new Krypton.Toolkit.KryptonTextBox();
            this.lblAddress = new Krypton.Toolkit.KryptonLabel();
            this.txtPhoneNumber = new Krypton.Toolkit.KryptonTextBox();
            this.lblPhoneNumber = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtGraduationYear = new Krypton.Toolkit.KryptonTextBox();
            this.txtClass = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.txtMajors = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.txtDepartment = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.txtCurrentJob = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.btnCreate = new Krypton.Toolkit.KryptonButton();
            this.dtBirthdate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.cbbRank = new Krypton.Toolkit.KryptonComboBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.txtName = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbbRank)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTille
            // 
            this.lblTille.Location = new System.Drawing.Point(8, 2);
            this.lblTille.Margin = new System.Windows.Forms.Padding(2);
            this.lblTille.Name = "lblTille";
            this.lblTille.Size = new System.Drawing.Size(133, 34);
            this.lblTille.StateCommon.Padding = new System.Windows.Forms.Padding(5);
            this.lblTille.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTille.TabIndex = 0;
            this.lblTille.Values.Text = "Thêm sinh viên";
            // 
            // lblStudent1
            // 
            this.lblStudent1.Location = new System.Drawing.Point(11, 31);
            this.lblStudent1.Margin = new System.Windows.Forms.Padding(2);
            this.lblStudent1.Name = "lblStudent1";
            this.lblStudent1.Size = new System.Drawing.Size(45, 21);
            this.lblStudent1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent1.TabIndex = 1;
            this.lblStudent1.Values.Text = "MSSV";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(11, 55);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(188, 28);
            this.txtMSSV.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMSSV.StateCommon.Border.Rounding = 5F;
            this.txtMSSV.StateCommon.Border.Width = 1;
            this.txtMSSV.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtMSSV.TabIndex = 0;
            // 
            // lblBirhdate
            // 
            this.lblBirhdate.Location = new System.Drawing.Point(11, 88);
            this.lblBirhdate.Margin = new System.Windows.Forms.Padding(2);
            this.lblBirhdate.Name = "lblBirhdate";
            this.lblBirhdate.Size = new System.Drawing.Size(70, 21);
            this.lblBirhdate.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirhdate.TabIndex = 3;
            this.lblBirhdate.Values.Text = "Ngày sinh";
            // 
            // txtHometown
            // 
            this.txtHometown.Location = new System.Drawing.Point(11, 169);
            this.txtHometown.Margin = new System.Windows.Forms.Padding(2);
            this.txtHometown.Name = "txtHometown";
            this.txtHometown.Size = new System.Drawing.Size(188, 28);
            this.txtHometown.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtHometown.StateCommon.Border.Rounding = 5F;
            this.txtHometown.StateCommon.Border.Width = 1;
            this.txtHometown.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHometown.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtHometown.TabIndex = 4;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 144);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(69, 21);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "Quê quán";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(11, 226);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(188, 28);
            this.txtAddress.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddress.StateCommon.Border.Rounding = 5F;
            this.txtAddress.StateCommon.Border.Width = 1;
            this.txtAddress.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtAddress.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(11, 201);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 21);
            this.lblAddress.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Values.Text = "Địa chỉ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(11, 283);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(188, 28);
            this.txtPhoneNumber.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhoneNumber.StateCommon.Border.Rounding = 5F;
            this.txtPhoneNumber.StateCommon.Border.Width = 1;
            this.txtPhoneNumber.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtPhoneNumber.TabIndex = 8;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhoneNumber_KeyPress);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(11, 258);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(34, 21);
            this.lblPhoneNumber.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Values.Text = "SĐT";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(232, 318);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(58, 21);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 19;
            this.kryptonLabel2.Values.Text = "Xếp loại";
            // 
            // txtGraduationYear
            // 
            this.txtGraduationYear.Location = new System.Drawing.Point(232, 286);
            this.txtGraduationYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtGraduationYear.Name = "txtGraduationYear";
            this.txtGraduationYear.Size = new System.Drawing.Size(188, 28);
            this.txtGraduationYear.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGraduationYear.StateCommon.Border.Rounding = 5F;
            this.txtGraduationYear.StateCommon.Border.Width = 1;
            this.txtGraduationYear.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGraduationYear.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtGraduationYear.TabIndex = 9;
            this.txtGraduationYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGraduationYear_KeyPress);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(232, 229);
            this.txtClass.Margin = new System.Windows.Forms.Padding(2);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(188, 28);
            this.txtClass.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClass.StateCommon.Border.Rounding = 5F;
            this.txtClass.StateCommon.Border.Width = 1;
            this.txtClass.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtClass.TabIndex = 7;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(232, 204);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(33, 21);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 15;
            this.kryptonLabel4.Values.Text = "Lớp";
            // 
            // txtMajors
            // 
            this.txtMajors.Location = new System.Drawing.Point(232, 172);
            this.txtMajors.Margin = new System.Windows.Forms.Padding(2);
            this.txtMajors.Name = "txtMajors";
            this.txtMajors.Size = new System.Drawing.Size(188, 28);
            this.txtMajors.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMajors.StateCommon.Border.Rounding = 5F;
            this.txtMajors.StateCommon.Border.Width = 1;
            this.txtMajors.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMajors.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtMajors.TabIndex = 5;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(232, 148);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(96, 21);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 13;
            this.kryptonLabel5.Values.Text = "Chuyên ngành";
            // 
            // txtDepartment
            // 
            this.txtDepartment.CueHint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtDepartment.Location = new System.Drawing.Point(232, 115);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(188, 28);
            this.txtDepartment.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDepartment.StateCommon.Border.Rounding = 5F;
            this.txtDepartment.StateCommon.Border.Width = 1;
            this.txtDepartment.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtDepartment.TabIndex = 3;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(232, 91);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(72, 21);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 11;
            this.kryptonLabel6.Values.Text = "Khoa/Viện";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(232, 264);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(105, 21);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 23;
            this.kryptonLabel7.Values.Text = "Năm tốt nghiệp";
            // 
            // txtCurrentJob
            // 
            this.txtCurrentJob.Location = new System.Drawing.Point(11, 340);
            this.txtCurrentJob.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentJob.Name = "txtCurrentJob";
            this.txtCurrentJob.Size = new System.Drawing.Size(188, 28);
            this.txtCurrentJob.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCurrentJob.StateCommon.Border.Rounding = 5F;
            this.txtCurrentJob.StateCommon.Border.Width = 1;
            this.txtCurrentJob.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentJob.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtCurrentJob.TabIndex = 10;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(11, 315);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(116, 21);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 21;
            this.kryptonLabel8.Values.Text = "Công việc hiện tại";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(169, 386);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCreate.Size = new System.Drawing.Size(93, 29);
            this.btnCreate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCreate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreate.StateCommon.Back.ColorAngle = 45F;
            this.btnCreate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCreate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreate.StateCommon.Border.ColorAngle = 45F;
            this.btnCreate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreate.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCreate.StateCommon.Border.Rounding = 5F;
            this.btnCreate.StateCommon.Border.Width = 1;
            this.btnCreate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCreate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnCreate.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnCreate.StatePressed.Back.ColorAngle = 135F;
            this.btnCreate.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(198)))));
            this.btnCreate.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnCreate.StatePressed.Border.ColorAngle = 135F;
            this.btnCreate.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreate.StatePressed.Border.Rounding = 5F;
            this.btnCreate.StatePressed.Border.Width = 1;
            this.btnCreate.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreate.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCreate.StateTracking.Back.ColorAngle = 45F;
            this.btnCreate.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnCreate.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCreate.StateTracking.Border.ColorAngle = 45F;
            this.btnCreate.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreate.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCreate.StateTracking.Border.Rounding = 5F;
            this.btnCreate.StateTracking.Border.Width = 1;
            this.btnCreate.TabIndex = 25;
            this.btnCreate.Values.Text = "Thêm mới";
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthdate.Location = new System.Drawing.Point(11, 112);
            this.dtBirthdate.Margin = new System.Windows.Forms.Padding(2);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(188, 27);
            this.dtBirthdate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtBirthdate.StateCommon.Border.Rounding = 6F;
            this.dtBirthdate.StateCommon.Border.Width = 1;
            this.dtBirthdate.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthdate.TabIndex = 2;
            // 
            // cbbRank
            // 
            this.cbbRank.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRank.DropDownWidth = 211;
            this.cbbRank.IntegralHeight = false;
            this.cbbRank.Items.AddRange(new object[] {
            "Xuất sắc",
            "Giỏi",
            "Khá",
            "Trung bình",
            "Yếu"});
            this.cbbRank.Location = new System.Drawing.Point(232, 343);
            this.cbbRank.Name = "cbbRank";
            this.cbbRank.Size = new System.Drawing.Size(188, 27);
            this.cbbRank.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbbRank.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbbRank.StateCommon.ComboBox.Border.Rounding = 6F;
            this.cbbRank.StateCommon.ComboBox.Border.Width = 1;
            this.cbbRank.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRank.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbbRank.TabIndex = 11;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Location = new System.Drawing.Point(403, 10);
            this.labelClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(14, 13);
            this.labelClose.TabIndex = 29;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.LabelClose_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(230, 31);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(32, 21);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Tên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(230, 55);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 28);
            this.txtName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName.StateCommon.Border.Rounding = 5F;
            this.txtName.StateCommon.Border.Width = 1;
            this.txtName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtName.TabIndex = 1;
            // 
            // AddStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.cbbRank);
            this.Controls.Add(this.dtBirthdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.txtCurrentJob);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.txtGraduationYear);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.txtMajors);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtHometown);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.lblBirhdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.lblStudent1);
            this.Controls.Add(this.lblTille);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(430, 430);
            ((System.ComponentModel.ISupportInitialize)(this.cbbRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Krypton.Toolkit.KryptonDateTimePicker dtBirthdate;

        private Krypton.Toolkit.KryptonButton btnCreate;

        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonTextBox txtCurrentJob;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtClass;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtMajors;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtDepartment;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;

        private Krypton.Toolkit.KryptonTextBox txtHometown;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtAddress;
        private Krypton.Toolkit.KryptonLabel lblAddress;
        private Krypton.Toolkit.KryptonTextBox txtGraduationYear;
        private Krypton.Toolkit.KryptonTextBox txtPhoneNumber;

        private Krypton.Toolkit.KryptonLabel lblPhoneNumber;

        private Krypton.Toolkit.KryptonLabel lblStudent1;

        private Krypton.Toolkit.KryptonTextBox txtMSSV;

        private Krypton.Toolkit.KryptonLabel lblBirhdate;

        private Krypton.Toolkit.KryptonLabel lblTille;

        #endregion

        private Krypton.Toolkit.KryptonComboBox cbbRank;
        private System.Windows.Forms.Label labelClose;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtName;
    }
}