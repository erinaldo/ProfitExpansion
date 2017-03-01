namespace ProfitContenedor
{
    partial class FrmPCP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPCP));
            this.grdSalida = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_confirm = new DevComponents.DotNetBar.ButtonX();
            this.btn_salir = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_noti = new DevComponents.DotNetBar.LabelX();
            this.ID = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
            this.quien_autoriza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desde12 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.hasta12 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.checkin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSalida
            // 
            this.grdSalida.BackgroundColor = System.Drawing.Color.White;
            this.grdSalida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.quien_autoriza,
            this.trabajador,
            this.razon,
            this.equipo,
            this.desde12,
            this.hasta12,
            this.checkin});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSalida.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdSalida.EnableHeadersVisualStyles = false;
            this.grdSalida.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdSalida.Location = new System.Drawing.Point(1, 0);
            this.grdSalida.Name = "grdSalida";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSalida.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdSalida.RowHeadersVisible = false;
            this.grdSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdSalida.Size = new System.Drawing.Size(803, 173);
            this.grdSalida.TabIndex = 0;
            this.grdSalida.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grdSalida_RowPrePaint);
            // 
            // btn_confirm
            // 
            this.btn_confirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_confirm.BackColor = System.Drawing.Color.White;
            this.btn_confirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_confirm.Location = new System.Drawing.Point(627, 175);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(68, 23);
            this.btn_confirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_confirm.TabIndex = 1;
            this.btn_confirm.Text = "Aceptar";
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_salir.BackColor = System.Drawing.Color.White;
            this.btn_salir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_salir.Location = new System.Drawing.Point(555, 175);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(68, 23);
            this.btn_salir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(4, 175);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(124, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Salidas para Hoy:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_noti
            // 
            // 
            // 
            // 
            this.lbl_noti.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_noti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noti.Location = new System.Drawing.Point(149, 218);
            this.lbl_noti.Name = "lbl_noti";
            this.lbl_noti.Size = new System.Drawing.Size(339, 23);
            this.lbl_noti.TabIndex = 4;
            this.lbl_noti.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.ID.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.ID.BackgroundStyle.Class = "DataGridViewIpAddressBorder";
            this.ID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ID.DataPropertyName = "id_movimiento";
            this.ID.FocusHighlightColor = System.Drawing.Color.White;
            this.ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ID.HeaderText = "ID_movi";
            this.ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ID.Name = "ID";
            this.ID.PasswordChar = '\0';
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ID.Text = "";
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID.Visible = false;
            // 
            // quien_autoriza
            // 
            this.quien_autoriza.DataPropertyName = "gerente";
            this.quien_autoriza.HeaderText = "Gerente";
            this.quien_autoriza.Name = "quien_autoriza";
            this.quien_autoriza.ReadOnly = true;
            this.quien_autoriza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quien_autoriza.Width = 135;
            // 
            // trabajador
            // 
            this.trabajador.DataPropertyName = "empleado";
            this.trabajador.HeaderText = "Empleado";
            this.trabajador.Name = "trabajador";
            this.trabajador.ReadOnly = true;
            this.trabajador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.trabajador.Width = 194;
            // 
            // razon
            // 
            this.razon.DataPropertyName = "autorizacion";
            this.razon.HeaderText = "Motivo";
            this.razon.Name = "razon";
            this.razon.ReadOnly = true;
            this.razon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // equipo
            // 
            this.equipo.DataPropertyName = "activo";
            this.equipo.HeaderText = "Activo";
            this.equipo.Name = "equipo";
            this.equipo.ReadOnly = true;
            this.equipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.equipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // desde12
            // 
            // 
            // 
            // 
            this.desde12.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.desde12.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.desde12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.desde12.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.desde12.DataPropertyName = "desde";
            this.desde12.HeaderText = "Desde";
            this.desde12.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.desde12.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.desde12.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.desde12.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.desde12.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.desde12.MonthCalendar.DisplayMonth = new System.DateTime(2016, 4, 1, 0, 0, 0, 0);
            this.desde12.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.desde12.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.desde12.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.desde12.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.desde12.Name = "desde12";
            this.desde12.ReadOnly = true;
            this.desde12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.desde12.Visible = false;
            // 
            // hasta12
            // 
            // 
            // 
            // 
            this.hasta12.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.hasta12.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.hasta12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hasta12.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.hasta12.DataPropertyName = "hasta";
            this.hasta12.HeaderText = "Hasta";
            this.hasta12.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.hasta12.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.hasta12.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hasta12.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.hasta12.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hasta12.MonthCalendar.DisplayMonth = new System.DateTime(2016, 4, 1, 0, 0, 0, 0);
            this.hasta12.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.hasta12.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.hasta12.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hasta12.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.hasta12.Name = "hasta12";
            this.hasta12.ReadOnly = true;
            this.hasta12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // checkin
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.NullValue = false;
            this.checkin.DefaultCellStyle = dataGridViewCellStyle2;
            this.checkin.FalseValue = "";
            this.checkin.HeaderText = "Confirmar";
            this.checkin.IndeterminateValue = "";
            this.checkin.Name = "checkin";
            this.checkin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkin.TrueValue = "";
            this.checkin.Width = 65;
            // 
            // FrmPCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 202);
            this.Controls.Add(this.lbl_noti);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.grdSalida);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPCP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salidas";
            this.Load += new System.EventHandler(this.FrmPCP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX grdSalida;
        private DevComponents.DotNetBar.ButtonX btn_confirm;
        private DevComponents.DotNetBar.ButtonX btn_salir;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.LabelX lbl_noti;
        private DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn quien_autoriza;
        private System.Windows.Forms.DataGridViewTextBoxColumn trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipo;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn desde12;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn hasta12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkin;
    }
}