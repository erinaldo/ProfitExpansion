namespace ProfitContenedor
{
    partial class FrmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbo_empresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_catalogo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_search = new Telerik.WinControls.UI.RadButton();
            this.Grd_busqueda = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.activo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_registro = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.ubicacion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogo3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_busqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_empresa
            // 
            this.cbo_empresa.BackColor = System.Drawing.Color.White;
            this.cbo_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empresa.ForeColor = System.Drawing.Color.Black;
            this.cbo_empresa.FormattingEnabled = true;
            this.cbo_empresa.Location = new System.Drawing.Point(62, 36);
            this.cbo_empresa.Name = "cbo_empresa";
            this.cbo_empresa.Size = new System.Drawing.Size(381, 21);
            this.cbo_empresa.TabIndex = 0;
            this.cbo_empresa.SelectedIndexChanged += new System.EventHandler(this.cbo_empresa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa:";
            // 
            // cbo_catalogo
            // 
            this.cbo_catalogo.BackColor = System.Drawing.Color.White;
            this.cbo_catalogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_catalogo.ForeColor = System.Drawing.Color.Black;
            this.cbo_catalogo.FormattingEnabled = true;
            this.cbo_catalogo.Location = new System.Drawing.Point(62, 65);
            this.cbo_catalogo.Name = "cbo_catalogo";
            this.cbo_catalogo.Size = new System.Drawing.Size(381, 21);
            this.cbo_catalogo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Catalogo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(132, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Busqueda Refinada";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Location = new System.Drawing.Point(449, 36);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(56, 50);
            this.btn_search.TabIndex = 6;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Grd_busqueda
            // 
            this.Grd_busqueda.AllowUserToResizeRows = false;
            this.Grd_busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_busqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activo2,
            this.descrip1,
            this.serial2,
            this.fecha_registro,
            this.ubicacion1,
            this.catalogo3,
            this.name});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grd_busqueda.DefaultCellStyle = dataGridViewCellStyle1;
            this.Grd_busqueda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.Grd_busqueda.Location = new System.Drawing.Point(4, 125);
            this.Grd_busqueda.Name = "Grd_busqueda";
            this.Grd_busqueda.RowHeadersVisible = false;
            this.Grd_busqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_busqueda.Size = new System.Drawing.Size(745, 259);
            this.Grd_busqueda.TabIndex = 7;
            this.Grd_busqueda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_busqueda_CellDoubleClick);
            // 
            // activo2
            // 
            this.activo2.DataPropertyName = "activo";
            this.activo2.HeaderText = "Activo";
            this.activo2.Name = "activo2";
            this.activo2.ReadOnly = true;
            this.activo2.Width = 70;
            // 
            // descrip1
            // 
            this.descrip1.DataPropertyName = "descripcion";
            this.descrip1.HeaderText = "Descripcion";
            this.descrip1.Name = "descrip1";
            this.descrip1.ReadOnly = true;
            this.descrip1.Width = 112;
            // 
            // serial2
            // 
            this.serial2.DataPropertyName = "serial";
            this.serial2.HeaderText = "Serial";
            this.serial2.Name = "serial2";
            this.serial2.ReadOnly = true;
            this.serial2.Width = 110;
            // 
            // fecha_registro
            // 
            // 
            // 
            // 
            this.fecha_registro.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.fecha_registro.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.fecha_registro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fecha_registro.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.fecha_registro.DataPropertyName = "adquisicion";
            this.fecha_registro.HeaderText = "Fec_Registro";
            this.fecha_registro.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.fecha_registro.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fecha_registro.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fecha_registro.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.fecha_registro.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fecha_registro.MonthCalendar.DisplayMonth = new System.DateTime(2016, 7, 1, 0, 0, 0, 0);
            this.fecha_registro.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.fecha_registro.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.fecha_registro.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fecha_registro.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.fecha_registro.Name = "fecha_registro";
            this.fecha_registro.ReadOnly = true;
            // 
            // ubicacion1
            // 
            this.ubicacion1.DataPropertyName = "ubicacion";
            this.ubicacion1.HeaderText = "Ubicacion";
            this.ubicacion1.Name = "ubicacion1";
            this.ubicacion1.ReadOnly = true;
            // 
            // catalogo3
            // 
            this.catalogo3.DataPropertyName = "catalogo";
            this.catalogo3.HeaderText = "Catalogo";
            this.catalogo3.Name = "catalogo3";
            this.catalogo3.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "nombre";
            this.name.HeaderText = "Empleado";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 386);
            this.Controls.Add(this.Grd_busqueda);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_catalogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_empresa);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_busqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadButton btn_search;
        private DevComponents.DotNetBar.Controls.DataGridViewX Grd_busqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial2;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn fecha_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogo3;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        public System.Windows.Forms.ComboBox cbo_empresa;
        public System.Windows.Forms.ComboBox cbo_catalogo;
    }
}