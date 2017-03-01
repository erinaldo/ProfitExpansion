namespace ProfitContenedor
{
    partial class FrmReportes
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
            this.btnImprimir = new DevComponents.DotNetBar.ButtonX();
            this.cboReporte = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImprimir.Location = new System.Drawing.Point(278, 239);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(127, 23);
            this.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "&Ver reporte";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cboReporte
            // 
            this.cboReporte.DisplayMember = "Text";
            this.cboReporte.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReporte.ForeColor = System.Drawing.Color.Black;
            this.cboReporte.FormattingEnabled = true;
            this.cboReporte.ItemHeight = 16;
            this.cboReporte.Location = new System.Drawing.Point(12, 55);
            this.cboReporte.Name = "cboReporte";
            this.cboReporte.Size = new System.Drawing.Size(393, 22);
            this.cboReporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboReporte.TabIndex = 3;
            this.cboReporte.Click += new System.EventHandler(this.cboReporte_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 32);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 17);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Reporte:";
            // 
            // FrmReportes
            // 
            this.AcceptButton = this.btnImprimir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 274);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cboReporte);
            this.Controls.Add(this.btnImprimir);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReportes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Gerencial";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnImprimir;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboReporte;
        private DevComponents.DotNetBar.LabelX labelX2;
        
    }
}