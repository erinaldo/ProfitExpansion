namespace ProfitContenedor
{
    partial class FrmEntrega
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.txtDesde = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtHasta = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnActualizar = new DevComponents.DotNetBar.ButtonX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.profitEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profit_E = new ProfitContenedor.Profit_E();
            this.chkPend = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkRet = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkAnu = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profit_E)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDesde
            // 
            this.txtDesde.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDesde.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDesde.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtDesde.ButtonDropDown.Visible = true;
            this.txtDesde.ForeColor = System.Drawing.Color.Black;
            this.txtDesde.IsPopupCalendarOpen = false;
            this.txtDesde.Location = new System.Drawing.Point(12, 65);
            // 
            // 
            // 
            this.txtDesde.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtDesde.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDesde.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtDesde.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtDesde.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtDesde.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDesde.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtDesde.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtDesde.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDesde.MonthCalendar.DisplayMonth = new System.DateTime(2014, 8, 1, 0, 0, 0, 0);
            this.txtDesde.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtDesde.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtDesde.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtDesde.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDesde.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtDesde.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDesde.MonthCalendar.TodayButtonVisible = true;
            this.txtDesde.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(151, 22);
            this.txtDesde.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtDesde.TabIndex = 0;
            // 
            // txtHasta
            // 
            this.txtHasta.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtHasta.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHasta.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtHasta.ButtonDropDown.Visible = true;
            this.txtHasta.ForeColor = System.Drawing.Color.Black;
            this.txtHasta.IsPopupCalendarOpen = false;
            this.txtHasta.Location = new System.Drawing.Point(169, 65);
            // 
            // 
            // 
            this.txtHasta.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtHasta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHasta.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtHasta.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtHasta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtHasta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtHasta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtHasta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtHasta.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHasta.MonthCalendar.DisplayMonth = new System.DateTime(2014, 8, 1, 0, 0, 0, 0);
            this.txtHasta.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtHasta.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtHasta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtHasta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtHasta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtHasta.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHasta.MonthCalendar.TodayButtonVisible = true;
            this.txtHasta.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(151, 22);
            this.txtHasta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtHasta.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 40);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 19);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Desde:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(169, 40);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 19);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Hasta:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnActualizar.Location = new System.Drawing.Point(486, 65);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(181, 22);
            this.btnActualizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // superGridControl1
            // 
            this.superGridControl1.BackColor = System.Drawing.Color.White;
            this.superGridControl1.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Square;
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.ForeColor = System.Drawing.Color.Black;
            this.superGridControl1.Location = new System.Drawing.Point(12, 93);
            this.superGridControl1.Name = "superGridControl1";
            gridColumn1.DataPropertyName = "Fact_num";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridButtonXEditControl);
            gridColumn1.HeaderText = "Pedido";
            gridColumn1.Name = "Fact_num";
            gridColumn2.DataPropertyName = "Fec_emis";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn2.HeaderText = "Fecha";
            gridColumn2.Name = "Fec_emis";
            gridColumn3.DataPropertyName = "Cli_des";
            gridColumn3.HeaderText = "Cliente";
            gridColumn3.Name = "Cli_des";
            gridColumn3.Width = 500;
            gridColumn4.DataPropertyName = "Zon_des";
            gridColumn4.HeaderText = "Zona";
            gridColumn4.Name = "Zon_des";
            gridColumn4.Width = 200;
            gridColumn5.DataPropertyName = "Empresa";
            gridColumn5.HeaderText = "Empresa";
            gridColumn5.Name = "Empresa";
            gridColumn5.Visible = false;
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn4);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn5);
            this.superGridControl1.PrimaryGrid.DataSource = this.profitEBindingSource;
            this.superGridControl1.PrimaryGrid.MultiSelect = false;
            this.superGridControl1.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.RowWithCellHighlight;
            this.superGridControl1.PrimaryGrid.ShowTreeButtons = true;
            this.superGridControl1.PrimaryGrid.ShowTreeLines = true;
            this.superGridControl1.PrimaryGrid.Title.Text = "Test";
            this.superGridControl1.Size = new System.Drawing.Size(969, 363);
            this.superGridControl1.TabIndex = 5;
            this.superGridControl1.Text = "superGridControl1";
            // 
            // profitEBindingSource
            // 
            this.profitEBindingSource.DataSource = this.profit_E;
            this.profitEBindingSource.Position = 0;
            // 
            // profit_E
            // 
            this.profit_E.DataSetName = "Profit_E";
            this.profit_E.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkPend
            // 
            this.chkPend.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkPend.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkPend.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkPend.Checked = true;
            this.chkPend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPend.CheckValue = "Y";
            this.chkPend.ForeColor = System.Drawing.Color.Black;
            this.chkPend.Location = new System.Drawing.Point(673, 65);
            this.chkPend.Name = "chkPend";
            this.chkPend.Size = new System.Drawing.Size(82, 23);
            this.chkPend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkPend.TabIndex = 6;
            this.chkPend.Text = "Pendientes";
            this.chkPend.CheckedChanged += new System.EventHandler(this.chkPend_CheckedChanged);
            // 
            // chkRet
            // 
            this.chkRet.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkRet.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkRet.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkRet.ForeColor = System.Drawing.Color.Black;
            this.chkRet.Location = new System.Drawing.Point(761, 65);
            this.chkRet.Name = "chkRet";
            this.chkRet.Size = new System.Drawing.Size(77, 23);
            this.chkRet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkRet.TabIndex = 7;
            this.chkRet.Text = "Retirados";
            this.chkRet.CheckedChanged += new System.EventHandler(this.chkRet_CheckedChanged);
            // 
            // chkAnu
            // 
            this.chkAnu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkAnu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkAnu.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkAnu.ForeColor = System.Drawing.Color.Black;
            this.chkAnu.Location = new System.Drawing.Point(844, 65);
            this.chkAnu.Name = "chkAnu";
            this.chkAnu.Size = new System.Drawing.Size(77, 23);
            this.chkAnu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkAnu.TabIndex = 8;
            this.chkAnu.Text = "Anulados";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 16;
            this.comboBoxEx1.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.comboBoxEx1.Location = new System.Drawing.Point(327, 65);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(153, 22);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 9;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Almacen (Exterior)";
            this.comboItem1.Value = "Almacen (Exterior)";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Deposito (Casita)";
            this.comboItem2.Value = "Deposito (Casita)";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(327, 40);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 19);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Ubicacion:";
            // 
            // FrmEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 468);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.chkAnu);
            this.Controls.Add(this.chkRet);
            this.Controls.Add(this.chkPend);
            this.Controls.Add(this.superGridControl1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FrmEntrega";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrega de Mercancia";
            this.Load += new System.EventHandler(this.FrmEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profit_E)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtDesde;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtHasta;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnActualizar;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private System.Windows.Forms.BindingSource profitEBindingSource;
        private Profit_E profit_E;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkPend;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkRet;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkAnu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
    }
}