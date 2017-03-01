namespace ProfitContenedor
{
    partial class FrmMantActivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantActivo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonItem();
            this.btnAgregarR = new DevComponents.DotNetBar.ButtonItem();
            this.btnQuitar = new DevComponents.DotNetBar.ButtonItem();
            this.grdDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IDMant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_mant = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.Observ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.Asesor_ext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IT_personal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
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
            this.bar1.Size = new System.Drawing.Size(1134, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 16;
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
            // grdDatos
            // 
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
            this.IDMant,
            this.ID_Activo,
            this.Fecha_mant,
            this.Observ,
            this.Monto,
            this.Asesor_ext,
            this.IT_personal,
            this.Prob,
            this.Sol,
            this.rowguid});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatos.Location = new System.Drawing.Point(0, 41);
            this.grdDatos.Name = "grdDatos";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(1134, 356);
            this.grdDatos.TabIndex = 18;
            this.grdDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellClick);
            // 
            // IDMant
            // 
            this.IDMant.DataPropertyName = "codigoM";
            this.IDMant.HeaderText = "ID Mant";
            this.IDMant.Name = "IDMant";
            this.IDMant.ReadOnly = true;
            this.IDMant.Width = 60;
            // 
            // ID_Activo
            // 
            this.ID_Activo.DataPropertyName = "idactivo";
            this.ID_Activo.HeaderText = "ID Activo";
            this.ID_Activo.Name = "ID_Activo";
            this.ID_Activo.ReadOnly = true;
            this.ID_Activo.Width = 60;
            // 
            // Fecha_mant
            // 
            // 
            // 
            // 
            this.Fecha_mant.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.Fecha_mant.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.Fecha_mant.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Fecha_mant.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.Fecha_mant.DataPropertyName = "fec_emis";
            dataGridViewCellStyle2.NullValue = null;
            this.Fecha_mant.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha_mant.HeaderText = "Fecha";
            this.Fecha_mant.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.Fecha_mant.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.Fecha_mant.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Fecha_mant.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.Fecha_mant.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Fecha_mant.MonthCalendar.DisplayMonth = new System.DateTime(2016, 2, 1, 0, 0, 0, 0);
            this.Fecha_mant.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.Fecha_mant.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.Fecha_mant.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Fecha_mant.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.Fecha_mant.Name = "Fecha_mant";
            this.Fecha_mant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fecha_mant.Width = 110;
            // 
            // Observ
            // 
            this.Observ.DataPropertyName = "observacion";
            this.Observ.HeaderText = "Observacion";
            this.Observ.Name = "Observ";
            this.Observ.Width = 200;
            // 
            // Monto
            // 
            // 
            // 
            // 
            this.Monto.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Monto.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Monto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Monto.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.Monto.DataPropertyName = "valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Format = "N2";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle3;
            this.Monto.HeaderText = "Valor";
            this.Monto.Increment = 1D;
            this.Monto.Name = "Monto";
            this.Monto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Monto.Width = 90;
            // 
            // Asesor_ext
            // 
            this.Asesor_ext.DataPropertyName = "asesor";
            this.Asesor_ext.HeaderText = "Proveedor";
            this.Asesor_ext.Name = "Asesor_ext";
            this.Asesor_ext.Width = 90;
            // 
            // IT_personal
            // 
            this.IT_personal.DataPropertyName = "consultor";
            this.IT_personal.HeaderText = "Personal IT";
            this.IT_personal.Name = "IT_personal";
            this.IT_personal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IT_personal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IT_personal.Width = 120;
            // 
            // Prob
            // 
            this.Prob.DataPropertyName = "problema";
            this.Prob.HeaderText = "Problema";
            this.Prob.Name = "Prob";
            this.Prob.Width = 200;
            // 
            // Sol
            // 
            this.Sol.DataPropertyName = "solucion";
            this.Sol.HeaderText = "Solucion";
            this.Sol.Name = "Sol";
            this.Sol.Width = 200;
            // 
            // rowguid
            // 
            this.rowguid.DataPropertyName = "Rowguid";
            this.rowguid.HeaderText = "Identificador";
            this.rowguid.Name = "rowguid";
            this.rowguid.ReadOnly = true;
            this.rowguid.Visible = false;
            // 
            // FrmMantActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 397);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FrmMantActivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMantActivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private DevComponents.DotNetBar.ButtonItem btnAgregarR;
        private DevComponents.DotNetBar.ButtonItem btnQuitar;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Activo;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn Fecha_mant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observ;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asesor_ext;
        private System.Windows.Forms.DataGridViewComboBoxColumn IT_personal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguid;
    }
}