namespace ProfitContenedor
{
    partial class FrmJPCheck
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJPCheck));
            this.cbo_supervi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbo_listsuper = new System.Windows.Forms.ListBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cbo_supervi
            // 
            this.cbo_supervi.DisplayMember = "Text";
            this.cbo_supervi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_supervi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_supervi.FormattingEnabled = true;
            this.cbo_supervi.ItemHeight = 14;
            this.cbo_supervi.Location = new System.Drawing.Point(6, 51);
            this.cbo_supervi.Name = "cbo_supervi";
            this.cbo_supervi.Size = new System.Drawing.Size(343, 20);
            this.cbo_supervi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_supervi.TabIndex = 0;
            this.cbo_supervi.SelectedValueChanged += new System.EventHandler(this.cbo_supervi_SelectedValueChanged);
            // 
            // cbo_listsuper
            // 
            this.cbo_listsuper.FormattingEnabled = true;
            this.cbo_listsuper.Location = new System.Drawing.Point(6, 106);
            this.cbo_listsuper.Name = "cbo_listsuper";
            this.cbo_listsuper.Size = new System.Drawing.Size(343, 212);
            this.cbo_listsuper.TabIndex = 1;
            this.cbo_listsuper.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_listsuper_KeyDown);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(6, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Supervisor:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(6, 77);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Supervisados:";
            // 
            // FrmJPCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 322);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbo_listsuper);
            this.Controls.Add(this.cbo_supervi);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmJPCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmJPCheck_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_supervi;
        private System.Windows.Forms.ListBox cbo_listsuper;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}