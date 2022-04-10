
namespace StudentMng.UserControls
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.labelClosePanel = new System.Windows.Forms.Label();
            this.cbxUsername = new Krypton.Toolkit.KryptonCheckBox();
            this.cbxPassword = new Krypton.Toolkit.KryptonCheckBox();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            this.txtPassword = new Krypton.Toolkit.KryptonTextBox();
            this.txtUsername = new Krypton.Toolkit.KryptonTextBox();
            this.labelPassword = new Krypton.Toolkit.KryptonLabel();
            this.labelUsername = new Krypton.Toolkit.KryptonLabel();
            this.labelTittle = new Krypton.Toolkit.KryptonLabel();
            this.labelFullname = new Krypton.Toolkit.KryptonLabel();
            this.txtFullname = new Krypton.Toolkit.KryptonTextBox();
            this.cbxFullname = new Krypton.Toolkit.KryptonCheckBox();
            this.SuspendLayout();
            // 
            // labelClosePanel
            // 
            this.labelClosePanel.AutoSize = true;
            this.labelClosePanel.Location = new System.Drawing.Point(326, 13);
            this.labelClosePanel.Name = "labelClosePanel";
            this.labelClosePanel.Size = new System.Drawing.Size(16, 17);
            this.labelClosePanel.TabIndex = 54;
            this.labelClosePanel.Text = "X";
            this.labelClosePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClosePanel.Click += new System.EventHandler(this.labelClosePanel_Click);
            // 
            // cbxUsername
            // 
            this.cbxUsername.AutoCheck = false;
            this.cbxUsername.Images.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("cbxUsername.Images.CheckedNormal")));
            this.cbxUsername.Images.CheckedPressed = ((System.Drawing.Image)(resources.GetObject("cbxUsername.Images.CheckedPressed")));
            this.cbxUsername.Images.CheckedTracking = ((System.Drawing.Image)(resources.GetObject("cbxUsername.Images.CheckedTracking")));
            this.cbxUsername.Images.Common = ((System.Drawing.Image)(resources.GetObject("cbxUsername.Images.Common")));
            this.cbxUsername.Images.UncheckedDisabled = ((System.Drawing.Image)(resources.GetObject("cbxUsername.Images.UncheckedDisabled")));
            this.cbxUsername.Images.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("cbxUsername.Images.UncheckedNormal")));
            this.cbxUsername.Images.UncheckedPressed = ((System.Drawing.Image)(resources.GetObject("cbxUsername.Images.UncheckedPressed")));
            this.cbxUsername.Images.UncheckedTracking = ((System.Drawing.Image)(resources.GetObject("cbxUsername.Images.UncheckedTracking")));
            this.cbxUsername.Location = new System.Drawing.Point(152, 90);
            this.cbxUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxUsername.Name = "cbxUsername";
            this.cbxUsername.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverLightMode;
            this.cbxUsername.Size = new System.Drawing.Size(26, 16);
            this.cbxUsername.StateCommon.Padding = new System.Windows.Forms.Padding(5);
            this.cbxUsername.TabIndex = 53;
            this.cbxUsername.TabStop = false;
            this.cbxUsername.Values.Text = "";
            this.cbxUsername.Visible = false;
            // 
            // cbxPassword
            // 
            this.cbxPassword.AutoCheck = false;
            this.cbxPassword.Images.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("cbxPassword.Images.CheckedNormal")));
            this.cbxPassword.Images.CheckedPressed = ((System.Drawing.Image)(resources.GetObject("cbxPassword.Images.CheckedPressed")));
            this.cbxPassword.Images.CheckedTracking = ((System.Drawing.Image)(resources.GetObject("cbxPassword.Images.CheckedTracking")));
            this.cbxPassword.Images.Common = ((System.Drawing.Image)(resources.GetObject("cbxPassword.Images.Common")));
            this.cbxPassword.Images.UncheckedDisabled = ((System.Drawing.Image)(resources.GetObject("cbxPassword.Images.UncheckedDisabled")));
            this.cbxPassword.Images.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("cbxPassword.Images.UncheckedNormal")));
            this.cbxPassword.Images.UncheckedPressed = ((System.Drawing.Image)(resources.GetObject("cbxPassword.Images.UncheckedPressed")));
            this.cbxPassword.Images.UncheckedTracking = ((System.Drawing.Image)(resources.GetObject("cbxPassword.Images.UncheckedTracking")));
            this.cbxPassword.Location = new System.Drawing.Point(152, 153);
            this.cbxPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxPassword.Name = "cbxPassword";
            this.cbxPassword.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverLightMode;
            this.cbxPassword.Size = new System.Drawing.Size(26, 16);
            this.cbxPassword.StateCommon.Padding = new System.Windows.Forms.Padding(5);
            this.cbxPassword.TabIndex = 52;
            this.cbxPassword.TabStop = false;
            this.cbxPassword.Values.Text = "";
            this.cbxPassword.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(114, 273);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.OverrideDefault.Border.Rounding = 6F;
            this.btnAdd.OverrideDefault.Border.Width = 1;
            this.btnAdd.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.OverrideFocus.Border.Rounding = 6F;
            this.btnAdd.OverrideFocus.Border.Width = 1;
            this.btnAdd.Size = new System.Drawing.Size(110, 34);
            this.btnAdd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.StateCommon.Border.Rounding = 6F;
            this.btnAdd.StateCommon.Border.Width = 1;
            this.btnAdd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.btnAdd.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.btnAdd.StateDisabled.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.btnAdd.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateDisabled.Border.Rounding = 6F;
            this.btnAdd.StateDisabled.Border.Width = 1;
            this.btnAdd.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.StateNormal.Border.Rounding = 6F;
            this.btnAdd.StateNormal.Border.Width = 1;
            this.btnAdd.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.StatePressed.Border.Rounding = 6F;
            this.btnAdd.StatePressed.Border.Width = 1;
            this.btnAdd.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.StateTracking.Border.Rounding = 6F;
            this.btnAdd.StateTracking.Border.Width = 1;
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Values.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(152, 119);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(190, 28);
            this.txtPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPassword.StateCommon.Border.Rounding = 5F;
            this.txtPassword.StateCommon.Border.Width = 1;
            this.txtPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(152, 56);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(190, 28);
            this.txtUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.Rounding = 5F;
            this.txtUsername.StateCommon.Border.Width = 1;
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtUsername.TabIndex = 0;
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(52, 119);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 21);
            this.labelPassword.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.TabIndex = 51;
            this.labelPassword.Values.Text = "Mật khẩu";
            // 
            // labelUsername
            // 
            this.labelUsername.Location = new System.Drawing.Point(28, 56);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(91, 21);
            this.labelUsername.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.TabIndex = 50;
            this.labelUsername.Values.Text = "Tên tài khoản";
            // 
            // labelTittle
            // 
            this.labelTittle.Location = new System.Drawing.Point(28, 10);
            this.labelTittle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(111, 20);
            this.labelTittle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.TabIndex = 49;
            this.labelTittle.Values.Text = "Thêm tài khoản";
            // 
            // labelFullname
            // 
            this.labelFullname.Location = new System.Drawing.Point(52, 186);
            this.labelFullname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(51, 21);
            this.labelFullname.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullname.TabIndex = 51;
            this.labelFullname.Values.Text = "Họ tên";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(152, 186);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(190, 28);
            this.txtFullname.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFullname.StateCommon.Border.Rounding = 5F;
            this.txtFullname.StateCommon.Border.Width = 1;
            this.txtFullname.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtFullname.TabIndex = 2;
            // 
            // cbxFullname
            // 
            this.cbxFullname.AutoCheck = false;
            this.cbxFullname.Images.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("cbxFullname.Images.CheckedNormal")));
            this.cbxFullname.Images.CheckedPressed = ((System.Drawing.Image)(resources.GetObject("cbxFullname.Images.CheckedPressed")));
            this.cbxFullname.Images.CheckedTracking = ((System.Drawing.Image)(resources.GetObject("cbxFullname.Images.CheckedTracking")));
            this.cbxFullname.Images.Common = ((System.Drawing.Image)(resources.GetObject("cbxFullname.Images.Common")));
            this.cbxFullname.Images.UncheckedDisabled = ((System.Drawing.Image)(resources.GetObject("cbxFullname.Images.UncheckedDisabled")));
            this.cbxFullname.Images.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("cbxFullname.Images.UncheckedNormal")));
            this.cbxFullname.Images.UncheckedPressed = ((System.Drawing.Image)(resources.GetObject("cbxFullname.Images.UncheckedPressed")));
            this.cbxFullname.Images.UncheckedTracking = ((System.Drawing.Image)(resources.GetObject("cbxFullname.Images.UncheckedTracking")));
            this.cbxFullname.Location = new System.Drawing.Point(152, 220);
            this.cbxFullname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxFullname.Name = "cbxFullname";
            this.cbxFullname.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverLightMode;
            this.cbxFullname.Size = new System.Drawing.Size(26, 16);
            this.cbxFullname.StateCommon.Padding = new System.Windows.Forms.Padding(5);
            this.cbxFullname.TabIndex = 52;
            this.cbxFullname.TabStop = false;
            this.cbxFullname.Values.Text = "";
            this.cbxFullname.Visible = false;
            // 
            // AddAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelClosePanel);
            this.Controls.Add(this.cbxUsername);
            this.Controls.Add(this.cbxFullname);
            this.Controls.Add(this.cbxPassword);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelFullname);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelTittle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddAccount";
            this.Size = new System.Drawing.Size(358, 343);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClosePanel;
        private Krypton.Toolkit.KryptonCheckBox cbxUsername;
        private Krypton.Toolkit.KryptonCheckBox cbxPassword;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Krypton.Toolkit.KryptonLabel labelPassword;
        private Krypton.Toolkit.KryptonLabel labelUsername;
        private Krypton.Toolkit.KryptonLabel labelTittle;
        private Krypton.Toolkit.KryptonLabel labelFullname;
        private Krypton.Toolkit.KryptonTextBox txtFullname;
        private Krypton.Toolkit.KryptonCheckBox cbxFullname;
    }
}
