namespace ProfitContenedor
{
    partial class FrmAsignacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonItem();
            this.btnAgregarR = new DevComponents.DotNetBar.ButtonItem();
            this.btnQuitar = new DevComponents.DotNetBar.ButtonItem();
            this.grddatos1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codigo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desde1 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.hasta1 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.consul = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rowguid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grddatos1)).BeginInit();
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
            this.btnGuardar,
            this.btnAgregarR,
            this.btnQuitar});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(937, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 15;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Text = "btnGuardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // grddatos1
            // 
            this.grddatos1.BackgroundColor = System.Drawing.Color.White;
            this.grddatos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddatos1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo1,
            this.Empleado,
            this.Empresa,
            this.Activo,
            this.desde1,
            this.hasta1,
            this.consul,
            this.rowguid});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grddatos1.DefaultCellStyle = dataGridViewCellStyle1;
            this.grddatos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grddatos1.EnableHeadersVisualStyles = false;
            this.grddatos1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grddatos1.Location = new System.Drawing.Point(0, 41);
            this.grddatos1.Name = "grddatos1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grddatos1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grddatos1.RowHeadersVisible = false;
            this.grddatos1.Size = new System.Drawing.Size(937, 316);
            this.grddatos1.TabIndex = 18;
            this.grddatos1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddatos1_CellClick);
            // 
            // codigo1
            // 
            this.codigo1.DataPropertyName = "codigo";
            this.codigo1.HeaderText = "ID Asignacion";
            this.codigo1.Name = "codigo1";
            this.codigo1.ReadOnly = true;
            this.codigo1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codigo1.Width = 80;
            // 
            // Empleado
            // 
            this.Empleado.DataPropertyName = "empleado";
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Empleado.Width = 250;
            // 
            // Empresa
            // 
            this.Empresa.DataPropertyName = "empresa";
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Empresa.Width = 150;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "activo";
            this.Activo.HeaderText = "ID Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // desde1
            // 
            // 
            // 
            // 
            this.desde1.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.desde1.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.desde1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.desde1.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.desde1.DataPropertyName = "desde";
            this.desde1.HeaderText = "Desde";
            this.desde1.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.desde1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.desde1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.desde1.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.desde1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.desde1.MonthCalendar.DisplayMonth = new System.DateTime(2016, 2, 1, 0, 0, 0, 0);
            this.desde1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.desde1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.desde1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.desde1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.desde1.Name = "desde1";
            this.desde1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // hasta1
            // 
            // 
            // 
            // 
            this.hasta1.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.hasta1.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.hasta1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hasta1.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.hasta1.DataPropertyName = "hasta";
            this.hasta1.HeaderText = "Hasta";
            this.hasta1.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.hasta1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.hasta1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hasta1.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.hasta1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hasta1.MonthCalendar.DisplayMonth = new System.DateTime(2016, 2, 1, 0, 0, 0, 0);
            this.hasta1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.hasta1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.hasta1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hasta1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.hasta1.Name = "hasta1";
            this.hasta1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // consul
            // 
            this.consul.AutoComplete = false;
            this.consul.DataPropertyName = "consultor";
            this.consul.HeaderText = "Consultor";
            this.consul.Name = "consul";
            this.consul.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.consul.Width = 154;
            // 
            // rowguid
            // 
            this.rowguid.DataPropertyName = "Rowguid";
            this.rowguid.HeaderText = "Indentificador";
            this.rowguid.Name = "rowguid";
            this.rowguid.ReadOnly = true;
            this.rowguid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rowguid.Visible = false;
            // 
            // FrmAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 357);
            this.Controls.Add(this.grddatos1);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAsignacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAsignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grddatos1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private DevComponents.DotNetBar.ButtonItem btnAgregarR;
        private DevComponents.DotNetBar.ButtonItem btnQuitar;
        public DevComponents.DotNetBar.Controls.DataGridViewX grddatos1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewComboBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn desde1;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn hasta1;
        private System.Windows.Forms.DataGridViewComboBoxColumn consul;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguid;
    }
}