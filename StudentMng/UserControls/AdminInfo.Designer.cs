using System.ComponentModel;

namespace StudentMng.UserControls
{
    partial class AdminInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInfo));
            this.lblTille = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtUsername = new Krypton.Toolkit.KryptonTextBox();
            this.txtFullname = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnUpdate = new Krypton.Toolkit.KryptonButton();
            this.txtCurrentPassword = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.txtNewPassword = new Krypton.Toolkit.KryptonTextBox();
            this.txtConfirmPassword = new Krypton.Toolkit.KryptonTextBox();
            this.btnChangePassword = new Krypton.Toolkit.KryptonButton();
            this.cbxMatch = new Krypton.Toolkit.KryptonCheckBox();
            this.cbxStrength = new Krypton.Toolkit.KryptonCheckBox();
            this.SuspendLayout();
            // 
            // lblTille
            // 
            this.lblTille.Location = new System.Drawing.Point(12, 12);
            this.lblTille.Margin = new System.Windows.Forms.Padding(2);
            this.lblTille.Name = "lblTille";
            this.lblTille.Size = new System.Drawing.Size(316, 40);
            this.lblTille.StateCommon.Padding = new System.Windows.Forms.Padding(5);
            this.lblTille.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTille.TabIndex = 1;
            this.lblTille.Values.Text = "Quản lý thông tin quản trị viên";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 100);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(123, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(130, 100);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(188, 32);
            this.txtUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.Rounding = 5F;
            this.txtUsername.StateCommon.Border.Width = 1;
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUsername.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(130, 150);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(188, 32);
            this.txtFullname.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFullname.StateCommon.Border.Rounding = 5F;
            this.txtFullname.StateCommon.Border.Width = 1;
            this.txtFullname.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtFullname.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtFullname.TabIndex = 2;
            this.txtFullname.TextChanged += new System.EventHandler(this.txtFullname_TextChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(15, 150);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.kryptonLabel2.TabIndex = 11;
            this.kryptonLabel2.Values.Text = "Họ tên";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(146, 250);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdate.OverrideDefault.Border.Rounding = 6F;
            this.btnUpdate.OverrideDefault.Border.Width = 1;
            this.btnUpdate.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdate.OverrideFocus.Border.Rounding = 6F;
            this.btnUpdate.OverrideFocus.Border.Width = 1;
            this.btnUpdate.Size = new System.Drawing.Size(165, 32);
            this.btnUpdate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdate.StateCommon.Border.Rounding = 6F;
            this.btnUpdate.StateCommon.Border.Width = 1;
            this.btnUpdate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUpdate.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.btnUpdate.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.btnUpdate.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.btnUpdate.StateDisabled.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.btnUpdate.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateDisabled.Border.Rounding = 6F;
            this.btnUpdate.StateDisabled.Border.Width = 1;
            this.btnUpdate.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdate.StateNormal.Border.Rounding = 6F;
            this.btnUpdate.StateNormal.Border.Width = 1;
            this.btnUpdate.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdate.StatePressed.Border.Rounding = 6F;
            this.btnUpdate.StatePressed.Border.Width = 1;
            this.btnUpdate.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnUpdate.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdate.StateTracking.Border.Rounding = 6F;
            this.btnUpdate.StateTracking.Border.Width = 1;
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Values.Text = "Cập nhật thông tin";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(780, 100);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(188, 32);
            this.txtCurrentPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCurrentPassword.StateCommon.Border.Rounding = 5F;
            this.txtCurrentPassword.StateCommon.Border.Width = 1;
            this.txtCurrentPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtCurrentPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtCurrentPassword.TabIndex = 4;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(15, 60);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(88, 24);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Thông tin ";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(617, 60);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(161, 24);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.kryptonLabel3.TabIndex = 15;
            this.kryptonLabel3.Values.Text = "Thay đổi mật khẩu";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(617, 100);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(141, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.kryptonLabel5.TabIndex = 16;
            this.kryptonLabel5.Values.Text = "Mật khẩu hiện tại";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(617, 150);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(115, 26);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.kryptonLabel6.TabIndex = 17;
            this.kryptonLabel6.Values.Text = "Mật khẩu mới";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(617, 200);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(153, 26);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.kryptonLabel7.TabIndex = 18;
            this.kryptonLabel7.Values.Text = "Xác nhận mật khẩu";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(780, 150);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(188, 32);
            this.txtNewPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNewPassword.StateCommon.Border.Rounding = 5F;
            this.txtNewPassword.StateCommon.Border.Width = 1;
            this.txtNewPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNewPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtNewPassword.TabIndex = 5;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(780, 200);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(188, 32);
            this.txtConfirmPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtConfirmPassword.StateCommon.Border.Rounding = 5F;
            this.txtConfirmPassword.StateCommon.Border.Width = 1;
            this.txtConfirmPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtConfirmPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Enabled = false;
            this.btnChangePassword.Location = new System.Drawing.Point(800, 250);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChangePassword.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChangePassword.OverrideDefault.Border.Rounding = 6F;
            this.btnChangePassword.OverrideDefault.Border.Width = 1;
            this.btnChangePassword.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChangePassword.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChangePassword.OverrideFocus.Border.Rounding = 6F;
            this.btnChangePassword.OverrideFocus.Border.Width = 1;
            this.btnChangePassword.Size = new System.Drawing.Size(165, 32);
            this.btnChangePassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChangePassword.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChangePassword.StateCommon.Border.Rounding = 6F;
            this.btnChangePassword.StateCommon.Border.Width = 1;
            this.btnChangePassword.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnChangePassword.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnChangePassword.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.btnChangePassword.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.btnChangePassword.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.btnChangePassword.StateDisabled.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.btnChangePassword.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChangePassword.StateDisabled.Border.Rounding = 6F;
            this.btnChangePassword.StateDisabled.Border.Width = 1;
            this.btnChangePassword.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChangePassword.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChangePassword.StateNormal.Border.Rounding = 6F;
            this.btnChangePassword.StateNormal.Border.Width = 1;
            this.btnChangePassword.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChangePassword.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChangePassword.StatePressed.Border.Rounding = 6F;
            this.btnChangePassword.StatePressed.Border.Width = 1;
            this.btnChangePassword.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (150)))), ((int) (((byte) (243)))));
            this.btnChangePassword.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders) ((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChangePassword.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChangePassword.StateTracking.Border.Rounding = 6F;
            this.btnChangePassword.StateTracking.Border.Width = 1;
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Values.Text = "Đổi mật khẩu";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // cbxMatch
            // 
            this.cbxMatch.Images.CheckedNormal = ((System.Drawing.Image) (resources.GetObject("cbxMatch.Images.CheckedNormal")));
            this.cbxMatch.Images.CheckedPressed = ((System.Drawing.Image) (resources.GetObject("cbxMatch.Images.CheckedPressed")));
            this.cbxMatch.Images.CheckedTracking = ((System.Drawing.Image) (resources.GetObject("cbxMatch.Images.CheckedTracking")));
            this.cbxMatch.Images.Common = ((System.Drawing.Image) (resources.GetObject("cbxMatch.Images.Common")));
            this.cbxMatch.Images.UncheckedDisabled = ((System.Drawing.Image) (resources.GetObject("cbxMatch.Images.UncheckedDisabled")));
            this.cbxMatch.Images.UncheckedNormal = ((System.Drawing.Image) (resources.GetObject("cbxMatch.Images.UncheckedNormal")));
            this.cbxMatch.Images.UncheckedPressed = ((System.Drawing.Image) (resources.GetObject("cbxMatch.Images.UncheckedPressed")));
            this.cbxMatch.Images.UncheckedTracking = ((System.Drawing.Image) (resources.GetObject("cbxMatch.Images.UncheckedTracking")));
            this.cbxMatch.Location = new System.Drawing.Point(973, 210);
            this.cbxMatch.MaximumSize = new System.Drawing.Size(0, 16);
            this.cbxMatch.Name = "cbxMatch";
            this.cbxMatch.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverLightMode;
            this.cbxMatch.Size = new System.Drawing.Size(26, 16);
            this.cbxMatch.StateCommon.Padding = new System.Windows.Forms.Padding(5);
            this.cbxMatch.TabIndex = 19;
            this.cbxMatch.TabStop = false;
            this.cbxMatch.Values.Text = "";
            this.cbxMatch.Visible = false;
            // 
            // cbxStrength
            // 
            this.cbxStrength.Images.CheckedNormal = ((System.Drawing.Image) (resources.GetObject("cbxStrength.Images.CheckedNormal")));
            this.cbxStrength.Images.CheckedPressed = ((System.Drawing.Image) (resources.GetObject("cbxStrength.Images.CheckedPressed")));
            this.cbxStrength.Images.CheckedTracking = ((System.Drawing.Image) (resources.GetObject("cbxStrength.Images.CheckedTracking")));
            this.cbxStrength.Images.Common = ((System.Drawing.Image) (resources.GetObject("cbxStrength.Images.Common")));
            this.cbxStrength.Images.UncheckedDisabled = ((System.Drawing.Image) (resources.GetObject("cbxStrength.Images.UncheckedDisabled")));
            this.cbxStrength.Images.UncheckedNormal = ((System.Drawing.Image) (resources.GetObject("cbxStrength.Images.UncheckedNormal")));
            this.cbxStrength.Images.UncheckedPressed = ((System.Drawing.Image) (resources.GetObject("cbxStrength.Images.UncheckedPressed")));
            this.cbxStrength.Images.UncheckedTracking = ((System.Drawing.Image) (resources.GetObject("cbxStrength.Images.UncheckedTracking")));
            this.cbxStrength.Location = new System.Drawing.Point(973, 160);
            this.cbxStrength.MaximumSize = new System.Drawing.Size(0, 16);
            this.cbxStrength.Name = "cbxStrength";
            this.cbxStrength.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverLightMode;
            this.cbxStrength.Size = new System.Drawing.Size(26, 16);
            this.cbxStrength.StateCommon.Padding = new System.Windows.Forms.Padding(5);
            this.cbxStrength.TabIndex = 20;
            this.cbxStrength.TabStop = false;
            this.cbxStrength.Values.Text = "";
            this.cbxStrength.Visible = false;
            // 
            // AdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbxStrength);
            this.Controls.Add(this.cbxMatch);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.lblTille);
            this.Location = new System.Drawing.Point(15, 30);
            this.Name = "AdminInfo";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1300, 500);
            this.Load += new System.EventHandler(this.AdminInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Krypton.Toolkit.KryptonCheckBox cbxStrength;

        private Krypton.Toolkit.KryptonCheckBox cbxMatch;

        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonTextBox txtNewPassword;
        private Krypton.Toolkit.KryptonTextBox txtConfirmPassword;
        private Krypton.Toolkit.KryptonButton btnChangePassword;

        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;

        private Krypton.Toolkit.KryptonLabel kryptonLabel4;

        private Krypton.Toolkit.KryptonTextBox txtCurrentPassword;

        private Krypton.Toolkit.KryptonButton btnUpdate;

        private Krypton.Toolkit.KryptonTextBox txtFullname;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;

        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;

        private Krypton.Toolkit.KryptonLabel lblTille;

        #endregion
    }
}