using System.ComponentModel;

namespace StudentMng.Forms
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
            this.txtRank = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtGraduationYear = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
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
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.dtBirthdate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.SuspendLayout();
            // 
            // lblTille
            // 
            this.lblTille.Location = new System.Drawing.Point(12, 12);
            this.lblTille.Name = "lblTille";
            this.lblTille.Size = new System.Drawing.Size(124, 29);
            this.lblTille.StateCommon.Padding = new System.Windows.Forms.Padding(5);
            this.lblTille.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTille.TabIndex = 0;
            this.lblTille.Values.Text = "Thêm sinh viên";
            // 
            // lblStudent1
            // 
            this.lblStudent1.Location = new System.Drawing.Point(10, 60);
            this.lblStudent1.Name = "lblStudent1";
            this.lblStudent1.Size = new System.Drawing.Size(51, 24);
            this.lblStudent1.TabIndex = 1;
            this.lblStudent1.Values.Text = "MSSV";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(10, 90);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(250, 36);
            this.txtMSSV.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMSSV.StateCommon.Border.Rounding = 5F;
            this.txtMSSV.StateCommon.Border.Width = 1;
            this.txtMSSV.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtMSSV.TabIndex = 2;
            // 
            // lblBirhdate
            // 
            this.lblBirhdate.Location = new System.Drawing.Point(10, 130);
            this.lblBirhdate.Name = "lblBirhdate";
            this.lblBirhdate.Size = new System.Drawing.Size(80, 24);
            this.lblBirhdate.TabIndex = 3;
            this.lblBirhdate.Values.Text = "Ngày sinh";
            // 
            // txtHometown
            // 
            this.txtHometown.Location = new System.Drawing.Point(10, 230);
            this.txtHometown.Name = "txtHometown";
            this.txtHometown.Size = new System.Drawing.Size(250, 36);
            this.txtHometown.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtHometown.StateCommon.Border.Rounding = 5F;
            this.txtHometown.StateCommon.Border.Width = 1;
            this.txtHometown.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtHometown.TabIndex = 6;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 200);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(79, 24);
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "Quê quán";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(10, 300);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 36);
            this.txtAddress.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddress.StateCommon.Border.Rounding = 5F;
            this.txtAddress.StateCommon.Border.Width = 1;
            this.txtAddress.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtAddress.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(10, 270);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 24);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Values.Text = "Địa chỉ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(10, 370);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(250, 36);
            this.txtPhoneNumber.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhoneNumber.StateCommon.Border.Rounding = 5F;
            this.txtPhoneNumber.StateCommon.Border.Width = 1;
            this.txtPhoneNumber.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtPhoneNumber.TabIndex = 10;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(10, 340);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(39, 24);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Values.Text = "SĐT";
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(305, 370);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(250, 36);
            this.txtRank.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRank.StateCommon.Border.Rounding = 5F;
            this.txtRank.StateCommon.Border.Width = 1;
            this.txtRank.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtRank.TabIndex = 20;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(305, 340);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(48, 24);
            this.kryptonLabel2.TabIndex = 19;
            this.kryptonLabel2.Values.Text = "Hạng";
            // 
            // txtGraduationYear
            // 
            this.txtGraduationYear.Location = new System.Drawing.Point(305, 300);
            this.txtGraduationYear.Name = "txtGraduationYear";
            this.txtGraduationYear.Size = new System.Drawing.Size(250, 36);
            this.txtGraduationYear.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGraduationYear.StateCommon.Border.Rounding = 5F;
            this.txtGraduationYear.StateCommon.Border.Width = 1;
            this.txtGraduationYear.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtGraduationYear.TabIndex = 18;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(305, 270);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(120, 24);
            this.kryptonLabel3.TabIndex = 17;
            this.kryptonLabel3.Values.Text = "Năm tốt nghiệp";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(305, 230);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(250, 36);
            this.txtClass.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClass.StateCommon.Border.Rounding = 5F;
            this.txtClass.StateCommon.Border.Width = 1;
            this.txtClass.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtClass.TabIndex = 16;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(305, 200);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(37, 24);
            this.kryptonLabel4.TabIndex = 15;
            this.kryptonLabel4.Values.Text = "Lớp";
            // 
            // txtMajors
            // 
            this.txtMajors.Location = new System.Drawing.Point(305, 160);
            this.txtMajors.Name = "txtMajors";
            this.txtMajors.Size = new System.Drawing.Size(250, 36);
            this.txtMajors.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMajors.StateCommon.Border.Rounding = 5F;
            this.txtMajors.StateCommon.Border.Width = 1;
            this.txtMajors.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtMajors.TabIndex = 14;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(305, 130);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(110, 24);
            this.kryptonLabel5.TabIndex = 13;
            this.kryptonLabel5.Values.Text = "Chuyên ngành";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(305, 90);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(250, 36);
            this.txtDepartment.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDepartment.StateCommon.Border.Rounding = 5F;
            this.txtDepartment.StateCommon.Border.Width = 1;
            this.txtDepartment.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtDepartment.TabIndex = 12;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(305, 60);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(82, 24);
            this.kryptonLabel6.TabIndex = 11;
            this.kryptonLabel6.Values.Text = "Khoa/Viện";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(305, 273);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(120, 24);
            this.kryptonLabel7.TabIndex = 23;
            this.kryptonLabel7.Values.Text = "Năm tốt nghiệp";
            // 
            // txtCurrentJob
            // 
            this.txtCurrentJob.Location = new System.Drawing.Point(10, 440);
            this.txtCurrentJob.Name = "txtCurrentJob";
            this.txtCurrentJob.Size = new System.Drawing.Size(250, 36);
            this.txtCurrentJob.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCurrentJob.StateCommon.Border.Rounding = 5F;
            this.txtCurrentJob.StateCommon.Border.Width = 1;
            this.txtCurrentJob.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txtCurrentJob.TabIndex = 22;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(10, 410);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(133, 24);
            this.kryptonLabel8.TabIndex = 21;
            this.kryptonLabel8.Values.Text = "Công việc hiện tại";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(305, 440);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCreate.Size = new System.Drawing.Size(124, 36);
            this.btnCreate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (6)))), ((int) (((byte) (174)))), ((int) (((byte) (244)))));
            this.btnCreate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (8)))), ((int) (((byte) (142)))), ((int) (((byte) (254)))));
            this.btnCreate.StateCommon.Back.ColorAngle = 45F;
            this.btnCreate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (6)))), ((int) (((byte) (174)))), ((int) (((byte) (244)))));
            this.btnCreate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (8)))), ((int) (((byte) (142)))), ((int) (((byte) (254)))));
            this.btnCreate.StateCommon.Border.ColorAngle = 45F;
            this.btnCreate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreate.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCreate.StateCommon.Border.Rounding = 5F;
            this.btnCreate.StateCommon.Border.Width = 1;
            this.btnCreate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCreate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCreate.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (20)))), ((int) (((byte) (145)))), ((int) (((byte) (198)))));
            this.btnCreate.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (22)))), ((int) (((byte) (121)))), ((int) (((byte) (206)))));
            this.btnCreate.StatePressed.Back.ColorAngle = 135F;
            this.btnCreate.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (20)))), ((int) (((byte) (45)))), ((int) (((byte) (198)))));
            this.btnCreate.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (22)))), ((int) (((byte) (121)))), ((int) (((byte) (206)))));
            this.btnCreate.StatePressed.Border.ColorAngle = 135F;
            this.btnCreate.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreate.StatePressed.Border.Rounding = 20F;
            this.btnCreate.StatePressed.Border.Width = 1;
            this.btnCreate.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (8)))), ((int) (((byte) (142)))), ((int) (((byte) (254)))));
            this.btnCreate.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (6)))), ((int) (((byte) (174)))), ((int) (((byte) (244)))));
            this.btnCreate.StateTracking.Back.ColorAngle = 45F;
            this.btnCreate.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (6)))), ((int) (((byte) (174)))), ((int) (((byte) (244)))));
            this.btnCreate.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (8)))), ((int) (((byte) (142)))), ((int) (((byte) (254)))));
            this.btnCreate.StateTracking.Border.ColorAngle = 45F;
            this.btnCreate.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreate.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCreate.StateTracking.Border.Rounding = 20F;
            this.btnCreate.StateTracking.Border.Width = 1;
            this.btnCreate.TabIndex = 25;
            this.btnCreate.Values.Text = "Thêm mới";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(435, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCancel.Size = new System.Drawing.Size(124, 36);
            this.btnCancel.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (230)))), ((int) (((byte) (9)))), ((int) (((byte) (101)))));
            this.btnCancel.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (249)))), ((int) (((byte) (72)))), ((int) (((byte) (146)))));
            this.btnCancel.StateCommon.Back.ColorAngle = 45F;
            this.btnCancel.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (230)))), ((int) (((byte) (9)))), ((int) (((byte) (101)))));
            this.btnCancel.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (249)))), ((int) (((byte) (72)))), ((int) (((byte) (146)))));
            this.btnCancel.StateCommon.Border.ColorAngle = 45F;
            this.btnCancel.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCancel.StateCommon.Border.Rounding = 5F;
            this.btnCancel.StateCommon.Border.Width = 1;
            this.btnCancel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCancel.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (254)))), ((int) (((byte) (143)))), ((int) (((byte) (143)))));
            this.btnCancel.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (92)))), ((int) (((byte) (98)))));
            this.btnCancel.StatePressed.Back.ColorAngle = 135F;
            this.btnCancel.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (20)))), ((int) (((byte) (45)))), ((int) (((byte) (198)))));
            this.btnCancel.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (22)))), ((int) (((byte) (121)))), ((int) (((byte) (206)))));
            this.btnCancel.StatePressed.Border.ColorAngle = 135F;
            this.btnCancel.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StatePressed.Border.Rounding = 20F;
            this.btnCancel.StatePressed.Border.Width = 1;
            this.btnCancel.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (8)))), ((int) (((byte) (142)))), ((int) (((byte) (254)))));
            this.btnCancel.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (6)))), ((int) (((byte) (174)))), ((int) (((byte) (244)))));
            this.btnCancel.StateTracking.Back.ColorAngle = 45F;
            this.btnCancel.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (6)))), ((int) (((byte) (174)))), ((int) (((byte) (244)))));
            this.btnCancel.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (8)))), ((int) (((byte) (142)))), ((int) (((byte) (254)))));
            this.btnCancel.StateTracking.Border.ColorAngle = 45F;
            this.btnCancel.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCancel.StateTracking.Border.Rounding = 20F;
            this.btnCancel.StateTracking.Border.Width = 1;
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Values.Text = "Huỷ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.Location = new System.Drawing.Point(10, 160);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(250, 25);
            this.dtBirthdate.TabIndex = 27;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dtBirthdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.txtCurrentJob);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.txtGraduationYear);
            this.Controls.Add(this.kryptonLabel3);
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
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.lblStudent1);
            this.Controls.Add(this.lblTille);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(570, 500);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Krypton.Toolkit.KryptonDateTimePicker dtBirthdate;

        private Krypton.Toolkit.KryptonButton btnCancel;

        private Krypton.Toolkit.KryptonButton btnCreate;

        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonTextBox txtCurrentJob;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;

        private Krypton.Toolkit.KryptonTextBox txtRank;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
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
    }
}