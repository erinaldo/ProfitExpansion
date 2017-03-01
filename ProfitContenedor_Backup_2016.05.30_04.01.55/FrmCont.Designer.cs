namespace ProfitContenedor
{
    partial class FrmCont
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCont));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Bar = new DevComponents.DotNetBar.Bar();
            this.btnPrimero = new DevComponents.DotNetBar.ButtonItem();
            this.btnAnterior = new DevComponents.DotNetBar.ButtonItem();
            this.btnSiguiente = new DevComponents.DotNetBar.ButtonItem();
            this.btnUltimo = new DevComponents.DotNetBar.ButtonItem();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonItem();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonItem();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonItem();
            this.btnDeshacer = new DevComponents.DotNetBar.ButtonItem();
            this.btnImprimir = new DevComponents.DotNetBar.ButtonItem();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.bar2 = new DevComponents.DotNetBar.Bar();
            this.btnImportar = new DevComponents.DotNetBar.ButtonItem();
            this.btnQuitar = new DevComponents.DotNetBar.ButtonItem();
            this.grdDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fact_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.art_des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtViaje = new DevComponents.Editors.IntegerInput();
            this.txtBL = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCo_consig = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDes_consig = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPto_Origen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPto_destino = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFec_sal = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtFec_lleg = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Ingrese el codigo del consignatario.");
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Ingrese el Puerto Origen");
            this.requiredFieldValidator6 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Ingrese el Puerto Destino.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.txtCo_naviera = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Ingrese la naviera.");
            this.txtCo_shipper = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Ingrese el shipper.");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Ingrese numero de contenedor.");
            this.btnEdoCta = new DevComponents.DotNetBar.ButtonX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtNavi_des = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.txtShipper_des = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtC20p = new DevComponents.Editors.IntegerInput();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txtC40p = new DevComponents.Editors.IntegerInput();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFec_sal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFec_lleg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC20p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC40p)).BeginInit();
            this.SuspendLayout();
            // 
            // Bar
            // 
            this.Bar.AntiAlias = true;
            this.Bar.BackColor = System.Drawing.Color.White;
            this.Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Bar.ForeColor = System.Drawing.Color.Black;
            this.Bar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPrimero,
            this.btnAnterior,
            this.btnSiguiente,
            this.btnUltimo,
            this.btnBuscar,
            this.btnNuevo,
            this.btnGuardar,
            this.btnEliminar,
            this.btnDeshacer,
            this.btnImprimir});
            this.Bar.Location = new System.Drawing.Point(0, 0);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(1209, 41);
            this.Bar.Stretch = true;
            this.Bar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Bar.TabIndex = 0;
            this.Bar.TabStop = false;
            this.Bar.Text = "bar1";
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
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Text = "btnDeshacer";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.bar2);
            this.expandablePanel1.Controls.Add(this.grdDatos);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.expandablePanel1.ExpandButtonVisible = false;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 364);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(1209, 271);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 11;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Detalle";
            // 
            // bar2
            // 
            this.bar2.AntiAlias = true;
            this.bar2.BackColor = System.Drawing.Color.White;
            this.bar2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bar2.DockOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.bar2.DockSide = DevComponents.DotNetBar.eDockSide.Bottom;
            this.bar2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar2.ForeColor = System.Drawing.Color.Black;
            this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnImportar,
            this.btnQuitar});
            this.bar2.Location = new System.Drawing.Point(1165, 26);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(44, 245);
            this.bar2.Stretch = true;
            this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar2.TabIndex = 2;
            this.bar2.TabStop = false;
            this.bar2.Text = "bar2";
            // 
            // btnImportar
            // 
            this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Text = "buttonItem10";
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Text = "buttonItem11";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empresa,
            this.fact_num,
            this.co_art,
            this.art_des,
            this.total_art,
            this.rowguid});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatos.Location = new System.Drawing.Point(0, 26);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(1159, 242);
            this.grdDatos.TabIndex = 0;
            // 
            // empresa
            // 
            this.empresa.DataPropertyName = "empresa";
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            this.empresa.Width = 70;
            // 
            // fact_num
            // 
            this.fact_num.DataPropertyName = "fact_num";
            this.fact_num.HeaderText = "Orden";
            this.fact_num.Name = "fact_num";
            this.fact_num.ReadOnly = true;
            this.fact_num.Width = 80;
            // 
            // co_art
            // 
            this.co_art.DataPropertyName = "co_art";
            this.co_art.HeaderText = "Codigo";
            this.co_art.Name = "co_art";
            this.co_art.ReadOnly = true;
            this.co_art.Width = 120;
            // 
            // art_des
            // 
            this.art_des.DataPropertyName = "art_des";
            this.art_des.HeaderText = "Descripción";
            this.art_des.Name = "art_des";
            this.art_des.ReadOnly = true;
            this.art_des.Width = 450;
            // 
            // total_art
            // 
            this.total_art.DataPropertyName = "total_art";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.total_art.DefaultCellStyle = dataGridViewCellStyle2;
            this.total_art.HeaderText = "Cantidad";
            this.total_art.Name = "total_art";
            this.total_art.ReadOnly = true;
            this.total_art.Width = 70;
            // 
            // rowguid
            // 
            this.rowguid.DataPropertyName = "rowguid";
            this.rowguid.HeaderText = "rowguid";
            this.rowguid.Name = "rowguid";
            this.rowguid.ReadOnly = true;
            this.rowguid.Visible = false;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 47);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Viaje:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(12, 70);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "BL:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(12, 148);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Consignatario:";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(12, 226);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 2;
            this.labelX5.Text = "Puerto Origen:";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(12, 252);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 2;
            this.labelX6.Text = "Fecha Salida:";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(12, 279);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(87, 23);
            this.labelX7.TabIndex = 2;
            this.labelX7.Text = "Puerto Destino:";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(12, 305);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(87, 23);
            this.labelX8.TabIndex = 2;
            this.labelX8.Text = "Fecha Llegada:";
            // 
            // txtViaje
            // 
            this.txtViaje.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtViaje.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtViaje.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtViaje.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtViaje.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtViaje.Enabled = false;
            this.txtViaje.ForeColor = System.Drawing.Color.Black;
            this.txtViaje.Location = new System.Drawing.Point(93, 47);
            this.txtViaje.Name = "txtViaje";
            this.txtViaje.Size = new System.Drawing.Size(52, 20);
            this.txtViaje.TabIndex = 0;
            // 
            // txtBL
            // 
            this.txtBL.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBL.Border.Class = "TextBoxBorder";
            this.txtBL.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBL.ForeColor = System.Drawing.Color.Black;
            this.txtBL.Location = new System.Drawing.Point(93, 73);
            this.txtBL.Name = "txtBL";
            this.txtBL.Size = new System.Drawing.Size(93, 20);
            this.txtBL.TabIndex = 1;
            // 
            // txtCo_consig
            // 
            this.txtCo_consig.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCo_consig.Border.Class = "TextBoxBorder";
            this.txtCo_consig.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCo_consig.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCo_consig.ForeColor = System.Drawing.Color.Black;
            this.txtCo_consig.Location = new System.Drawing.Point(93, 151);
            this.txtCo_consig.Name = "txtCo_consig";
            this.txtCo_consig.Size = new System.Drawing.Size(93, 20);
            this.txtCo_consig.TabIndex = 4;
            this.superValidator1.SetValidator1(this.txtCo_consig, this.requiredFieldValidator2);
            this.txtCo_consig.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCo_consig_KeyDown);
            this.txtCo_consig.Leave += new System.EventHandler(this.txtCo_consig_Leave);
            // 
            // txtDes_consig
            // 
            this.txtDes_consig.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDes_consig.Border.Class = "TextBoxBorder";
            this.txtDes_consig.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDes_consig.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDes_consig.Enabled = false;
            this.txtDes_consig.ForeColor = System.Drawing.Color.Black;
            this.txtDes_consig.Location = new System.Drawing.Point(192, 151);
            this.txtDes_consig.Name = "txtDes_consig";
            this.txtDes_consig.Size = new System.Drawing.Size(247, 20);
            this.txtDes_consig.TabIndex = 5;
            // 
            // txtPto_Origen
            // 
            this.txtPto_Origen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPto_Origen.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPto_Origen.Border.Class = "TextBoxBorder";
            this.txtPto_Origen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPto_Origen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPto_Origen.ForeColor = System.Drawing.Color.Black;
            this.txtPto_Origen.Location = new System.Drawing.Point(93, 229);
            this.txtPto_Origen.Name = "txtPto_Origen";
            this.txtPto_Origen.Size = new System.Drawing.Size(144, 20);
            this.txtPto_Origen.TabIndex = 10;
            this.superValidator1.SetValidator1(this.txtPto_Origen, this.requiredFieldValidator5);
            // 
            // txtPto_destino
            // 
            this.txtPto_destino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPto_destino.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPto_destino.Border.Class = "TextBoxBorder";
            this.txtPto_destino.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPto_destino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPto_destino.ForeColor = System.Drawing.Color.Black;
            this.txtPto_destino.Location = new System.Drawing.Point(93, 282);
            this.txtPto_destino.Name = "txtPto_destino";
            this.txtPto_destino.Size = new System.Drawing.Size(144, 20);
            this.txtPto_destino.TabIndex = 12;
            this.superValidator1.SetValidator1(this.txtPto_destino, this.requiredFieldValidator6);
            // 
            // txtFec_sal
            // 
            this.txtFec_sal.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFec_sal.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtFec_sal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFec_sal.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtFec_sal.ButtonDropDown.Visible = true;
            this.txtFec_sal.ForeColor = System.Drawing.Color.Black;
            this.txtFec_sal.IsPopupCalendarOpen = false;
            this.txtFec_sal.Location = new System.Drawing.Point(93, 255);
            // 
            // 
            // 
            this.txtFec_sal.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtFec_sal.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtFec_sal.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFec_sal.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtFec_sal.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtFec_sal.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtFec_sal.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtFec_sal.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtFec_sal.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtFec_sal.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtFec_sal.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFec_sal.MonthCalendar.DisplayMonth = new System.DateTime(2013, 7, 1, 0, 0, 0, 0);
            this.txtFec_sal.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtFec_sal.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtFec_sal.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtFec_sal.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtFec_sal.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtFec_sal.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFec_sal.MonthCalendar.TodayButtonVisible = true;
            this.txtFec_sal.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtFec_sal.Name = "txtFec_sal";
            this.txtFec_sal.Size = new System.Drawing.Size(144, 20);
            this.txtFec_sal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtFec_sal.TabIndex = 11;
            this.txtFec_sal.Leave += new System.EventHandler(this.txtFec_sal_Leave);
            // 
            // txtFec_lleg
            // 
            this.txtFec_lleg.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFec_lleg.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtFec_lleg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFec_lleg.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtFec_lleg.ButtonDropDown.Visible = true;
            this.txtFec_lleg.ForeColor = System.Drawing.Color.Black;
            this.txtFec_lleg.IsPopupCalendarOpen = false;
            this.txtFec_lleg.Location = new System.Drawing.Point(93, 308);
            // 
            // 
            // 
            this.txtFec_lleg.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtFec_lleg.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtFec_lleg.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFec_lleg.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtFec_lleg.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtFec_lleg.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtFec_lleg.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtFec_lleg.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtFec_lleg.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtFec_lleg.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtFec_lleg.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFec_lleg.MonthCalendar.DisplayMonth = new System.DateTime(2013, 7, 1, 0, 0, 0, 0);
            this.txtFec_lleg.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtFec_lleg.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtFec_lleg.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtFec_lleg.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtFec_lleg.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtFec_lleg.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFec_lleg.MonthCalendar.TodayButtonVisible = true;
            this.txtFec_lleg.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtFec_lleg.Name = "txtFec_lleg";
            this.txtFec_lleg.Size = new System.Drawing.Size(144, 20);
            this.txtFec_lleg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtFec_lleg.TabIndex = 13;
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Ingrese el codigo del consignatario.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.ErrorMessage = "Ingrese el Puerto Origen";
            this.requiredFieldValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator6
            // 
            this.requiredFieldValidator6.ErrorMessage = "Ingrese el Puerto Destino.";
            this.requiredFieldValidator6.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // txtCo_naviera
            // 
            this.txtCo_naviera.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCo_naviera.Border.Class = "TextBoxBorder";
            this.txtCo_naviera.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCo_naviera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCo_naviera.ForeColor = System.Drawing.Color.Black;
            this.txtCo_naviera.Location = new System.Drawing.Point(93, 177);
            this.txtCo_naviera.Name = "txtCo_naviera";
            this.txtCo_naviera.Size = new System.Drawing.Size(93, 20);
            this.txtCo_naviera.TabIndex = 6;
            this.superValidator1.SetValidator1(this.txtCo_naviera, this.requiredFieldValidator3);
            this.txtCo_naviera.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCo_naviera_KeyDown);
            this.txtCo_naviera.Leave += new System.EventHandler(this.txtCo_naviera_Leave);
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Ingrese la naviera.";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // txtCo_shipper
            // 
            this.txtCo_shipper.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCo_shipper.Border.Class = "TextBoxBorder";
            this.txtCo_shipper.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCo_shipper.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCo_shipper.ForeColor = System.Drawing.Color.Black;
            this.txtCo_shipper.Location = new System.Drawing.Point(93, 203);
            this.txtCo_shipper.Name = "txtCo_shipper";
            this.txtCo_shipper.Size = new System.Drawing.Size(93, 20);
            this.txtCo_shipper.TabIndex = 8;
            this.superValidator1.SetValidator1(this.txtCo_shipper, this.requiredFieldValidator4);
            this.txtCo_shipper.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCo_shipper_KeyDown);
            this.txtCo_shipper.Leave += new System.EventHandler(this.txtCo_shipper_Leave);
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "Ingrese el shipper.";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Ingrese numero de contenedor.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // btnEdoCta
            // 
            this.btnEdoCta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdoCta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdoCta.Location = new System.Drawing.Point(340, 308);
            this.btnEdoCta.Name = "btnEdoCta";
            this.btnEdoCta.Size = new System.Drawing.Size(99, 20);
            this.btnEdoCta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdoCta.TabIndex = 15;
            this.btnEdoCta.Text = "&Ver Edo Cta.";
            this.btnEdoCta.Click += new System.EventHandler(this.btnEdoCta_Click);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(243, 307);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(91, 20);
            this.labelX9.TabIndex = 14;
            this.labelX9.Text = "[ ]dias restantes";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(12, 174);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 2;
            this.labelX10.Text = "Naviera:";
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
            this.txtNavi_des.Enabled = false;
            this.txtNavi_des.ForeColor = System.Drawing.Color.Black;
            this.txtNavi_des.Location = new System.Drawing.Point(192, 177);
            this.txtNavi_des.Name = "txtNavi_des";
            this.txtNavi_des.Size = new System.Drawing.Size(247, 20);
            this.txtNavi_des.TabIndex = 7;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.ForeColor = System.Drawing.Color.Black;
            this.labelX11.Location = new System.Drawing.Point(12, 200);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(75, 23);
            this.labelX11.TabIndex = 2;
            this.labelX11.Text = "Shipper:";
            // 
            // txtShipper_des
            // 
            this.txtShipper_des.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtShipper_des.Border.Class = "TextBoxBorder";
            this.txtShipper_des.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtShipper_des.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtShipper_des.Enabled = false;
            this.txtShipper_des.ForeColor = System.Drawing.Color.Black;
            this.txtShipper_des.Location = new System.Drawing.Point(192, 203);
            this.txtShipper_des.Name = "txtShipper_des";
            this.txtShipper_des.Size = new System.Drawing.Size(247, 20);
            this.txtShipper_des.TabIndex = 9;
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.ForeColor = System.Drawing.Color.Black;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(631, 47);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(267, 318);
            this.reflectionImage1.TabIndex = 16;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 99);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "C. 20 pies:";
            // 
            // txtC20p
            // 
            this.txtC20p.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtC20p.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtC20p.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtC20p.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtC20p.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtC20p.ForeColor = System.Drawing.Color.Black;
            this.txtC20p.Location = new System.Drawing.Point(93, 99);
            this.txtC20p.MinValue = 0;
            this.txtC20p.Name = "txtC20p";
            this.txtC20p.ShowUpDown = true;
            this.txtC20p.Size = new System.Drawing.Size(52, 20);
            this.txtC20p.TabIndex = 2;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.ForeColor = System.Drawing.Color.Black;
            this.labelX12.Location = new System.Drawing.Point(12, 125);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(75, 23);
            this.labelX12.TabIndex = 2;
            this.labelX12.Text = "C. 40 pies:";
            // 
            // txtC40p
            // 
            this.txtC40p.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtC40p.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtC40p.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtC40p.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtC40p.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtC40p.ForeColor = System.Drawing.Color.Black;
            this.txtC40p.Location = new System.Drawing.Point(93, 125);
            this.txtC40p.MinValue = 0;
            this.txtC40p.Name = "txtC40p";
            this.txtC40p.ShowUpDown = true;
            this.txtC40p.Size = new System.Drawing.Size(52, 20);
            this.txtC40p.TabIndex = 3;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // FrmCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 635);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.btnEdoCta);
            this.Controls.Add(this.txtFec_lleg);
            this.Controls.Add(this.txtFec_sal);
            this.Controls.Add(this.txtShipper_des);
            this.Controls.Add(this.txtNavi_des);
            this.Controls.Add(this.txtDes_consig);
            this.Controls.Add(this.txtPto_destino);
            this.Controls.Add(this.txtPto_Origen);
            this.Controls.Add(this.txtCo_shipper);
            this.Controls.Add(this.txtCo_naviera);
            this.Controls.Add(this.txtCo_consig);
            this.Controls.Add(this.txtBL);
            this.Controls.Add(this.txtC40p);
            this.Controls.Add(this.txtC20p);
            this.Controls.Add(this.txtViaje);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.reflectionImage1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCont";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de contenedores - Grupo RG";
            this.Load += new System.EventHandler(this.FrmCont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFec_sal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFec_lleg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC20p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtC40p)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar Bar;
        private DevComponents.DotNetBar.ButtonItem btnPrimero;
        private DevComponents.DotNetBar.ButtonItem btnAnterior;
        private DevComponents.DotNetBar.ButtonItem btnSiguiente;
        private DevComponents.DotNetBar.ButtonItem btnUltimo;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private DevComponents.DotNetBar.ButtonItem btnEliminar;
        private DevComponents.DotNetBar.ButtonItem btnDeshacer;
        private DevComponents.DotNetBar.ButtonItem btnBuscar;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.Bar bar2;
        private DevComponents.DotNetBar.ButtonItem btnImportar;
        private DevComponents.DotNetBar.ButtonItem btnQuitar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBL;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPto_Origen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPto_destino;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtFec_sal;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtFec_lleg;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCo_consig;
        public DevComponents.DotNetBar.Controls.TextBoxX txtDes_consig;
        public DevComponents.Editors.IntegerInput txtViaje;
        public DevComponents.DotNetBar.Controls.DataGridViewX grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fact_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_art;
        private System.Windows.Forms.DataGridViewTextBoxColumn art_des;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_art;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguid;
        private DevComponents.DotNetBar.ButtonX btnEdoCta;
        private DevComponents.DotNetBar.LabelX labelX9;
        public DevComponents.DotNetBar.Controls.TextBoxX txtNavi_des;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCo_naviera;
        private DevComponents.DotNetBar.LabelX labelX10;
        public DevComponents.DotNetBar.Controls.TextBoxX txtShipper_des;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCo_shipper;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator6;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator5;
        public DevComponents.Editors.IntegerInput txtC40p;
        public DevComponents.Editors.IntegerInput txtC20p;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonItem btnImprimir;
    }
}

