namespace ProfitContenedor
{
    partial class FrmAddSupervisados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddSupervisados));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonItem();
            this.cbo_nomina = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbo_listar = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(6, 47);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Nomina:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(6, 100);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(67, 20);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Empleados:";
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.BackColor = System.Drawing.Color.White;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.ForeColor = System.Drawing.Color.Black;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNuevo,
            this.btnGuardar});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(400, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 7;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Text = "btnNuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Text = "btnGuardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbo_nomina
            // 
            this.cbo_nomina.DisplayMember = "Text";
            this.cbo_nomina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_nomina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nomina.FormattingEnabled = true;
            this.cbo_nomina.ItemHeight = 14;
            this.cbo_nomina.Location = new System.Drawing.Point(6, 74);
            this.cbo_nomina.Name = "cbo_nomina";
            this.cbo_nomina.Size = new System.Drawing.Size(389, 20);
            this.cbo_nomina.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_nomina.TabIndex = 3;
            this.cbo_nomina.SelectedIndexChanged += new System.EventHandler(this.cbo_nomina_SelectedIndexChanged);
            // 
            // cbo_listar
            // 
            this.cbo_listar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo_listar.FormattingEnabled = true;
            this.cbo_listar.Location = new System.Drawing.Point(6, 126);
            this.cbo_listar.Name = "cbo_listar";
            this.cbo_listar.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.cbo_listar.Size = new System.Drawing.Size(394, 184);
            this.cbo_listar.TabIndex = 9;
            this.cbo_listar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_listar_KeyDown);
            // 
            // FrmAddSupervisados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 312);
            this.Controls.Add(this.cbo_listar);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.cbo_nomina);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddSupervisados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Supervisor";
            this.Load += new System.EventHandler(this.FrmAddSupervisados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_nomina;
        private System.Windows.Forms.ListBox cbo_listar;
    }
}