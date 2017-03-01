namespace ProfitContenedor
{
    partial class FrmHistorialG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialG));
            this.grdDatosH = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id_movimiento = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.autoriza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desde1 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.hasta1 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.status1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosH)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatosH
            // 
            this.grdDatosH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_movimiento,
            this.autoriza,
            this.ACTIVO1,
            this.desde1,
            this.hasta1,
            this.status1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatosH.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatosH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatosH.Location = new System.Drawing.Point(1, 3);
            this.grdDatosH.MultiSelect = false;
            this.grdDatosH.Name = "grdDatosH";
            this.grdDatosH.RowHeadersVisible = false;
            this.grdDatosH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdDatosH.Size = new System.Drawing.Size(603, 143);
            this.grdDatosH.TabIndex = 0;
            this.grdDatosH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosH_CellClick);
            this.grdDatosH.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grdDatosH_RowPrePaint);
            // 
            // id_movimiento
            // 
            // 
            // 
            // 
            this.id_movimiento.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.id_movimiento.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.id_movimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.id_movimiento.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.id_movimiento.DataPropertyName = "cod";
            this.id_movimiento.HeaderText = "ID";
            this.id_movimiento.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.id_movimiento.Name = "id_movimiento";
            this.id_movimiento.ReadOnly = true;
            this.id_movimiento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_movimiento.Visible = false;
            this.id_movimiento.Width = 50;
            // 
            // autoriza
            // 
            this.autoriza.DataPropertyName = "razon";
            this.autoriza.HeaderText = "Razon ";
            this.autoriza.Name = "autoriza";
            this.autoriza.ReadOnly = true;
            this.autoriza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.autoriza.Width = 200;
            // 
            // ACTIVO1
            // 
            this.ACTIVO1.DataPropertyName = "activo";
            this.ACTIVO1.HeaderText = "Activo";
            this.ACTIVO1.Name = "ACTIVO1";
            this.ACTIVO1.ReadOnly = true;
            this.ACTIVO1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // desde1
            // 
            // 
            // 
            // 
            this.desde1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
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
            this.desde1.MonthCalendar.DisplayMonth = new System.DateTime(2016, 5, 1, 0, 0, 0, 0);
            this.desde1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.desde1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.desde1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.desde1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.desde1.Name = "desde1";
            this.desde1.ReadOnly = true;
            this.desde1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // hasta1
            // 
            // 
            // 
            // 
            this.hasta1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
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
            this.hasta1.MonthCalendar.DisplayMonth = new System.DateTime(2016, 5, 1, 0, 0, 0, 0);
            this.hasta1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.hasta1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.hasta1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hasta1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.hasta1.Name = "hasta1";
            this.hasta1.ReadOnly = true;
            this.hasta1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // status1
            // 
            this.status1.ActiveLinkColor = System.Drawing.Color.Black;
            this.status1.DataPropertyName = "status";
            this.status1.HeaderText = "Status";
            this.status1.LinkColor = System.Drawing.Color.Blue;
            this.status1.Name = "status1";
            this.status1.ReadOnly = true;
            this.status1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.status1.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(1, 147);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(248, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Nota: Haga click en el estatus que desea anular.";
            // 
            // FrmHistorialG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 165);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.grdDatosH);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHistorialG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmHistorialG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX grdDatosH;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn id_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoriza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO1;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn desde1;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn hasta1;
        private System.Windows.Forms.DataGridViewLinkColumn status1;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}