namespace ProfitContenedor
{
    partial class FrmE2
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
            this.cboRecibe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboEntrega = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnEntregar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cboRecibe
            // 
            this.cboRecibe.DisplayMember = "Text";
            this.cboRecibe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRecibe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecibe.ForeColor = System.Drawing.Color.Black;
            this.cboRecibe.FormattingEnabled = true;
            this.cboRecibe.ItemHeight = 16;
            this.cboRecibe.Location = new System.Drawing.Point(56, 35);
            this.cboRecibe.Name = "cboRecibe";
            this.cboRecibe.Size = new System.Drawing.Size(218, 22);
            this.cboRecibe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboRecibe.TabIndex = 0;
            // 
            // cboEntrega
            // 
            this.cboEntrega.DisplayMember = "Text";
            this.cboEntrega.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEntrega.ForeColor = System.Drawing.Color.Black;
            this.cboEntrega.FormattingEnabled = true;
            this.cboEntrega.ItemHeight = 16;
            this.cboEntrega.Location = new System.Drawing.Point(56, 63);
            this.cboEntrega.Name = "cboEntrega";
            this.cboEntrega.Size = new System.Drawing.Size(218, 22);
            this.cboEntrega.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboEntrega.TabIndex = 1;
            // 
            // btnEntregar
            // 
            this.btnEntregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEntregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEntregar.Location = new System.Drawing.Point(280, 35);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(120, 22);
            this.btnEntregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEntregar.TabIndex = 2;
            this.btnEntregar.Text = "&Entregar";
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(280, 63);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 22);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(9, 35);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(41, 22);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Recibe:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(9, 63);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(41, 22);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Entrega:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(56, 7);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(218, 22);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Recibe:";
            // 
            // FrmE2
            // 
            this.AcceptButton = this.btnEntregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(426, 104);
            this.ControlBox = false;
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEntregar);
            this.Controls.Add(this.cboEntrega);
            this.Controls.Add(this.cboRecibe);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmE2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de entrega";
            this.Load += new System.EventHandler(this.FrmE2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cboRecibe;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboEntrega;
        private DevComponents.DotNetBar.ButtonX btnEntregar;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}