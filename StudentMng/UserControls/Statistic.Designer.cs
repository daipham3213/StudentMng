
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
            this.lbYearFilter = new System.Windows.Forms.Label();
            this.cbbYearFilter = new Krypton.Toolkit.KryptonComboBox();
            this.lbConditionFilter = new System.Windows.Forms.Label();
            this.cbbCondition = new Krypton.Toolkit.KryptonComboBox();
            this.btnYearFilter = new System.Windows.Forms.Button();
            this.cbbConditionFilter = new Krypton.Toolkit.KryptonComboBox();
            this.btnConditionFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cbbYearFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbConditionFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // lbYearFilter
            // 
            this.lbYearFilter.AutoSize = true;
            this.lbYearFilter.Location = new System.Drawing.Point(17, 35);
            this.lbYearFilter.Name = "lbYearFilter";
            this.lbYearFilter.Size = new System.Drawing.Size(69, 17);
            this.lbYearFilter.TabIndex = 0;
            this.lbYearFilter.Text = "Theo Năm";
            // 
            // cbbYearFilter
            // 
            this.cbbYearFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbYearFilter.DropDownWidth = 188;
            this.cbbYearFilter.IntegralHeight = false;
            this.cbbYearFilter.Location = new System.Drawing.Point(151, 35);
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
            this.lbConditionFilter.Location = new System.Drawing.Point(17, 78);
            this.lbConditionFilter.Name = "lbConditionFilter";
            this.lbConditionFilter.Size = new System.Drawing.Size(117, 17);
            this.lbConditionFilter.TabIndex = 0;
            this.lbConditionFilter.Text = "Lọc theo điều kiện:";
            // 
            // cbbCondition
            // 
            this.cbbCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbCondition.DropDownWidth = 151;
            this.cbbCondition.IntegralHeight = false;
            this.cbbCondition.Items.AddRange(new object[] {
            "Lớp",
            "Khoa",
            "Ngành"});
            this.cbbCondition.Location = new System.Drawing.Point(151, 78);
            this.cbbCondition.Name = "cbbCondition";
            this.cbbCondition.Size = new System.Drawing.Size(89, 27);
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
            // btnYearFilter
            // 
            this.btnYearFilter.AutoSize = true;
            this.btnYearFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYearFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.btnYearFilter.Location = new System.Drawing.Point(355, 35);
            this.btnYearFilter.Name = "btnYearFilter";
            this.btnYearFilter.Size = new System.Drawing.Size(60, 27);
            this.btnYearFilter.TabIndex = 13;
            this.btnYearFilter.Text = "Lọc >>";
            this.btnYearFilter.UseVisualStyleBackColor = false;
            // 
            // cbbConditionFilter
            // 
            this.cbbConditionFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbConditionFilter.DropDownWidth = 211;
            this.cbbConditionFilter.IntegralHeight = false;
            this.cbbConditionFilter.Location = new System.Drawing.Point(250, 78);
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
            // btnConditionFilter
            // 
            this.btnConditionFilter.AutoSize = true;
            this.btnConditionFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConditionFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConditionFilter.Location = new System.Drawing.Point(574, 78);
            this.btnConditionFilter.Name = "btnConditionFilter";
            this.btnConditionFilter.Size = new System.Drawing.Size(60, 27);
            this.btnConditionFilter.TabIndex = 13;
            this.btnConditionFilter.Text = "Lọc >>";
            this.btnConditionFilter.UseVisualStyleBackColor = false;
            // 
            // Statistic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnConditionFilter);
            this.Controls.Add(this.btnYearFilter);
            this.Controls.Add(this.cbbConditionFilter);
            this.Controls.Add(this.cbbCondition);
            this.Controls.Add(this.lbConditionFilter);
            this.Controls.Add(this.cbbYearFilter);
            this.Controls.Add(this.lbYearFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Statistic";
            this.Size = new System.Drawing.Size(1400, 800);
            this.Load += new System.EventHandler(this.Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbbYearFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbConditionFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbYearFilter;
        private Krypton.Toolkit.KryptonComboBox cbbYearFilter;
        private System.Windows.Forms.Label lbConditionFilter;
        private Krypton.Toolkit.KryptonComboBox cbbCondition;
        private System.Windows.Forms.Button btnYearFilter;
        private Krypton.Toolkit.KryptonComboBox cbbConditionFilter;
        private System.Windows.Forms.Button btnConditionFilter;
    }
}
