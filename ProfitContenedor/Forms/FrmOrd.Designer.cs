namespace ProfitContenedor
{
    partial class FrmOrd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrd));
            this.grdDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Reng_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_art = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.Precio = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.Total_reng = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.Pendiente = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.txtFact_num = new DevComponents.Editors.IntegerInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtFecha = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtEmpresa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmp_des = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtProv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtProv_des = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtObserv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnPrimero = new DevComponents.DotNetBar.ButtonItem();
            this.btnAnterior = new DevComponents.DotNetBar.ButtonItem();
            this.btnSiguiente = new DevComponents.DotNetBar.ButtonItem();
            this.btnUltimo = new DevComponents.DotNetBar.ButtonItem();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonItem();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonItem();
            this.btnDeshacer = new DevComponents.DotNetBar.ButtonItem();
            this.btnAgregarR = new DevComponents.DotNetBar.ButtonItem();
            this.btnQuitar = new DevComponents.DotNetBar.ButtonItem();
            this.txtBuscar = new DevComponents.DotNetBar.TextBoxItem();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.lblStatus = new DevComponents.DotNetBar.LabelX();
            this.txtTotal = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFact_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reng_num,
            this.Codigo,
            this.Descripcion,
            this.Total_art,
            this.Precio,
            this.Total_reng,
            this.Pendiente});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatos.Location = new System.Drawing.Point(12, 227);
            this.grdDatos.Name = "grdDatos";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdDatos.Size = new System.Drawing.Size(915, 263);
            this.grdDatos.TabIndex = 7;
            this.grdDatos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellEndEdit);
            // 
            // Reng_num
            // 
            this.Reng_num.DataPropertyName = "reng_num";
            this.Reng_num.HeaderText = "Renglon";
            this.Reng_num.Name = "Reng_num";
            this.Reng_num.ReadOnly = true;
            this.Reng_num.Width = 60;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "co_art";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "art_des";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 290;
            // 
            // Total_art
            // 
            // 
            // 
            // 
            this.Total_art.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Total_art.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Total_art.ButtonFreeText.Enabled = false;
            this.Total_art.DataPropertyName = "total_art";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.Total_art.DefaultCellStyle = dataGridViewCellStyle3;
            this.Total_art.HeaderText = "Cantidad";
            this.Total_art.Increment = 1D;
            this.Total_art.Name = "Total_art";
            this.Total_art.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Precio
            // 
            // 
            // 
            // 
            this.Precio.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Precio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Precio.DataPropertyName = "precio";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle4;
            this.Precio.HeaderText = "Precio $";
            this.Precio.Increment = 1D;
            this.Precio.Name = "Precio";
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Total_reng
            // 
            // 
            // 
            // 
            this.Total_reng.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Total_reng.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Total_reng.ButtonDropDown.Enabled = false;
            this.Total_reng.DataPropertyName = "reng_neto";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.Total_reng.DefaultCellStyle = dataGridViewCellStyle5;
            this.Total_reng.HeaderText = "Total renglon $";
            this.Total_reng.Increment = 1D;
            this.Total_reng.Name = "Total_reng";
            this.Total_reng.ReadOnly = true;
            this.Total_reng.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Pendiente
            // 
            // 
            // 
            // 
            this.Pendiente.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Pendiente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Pendiente.ButtonDropDown.Enabled = false;
            this.Pendiente.DataPropertyName = "pendiente";
            dataGridViewCellStyle6.Format = "d2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.Pendiente.DefaultCellStyle = dataGridViewCellStyle6;
            this.Pendiente.HeaderText = "Pendiente";
            this.Pendiente.Increment = 1D;
            this.Pendiente.Name = "Pendiente";
            this.Pendiente.ReadOnly = true;
            this.Pendiente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtFact_num
            // 
            this.txtFact_num.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFact_num.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtFact_num.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFact_num.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtFact_num.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFact_num.DisabledForeColor = System.Drawing.Color.Black;
            this.txtFact_num.Enabled = false;
            this.txtFact_num.ForeColor = System.Drawing.Color.Black;
            this.txtFact_num.Location = new System.Drawing.Point(93, 47);
            this.txtFact_num.Name = "txtFact_num";
            this.txtFact_num.Size = new System.Drawing.Size(80, 22);
            this.txtFact_num.TabIndex = 0;
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
            this.labelX1.Text = "Orden:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 76);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Empresa:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(12, 105);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Proveedor:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(12, 134);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Fecha:";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(12, 163);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 2;
            this.labelX5.Text = "Observacion:";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFecha.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtFecha.ButtonDropDown.Visible = true;
            this.txtFecha.ForeColor = System.Drawing.Color.Black;
            this.txtFecha.IsPopupCalendarOpen = false;
            this.txtFecha.Location = new System.Drawing.Point(93, 134);
            // 
            // 
            // 
            this.txtFecha.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtFecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFecha.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtFecha.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtFecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtFecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtFecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtFecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtFecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFecha.MonthCalendar.DisplayMonth = new System.DateTime(2014, 10, 1, 0, 0, 0, 0);
            this.txtFecha.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtFecha.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtFecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtFecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtFecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtFecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFecha.MonthCalendar.TodayButtonVisible = true;
            this.txtFecha.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(164, 22);
            this.txtFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtFecha.TabIndex = 5;
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
            this.txtEmpresa.Location = new System.Drawing.Point(93, 76);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(80, 22);
            this.txtEmpresa.TabIndex = 1;
            this.txtEmpresa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpresa_KeyDown);
            this.txtEmpresa.Leave += new System.EventHandler(this.txtEmpresa_Leave);
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
            this.txtEmp_des.Location = new System.Drawing.Point(179, 76);
            this.txtEmp_des.Name = "txtEmp_des";
            this.txtEmp_des.Size = new System.Drawing.Size(373, 22);
            this.txtEmp_des.TabIndex = 2;
            // 
            // txtProv
            // 
            this.txtProv.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtProv.Border.Class = "TextBoxBorder";
            this.txtProv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProv.DisabledBackColor = System.Drawing.Color.White;
            this.txtProv.ForeColor = System.Drawing.Color.Black;
            this.txtProv.Location = new System.Drawing.Point(93, 104);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(80, 22);
            this.txtProv.TabIndex = 3;
            this.txtProv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProv_KeyDown);
            this.txtProv.Leave += new System.EventHandler(this.txtProv_Leave);
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
            this.txtProv_des.Location = new System.Drawing.Point(179, 104);
            this.txtProv_des.Name = "txtProv_des";
            this.txtProv_des.Size = new System.Drawing.Size(373, 22);
            this.txtProv_des.TabIndex = 4;
            // 
            // txtObserv
            // 
            this.txtObserv.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtObserv.Border.Class = "TextBoxBorder";
            this.txtObserv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtObserv.DisabledBackColor = System.Drawing.Color.White;
            this.txtObserv.ForeColor = System.Drawing.Color.Black;
            this.txtObserv.Location = new System.Drawing.Point(93, 162);
            this.txtObserv.Multiline = true;
            this.txtObserv.Name = "txtObserv";
            this.txtObserv.Size = new System.Drawing.Size(834, 59);
            this.txtObserv.TabIndex = 6;
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
            this.btnNuevo,
            this.btnGuardar,
            this.btnEliminar,
            this.btnDeshacer,
            this.btnAgregarR,
            this.btnQuitar,
            this.txtBuscar});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(939, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 12;
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
            // btnAgregarR
            // 
            this.btnAgregarR.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarR.Image")));
            this.btnAgregarR.Name = "btnAgregarR";
            this.btnAgregarR.Text = "buttonItem10";
            this.btnAgregarR.Click += new System.EventHandler(this.btnAgregarR_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Text = "buttonItem11";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.TextBoxWidth = 150;
            this.txtBuscar.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtBuscar.WatermarkText = "Buscar orden...";
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(725, 496);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(73, 23);
            this.labelX6.TabIndex = 13;
            this.labelX6.Text = "Total $:";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(179, 44);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 24);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTotal.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtTotal.Enabled = false;
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Increment = 1D;
            this.txtTotal.Location = new System.Drawing.Point(804, 496);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(123, 22);
            this.txtTotal.TabIndex = 16;
            // 
            // FrmOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 522);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.txtProv_des);
            this.Controls.Add(this.txtEmp_des);
            this.Controls.Add(this.txtObserv);
            this.Controls.Add(this.txtProv);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtFact_num);
            this.Controls.Add(this.grdDatos);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FrmOrd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de produccion";
            this.Load += new System.EventHandler(this.FrmOrd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFact_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Editors.IntegerInput txtFact_num;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtFecha;
        private DevComponents.DotNetBar.Controls.TextBoxX txtObserv;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnPrimero;
        private DevComponents.DotNetBar.ButtonItem btnAnterior;
        private DevComponents.DotNetBar.ButtonItem btnSiguiente;
        private DevComponents.DotNetBar.ButtonItem btnUltimo;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private DevComponents.DotNetBar.ButtonItem btnEliminar;
        private DevComponents.DotNetBar.ButtonItem btnDeshacer;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonItem btnQuitar;
        private DevComponents.DotNetBar.ButtonItem btnAgregarR;
        private DevComponents.DotNetBar.TextBoxItem txtBuscar;
        private DevComponents.DotNetBar.LabelX lblStatus;
        private DevComponents.Editors.DoubleInput txtTotal;
        public DevComponents.DotNetBar.Controls.DataGridViewX grdDatos;
        public DevComponents.DotNetBar.Controls.TextBoxX txtEmpresa;
        public DevComponents.DotNetBar.Controls.TextBoxX txtEmp_des;
        public DevComponents.DotNetBar.Controls.TextBoxX txtProv;
        public DevComponents.DotNetBar.Controls.TextBoxX txtProv_des;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reng_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Total_art;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Precio;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Total_reng;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Pendiente;
    }
}