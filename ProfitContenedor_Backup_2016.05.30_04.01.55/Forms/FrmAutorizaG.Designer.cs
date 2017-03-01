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
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnProcesar = new DevComponents.DotNetBar.ButtonItem();
            this.btn_hist32 = new DevComponents.DotNetBar.ButtonItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txt_activo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_razon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.date_desde = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.date_hasta = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txt_fecha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cbo_autorizado1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_desde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_hasta)).BeginInit();
            this.groupPanel1.SuspendLayout();
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
            this.btnNuevo,
            this.btnProcesar,
            this.btn_hist32});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(482, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 14;
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
            // btnProcesar
            // 
            this.btnProcesar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcesar.Image")));
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Text = "btnGuardar";
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btn_hist32
            // 
            this.btn_hist32.Image = ((System.Drawing.Image)(resources.GetObject("btn_hist32.Image")));
            this.btn_hist32.Name = "btn_hist32";
            this.btn_hist32.Text = "btnEliminar";
            this.btn_hist32.Click += new System.EventHandler(this.btn_historial_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 25);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Autorizado:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(3, 51);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "Activo:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(3, 78);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 18;
            this.labelX4.Text = "Desde:";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(3, 104);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 19;
            this.labelX5.Text = "Hasta:";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(3, 154);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(44, 23);
            this.labelX6.TabIndex = 20;
            this.labelX6.Text = "Razon:";
            // 
            // txt_activo
            // 
            this.txt_activo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_activo.Border.Class = "TextBoxBorder";
            this.txt_activo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_activo.DisabledBackColor = System.Drawing.Color.White;
            this.txt_activo.ForeColor = System.Drawing.Color.Black;
            this.txt_activo.Location = new System.Drawing.Point(77, 130);
            this.txt_activo.Name = "txt_activo";
            this.txt_activo.PreventEnterBeep = true;
            this.txt_activo.Size = new System.Drawing.Size(378, 20);
            this.txt_activo.TabIndex = 1;
            // 
            // txt_razon
            // 
            this.txt_razon.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_razon.Border.Class = "TextBoxBorder";
            this.txt_razon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_razon.DisabledBackColor = System.Drawing.Color.White;
            this.txt_razon.ForeColor = System.Drawing.Color.Black;
            this.txt_razon.Location = new System.Drawing.Point(77, 235);
            this.txt_razon.Multiline = true;
            this.txt_razon.Name = "txt_razon";
            this.txt_razon.PreventEnterBeep = true;
            this.txt_razon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_razon.Size = new System.Drawing.Size(378, 123);
            this.txt_razon.TabIndex = 5;
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
            this.date_desde.Location = new System.Drawing.Point(77, 156);
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
            this.date_desde.MonthCalendar.DisplayMonth = new System.DateTime(2016, 4, 1, 0, 0, 0, 0);
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
            this.date_desde.Size = new System.Drawing.Size(378, 20);
            this.date_desde.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.date_desde.TabIndex = 2;
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
            this.date_hasta.Location = new System.Drawing.Point(77, 183);
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
            this.date_hasta.MonthCalendar.DisplayMonth = new System.DateTime(2016, 4, 1, 0, 0, 0, 0);
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
            this.date_hasta.Size = new System.Drawing.Size(378, 20);
            this.date_hasta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.date_hasta.TabIndex = 3;
            // 
            // txt_fecha
            // 
            this.txt_fecha.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_fecha.Border.Class = "TextBoxBorder";
            this.txt_fecha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_fecha.DisabledBackColor = System.Drawing.Color.White;
            this.txt_fecha.ForeColor = System.Drawing.Color.Black;
            this.txt_fecha.Location = new System.Drawing.Point(77, 209);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.PreventEnterBeep = true;
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(378, 20);
            this.txt_fecha.TabIndex = 4;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(3, 129);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(44, 23);
            this.labelX7.TabIndex = 27;
            this.labelX7.Text = "Fecha:";
            // 
            // cbo_autorizado1
            // 
            this.cbo_autorizado1.DisplayMember = "Text";
            this.cbo_autorizado1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_autorizado1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_autorizado1.FormattingEnabled = true;
            this.cbo_autorizado1.ItemHeight = 14;
            this.cbo_autorizado1.Location = new System.Drawing.Point(77, 104);
            this.cbo_autorizado1.Name = "cbo_autorizado1";
            this.cbo_autorizado1.Size = new System.Drawing.Size(378, 20);
            this.cbo_autorizado1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_autorizado1.TabIndex = 0;
            this.cbo_autorizado1.SelectedIndexChanged += new System.EventHandler(this.cbo_autorizado1_SelectedIndexChanged);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(0, 72);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(481, 314);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 28;
            // 
            // FrmAutorizaG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 390);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.cbo_autorizado1);
            this.Controls.Add(this.date_hasta);
            this.Controls.Add(this.date_desde);
            this.Controls.Add(this.txt_razon);
            this.Controls.Add(this.txt_activo);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAutorizaG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAutorizaG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_desde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_hasta)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnProcesar;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_razon;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput date_desde;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput date_hasta;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_fecha;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_autorizado1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_activo;
        private DevComponents.DotNetBar.ButtonItem btn_hist32;
    }
}