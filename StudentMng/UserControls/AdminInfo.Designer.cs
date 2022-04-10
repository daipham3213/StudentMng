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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAccounts = new Krypton.Toolkit.KryptonDataGridView();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.panelChangePassword = new System.Windows.Forms.Panel();
            this.labelClosePanel = new System.Windows.Forms.Label();
            this.cbxStrength = new Krypton.Toolkit.KryptonCheckBox();
            this.cbxMatch = new Krypton.Toolkit.KryptonCheckBox();
            this.bnConfirm = new Krypton.Toolkit.KryptonButton();
            this.txtConfirmPassword = new Krypton.Toolkit.KryptonTextBox();
            this.txtNewPassword = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.btnChangePassword = new Krypton.Toolkit.KryptonButton();
            this.btnAddAccount = new Krypton.Toolkit.KryptonButton();
            this.panelAddAcount = new System.Windows.Forms.Panel();
            this.IdColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.UsernameColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.FullnameColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.PasswordColumn = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            this.panelUsers.SuspendLayout();
            this.panelChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAccounts
            // 
            this.dataGridViewAccounts.AllowUserToAddRows = false;
            this.dataGridViewAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.UsernameColumn,
            this.FullnameColumn,
            this.PasswordColumn});
            this.dataGridViewAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAccounts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.RowHeadersVisible = false;
            this.dataGridViewAccounts.RowHeadersWidth = 51;
            this.dataGridViewAccounts.Size = new System.Drawing.Size(959, 340);
            this.dataGridViewAccounts.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dataGridViewAccounts.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dataGridViewAccounts.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewAccounts.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAccounts.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, 5);
            this.dataGridViewAccounts.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.dataGridViewAccounts.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.dataGridViewAccounts.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dataGridViewAccounts.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dataGridViewAccounts.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAccounts.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridViewAccounts.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dataGridViewAccounts.TabIndex = 22;
            this.dataGridViewAccounts.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewStudents_CellBeginEdit);
            this.dataGridViewAccounts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellEndEdit);
            // 
            // panelUsers
            // 
            this.panelUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsers.Controls.Add(this.dataGridViewAccounts);
            this.panelUsers.Location = new System.Drawing.Point(8, 63);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(959, 340);
            this.panelUsers.TabIndex = 23;
            // 
            // panelChangePassword
            // 
            this.panelChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChangePassword.Controls.Add(this.labelClosePanel);
            this.panelChangePassword.Controls.Add(this.cbxStrength);
            this.panelChangePassword.Controls.Add(this.cbxMatch);
            this.panelChangePassword.Controls.Add(this.bnConfirm);
            this.panelChangePassword.Controls.Add(this.txtConfirmPassword);
            this.panelChangePassword.Controls.Add(this.txtNewPassword);
            this.panelChangePassword.Controls.Add(this.kryptonLabel7);
            this.panelChangePassword.Controls.Add(this.kryptonLabel6);
            this.panelChangePassword.Controls.Add(this.kryptonLabel3);
            this.panelChangePassword.Location = new System.Drawing.Point(607, 32);
            this.panelChangePassword.Name = "panelChangePassword";
            this.panelChangePassword.Size = new System.Drawing.Size(365, 244);
            this.panelChangePassword.TabIndex = 24;
            this.panelChangePassword.Visible = false;
            // 
            // labelClosePanel
            // 
            this.labelClosePanel.AutoSize = true;
            this.labelClosePanel.Location = new System.Drawing.Point(327, 11);
            this.labelClosePanel.Name = "labelClosePanel";
            this.labelClosePanel.Size = new System.Drawing.Size(16, 17);
            this.labelClosePanel.TabIndex = 45;
            this.labelClosePanel.Text = "X";
            this.labelClosePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClosePanel.Click += new System.EventHandler(this.labelClosePanel_Click);
            // 
            // cbxStrength
            // 
            this.cbxStrength.AutoCheck = false;
            this.cbxStrength.Images.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.CheckedNormal")));
            this.cbxStrength.Images.CheckedPressed = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.CheckedPressed")));
            this.cbxStrength.Images.CheckedTracking = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.CheckedTracking")));
            this.cbxStrength.Images.Common = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.Common")));
            this.cbxStrength.Images.UncheckedDisabled = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.UncheckedDisabled")));
            this.cbxStrength.Images.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.UncheckedNormal")));
            this.cbxStrength.Images.UncheckedPressed = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.UncheckedPressed")));
            this.cbxStrength.Images.UncheckedTracking = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.UncheckedTracking")));
            this.cbxStrength.Location = new System.Drawing.Point(140, 82);
            this.cbxStrength.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStrength.Name = "cbxStrength";
            this.cbxStrength.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverLightMode;
            this.cbxStrength.Size = new System.Drawing.Size(26, 16);
            this.cbxStrength.StateCommon.Padding = new System.Windows.Forms.Padding(5);
            this.cbxStrength.TabIndex = 44;
            this.cbxStrength.TabStop = false;
            this.cbxStrength.Values.Text = "";
            this.cbxStrength.Visible = false;
            // 
            // cbxMatch
            // 
            this.cbxMatch.AutoCheck = false;
            this.cbxMatch.Images.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.CheckedNormal")));
            this.cbxMatch.Images.CheckedPressed = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.CheckedPressed")));
            this.cbxMatch.Images.CheckedTracking = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.CheckedTracking")));
            this.cbxMatch.Images.Common = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.Common")));
            this.cbxMatch.Images.UncheckedDisabled = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.UncheckedDisabled")));
            this.cbxMatch.Images.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.UncheckedNormal")));
            this.cbxMatch.Images.UncheckedPressed = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.UncheckedPressed")));
            this.cbxMatch.Images.UncheckedTracking = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.UncheckedTracking")));
            this.cbxMatch.Location = new System.Drawing.Point(140, 150);
            this.cbxMatch.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMatch.Name = "cbxMatch";
            this.cbxMatch.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverLightMode;
            this.cbxMatch.Size = new System.Drawing.Size(26, 16);
            this.cbxMatch.StateCommon.Padding = new System.Windows.Forms.Padding(5);
            this.cbxMatch.TabIndex = 43;
            this.cbxMatch.TabStop = false;
            this.cbxMatch.Values.Text = "";
            this.cbxMatch.Visible = false;
            // 
            // bnConfirm
            // 
            this.bnConfirm.Enabled = false;
            this.bnConfirm.Location = new System.Drawing.Point(122, 190);
            this.bnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.bnConfirm.Name = "bnConfirm";
            this.bnConfirm.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bnConfirm.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bnConfirm.OverrideDefault.Border.Rounding = 6F;
            this.bnConfirm.OverrideDefault.Border.Width = 1;
            this.bnConfirm.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bnConfirm.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bnConfirm.OverrideFocus.Border.Rounding = 6F;
            this.bnConfirm.OverrideFocus.Border.Width = 1;
            this.bnConfirm.Size = new System.Drawing.Size(94, 26);
            this.bnConfirm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bnConfirm.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bnConfirm.StateCommon.Border.Rounding = 6F;
            this.bnConfirm.StateCommon.Border.Width = 1;
            this.bnConfirm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.bnConfirm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnConfirm.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnConfirm.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.bnConfirm.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.bnConfirm.StateDisabled.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.bnConfirm.StateDisabled.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bnConfirm.StateDisabled.Border.Rounding = 6F;
            this.bnConfirm.StateDisabled.Border.Width = 1;
            this.bnConfirm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bnConfirm.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bnConfirm.StateNormal.Border.Rounding = 6F;
            this.bnConfirm.StateNormal.Border.Width = 1;
            this.bnConfirm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bnConfirm.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bnConfirm.StatePressed.Border.Rounding = 6F;
            this.bnConfirm.StatePressed.Border.Width = 1;
            this.bnConfirm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bnConfirm.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bnConfirm.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.bnConfirm.StateTracking.Border.Rounding = 6F;
            this.bnConfirm.StateTracking.Border.Width = 1;
            this.bnConfirm.TabIndex = 39;
            this.bnConfirm.Values.Text = "Xác nhận";
            this.bnConfirm.Click += new System.EventHandler(this.bnConfirm_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(140, 118);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(203, 28);
            this.txtConfirmPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtConfirmPassword.StateCommon.Border.Rounding = 5F;
            this.txtConfirmPassword.StateCommon.Border.Width = 1;
            this.txtConfirmPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtConfirmPassword.TabIndex = 38;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(140, 50);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(203, 28);
            this.txtNewPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNewPassword.StateCommon.Border.Rounding = 5F;
            this.txtNewPassword.StateCommon.Border.Width = 1;
            this.txtNewPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtNewPassword.TabIndex = 37;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(12, 120);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(124, 21);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 42;
            this.kryptonLabel7.Values.Text = "Xác nhận mật khẩu";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(12, 57);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(93, 21);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 41;
            this.kryptonLabel6.Values.Text = "Mật khẩu mới";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 11);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(130, 20);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 40;
            this.kryptonLabel3.Values.Text = "Thay đổi mật khẩu";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(10, 10);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChangePassword.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChangePassword.OverrideDefault.Border.Rounding = 6F;
            this.btnChangePassword.OverrideDefault.Border.Width = 1;
            this.btnChangePassword.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChangePassword.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChangePassword.OverrideFocus.Border.Rounding = 6F;
            this.btnChangePassword.OverrideFocus.Border.Width = 1;
            this.btnChangePassword.Size = new System.Drawing.Size(127, 32);
            this.btnChangePassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChangePassword.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChangePassword.StateCommon.Border.Rounding = 6F;
            this.btnChangePassword.StateCommon.Border.Width = 1;
            this.btnChangePassword.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnChangePassword.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChangePassword.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChangePassword.StateNormal.Border.Rounding = 6F;
            this.btnChangePassword.StateNormal.Border.Width = 1;
            this.btnChangePassword.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChangePassword.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChangePassword.StatePressed.Border.Rounding = 6F;
            this.btnChangePassword.StatePressed.Border.Width = 1;
            this.btnChangePassword.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangePassword.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChangePassword.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChangePassword.StateTracking.Border.Rounding = 6F;
            this.btnChangePassword.StateTracking.Border.Width = 1;
            this.btnChangePassword.TabIndex = 23;
            this.btnChangePassword.Values.Text = "Đổi mật khẩu";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(195, 10);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddAccount.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddAccount.OverrideDefault.Border.Rounding = 6F;
            this.btnAddAccount.OverrideDefault.Border.Width = 1;
            this.btnAddAccount.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddAccount.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddAccount.OverrideFocus.Border.Rounding = 6F;
            this.btnAddAccount.OverrideFocus.Border.Width = 1;
            this.btnAddAccount.Size = new System.Drawing.Size(127, 32);
            this.btnAddAccount.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddAccount.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddAccount.StateCommon.Border.Rounding = 6F;
            this.btnAddAccount.StateCommon.Border.Width = 1;
            this.btnAddAccount.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddAccount.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddAccount.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddAccount.StateNormal.Border.Rounding = 6F;
            this.btnAddAccount.StateNormal.Border.Width = 1;
            this.btnAddAccount.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddAccount.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddAccount.StatePressed.Border.Rounding = 6F;
            this.btnAddAccount.StatePressed.Border.Width = 1;
            this.btnAddAccount.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddAccount.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddAccount.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddAccount.StateTracking.Border.Rounding = 6F;
            this.btnAddAccount.StateTracking.Border.Width = 1;
            this.btnAddAccount.TabIndex = 23;
            this.btnAddAccount.Values.Text = "Thêm tài khoản";
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // panelAddAcount
            // 
            this.panelAddAcount.Location = new System.Drawing.Point(615, 46);
            this.panelAddAcount.Name = "panelAddAcount";
            this.panelAddAcount.Size = new System.Drawing.Size(360, 345);
            this.panelAddAcount.TabIndex = 25;
            this.panelAddAcount.Visible = false;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Width = 48;
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.DataPropertyName = "Username";
            this.UsernameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.UsernameColumn.HeaderText = "Tên đăng nhập";
            this.UsernameColumn.Name = "UsernameColumn";
            this.UsernameColumn.Width = 124;
            // 
            // FullnameColumn
            // 
            this.FullnameColumn.DataPropertyName = "FullName";
            this.FullnameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.FullnameColumn.HeaderText = "Họ Tên";
            this.FullnameColumn.Name = "FullnameColumn";
            this.FullnameColumn.Width = 78;
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.DataPropertyName = "Password";
            this.PasswordColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.PasswordColumn.HeaderText = "Mật khẩu";
            this.PasswordColumn.Name = "PasswordColumn";
            this.PasswordColumn.Visible = false;
            this.PasswordColumn.Width = 91;
            // 
            // AdminInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelChangePassword);
            this.Controls.Add(this.panelAddAcount);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.panelUsers);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(15, 30);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminInfo";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(975, 411);
            this.Load += new System.EventHandler(this.AdminInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            this.panelUsers.ResumeLayout(false);
            this.panelChangePassword.ResumeLayout(false);
            this.panelChangePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonDataGridView dataGridViewAccounts;
        private System.Windows.Forms.Panel panelUsers;
        private Krypton.Toolkit.KryptonButton btnChangePassword;
        private System.Windows.Forms.Panel panelChangePassword;
        private Krypton.Toolkit.KryptonCheckBox cbxStrength;
        private Krypton.Toolkit.KryptonCheckBox cbxMatch;
        private Krypton.Toolkit.KryptonButton bnConfirm;
        private Krypton.Toolkit.KryptonTextBox txtConfirmPassword;
        private Krypton.Toolkit.KryptonTextBox txtNewPassword;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.Label labelClosePanel;
        private Krypton.Toolkit.KryptonButton btnAddAccount;
        private System.Windows.Forms.Panel panelAddAcount;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn IdColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn UsernameColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn FullnameColumn;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn PasswordColumn;
    }
}