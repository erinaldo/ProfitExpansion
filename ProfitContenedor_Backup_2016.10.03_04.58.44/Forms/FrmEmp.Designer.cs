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
            this.txtAlma = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtAlm_des = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtDes_tran = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCo_tran = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtSucursal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCo_sucu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtNomina = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.txtContab = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txtFpDescrip = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFpago = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtMoneda = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCo_moneda = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.txtDes_emp.DisabledBackColor = System.Drawing.Color.White;
            this.txtDes_emp.ForeColor = System.Drawing.Color.Black;
            this.txtDes_emp.Location = new System.Drawing.Point(98, 91);
            this.txtDes_emp.Name = "txtDes_emp";
            this.txtDes_emp.Size = new System.Drawing.Size(399, 20);
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
            this.labelX2.Size = new System.Drawing.Size(78, 23);
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
            this.txtCo_empresa.DisabledBackColor = System.Drawing.Color.White;
            this.txtCo_empresa.ForeColor = System.Drawing.Color.Black;
            this.txtCo_empresa.Location = new System.Drawing.Point(98, 65);
            this.txtCo_empresa.Name = "txtCo_empresa";
            this.txtCo_empresa.Size = new System.Drawing.Size(88, 20);
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
            this.labelX1.Size = new System.Drawing.Size(78, 23);
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
            this.bar1.Size = new System.Drawing.Size(502, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 11;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBuscar.Border.Class = "TextBoxBorder";
            this.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.DisabledBackColor = System.Drawing.Color.White;
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(325, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(172, 23);
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
            this.txtEmail.DisabledBackColor = System.Drawing.Color.White;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(98, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(399, 20);
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
            this.labelX3.Size = new System.Drawing.Size(78, 23);
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
            this.labelX4.Size = new System.Drawing.Size(78, 23);
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
            this.txtClave.DisabledBackColor = System.Drawing.Color.White;
            this.txtClave.ForeColor = System.Drawing.Color.Black;
            this.txtClave.Location = new System.Drawing.Point(98, 196);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(88, 20);
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
            this.txtServidor.DisabledBackColor = System.Drawing.Color.White;
            this.txtServidor.ForeColor = System.Drawing.Color.Black;
            this.txtServidor.Location = new System.Drawing.Point(98, 117);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(399, 20);
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
            this.labelX5.Size = new System.Drawing.Size(78, 23);
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
            this.labelX6.Size = new System.Drawing.Size(78, 23);
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
            this.txtPuerto.Size = new System.Drawing.Size(88, 20);
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
            this.OptSSL.Location = new System.Drawing.Point(192, 144);
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
            // txtAlma
            // 
            this.txtAlma.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAlma.Border.Class = "TextBoxBorder";
            this.txtAlma.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAlma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAlma.DisabledBackColor = System.Drawing.Color.White;
            this.txtAlma.ForeColor = System.Drawing.Color.Black;
            this.txtAlma.Location = new System.Drawing.Point(98, 222);
            this.txtAlma.Name = "txtAlma";
            this.txtAlma.Size = new System.Drawing.Size(88, 20);
            this.txtAlma.TabIndex = 7;
            this.txtAlma.Leave += new System.EventHandler(this.txtAlma_Leave);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(12, 219);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(78, 23);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "Almacen:";
            // 
            // txtAlm_des
            // 
            this.txtAlm_des.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAlm_des.Border.Class = "TextBoxBorder";
            this.txtAlm_des.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAlm_des.DisabledBackColor = System.Drawing.Color.White;
            this.txtAlm_des.Enabled = false;
            this.txtAlm_des.ForeColor = System.Drawing.Color.Black;
            this.txtAlm_des.Location = new System.Drawing.Point(192, 222);
            this.txtAlm_des.Name = "txtAlm_des";
            this.txtAlm_des.ReadOnly = true;
            this.txtAlm_des.Size = new System.Drawing.Size(305, 20);
            this.txtAlm_des.TabIndex = 8;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(12, 297);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(78, 23);
            this.labelX8.TabIndex = 16;
            this.labelX8.Text = "Transporte:";
            // 
            // txtDes_tran
            // 
            this.txtDes_tran.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDes_tran.Border.Class = "TextBoxBorder";
            this.txtDes_tran.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDes_tran.DisabledBackColor = System.Drawing.Color.White;
            this.txtDes_tran.Enabled = false;
            this.txtDes_tran.ForeColor = System.Drawing.Color.Black;
            this.txtDes_tran.Location = new System.Drawing.Point(192, 300);
            this.txtDes_tran.Name = "txtDes_tran";
            this.txtDes_tran.ReadOnly = true;
            this.txtDes_tran.Size = new System.Drawing.Size(305, 20);
            this.txtDes_tran.TabIndex = 14;
            // 
            // txtCo_tran
            // 
            this.txtCo_tran.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCo_tran.Border.Class = "TextBoxBorder";
            this.txtCo_tran.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCo_tran.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCo_tran.DisabledBackColor = System.Drawing.Color.White;
            this.txtCo_tran.ForeColor = System.Drawing.Color.Black;
            this.txtCo_tran.Location = new System.Drawing.Point(98, 300);
            this.txtCo_tran.Name = "txtCo_tran";
            this.txtCo_tran.Size = new System.Drawing.Size(88, 20);
            this.txtCo_tran.TabIndex = 13;
            this.txtCo_tran.Leave += new System.EventHandler(this.txtCo_tran_Leave);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(12, 323);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(78, 23);
            this.labelX9.TabIndex = 19;
            this.labelX9.Text = "Sucursal:";
            // 
            // txtSucursal
            // 
            this.txtSucursal.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSucursal.Border.Class = "TextBoxBorder";
            this.txtSucursal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSucursal.DisabledBackColor = System.Drawing.Color.White;
            this.txtSucursal.Enabled = false;
            this.txtSucursal.ForeColor = System.Drawing.Color.Black;
            this.txtSucursal.Location = new System.Drawing.Point(192, 326);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.ReadOnly = true;
            this.txtSucursal.Size = new System.Drawing.Size(305, 20);
            this.txtSucursal.TabIndex = 16;
            // 
            // txtCo_sucu
            // 
            this.txtCo_sucu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCo_sucu.Border.Class = "TextBoxBorder";
            this.txtCo_sucu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCo_sucu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCo_sucu.DisabledBackColor = System.Drawing.Color.White;
            this.txtCo_sucu.ForeColor = System.Drawing.Color.Black;
            this.txtCo_sucu.Location = new System.Drawing.Point(98, 326);
            this.txtCo_sucu.Name = "txtCo_sucu";
            this.txtCo_sucu.Size = new System.Drawing.Size(88, 20);
            this.txtCo_sucu.TabIndex = 15;
            this.txtCo_sucu.Leave += new System.EventHandler(this.txtCo_sucu_Leave);
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(12, 349);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(78, 23);
            this.labelX10.TabIndex = 22;
            this.labelX10.Text = "Nómina:";
            // 
            // txtNomina
            // 
            this.txtNomina.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNomina.Border.Class = "TextBoxBorder";
            this.txtNomina.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNomina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomina.DisabledBackColor = System.Drawing.Color.White;
            this.txtNomina.ForeColor = System.Drawing.Color.Black;
            this.txtNomina.Location = new System.Drawing.Point(98, 352);
            this.txtNomina.Name = "txtNomina";
            this.txtNomina.Size = new System.Drawing.Size(88, 20);
            this.txtNomina.TabIndex = 17;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.ForeColor = System.Drawing.Color.Black;
            this.labelX11.Location = new System.Drawing.Point(12, 375);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(78, 23);
            this.labelX11.TabIndex = 25;
            this.labelX11.Text = "Contabilidad:";
            // 
            // txtContab
            // 
            this.txtContab.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContab.Border.Class = "TextBoxBorder";
            this.txtContab.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContab.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContab.DisabledBackColor = System.Drawing.Color.White;
            this.txtContab.ForeColor = System.Drawing.Color.Black;
            this.txtContab.Location = new System.Drawing.Point(98, 378);
            this.txtContab.Name = "txtContab";
            this.txtContab.Size = new System.Drawing.Size(88, 20);
            this.txtContab.TabIndex = 18;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.ForeColor = System.Drawing.Color.Black;
            this.labelX12.Location = new System.Drawing.Point(12, 271);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(78, 23);
            this.labelX12.TabIndex = 28;
            this.labelX12.Text = "Forma de pago:";
            // 
            // txtFpDescrip
            // 
            this.txtFpDescrip.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFpDescrip.Border.Class = "TextBoxBorder";
            this.txtFpDescrip.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFpDescrip.DisabledBackColor = System.Drawing.Color.White;
            this.txtFpDescrip.Enabled = false;
            this.txtFpDescrip.ForeColor = System.Drawing.Color.Black;
            this.txtFpDescrip.Location = new System.Drawing.Point(192, 274);
            this.txtFpDescrip.Name = "txtFpDescrip";
            this.txtFpDescrip.ReadOnly = true;
            this.txtFpDescrip.Size = new System.Drawing.Size(305, 20);
            this.txtFpDescrip.TabIndex = 12;
            // 
            // txtFpago
            // 
            this.txtFpago.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFpago.Border.Class = "TextBoxBorder";
            this.txtFpago.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFpago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFpago.DisabledBackColor = System.Drawing.Color.White;
            this.txtFpago.ForeColor = System.Drawing.Color.Black;
            this.txtFpago.Location = new System.Drawing.Point(98, 274);
            this.txtFpago.Name = "txtFpago";
            this.txtFpago.Size = new System.Drawing.Size(88, 20);
            this.txtFpago.TabIndex = 11;
            this.txtFpago.Leave += new System.EventHandler(this.txtFpago_Leave);
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.ForeColor = System.Drawing.Color.Black;
            this.labelX13.Location = new System.Drawing.Point(12, 245);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(78, 23);
            this.labelX13.TabIndex = 31;
            this.labelX13.Text = "Moneda:";
            // 
            // txtMoneda
            // 
            this.txtMoneda.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMoneda.Border.Class = "TextBoxBorder";
            this.txtMoneda.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMoneda.DisabledBackColor = System.Drawing.Color.White;
            this.txtMoneda.Enabled = false;
            this.txtMoneda.ForeColor = System.Drawing.Color.Black;
            this.txtMoneda.Location = new System.Drawing.Point(192, 248);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.ReadOnly = true;
            this.txtMoneda.Size = new System.Drawing.Size(305, 20);
            this.txtMoneda.TabIndex = 10;
            // 
            // txtCo_moneda
            // 
            this.txtCo_moneda.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCo_moneda.Border.Class = "TextBoxBorder";
            this.txtCo_moneda.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCo_moneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCo_moneda.DisabledBackColor = System.Drawing.Color.White;
            this.txtCo_moneda.ForeColor = System.Drawing.Color.Black;
            this.txtCo_moneda.Location = new System.Drawing.Point(98, 248);
            this.txtCo_moneda.Name = "txtCo_moneda";
            this.txtCo_moneda.Size = new System.Drawing.Size(88, 20);
            this.txtCo_moneda.TabIndex = 9;
            this.txtCo_moneda.Leave += new System.EventHandler(this.txtCo_moneda_Leave);
            // 
            // FrmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 398);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.txtCo_moneda);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.txtFpDescrip);
            this.Controls.Add(this.txtFpago);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.txtContab);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.txtNomina);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.txtCo_sucu);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtDes_tran);
            this.Controls.Add(this.txtCo_tran);
            this.Controls.Add(this.OptSSL);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.txtDes_emp);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtAlm_des);
            this.Controls.Add(this.txtAlma);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCo_empresa);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEmp";
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
        private DevComponents.DotNetBar.LabelX labelX7;
        public DevComponents.DotNetBar.Controls.TextBoxX txtAlm_des;
        public DevComponents.DotNetBar.Controls.TextBoxX txtAlma;
        private DevComponents.DotNetBar.LabelX labelX11;
        public DevComponents.DotNetBar.Controls.TextBoxX txtContab;
        private DevComponents.DotNetBar.LabelX labelX10;
        public DevComponents.DotNetBar.Controls.TextBoxX txtNomina;
        private DevComponents.DotNetBar.LabelX labelX9;
        public DevComponents.DotNetBar.Controls.TextBoxX txtSucursal;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCo_sucu;
        private DevComponents.DotNetBar.LabelX labelX8;
        public DevComponents.DotNetBar.Controls.TextBoxX txtDes_tran;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCo_tran;
        private DevComponents.DotNetBar.LabelX labelX12;
        public DevComponents.DotNetBar.Controls.TextBoxX txtFpDescrip;
        public DevComponents.DotNetBar.Controls.TextBoxX txtFpago;
        private DevComponents.DotNetBar.LabelX labelX13;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMoneda;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCo_moneda;
    }
}