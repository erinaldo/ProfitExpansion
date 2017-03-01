namespace ProfitContenedor
{
    partial class FrmPCPE_S
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPCPE_S));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.grdentradaPCP = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id_mov1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btn_confirm = new DevComponents.DotNetBar.ButtonX();
            this.grdSalida = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
            this.quien_autoriza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desde12 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.hasta12 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.checkin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_entradas = new DevComponents.DotNetBar.LabelX();
            this.lbl_noti = new DevComponents.DotNetBar.LabelX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.grdentradaPCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(8, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(124, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Entradas para Hoy:";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(628, 9);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(67, 23);
            this.buttonX1.TabIndex = 5;
            this.buttonX1.Text = "Aceptar";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // grdentradaPCP
            // 
            this.grdentradaPCP.BackgroundColor = System.Drawing.Color.White;
            this.grdentradaPCP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdentradaPCP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdentradaPCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdentradaPCP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_mov1,
            this.empleado1,
            this.activo1,
            this.descrip,
            this.serial1,
            this.Confirm});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdentradaPCP.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdentradaPCP.EnableHeadersVisualStyles = false;
            this.grdentradaPCP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdentradaPCP.Location = new System.Drawing.Point(1, 38);
            this.grdentradaPCP.Name = "grdentradaPCP";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdentradaPCP.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdentradaPCP.RowHeadersVisible = false;
            this.grdentradaPCP.Size = new System.Drawing.Size(701, 175);
            this.grdentradaPCP.TabIndex = 4;
            // 
            // id_mov1
            // 
            this.id_mov1.DataPropertyName = "id_mov";
            this.id_mov1.HeaderText = "ID_mov";
            this.id_mov1.Name = "id_mov1";
            this.id_mov1.Visible = false;
            // 
            // empleado1
            // 
            this.empleado1.DataPropertyName = "empleado";
            this.empleado1.HeaderText = "Empleado";
            this.empleado1.Name = "empleado1";
            this.empleado1.ReadOnly = true;
            this.empleado1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.empleado1.Width = 230;
            // 
            // activo1
            // 
            this.activo1.DataPropertyName = "activo";
            this.activo1.HeaderText = "Activo";
            this.activo1.Name = "activo1";
            this.activo1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // descrip
            // 
            this.descrip.DataPropertyName = "descripcion";
            this.descrip.HeaderText = "Descripcion";
            this.descrip.Name = "descrip";
            this.descrip.ReadOnly = true;
            this.descrip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descrip.Width = 150;
            // 
            // serial1
            // 
            this.serial1.DataPropertyName = "serial";
            this.serial1.HeaderText = "Serial";
            this.serial1.Name = "serial1";
            this.serial1.ReadOnly = true;
            this.serial1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.serial1.Width = 150;
            // 
            // Confirm
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.NullValue = false;
            this.Confirm.DefaultCellStyle = dataGridViewCellStyle2;
            this.Confirm.HeaderText = "Confirmar";
            this.Confirm.Name = "Confirm";
            this.Confirm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Confirm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Confirm.Width = 65;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(8, 220);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(124, 23);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Salidas para Hoy:";
            // 
            // btn_confirm
            // 
            this.btn_confirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_confirm.BackColor = System.Drawing.Color.White;
            this.btn_confirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_confirm.Location = new System.Drawing.Point(627, 426);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(68, 23);
            this.btn_confirm.TabIndex = 9;
            this.btn_confirm.Text = "Aceptar";
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // grdSalida
            // 
            this.grdSalida.BackgroundColor = System.Drawing.Color.White;
            this.grdSalida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSalida.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdSalida.EnableHeadersVisualStyles = false;
            this.grdSalida.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdSalida.Location = new System.Drawing.Point(1, 249);
            this.grdSalida.Name = "grdSalida";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSalida.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdSalida.RowHeadersVisible = false;
            this.grdSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdSalida.Size = new System.Drawing.Size(701, 173);
            this.grdSalida.TabIndex = 8;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.NullValue = false;
            this.checkin.DefaultCellStyle = dataGridViewCellStyle6;
            this.checkin.FalseValue = "";
            this.checkin.HeaderText = "Confirmar";
            this.checkin.IndeterminateValue = "";
            this.checkin.Name = "checkin";
            this.checkin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkin.TrueValue = "";
            this.checkin.Width = 65;
            // 
            // lbl_entradas
            // 
            // 
            // 
            // 
            this.lbl_entradas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_entradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entradas.Location = new System.Drawing.Point(169, 10);
            this.lbl_entradas.Name = "lbl_entradas";
            this.lbl_entradas.Size = new System.Drawing.Size(339, 23);
            this.lbl_entradas.TabIndex = 12;
            this.lbl_entradas.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lbl_noti
            // 
            // 
            // 
            // 
            this.lbl_noti.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_noti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noti.Location = new System.Drawing.Point(169, 219);
            this.lbl_noti.Name = "lbl_noti";
            this.lbl_noti.Size = new System.Drawing.Size(339, 23);
            this.lbl_noti.TabIndex = 13;
            this.lbl_noti.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(555, 9);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(67, 23);
            this.buttonX2.TabIndex = 14;
            this.buttonX2.Text = "Salir";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(422, 9);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(127, 23);
            this.buttonX3.TabIndex = 15;
            this.buttonX3.Text = "Entradas Adelantadas";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // FrmPCPE_S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 453);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.lbl_noti);
            this.Controls.Add(this.lbl_entradas);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.grdSalida);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.grdentradaPCP);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPCPE_S";
            this.Load += new System.EventHandler(this.FrmPCPE_S_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdentradaPCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdentradaPCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mov1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Confirm;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btn_confirm;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdSalida;
        private DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn quien_autoriza;
        private System.Windows.Forms.DataGridViewTextBoxColumn trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipo;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn desde12;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn hasta12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkin;
        private DevComponents.DotNetBar.LabelX lbl_entradas;
        private DevComponents.DotNetBar.LabelX lbl_noti;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
    }
}