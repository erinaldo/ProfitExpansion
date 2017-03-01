namespace ProfitContenedor
{
    partial class FrmGodc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGodc));
            this.cboEmpresa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnAceptar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.DisplayMember = "Text";
            this.cboEmpresa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.ItemHeight = 16;
            this.cboEmpresa.Location = new System.Drawing.Point(12, 41);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(244, 22);
            this.cboEmpresa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboEmpresa.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAceptar.Location = new System.Drawing.Point(12, 69);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 38);
            this.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Location = new System.Drawing.Point(137, 69);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 38);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(13, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 13);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Empresa:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGodc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 112);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboEmpresa);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGodc";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar ODC en Profit Administrativo 2K8";
            this.Load += new System.EventHandler(this.FrmGodc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cboEmpresa;
        private DevComponents.DotNetBar.ButtonX btnAceptar;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}