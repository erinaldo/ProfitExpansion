namespace ProfitContenedor
{
    partial class FrmActivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActivos));
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
            this.txtCo_activo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_descrip = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_serial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_modelo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_valor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.date_fec_regis = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.date_fec_adqui = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.date_fec_reti = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.cbo_ubic = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.cbo_Cat = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_mtto = new DevComponents.DotNetBar.ButtonX();
            this.btn_movES = new DevComponents.DotNetBar.ButtonX();
            this.btn_casos = new DevComponents.DotNetBar.ButtonX();
            this.bnt_conf_logic = new DevComponents.DotNetBar.ButtonX();
            this.btn_asign12 = new DevComponents.DotNetBar.ButtonX();
            this.labeldolars = new DevComponents.DotNetBar.LabelX();
            this.txt_asigna54 = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_fec_regis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_fec_adqui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_fec_reti)).BeginInit();
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
            this.bar1.Size = new System.Drawing.Size(647, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 13;
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
            this.txtBuscar.Size = new System.Drawing.Size(222, 23);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.WatermarkText = "Buscar Activo...";
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
            // txtCo_activo
            // 
            this.txtCo_activo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCo_activo.Border.Class = "TextBoxBorder";
            this.txtCo_activo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCo_activo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCo_activo.DisabledBackColor = System.Drawing.Color.White;
            this.txtCo_activo.ForeColor = System.Drawing.Color.Black;
            this.txtCo_activo.Location = new System.Drawing.Point(95, 66);
            this.txtCo_activo.Name = "txtCo_activo";
            this.txtCo_activo.Size = new System.Drawing.Size(193, 20);
            this.txtCo_activo.TabIndex = 17;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(20, 65);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(69, 20);
            this.labelX1.TabIndex = 18;
            this.labelX1.Text = "Codigo:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txt_descrip
            // 
            this.txt_descrip.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_descrip.Border.Class = "TextBoxBorder";
            this.txt_descrip.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_descrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descrip.DisabledBackColor = System.Drawing.Color.White;
            this.txt_descrip.ForeColor = System.Drawing.Color.Black;
            this.txt_descrip.Location = new System.Drawing.Point(95, 94);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(193, 20);
            this.txt_descrip.TabIndex = 19;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(20, 96);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(69, 20);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "Descripción:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txt_serial
            // 
            this.txt_serial.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_serial.Border.Class = "TextBoxBorder";
            this.txt_serial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_serial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_serial.DisabledBackColor = System.Drawing.Color.White;
            this.txt_serial.ForeColor = System.Drawing.Color.Black;
            this.txt_serial.Location = new System.Drawing.Point(95, 122);
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.Size = new System.Drawing.Size(193, 20);
            this.txt_serial.TabIndex = 21;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(20, 122);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(69, 20);
            this.labelX3.TabIndex = 22;
            this.labelX3.Text = "Serial:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txt_modelo
            // 
            this.txt_modelo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_modelo.Border.Class = "TextBoxBorder";
            this.txt_modelo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_modelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_modelo.DisabledBackColor = System.Drawing.Color.White;
            this.txt_modelo.ForeColor = System.Drawing.Color.Black;
            this.txt_modelo.Location = new System.Drawing.Point(95, 150);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(193, 20);
            this.txt_modelo.TabIndex = 23;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(20, 150);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(69, 20);
            this.labelX4.TabIndex = 24;
            this.labelX4.Text = "Modelo:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_valor.Border.Class = "TextBoxBorder";
            this.txt_valor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_valor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_valor.DisabledBackColor = System.Drawing.Color.White;
            this.txt_valor.ForeColor = System.Drawing.Color.Black;
            this.txt_valor.Location = new System.Drawing.Point(420, 65);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(182, 20);
            this.txt_valor.TabIndex = 25;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(301, 64);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(115, 20);
            this.labelX5.TabIndex = 26;
            this.labelX5.Text = "Valor:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(301, 90);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(115, 20);
            this.labelX6.TabIndex = 27;
            this.labelX6.Text = "Fecha de Registro:";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // date_fec_regis
            // 
            this.date_fec_regis.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.date_fec_regis.BackgroundStyle.Class = "DateTimeInputBackground";
            this.date_fec_regis.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_fec_regis.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.date_fec_regis.ButtonDropDown.Visible = true;
            this.date_fec_regis.ForeColor = System.Drawing.Color.Black;
            this.date_fec_regis.IsPopupCalendarOpen = false;
            this.date_fec_regis.Location = new System.Drawing.Point(420, 93);
            // 
            // 
            // 
            this.date_fec_regis.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_fec_regis.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_fec_regis.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.date_fec_regis.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.date_fec_regis.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.date_fec_regis.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.date_fec_regis.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.date_fec_regis.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.date_fec_regis.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.date_fec_regis.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.date_fec_regis.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_fec_regis.MonthCalendar.DisplayMonth = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.date_fec_regis.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.date_fec_regis.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_fec_regis.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.date_fec_regis.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.date_fec_regis.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.date_fec_regis.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_fec_regis.MonthCalendar.TodayButtonVisible = true;
            this.date_fec_regis.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.date_fec_regis.Name = "date_fec_regis";
            this.date_fec_regis.Size = new System.Drawing.Size(201, 20);
            this.date_fec_regis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.date_fec_regis.TabIndex = 28;
            // 
            // date_fec_adqui
            // 
            this.date_fec_adqui.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.date_fec_adqui.BackgroundStyle.Class = "DateTimeInputBackground";
            this.date_fec_adqui.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_fec_adqui.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.date_fec_adqui.ButtonDropDown.Visible = true;
            this.date_fec_adqui.ForeColor = System.Drawing.Color.Black;
            this.date_fec_adqui.IsPopupCalendarOpen = false;
            this.date_fec_adqui.Location = new System.Drawing.Point(420, 119);
            // 
            // 
            // 
            this.date_fec_adqui.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_fec_adqui.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_fec_adqui.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.date_fec_adqui.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.date_fec_adqui.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.date_fec_adqui.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.date_fec_adqui.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.date_fec_adqui.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.date_fec_adqui.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.date_fec_adqui.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.date_fec_adqui.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_fec_adqui.MonthCalendar.DisplayMonth = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.date_fec_adqui.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.date_fec_adqui.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_fec_adqui.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.date_fec_adqui.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.date_fec_adqui.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.date_fec_adqui.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_fec_adqui.MonthCalendar.TodayButtonVisible = true;
            this.date_fec_adqui.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.date_fec_adqui.Name = "date_fec_adqui";
            this.date_fec_adqui.Size = new System.Drawing.Size(201, 20);
            this.date_fec_adqui.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.date_fec_adqui.TabIndex = 30;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(301, 120);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(115, 20);
            this.labelX7.TabIndex = 29;
            this.labelX7.Text = "Fecha de Adquisición:";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // date_fec_reti
            // 
            this.date_fec_reti.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.date_fec_reti.BackgroundStyle.Class = "DateTimeInputBackground";
            this.date_fec_reti.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_fec_reti.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.date_fec_reti.ButtonDropDown.Visible = true;
            this.date_fec_reti.ForeColor = System.Drawing.Color.Black;
            this.date_fec_reti.IsPopupCalendarOpen = false;
            this.date_fec_reti.Location = new System.Drawing.Point(420, 149);
            // 
            // 
            // 
            this.date_fec_reti.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_fec_reti.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_fec_reti.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.date_fec_reti.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.date_fec_reti.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.date_fec_reti.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.date_fec_reti.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.date_fec_reti.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.date_fec_reti.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.date_fec_reti.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.date_fec_reti.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_fec_reti.MonthCalendar.DisplayMonth = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.date_fec_reti.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.date_fec_reti.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_fec_reti.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.date_fec_reti.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.date_fec_reti.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.date_fec_reti.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_fec_reti.MonthCalendar.TodayButtonVisible = true;
            this.date_fec_reti.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.date_fec_reti.Name = "date_fec_reti";
            this.date_fec_reti.Size = new System.Drawing.Size(201, 20);
            this.date_fec_reti.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.date_fec_reti.TabIndex = 32;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(301, 148);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(115, 20);
            this.labelX8.TabIndex = 31;
            this.labelX8.Text = "Fecha de Retiro:";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbo_ubic
            // 
            this.cbo_ubic.DisplayMember = "Text";
            this.cbo_ubic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_ubic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ubic.ForeColor = System.Drawing.Color.Black;
            this.cbo_ubic.FormattingEnabled = true;
            this.cbo_ubic.ItemHeight = 14;
            this.cbo_ubic.Location = new System.Drawing.Point(95, 178);
            this.cbo_ubic.Name = "cbo_ubic";
            this.cbo_ubic.Size = new System.Drawing.Size(193, 20);
            this.cbo_ubic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_ubic.TabIndex = 33;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(20, 178);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(69, 20);
            this.labelX9.TabIndex = 34;
            this.labelX9.Text = "Ubicación:";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(347, 177);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(69, 20);
            this.labelX10.TabIndex = 36;
            this.labelX10.Text = "Asignado a:";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.ForeColor = System.Drawing.Color.Black;
            this.labelX11.Location = new System.Drawing.Point(20, 204);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(69, 20);
            this.labelX11.TabIndex = 38;
            this.labelX11.Text = "Catalogo:";
            this.labelX11.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbo_Cat
            // 
            this.cbo_Cat.DisplayMember = "Text";
            this.cbo_Cat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Cat.ForeColor = System.Drawing.Color.Black;
            this.cbo_Cat.FormattingEnabled = true;
            this.cbo_Cat.ItemHeight = 14;
            this.cbo_Cat.Location = new System.Drawing.Point(95, 204);
            this.cbo_Cat.Name = "cbo_Cat";
            this.cbo_Cat.Size = new System.Drawing.Size(193, 20);
            this.cbo_Cat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_Cat.TabIndex = 37;
            // 
            // btn_mtto
            // 
            this.btn_mtto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_mtto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_mtto.Location = new System.Drawing.Point(177, 242);
            this.btn_mtto.Name = "btn_mtto";
            this.btn_mtto.Size = new System.Drawing.Size(140, 23);
            this.btn_mtto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_mtto.TabIndex = 39;
            this.btn_mtto.Text = "Mantenimiento";
            this.btn_mtto.Click += new System.EventHandler(this.btn_mtto_Click);
            // 
            // btn_movES
            // 
            this.btn_movES.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_movES.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_movES.Location = new System.Drawing.Point(15, 242);
            this.btn_movES.Name = "btn_movES";
            this.btn_movES.Size = new System.Drawing.Size(140, 23);
            this.btn_movES.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_movES.TabIndex = 40;
            this.btn_movES.Text = "Movimiento E/S";
            this.btn_movES.Click += new System.EventHandler(this.btn_movES_Click);
            // 
            // btn_casos
            // 
            this.btn_casos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_casos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_casos.Location = new System.Drawing.Point(340, 242);
            this.btn_casos.Name = "btn_casos";
            this.btn_casos.Size = new System.Drawing.Size(140, 23);
            this.btn_casos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_casos.TabIndex = 41;
            this.btn_casos.Text = "Casos";
            // 
            // bnt_conf_logic
            // 
            this.bnt_conf_logic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnt_conf_logic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnt_conf_logic.Location = new System.Drawing.Point(501, 242);
            this.bnt_conf_logic.Name = "bnt_conf_logic";
            this.bnt_conf_logic.Size = new System.Drawing.Size(140, 23);
            this.bnt_conf_logic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnt_conf_logic.TabIndex = 42;
            this.bnt_conf_logic.Text = "Config. Logica";
            // 
            // btn_asign12
            // 
            this.btn_asign12.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_asign12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_asign12.Location = new System.Drawing.Point(15, 271);
            this.btn_asign12.Name = "btn_asign12";
            this.btn_asign12.Size = new System.Drawing.Size(140, 23);
            this.btn_asign12.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_asign12.TabIndex = 43;
            this.btn_asign12.Text = "Asignaciones";
            this.btn_asign12.Click += new System.EventHandler(this.btn_asign12_Click);
            // 
            // labeldolars
            // 
            this.labeldolars.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labeldolars.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labeldolars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldolars.ForeColor = System.Drawing.Color.Black;
            this.labeldolars.Location = new System.Drawing.Point(606, 64);
            this.labeldolars.Name = "labeldolars";
            this.labeldolars.Size = new System.Drawing.Size(12, 20);
            this.labeldolars.TabIndex = 44;
            this.labeldolars.Text = "$";
            this.labeldolars.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txt_asigna54
            // 
            this.txt_asigna54.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_asigna54.Border.Class = "TextBoxBorder";
            this.txt_asigna54.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_asigna54.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_asigna54.DisabledBackColor = System.Drawing.Color.White;
            this.txt_asigna54.ForeColor = System.Drawing.Color.Black;
            this.txt_asigna54.Location = new System.Drawing.Point(420, 179);
            this.txt_asigna54.Name = "txt_asigna54";
            this.txt_asigna54.ReadOnly = true;
            this.txt_asigna54.Size = new System.Drawing.Size(201, 20);
            this.txt_asigna54.TabIndex = 45;
            this.txt_asigna54.TextChanged += new System.EventHandler(this.txt_asigna54_TextChanged);
            // 
            // FrmActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 318);
            this.Controls.Add(this.txt_asigna54);
            this.Controls.Add(this.labeldolars);
            this.Controls.Add(this.btn_asign12);
            this.Controls.Add(this.bnt_conf_logic);
            this.Controls.Add(this.btn_casos);
            this.Controls.Add(this.btn_movES);
            this.Controls.Add(this.btn_mtto);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.cbo_Cat);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.cbo_ubic);
            this.Controls.Add(this.date_fec_reti);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.date_fec_adqui);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.date_fec_regis);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txt_serial);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txt_descrip);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtCo_activo);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activos";
            this.Load += new System.EventHandler(this.FrmActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.date_fec_regis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_fec_adqui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_fec_reti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        public DevComponents.DotNetBar.Controls.TextBoxX txtBuscar;
        private DevComponents.DotNetBar.ButtonItem btnPrimero;
        private DevComponents.DotNetBar.ButtonItem btnAnterior;
        private DevComponents.DotNetBar.ButtonItem btnSiguiente;
        private DevComponents.DotNetBar.ButtonItem btnUltimo;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private DevComponents.DotNetBar.ButtonItem btnEliminar;
        private DevComponents.DotNetBar.ButtonItem btnDeshacer;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_descrip;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_serial;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_modelo;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_valor;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput date_fec_regis;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput date_fec_adqui;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput date_fec_reti;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_ubic;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_Cat;
        private DevComponents.DotNetBar.ButtonX btn_mtto;
        private DevComponents.DotNetBar.ButtonX btn_movES;
        private DevComponents.DotNetBar.ButtonX btn_casos;
        private DevComponents.DotNetBar.ButtonX bnt_conf_logic;
        private DevComponents.DotNetBar.ButtonX btn_asign12;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCo_activo;
        private DevComponents.DotNetBar.LabelX labeldolars;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_asigna54;
    }
}