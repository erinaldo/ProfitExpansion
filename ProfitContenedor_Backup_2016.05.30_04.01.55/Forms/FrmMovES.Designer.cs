﻿namespace ProfitContenedor
{
    partial class FrmMovES
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.movimient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoriza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fech = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.activ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desd = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.hast = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.salida = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.entr = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.stat = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.entradPCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salid_pcp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos2
            // 
            this.grdDatos2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movimient,
            this.autoriza,
            this.fech,
            this.activ,
            this.desd,
            this.hast,
            this.salida,
            this.entr,
            this.stat,
            this.entradPCP,
            this.salid_pcp});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos2.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdDatos2.EnableHeadersVisualStyles = false;
            this.grdDatos2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatos2.Location = new System.Drawing.Point(2, 12);
            this.grdDatos2.Name = "grdDatos2";
            this.grdDatos2.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos2.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdDatos2.Size = new System.Drawing.Size(1107, 363);
            this.grdDatos2.TabIndex = 0;
            // 
            // movimient
            // 
            this.movimient.DataPropertyName = "id_movimiento";
            this.movimient.HeaderText = "ID_Movimiento";
            this.movimient.Name = "movimient";
            this.movimient.ReadOnly = true;
            // 
            // autoriza
            // 
            this.autoriza.DataPropertyName = "autoriza";
            this.autoriza.HeaderText = "Autorizacion";
            this.autoriza.Name = "autoriza";
            this.autoriza.ReadOnly = true;
            // 
            // fech
            // 
            // 
            // 
            // 
            this.fech.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.fech.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.fech.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fech.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.fech.DataPropertyName = "date";
            this.fech.HeaderText = "Fecha";
            this.fech.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.fech.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fech.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fech.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.fech.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fech.MonthCalendar.DisplayMonth = new System.DateTime(2016, 4, 1, 0, 0, 0, 0);
            this.fech.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.fech.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fech.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fech.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.fech.Name = "fech";
            this.fech.ReadOnly = true;
            // 
            // activ
            // 
            this.activ.DataPropertyName = "activo";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activ.DefaultCellStyle = dataGridViewCellStyle2;
            this.activ.HeaderText = "Activo";
            this.activ.Name = "activ";
            this.activ.ReadOnly = true;
            this.activ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.activ.Width = 50;
            // 
            // desd
            // 
            // 
            // 
            // 
            this.desd.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.desd.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.desd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.desd.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.desd.DataPropertyName = "desde";
            dataGridViewCellStyle3.NullValue = null;
            this.desd.DefaultCellStyle = dataGridViewCellStyle3;
            this.desd.HeaderText = "Desde";
            this.desd.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.desd.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.desd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.desd.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.desd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.desd.MonthCalendar.DisplayMonth = new System.DateTime(2016, 5, 1, 0, 0, 0, 0);
            this.desd.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.desd.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.desd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.desd.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.desd.Name = "desd";
            this.desd.ReadOnly = true;
            this.desd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // hast
            // 
            // 
            // 
            // 
            this.hast.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.hast.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.hast.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hast.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.hast.DataPropertyName = "hasta";
            this.hast.HeaderText = "Hasta";
            this.hast.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.hast.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.hast.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hast.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.hast.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hast.MonthCalendar.DisplayMonth = new System.DateTime(2016, 5, 1, 0, 0, 0, 0);
            this.hast.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.hast.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.hast.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hast.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.hast.Name = "hast";
            this.hast.ReadOnly = true;
            this.hast.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // salida
            // 
            // 
            // 
            // 
            this.salida.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.salida.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.salida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.salida.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.salida.DataPropertyName = "confirmar_salida";
            dataGridViewCellStyle4.NullValue = null;
            this.salida.DefaultCellStyle = dataGridViewCellStyle4;
            this.salida.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime;
            this.salida.HeaderText = "Salida";
            this.salida.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.salida.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.salida.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.salida.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.salida.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.salida.MonthCalendar.DisplayMonth = new System.DateTime(2016, 4, 1, 0, 0, 0, 0);
            this.salida.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.salida.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.salida.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.salida.MonthCalendar.Visible = false;
            this.salida.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.salida.Name = "salida";
            this.salida.ReadOnly = true;
            // 
            // entr
            // 
            // 
            // 
            // 
            this.entr.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.entr.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.entr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.entr.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.entr.DataPropertyName = "confirmar_entrada";
            dataGridViewCellStyle5.NullValue = null;
            this.entr.DefaultCellStyle = dataGridViewCellStyle5;
            this.entr.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime;
            this.entr.HeaderText = "Entrada";
            this.entr.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.entr.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.entr.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.entr.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.entr.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.entr.MonthCalendar.DisplayMonth = new System.DateTime(2016, 4, 1, 0, 0, 0, 0);
            this.entr.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.entr.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.entr.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.entr.MonthCalendar.Visible = false;
            this.entr.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.entr.Name = "entr";
            this.entr.ReadOnly = true;
            // 
            // stat
            // 
            // 
            // 
            // 
            this.stat.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.stat.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.stat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.stat.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.stat.DataPropertyName = "status";
            this.stat.HeaderText = "Status";
            this.stat.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.stat.Name = "stat";
            this.stat.ReadOnly = true;
            this.stat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // entradPCP
            // 
            this.entradPCP.DataPropertyName = "pcp_entrada";
            this.entradPCP.HeaderText = "Entrada_PCP";
            this.entradPCP.Name = "entradPCP";
            this.entradPCP.ReadOnly = true;
            this.entradPCP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // salid_pcp
            // 
            this.salid_pcp.DataPropertyName = "pcp_salida";
            this.salid_pcp.HeaderText = "Salida_PCP";
            this.salid_pcp.Name = "salid_pcp";
            this.salid_pcp.ReadOnly = true;
            // 
            // FrmMovES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 377);
            this.Controls.Add(this.grdDatos2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "FrmMovES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMovES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX grdDatos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn movimient;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoriza;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn fech;
        private System.Windows.Forms.DataGridViewTextBoxColumn activ;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn desd;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn hast;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn salida;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn entr;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn stat;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradPCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn salid_pcp;
    }
}