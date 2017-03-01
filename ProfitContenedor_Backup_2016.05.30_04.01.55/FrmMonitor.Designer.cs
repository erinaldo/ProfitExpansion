namespace ProfitContenedor
{
    partial class FrmMonitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.nro_viaje = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.Consignatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C20p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C40p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_sal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_lleg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naviera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shipper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.txtDesde = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtHasta = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnConsultar = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnImprimir = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro_viaje,
            this.Consignatario,
            this.Bl,
            this.C20p,
            this.C40p,
            this.Origen,
            this.Fecha_sal,
            this.Destino,
            this.Fec_lleg,
            this.Naviera,
            this.Shipper,
            this.monto});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatos.Location = new System.Drawing.Point(0, 41);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(1178, 405);
            this.grdDatos.TabIndex = 0;
            // 
            // nro_viaje
            // 
            this.nro_viaje.DataPropertyName = "nro_viaje";
            this.nro_viaje.Frozen = true;
            this.nro_viaje.HeaderText = "Nro. Viaje";
            this.nro_viaje.Name = "nro_viaje";
            this.nro_viaje.ReadOnly = true;
            this.nro_viaje.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nro_viaje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nro_viaje.Text = null;
            this.nro_viaje.Width = 60;
            // 
            // Consignatario
            // 
            this.Consignatario.DataPropertyName = "co_consig";
            this.Consignatario.HeaderText = "Consignatario";
            this.Consignatario.Name = "Consignatario";
            this.Consignatario.ReadOnly = true;
            this.Consignatario.Width = 90;
            // 
            // Bl
            // 
            this.Bl.DataPropertyName = "bl";
            this.Bl.HeaderText = "BL";
            this.Bl.Name = "Bl";
            this.Bl.ReadOnly = true;
            this.Bl.Width = 115;
            // 
            // C20p
            // 
            this.C20p.DataPropertyName = "c20p";
            this.C20p.HeaderText = "C. 20 ft";
            this.C20p.Name = "C20p";
            this.C20p.ReadOnly = true;
            this.C20p.Width = 80;
            // 
            // C40p
            // 
            this.C40p.DataPropertyName = "c40p";
            this.C40p.HeaderText = "C. 40 ft";
            this.C40p.Name = "C40p";
            this.C40p.ReadOnly = true;
            this.C40p.Width = 80;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "pto_sal";
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            this.Origen.Width = 90;
            // 
            // Fecha_sal
            // 
            this.Fecha_sal.DataPropertyName = "fecha_sal";
            this.Fecha_sal.HeaderText = "Fecha Sal.";
            this.Fecha_sal.Name = "Fecha_sal";
            this.Fecha_sal.ReadOnly = true;
            this.Fecha_sal.Width = 80;
            // 
            // Destino
            // 
            this.Destino.DataPropertyName = "pto_lleg";
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Width = 90;
            // 
            // Fec_lleg
            // 
            this.Fec_lleg.DataPropertyName = "fecha_lleg";
            this.Fec_lleg.HeaderText = "Fec. Llegada";
            this.Fec_lleg.Name = "Fec_lleg";
            this.Fec_lleg.ReadOnly = true;
            this.Fec_lleg.Width = 80;
            // 
            // Naviera
            // 
            this.Naviera.DataPropertyName = "navi_des";
            this.Naviera.HeaderText = "Naviera";
            this.Naviera.Name = "Naviera";
            this.Naviera.ReadOnly = true;
            this.Naviera.Width = 60;
            // 
            // Shipper
            // 
            this.Shipper.DataPropertyName = "shipper_des";
            this.Shipper.HeaderText = "Shipper";
            this.Shipper.Name = "Shipper";
            this.Shipper.ReadOnly = true;
            this.Shipper.Width = 200;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N2";
            this.monto.DefaultCellStyle = dataGridViewCellStyle6;
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.monto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.monto.Text = null;
            this.monto.Width = 90;
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
            this.txtDesde.Location = new System.Drawing.Point(46, 15);
            // 
            // 
            // 
            this.txtDesde.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtDesde.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtDesde.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
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
            this.txtDesde.MonthCalendar.DisplayMonth = new System.DateTime(2013, 7, 1, 0, 0, 0, 0);
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
            this.txtDesde.Size = new System.Drawing.Size(200, 20);
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
            this.txtHasta.Location = new System.Drawing.Point(298, 15);
            // 
            // 
            // 
            this.txtHasta.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtHasta.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtHasta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
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
            this.txtHasta.MonthCalendar.DisplayMonth = new System.DateTime(2013, 7, 1, 0, 0, 0, 0);
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
            this.txtHasta.Size = new System.Drawing.Size(200, 20);
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
            this.labelX1.Location = new System.Drawing.Point(0, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(40, 23);
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
            this.labelX2.Location = new System.Drawing.Point(252, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(40, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Hasta:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConsultar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConsultar.Location = new System.Drawing.Point(504, 16);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(129, 19);
            this.btnConsultar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // btnImprimir
            // 
            this.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImprimir.Location = new System.Drawing.Point(639, 16);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(129, 19);
            this.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 446);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.grdDatos);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMonitor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor de Contenedores";
            this.Load += new System.EventHandler(this.FrmMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHasta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX grdDatos;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtDesde;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtHasta;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnConsultar;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn nro_viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consignatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bl;
        private System.Windows.Forms.DataGridViewTextBoxColumn C20p;
        private System.Windows.Forms.DataGridViewTextBoxColumn C40p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_sal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_lleg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naviera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shipper;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn monto;
        private DevComponents.DotNetBar.ButtonX btnImprimir;
    }
}