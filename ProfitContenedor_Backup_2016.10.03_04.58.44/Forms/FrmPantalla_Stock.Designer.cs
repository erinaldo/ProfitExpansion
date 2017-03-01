namespace ProfitContenedor
{
    partial class FrmPantalla_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPantalla_Stock));
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.txtBuscar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnPrimero = new DevComponents.DotNetBar.ButtonItem();
            this.btnAnterior = new DevComponents.DotNetBar.ButtonItem();
            this.btnSiguiente = new DevComponents.DotNetBar.ButtonItem();
            this.btnUltimo = new DevComponents.DotNetBar.ButtonItem();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonItem();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonItem();
            this.btnDeshacer = new DevComponents.DotNetBar.ButtonItem();
            this.txtUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtEmpresa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtAlmacen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDes_Usuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDes_emp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDes_Alm = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.BackColor = System.Drawing.Color.White;
            this.bar1.Controls.Add(this.txtBuscar);
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.ForeColor = System.Drawing.Color.Black;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPrimero,
            this.btnAnterior,
            this.btnSiguiente,
            this.btnUltimo,
            this.btnNuevo,
            this.btnGuardar,
            this.btnEliminar,
            this.btnDeshacer});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(464, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 12;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBuscar.Border.Class = "TextBoxBorder";
            this.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBuscar.DisabledBackColor = System.Drawing.Color.White;
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(325, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(106, 23);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.WatermarkText = "Buscar usuario...";
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimero.Image")));
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Text = "btnPrimero";
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Text = "btnAnterior";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Text = "btnSiguiente";
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Text = "btnUltimo";
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
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
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "btnEliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshacer.Image")));
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Text = "btnDeshacer";
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUsuario.Border.Class = "TextBoxBorder";
            this.txtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.DisabledBackColor = System.Drawing.Color.White;
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(66, 58);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(65, 22);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 58);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(48, 22);
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "Usuario:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 86);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(48, 22);
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "Empresa:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmpresa.Border.Class = "TextBoxBorder";
            this.txtEmpresa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpresa.DisabledBackColor = System.Drawing.Color.White;
            this.txtEmpresa.ForeColor = System.Drawing.Color.Black;
            this.txtEmpresa.Location = new System.Drawing.Point(66, 86);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(65, 22);
            this.txtEmpresa.TabIndex = 1;
            this.txtEmpresa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpresa_KeyDown);
            this.txtEmpresa.Leave += new System.EventHandler(this.txtEmpresa_Leave);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(12, 114);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(48, 22);
            this.labelX3.TabIndex = 15;
            this.labelX3.Text = "Almacen:";
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAlmacen.Border.Class = "TextBoxBorder";
            this.txtAlmacen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAlmacen.DisabledBackColor = System.Drawing.Color.White;
            this.txtAlmacen.ForeColor = System.Drawing.Color.Black;
            this.txtAlmacen.Location = new System.Drawing.Point(66, 114);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.Size = new System.Drawing.Size(65, 22);
            this.txtAlmacen.TabIndex = 2;
            this.txtAlmacen.Leave += new System.EventHandler(this.txtAlmacen_Leave);
            // 
            // txtDes_Usuario
            // 
            this.txtDes_Usuario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDes_Usuario.Border.Class = "TextBoxBorder";
            this.txtDes_Usuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDes_Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDes_Usuario.DisabledBackColor = System.Drawing.Color.White;
            this.txtDes_Usuario.Enabled = false;
            this.txtDes_Usuario.ForeColor = System.Drawing.Color.Black;
            this.txtDes_Usuario.Location = new System.Drawing.Point(137, 58);
            this.txtDes_Usuario.Name = "txtDes_Usuario";
            this.txtDes_Usuario.Size = new System.Drawing.Size(294, 22);
            this.txtDes_Usuario.TabIndex = 3;
            // 
            // txtDes_emp
            // 
            this.txtDes_emp.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDes_emp.Border.Class = "TextBoxBorder";
            this.txtDes_emp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDes_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDes_emp.DisabledBackColor = System.Drawing.Color.White;
            this.txtDes_emp.Enabled = false;
            this.txtDes_emp.ForeColor = System.Drawing.Color.Black;
            this.txtDes_emp.Location = new System.Drawing.Point(137, 86);
            this.txtDes_emp.Name = "txtDes_emp";
            this.txtDes_emp.Size = new System.Drawing.Size(294, 22);
            this.txtDes_emp.TabIndex = 4;
            // 
            // txtDes_Alm
            // 
            this.txtDes_Alm.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDes_Alm.Border.Class = "TextBoxBorder";
            this.txtDes_Alm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDes_Alm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDes_Alm.DisabledBackColor = System.Drawing.Color.White;
            this.txtDes_Alm.Enabled = false;
            this.txtDes_Alm.ForeColor = System.Drawing.Color.Black;
            this.txtDes_Alm.Location = new System.Drawing.Point(137, 114);
            this.txtDes_Alm.Name = "txtDes_Alm";
            this.txtDes_Alm.Size = new System.Drawing.Size(294, 22);
            this.txtDes_Alm.TabIndex = 5;
            // 
            // FrmPantalla_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 158);
            this.Controls.Add(this.txtAlmacen);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtDes_Alm);
            this.Controls.Add(this.txtDes_emp);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtDes_Usuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPantalla_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla para Stock";
            this.Load += new System.EventHandler(this.FrmPantalla_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnPrimero;
        private DevComponents.DotNetBar.ButtonItem btnAnterior;
        private DevComponents.DotNetBar.ButtonItem btnSiguiente;
        private DevComponents.DotNetBar.ButtonItem btnUltimo;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private DevComponents.DotNetBar.ButtonItem btnEliminar;
        private DevComponents.DotNetBar.ButtonItem btnDeshacer;
        public DevComponents.DotNetBar.Controls.TextBoxX txtUsuario;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.DotNetBar.Controls.TextBoxX txtEmpresa;
        private DevComponents.DotNetBar.LabelX labelX3;
        public DevComponents.DotNetBar.Controls.TextBoxX txtAlmacen;
        public DevComponents.DotNetBar.Controls.TextBoxX txtDes_Usuario;
        public DevComponents.DotNetBar.Controls.TextBoxX txtDes_emp;
        public DevComponents.DotNetBar.Controls.TextBoxX txtDes_Alm;
        public DevComponents.DotNetBar.Controls.TextBoxX txtBuscar;
    }
}