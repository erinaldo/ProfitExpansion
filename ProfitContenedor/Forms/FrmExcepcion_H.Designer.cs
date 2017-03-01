namespace ProfitContenedor
{
    partial class FrmExcepcion_H
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExcepcion_H));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Bar = new DevComponents.DotNetBar.Bar();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonItem();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonItem();
            this.grdDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fe_us_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaHora = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaHora)).BeginInit();
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
            this.btnNuevo,
            this.btnGuardar,
            this.btnEliminar});
            this.Bar.Location = new System.Drawing.Point(0, 0);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(336, 41);
            this.Bar.Stretch = true;
            this.Bar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Bar.TabIndex = 2;
            this.Bar.TabStop = false;
            this.Bar.Text = "bar1";
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
            // grdDatos
            // 
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Fe_us_in});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatos.Location = new System.Drawing.Point(0, 94);
            this.grdDatos.Name = "grdDatos";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(336, 242);
            this.grdDatos.TabIndex = 1;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            dataGridViewCellStyle10.Format = "g";
            dataGridViewCellStyle10.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle10;
            this.Fecha.HeaderText = "Fecha/Hora";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 152;
            // 
            // Fe_us_in
            // 
            this.Fe_us_in.DataPropertyName = "fe_us_in";
            this.Fe_us_in.HeaderText = "Fecha registro";
            this.Fe_us_in.Name = "Fe_us_in";
            this.Fe_us_in.ReadOnly = true;
            this.Fe_us_in.Width = 152;
            // 
            // txtFechaHora
            // 
            // 
            // 
            // 
            this.txtFechaHora.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtFechaHora.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFechaHora.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtFechaHora.ButtonDropDown.Visible = true;
            this.txtFechaHora.CustomFormat = "dd/mm/yyyy hh:mm:ss";
            this.txtFechaHora.DateTimeSelectorVisibility = DevComponents.Editors.DateTimeAdv.eDateTimeSelectorVisibility.Both;
            this.txtFechaHora.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.txtFechaHora.IsPopupCalendarOpen = false;
            this.txtFechaHora.Location = new System.Drawing.Point(0, 68);
            // 
            // 
            // 
            this.txtFechaHora.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtFechaHora.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFechaHora.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtFechaHora.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtFechaHora.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtFechaHora.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtFechaHora.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtFechaHora.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtFechaHora.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtFechaHora.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtFechaHora.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFechaHora.MonthCalendar.DayClickAutoClosePopup = false;
            this.txtFechaHora.MonthCalendar.DisplayMonth = new System.DateTime(2015, 4, 1, 0, 0, 0, 0);
            this.txtFechaHora.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtFechaHora.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtFechaHora.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtFechaHora.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtFechaHora.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtFechaHora.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFechaHora.MonthCalendar.TodayButtonVisible = true;
            this.txtFechaHora.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtFechaHora.Name = "txtFechaHora";
            this.txtFechaHora.Size = new System.Drawing.Size(336, 22);
            this.txtFechaHora.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtFechaHora.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(0, 47);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(153, 15);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Fecha y hora de cierre diario:";
            // 
            // FrmExcepcion_H
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 340);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtFechaHora);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.Bar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExcepcion_H";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excepciones de horario";
            this.Load += new System.EventHandler(this.FrmExcepcion_H_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaHora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar Bar;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private DevComponents.DotNetBar.ButtonItem btnEliminar;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fe_us_in;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtFechaHora;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}