namespace ProfitContenedor
{
    partial class FrmAutorizaG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutorizaG));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btn_Nuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Procesar = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Historial = new DevComponents.DotNetBar.ButtonItem();
            this.radPageAutorizaG = new Telerik.WinControls.UI.RadPageView();
            this.PageGerencia = new Telerik.WinControls.UI.RadPageViewPage();
            this.cbo_activo23 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_razon_G = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_fecha_actual_G = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.date_hasta = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.date_desde = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbo_empleados_G = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.PageSistemas = new Telerik.WinControls.UI.RadPageViewPage();
            this.cbo_activo_S = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txt_razon_S = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_fecha_S = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.date_hasta_S = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.date_desde_S = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cbo_empleados_S = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageAutorizaG)).BeginInit();
            this.radPageAutorizaG.SuspendLayout();
            this.PageGerencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_hasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_desde)).BeginInit();
            this.PageSistemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_activo_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_activo_S.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_activo_S.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_hasta_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_desde_S)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_Nuevo,
            this.btn_Procesar,
            this.btn_Historial});
            this.bar1.Location = new System.Drawing.Point(2, 12);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(630, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Text = "buttonItem1";
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Procesar
            // 
            this.btn_Procesar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Procesar.Image")));
            this.btn_Procesar.Name = "btn_Procesar";
            this.btn_Procesar.Text = "buttonItem2";
            this.btn_Procesar.Click += new System.EventHandler(this.btn_Procesar_Click);
            // 
            // btn_Historial
            // 
            this.btn_Historial.Image = ((System.Drawing.Image)(resources.GetObject("btn_Historial.Image")));
            this.btn_Historial.Name = "btn_Historial";
            this.btn_Historial.Text = "buttonItem3";
            this.btn_Historial.Click += new System.EventHandler(this.btn_Historial_Click);
            // 
            // radPageAutorizaG
            // 
            this.radPageAutorizaG.Controls.Add(this.PageGerencia);
            this.radPageAutorizaG.Controls.Add(this.PageSistemas);
            this.radPageAutorizaG.Location = new System.Drawing.Point(2, 59);
            this.radPageAutorizaG.Name = "radPageAutorizaG";
            this.radPageAutorizaG.SelectedPage = this.PageSistemas;
            this.radPageAutorizaG.Size = new System.Drawing.Size(630, 336);
            this.radPageAutorizaG.TabIndex = 1;
            this.radPageAutorizaG.Text = "radPageView1";
            this.radPageAutorizaG.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageAutorizaG.GetChildAt(0).GetChildAt(0))).MinSize = new System.Drawing.Size(60, 0);
            // 
            // PageGerencia
            // 
            this.PageGerencia.BackColor = System.Drawing.Color.Transparent;
            this.PageGerencia.Controls.Add(this.cbo_activo23);
            this.PageGerencia.Controls.Add(this.labelX6);
            this.PageGerencia.Controls.Add(this.labelX5);
            this.PageGerencia.Controls.Add(this.labelX4);
            this.PageGerencia.Controls.Add(this.labelX3);
            this.PageGerencia.Controls.Add(this.labelX2);
            this.PageGerencia.Controls.Add(this.labelX1);
            this.PageGerencia.Controls.Add(this.txt_razon_G);
            this.PageGerencia.Controls.Add(this.txt_fecha_actual_G);
            this.PageGerencia.Controls.Add(this.date_hasta);
            this.PageGerencia.Controls.Add(this.date_desde);
            this.PageGerencia.Controls.Add(this.cbo_empleados_G);
            this.PageGerencia.ItemSize = new System.Drawing.SizeF(62F, 45F);
            this.PageGerencia.Location = new System.Drawing.Point(92, 4);
            this.PageGerencia.Name = "PageGerencia";
            this.PageGerencia.Size = new System.Drawing.Size(534, 328);
            this.PageGerencia.Text = "Gerencia";
            this.PageGerencia.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbo_activo23
            // 
            this.cbo_activo23.DisplayMember = "Text";
            this.cbo_activo23.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_activo23.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_activo23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_activo23.FormattingEnabled = true;
            this.cbo_activo23.ItemHeight = 17;
            this.cbo_activo23.Location = new System.Drawing.Point(116, 57);
            this.cbo_activo23.Name = "cbo_activo23";
            this.cbo_activo23.Size = new System.Drawing.Size(415, 23);
            this.cbo_activo23.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_activo23.TabIndex = 12;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(2, 210);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(108, 23);
            this.labelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "Motivo del Prestamo:";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(2, 171);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(108, 23);
            this.labelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX5.TabIndex = 10;
            this.labelX5.Text = "Fecha Actual:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(2, 133);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(108, 23);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "Hasta:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(2, 94);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(108, 23);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "Desde:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(2, 57);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(108, 23);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Activo:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(2, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(108, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Empleado:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txt_razon_G
            // 
            this.txt_razon_G.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_razon_G.Border.Class = "TextBoxBorder";
            this.txt_razon_G.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_razon_G.DisabledBackColor = System.Drawing.Color.White;
            this.txt_razon_G.ForeColor = System.Drawing.Color.Black;
            this.txt_razon_G.Location = new System.Drawing.Point(116, 210);
            this.txt_razon_G.Multiline = true;
            this.txt_razon_G.Name = "txt_razon_G";
            this.txt_razon_G.PreventEnterBeep = true;
            this.txt_razon_G.Size = new System.Drawing.Size(415, 109);
            this.txt_razon_G.TabIndex = 5;
            // 
            // txt_fecha_actual_G
            // 
            this.txt_fecha_actual_G.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_fecha_actual_G.Border.Class = "TextBoxBorder";
            this.txt_fecha_actual_G.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_fecha_actual_G.DisabledBackColor = System.Drawing.Color.White;
            this.txt_fecha_actual_G.ForeColor = System.Drawing.Color.Black;
            this.txt_fecha_actual_G.Location = new System.Drawing.Point(116, 171);
            this.txt_fecha_actual_G.Name = "txt_fecha_actual_G";
            this.txt_fecha_actual_G.PreventEnterBeep = true;
            this.txt_fecha_actual_G.Size = new System.Drawing.Size(415, 22);
            this.txt_fecha_actual_G.TabIndex = 4;
            // 
            // date_hasta
            // 
            // 
            // 
            // 
            this.date_hasta.BackgroundStyle.Class = "DateTimeInputBackground";
            this.date_hasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_hasta.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.date_hasta.ButtonDropDown.Visible = true;
            this.date_hasta.IsPopupCalendarOpen = false;
            this.date_hasta.Location = new System.Drawing.Point(116, 133);
            // 
            // 
            // 
            this.date_hasta.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_hasta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_hasta.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.date_hasta.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.date_hasta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.date_hasta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.date_hasta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.date_hasta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.date_hasta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.date_hasta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.date_hasta.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_hasta.MonthCalendar.DisplayMonth = new System.DateTime(2016, 6, 1, 0, 0, 0, 0);
            this.date_hasta.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.date_hasta.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_hasta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.date_hasta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.date_hasta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.date_hasta.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_hasta.MonthCalendar.TodayButtonVisible = true;
            this.date_hasta.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.date_hasta.Name = "date_hasta";
            this.date_hasta.Size = new System.Drawing.Size(415, 22);
            this.date_hasta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.date_hasta.TabIndex = 3;
            // 
            // date_desde
            // 
            // 
            // 
            // 
            this.date_desde.BackgroundStyle.Class = "DateTimeInputBackground";
            this.date_desde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_desde.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.date_desde.ButtonDropDown.Visible = true;
            this.date_desde.IsPopupCalendarOpen = false;
            this.date_desde.Location = new System.Drawing.Point(116, 95);
            // 
            // 
            // 
            this.date_desde.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_desde.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_desde.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.date_desde.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.date_desde.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.date_desde.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.date_desde.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.date_desde.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.date_desde.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.date_desde.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.date_desde.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_desde.MonthCalendar.DisplayMonth = new System.DateTime(2016, 6, 1, 0, 0, 0, 0);
            this.date_desde.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.date_desde.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_desde.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.date_desde.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.date_desde.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.date_desde.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_desde.MonthCalendar.TodayButtonVisible = true;
            this.date_desde.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.date_desde.Name = "date_desde";
            this.date_desde.Size = new System.Drawing.Size(415, 22);
            this.date_desde.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.date_desde.TabIndex = 2;
            // 
            // cbo_empleados_G
            // 
            this.cbo_empleados_G.DisplayMember = "Text";
            this.cbo_empleados_G.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_empleados_G.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empleados_G.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_empleados_G.FormattingEnabled = true;
            this.cbo_empleados_G.ItemHeight = 17;
            this.cbo_empleados_G.Location = new System.Drawing.Point(116, 19);
            this.cbo_empleados_G.Name = "cbo_empleados_G";
            this.cbo_empleados_G.Size = new System.Drawing.Size(415, 23);
            this.cbo_empleados_G.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_empleados_G.TabIndex = 0;
            this.cbo_empleados_G.SelectedIndexChanged += new System.EventHandler(this.cbo_empleados_G_SelectedIndexChanged);
            // 
            // PageSistemas
            // 
            this.PageSistemas.BackColor = System.Drawing.Color.Transparent;
            this.PageSistemas.Controls.Add(this.cbo_activo_S);
            this.PageSistemas.Controls.Add(this.labelX9);
            this.PageSistemas.Controls.Add(this.labelX10);
            this.PageSistemas.Controls.Add(this.labelX11);
            this.PageSistemas.Controls.Add(this.labelX12);
            this.PageSistemas.Controls.Add(this.txt_razon_S);
            this.PageSistemas.Controls.Add(this.txt_fecha_S);
            this.PageSistemas.Controls.Add(this.date_hasta_S);
            this.PageSistemas.Controls.Add(this.date_desde_S);
            this.PageSistemas.Controls.Add(this.labelX8);
            this.PageSistemas.Controls.Add(this.labelX7);
            this.PageSistemas.Controls.Add(this.cbo_empleados_S);
            this.PageSistemas.ItemSize = new System.Drawing.SizeF(62F, 45F);
            this.PageSistemas.Location = new System.Drawing.Point(92, 4);
            this.PageSistemas.Name = "PageSistemas";
            this.PageSistemas.Size = new System.Drawing.Size(534, 328);
            this.PageSistemas.Text = "Sistemas";
            this.PageSistemas.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbo_activo_S
            // 
            this.cbo_activo_S.AutoSize = true;
            this.cbo_activo_S.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // cbo_activo_S.NestedRadGridView
            // 
            this.cbo_activo_S.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_activo_S.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_activo_S.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbo_activo_S.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.cbo_activo_S.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.cbo_activo_S.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.cbo_activo_S.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.cbo_activo_S.EditorControl.MasterTemplate.EnableGrouping = false;
            this.cbo_activo_S.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.cbo_activo_S.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.cbo_activo_S.EditorControl.Name = "NestedRadGridView";
            this.cbo_activo_S.EditorControl.ReadOnly = true;
            this.cbo_activo_S.EditorControl.ShowGroupPanel = false;
            this.cbo_activo_S.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.cbo_activo_S.EditorControl.TabIndex = 0;
            this.cbo_activo_S.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_activo_S.Location = new System.Drawing.Point(117, 58);
            this.cbo_activo_S.Name = "cbo_activo_S";
            this.cbo_activo_S.Size = new System.Drawing.Size(414, 23);
            this.cbo_activo_S.TabIndex = 20;
            this.cbo_activo_S.TabStop = false;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(2, 212);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(108, 23);
            this.labelX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX9.TabIndex = 19;
            this.labelX9.Text = "Motivo del Prestamo:";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(2, 173);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(108, 23);
            this.labelX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX10.TabIndex = 18;
            this.labelX10.Text = "Fecha Actual:";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(2, 135);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(108, 23);
            this.labelX11.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX11.TabIndex = 17;
            this.labelX11.Text = "Hasta:";
            this.labelX11.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(2, 96);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(108, 23);
            this.labelX12.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX12.TabIndex = 16;
            this.labelX12.Text = "Desde:";
            this.labelX12.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txt_razon_S
            // 
            this.txt_razon_S.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_razon_S.Border.Class = "TextBoxBorder";
            this.txt_razon_S.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_razon_S.DisabledBackColor = System.Drawing.Color.White;
            this.txt_razon_S.ForeColor = System.Drawing.Color.Black;
            this.txt_razon_S.Location = new System.Drawing.Point(116, 212);
            this.txt_razon_S.Multiline = true;
            this.txt_razon_S.Name = "txt_razon_S";
            this.txt_razon_S.PreventEnterBeep = true;
            this.txt_razon_S.Size = new System.Drawing.Size(415, 109);
            this.txt_razon_S.TabIndex = 15;
            // 
            // txt_fecha_S
            // 
            this.txt_fecha_S.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_fecha_S.Border.Class = "TextBoxBorder";
            this.txt_fecha_S.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_fecha_S.DisabledBackColor = System.Drawing.Color.White;
            this.txt_fecha_S.ForeColor = System.Drawing.Color.Black;
            this.txt_fecha_S.Location = new System.Drawing.Point(116, 173);
            this.txt_fecha_S.Name = "txt_fecha_S";
            this.txt_fecha_S.PreventEnterBeep = true;
            this.txt_fecha_S.ReadOnly = true;
            this.txt_fecha_S.Size = new System.Drawing.Size(415, 22);
            this.txt_fecha_S.TabIndex = 14;
            // 
            // date_hasta_S
            // 
            // 
            // 
            // 
            this.date_hasta_S.BackgroundStyle.Class = "DateTimeInputBackground";
            this.date_hasta_S.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_hasta_S.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.date_hasta_S.ButtonDropDown.Visible = true;
            this.date_hasta_S.IsPopupCalendarOpen = false;
            this.date_hasta_S.Location = new System.Drawing.Point(116, 135);
            // 
            // 
            // 
            this.date_hasta_S.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_hasta_S.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_hasta_S.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.date_hasta_S.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.date_hasta_S.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.date_hasta_S.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.date_hasta_S.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.date_hasta_S.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.date_hasta_S.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.date_hasta_S.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.date_hasta_S.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_hasta_S.MonthCalendar.DisplayMonth = new System.DateTime(2016, 6, 1, 0, 0, 0, 0);
            this.date_hasta_S.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.date_hasta_S.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_hasta_S.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.date_hasta_S.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.date_hasta_S.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.date_hasta_S.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_hasta_S.MonthCalendar.TodayButtonVisible = true;
            this.date_hasta_S.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.date_hasta_S.Name = "date_hasta_S";
            this.date_hasta_S.Size = new System.Drawing.Size(415, 22);
            this.date_hasta_S.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.date_hasta_S.TabIndex = 13;
            // 
            // date_desde_S
            // 
            // 
            // 
            // 
            this.date_desde_S.BackgroundStyle.Class = "DateTimeInputBackground";
            this.date_desde_S.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_desde_S.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.date_desde_S.ButtonDropDown.Visible = true;
            this.date_desde_S.IsPopupCalendarOpen = false;
            this.date_desde_S.Location = new System.Drawing.Point(116, 97);
            // 
            // 
            // 
            this.date_desde_S.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_desde_S.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_desde_S.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.date_desde_S.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.date_desde_S.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.date_desde_S.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.date_desde_S.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.date_desde_S.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.date_desde_S.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.date_desde_S.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.date_desde_S.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_desde_S.MonthCalendar.DisplayMonth = new System.DateTime(2016, 6, 1, 0, 0, 0, 0);
            this.date_desde_S.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.date_desde_S.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_desde_S.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.date_desde_S.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.date_desde_S.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.date_desde_S.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_desde_S.MonthCalendar.TodayButtonVisible = true;
            this.date_desde_S.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.date_desde_S.Name = "date_desde_S";
            this.date_desde_S.Size = new System.Drawing.Size(415, 22);
            this.date_desde_S.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.date_desde_S.TabIndex = 12;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(3, 60);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(108, 23);
            this.labelX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX8.TabIndex = 10;
            this.labelX8.Text = "Activo:";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(2, 19);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(108, 23);
            this.labelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.labelX7.TabIndex = 8;
            this.labelX7.Text = "Empleado:";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbo_empleados_S
            // 
            this.cbo_empleados_S.DisplayMember = "Text";
            this.cbo_empleados_S.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_empleados_S.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empleados_S.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_empleados_S.FormattingEnabled = true;
            this.cbo_empleados_S.ItemHeight = 17;
            this.cbo_empleados_S.Location = new System.Drawing.Point(116, 19);
            this.cbo_empleados_S.Name = "cbo_empleados_S";
            this.cbo_empleados_S.Size = new System.Drawing.Size(415, 23);
            this.cbo_empleados_S.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_empleados_S.TabIndex = 7;
            // 
            // FrmAutorizaG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 394);
            this.Controls.Add(this.radPageAutorizaG);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAutorizaG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAutorizaG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageAutorizaG)).EndInit();
            this.radPageAutorizaG.ResumeLayout(false);
            this.PageGerencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.date_hasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_desde)).EndInit();
            this.PageSistemas.ResumeLayout(false);
            this.PageSistemas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_activo_S.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_activo_S.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_activo_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_hasta_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_desde_S)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btn_Nuevo;
        private DevComponents.DotNetBar.ButtonItem btn_Procesar;
        private DevComponents.DotNetBar.ButtonItem btn_Historial;
        private Telerik.WinControls.UI.RadPageView radPageAutorizaG;
        private Telerik.WinControls.UI.RadPageViewPage PageGerencia;
        private Telerik.WinControls.UI.RadPageViewPage PageSistemas;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_razon_G;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_fecha_actual_G;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput date_hasta;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput date_desde;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_empleados_G;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_razon_S;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_fecha_S;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput date_hasta_S;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput date_desde_S;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_empleados_S;
        private Telerik.WinControls.UI.RadMultiColumnComboBox cbo_activo_S;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_activo23;
    }
}