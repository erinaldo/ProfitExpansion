namespace ProfitContenedor
{
    partial class FrmEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmp));
            this.txtDes_emp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtCo_empresa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
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
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Falta el nombre de la empresa.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.regularExpressionValidator1 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtClave = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtServidor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtPuerto = new DevComponents.Editors.IntegerInput();
            this.OptSSL = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuerto)).BeginInit();
            this.SuspendLayout();
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
            this.txtDes_emp.ForeColor = System.Drawing.Color.Black;
            this.txtDes_emp.Location = new System.Drawing.Point(98, 91);
            this.txtDes_emp.Name = "txtDes_emp";
            this.txtDes_emp.Size = new System.Drawing.Size(286, 20);
            this.txtDes_emp.TabIndex = 1;
            this.superValidator1.SetValidator1(this.txtDes_emp, this.requiredFieldValidator2);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 88);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(80, 23);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "Descripción:";
            // 
            // txtCo_empresa
            // 
            this.txtCo_empresa.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCo_empresa.Border.Class = "TextBoxBorder";
            this.txtCo_empresa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCo_empresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCo_empresa.ForeColor = System.Drawing.Color.Black;
            this.txtCo_empresa.Location = new System.Drawing.Point(98, 65);
            this.txtCo_empresa.Name = "txtCo_empresa";
            this.txtCo_empresa.Size = new System.Drawing.Size(65, 20);
            this.txtCo_empresa.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 62);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(80, 23);
            this.labelX1.TabIndex = 13;
            this.labelX1.Text = "Codigo:";
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
            this.bar1.Size = new System.Drawing.Size(584, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 11;
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
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(325, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(164, 23);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.WatermarkText = "Buscar empresa...";
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
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Falta el nombre de la empresa.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(98, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 20);
            this.txtEmail.TabIndex = 5;
            this.superValidator1.SetValidator1(this.txtEmail, this.regularExpressionValidator1);
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.ErrorMessage = "Ingrese una direccion de email valida.";
            this.regularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator1.ValidationExpression = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9" +
    "})$";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(12, 167);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(80, 23);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "Email:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(12, 196);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(80, 23);
            this.labelX4.TabIndex = 12;
            this.labelX4.Text = "Clave:";
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtClave.Border.Class = "TextBoxBorder";
            this.txtClave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtClave.ForeColor = System.Drawing.Color.Black;
            this.txtClave.Location = new System.Drawing.Point(98, 196);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 6;
            // 
            // txtServidor
            // 
            this.txtServidor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtServidor.Border.Class = "TextBoxBorder";
            this.txtServidor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtServidor.ForeColor = System.Drawing.Color.Black;
            this.txtServidor.Location = new System.Drawing.Point(98, 117);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(214, 20);
            this.txtServidor.TabIndex = 2;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(12, 114);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(80, 23);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "Servidor:";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(12, 141);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(80, 23);
            this.labelX6.TabIndex = 12;
            this.labelX6.Text = "Puerto:";
            // 
            // txtPuerto
            // 
            this.txtPuerto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPuerto.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPuerto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPuerto.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtPuerto.ForeColor = System.Drawing.Color.Black;
            this.txtPuerto.Location = new System.Drawing.Point(98, 144);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(65, 20);
            this.txtPuerto.TabIndex = 3;
            // 
            // OptSSL
            // 
            this.OptSSL.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.OptSSL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.OptSSL.ForeColor = System.Drawing.Color.Black;
            this.OptSSL.Location = new System.Drawing.Point(169, 144);
            this.OptSSL.Name = "OptSSL";
            this.OptSSL.Size = new System.Drawing.Size(143, 20);
            this.OptSSL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.OptSSL.TabIndex = 4;
            this.OptSSL.Text = "Requiere SSL";
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // FrmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 232);
            this.Controls.Add(this.OptSSL);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.txtDes_emp);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCo_empresa);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.FrmEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuerto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Controls.TextBoxX txtDes_emp;
        private DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCo_empresa;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnPrimero;
        private DevComponents.DotNetBar.ButtonItem btnAnterior;
        private DevComponents.DotNetBar.ButtonItem btnSiguiente;
        private DevComponents.DotNetBar.ButtonItem btnUltimo;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private DevComponents.DotNetBar.ButtonItem btnEliminar;
        private DevComponents.DotNetBar.ButtonItem btnDeshacer;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        public DevComponents.DotNetBar.Controls.TextBoxX txtClave;
        public DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator1;
        private DevComponents.DotNetBar.Controls.CheckBoxX OptSSL;
        private DevComponents.Editors.IntegerInput txtPuerto;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        public DevComponents.DotNetBar.Controls.TextBoxX txtServidor;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        public DevComponents.DotNetBar.Controls.TextBoxX txtBuscar;
    }
}