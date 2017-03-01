namespace ProfitContenedor
{
    partial class FrmNaviera
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNaviera));
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnPrimero = new DevComponents.DotNetBar.ButtonItem();
            this.btnAnterior = new DevComponents.DotNetBar.ButtonItem();
            this.btnSiguiente = new DevComponents.DotNetBar.ButtonItem();
            this.btnUltimo = new DevComponents.DotNetBar.ButtonItem();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonItem();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonItem();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonItem();
            this.btnDeshacer = new DevComponents.DotNetBar.ButtonItem();
            this.txtProv_des = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCo_prov = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtCo_naviera = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtNavi_des = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmp_des = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmpresa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Falta el representante nacional. ");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Falta el codigo de la naviera.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Falta el nombre de la naviera.");
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Falta la empresa a relacionar.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.BackColor = System.Drawing.Color.White;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.ForeColor = System.Drawing.Color.Black;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPrimero,
            this.btnAnterior,
            this.btnSiguiente,
            this.btnUltimo,
            this.btnBuscar,
            this.btnNuevo,
            this.btnGuardar,
            this.btnEliminar,
            this.btnDeshacer});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(456, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 1;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
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
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Text = "btnBuscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // txtProv_des
            // 
            this.txtProv_des.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtProv_des.Border.Class = "TextBoxBorder";
            this.txtProv_des.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProv_des.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProv_des.DisabledBackColor = System.Drawing.Color.White;
            this.txtProv_des.Enabled = false;
            this.txtProv_des.ForeColor = System.Drawing.Color.Black;
            this.txtProv_des.Location = new System.Drawing.Point(169, 136);
            this.txtProv_des.Name = "txtProv_des";
            this.txtProv_des.Size = new System.Drawing.Size(275, 20);
            this.txtProv_des.TabIndex = 5;
            // 
            // txtCo_prov
            // 
            this.txtCo_prov.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCo_prov.Border.Class = "TextBoxBorder";
            this.txtCo_prov.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCo_prov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCo_prov.DisabledBackColor = System.Drawing.Color.White;
            this.txtCo_prov.ForeColor = System.Drawing.Color.Black;
            this.txtCo_prov.Location = new System.Drawing.Point(98, 136);
            this.txtCo_prov.Name = "txtCo_prov";
            this.txtCo_prov.Size = new System.Drawing.Size(65, 20);
            this.txtCo_prov.TabIndex = 4;
            this.superValidator1.SetValidator1(this.txtCo_prov, this.requiredFieldValidator4);
            this.txtCo_prov.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCo_prov_KeyDown);
            this.txtCo_prov.Leave += new System.EventHandler(this.txtCo_prov_Leave);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(12, 133);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(80, 23);
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "Representante:";
            // 
            // txtCo_naviera
            // 
            this.txtCo_naviera.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCo_naviera.Border.Class = "TextBoxBorder";
            this.txtCo_naviera.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCo_naviera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCo_naviera.DisabledBackColor = System.Drawing.Color.White;
            this.txtCo_naviera.ForeColor = System.Drawing.Color.Black;
            this.txtCo_naviera.Location = new System.Drawing.Point(98, 58);
            this.txtCo_naviera.Name = "txtCo_naviera";
            this.txtCo_naviera.Size = new System.Drawing.Size(65, 20);
            this.txtCo_naviera.TabIndex = 0;
            this.superValidator1.SetValidator1(this.txtCo_naviera, this.requiredFieldValidator1);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 55);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(80, 23);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Codigo:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 81);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(80, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Descripción:";
            // 
            // txtNavi_des
            // 
            this.txtNavi_des.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNavi_des.Border.Class = "TextBoxBorder";
            this.txtNavi_des.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNavi_des.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNavi_des.DisabledBackColor = System.Drawing.Color.White;
            this.txtNavi_des.ForeColor = System.Drawing.Color.Black;
            this.txtNavi_des.Location = new System.Drawing.Point(98, 84);
            this.txtNavi_des.Name = "txtNavi_des";
            this.txtNavi_des.Size = new System.Drawing.Size(198, 20);
            this.txtNavi_des.TabIndex = 1;
            this.superValidator1.SetValidator1(this.txtNavi_des, this.requiredFieldValidator2);
            // 
            // txtEmp_des
            // 
            this.txtEmp_des.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmp_des.Border.Class = "TextBoxBorder";
            this.txtEmp_des.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmp_des.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmp_des.DisabledBackColor = System.Drawing.Color.White;
            this.txtEmp_des.Enabled = false;
            this.txtEmp_des.ForeColor = System.Drawing.Color.Black;
            this.txtEmp_des.Location = new System.Drawing.Point(169, 110);
            this.txtEmp_des.Name = "txtEmp_des";
            this.txtEmp_des.Size = new System.Drawing.Size(275, 20);
            this.txtEmp_des.TabIndex = 3;
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
            this.txtEmpresa.Location = new System.Drawing.Point(98, 110);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(65, 20);
            this.txtEmpresa.TabIndex = 2;
            this.superValidator1.SetValidator1(this.txtEmpresa, this.requiredFieldValidator3);
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
            this.labelX3.Location = new System.Drawing.Point(12, 107);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(80, 23);
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "Empresa:";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "Falta el representante nacional. ";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Falta el codigo de la naviera.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Falta el nombre de la naviera.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Falta la empresa a relacionar.";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2013;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // FrmNaviera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 164);
            this.Controls.Add(this.txtEmp_des);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtNavi_des);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtCo_naviera);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtProv_des);
            this.Controls.Add(this.txtCo_prov);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmNaviera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naviera";
            this.Load += new System.EventHandler(this.FrmNaviera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnPrimero;
        private DevComponents.DotNetBar.ButtonItem btnAnterior;
        private DevComponents.DotNetBar.ButtonItem btnSiguiente;
        private DevComponents.DotNetBar.ButtonItem btnUltimo;
        private DevComponents.DotNetBar.ButtonItem btnBuscar;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private DevComponents.DotNetBar.ButtonItem btnEliminar;
        private DevComponents.DotNetBar.ButtonItem btnDeshacer;
        public DevComponents.DotNetBar.Controls.TextBoxX txtProv_des;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCo_prov;
        private DevComponents.DotNetBar.LabelX labelX4;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCo_naviera;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.DotNetBar.Controls.TextBoxX txtNavi_des;
        public DevComponents.DotNetBar.Controls.TextBoxX txtEmp_des;
        public DevComponents.DotNetBar.Controls.TextBoxX txtEmpresa;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}