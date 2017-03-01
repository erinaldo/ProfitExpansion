namespace ProfitContenedor
{
    partial class FrmPrintActivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintActivos));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(130, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Imprimir Activos por:";
            // 
            // radButton1
            // 
            this.radButton1.Image = ((System.Drawing.Image)(resources.GetObject("radButton1.Image")));
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radButton1.Location = new System.Drawing.Point(12, 39);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(78, 47);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Supervisores";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Image = ((System.Drawing.Image)(resources.GetObject("radButton2.Image")));
            this.radButton2.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radButton2.Location = new System.Drawing.Point(96, 39);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(78, 47);
            this.radButton2.TabIndex = 2;
            this.radButton2.Text = "Ubicación";
            this.radButton2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // FrmPrintActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 90);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrintActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}