namespace ProfitContenedor
{
    partial class FrmR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmR));
            this.btnEFiltro = new DevComponents.DotNetBar.ButtonX();
            this.btnAFiltro = new DevComponents.DotNetBar.ButtonX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.grdDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.cboFuncion = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnBuscarRep = new DevComponents.DotNetBar.ButtonX();
            this.txtArchivo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtRuta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtTitulo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtCod_rep = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnPrimero = new DevComponents.DotNetBar.ButtonItem();
            this.btnAnterior = new DevComponents.DotNetBar.ButtonItem();
            this.btnSiguiente = new DevComponents.DotNetBar.ButtonItem();
            this.btnUltimo = new DevComponents.DotNetBar.ButtonItem();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonItem();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonItem();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonItem();
            this.btnDeshacer = new DevComponents.DotNetBar.ButtonItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEFiltro
            // 
            this.btnEFiltro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEFiltro.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEFiltro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEFiltro.Location = new System.Drawing.Point(448, 287);
            this.btnEFiltro.Name = "btnEFiltro";
            this.btnEFiltro.Size = new System.Drawing.Size(30, 22);
            this.btnEFiltro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEFiltro.TabIndex = 8;
            this.btnEFiltro.Text = "-";
            this.btnEFiltro.Click += new System.EventHandler(this.btnEFiltro_Click);
            // 
            // btnAFiltro
            // 
            this.btnAFiltro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAFiltro.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAFiltro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAFiltro.Location = new System.Drawing.Point(448, 259);
            this.btnAFiltro.Name = "btnAFiltro";
            this.btnAFiltro.Size = new System.Drawing.Size(30, 22);
            this.btnAFiltro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAFiltro.TabIndex = 7;
            this.btnAFiltro.Text = "+";
            this.btnAFiltro.Click += new System.EventHandler(this.btnAFiltro_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.ForeColor = System.Drawing.Color.Black;
            this.line1.Location = new System.Drawing.Point(12, 219);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(466, 23);
            this.line1.TabIndex = 44;
            this.line1.Text = "line1";
            this.line1.Thickness = 2;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(12, 235);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(48, 22);
            this.labelX6.TabIndex = 43;
            this.labelX6.Text = "Filtros:";
            // 
            // grdDatos
            // 
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Tipo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatos.Location = new System.Drawing.Point(12, 259);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(430, 129);
            this.grdDatos.TabIndex = 6;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre_par";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipo";
            this.Tipo.DisplayMember = "Text";
            this.Tipo.DropDownHeight = 106;
            this.Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo.DropDownWidth = 121;
            this.Tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Tipo.IntegralHeight = false;
            this.Tipo.ItemHeight = 17;
            this.Tipo.Items.AddRange(new object[] {
            "Char",
            "Int",
            "Decimal",
            "DateTime",
            "Time",
            "Bit"});
            this.Tipo.Name = "Tipo";
            this.Tipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tipo.Width = 200;
            // 
            // cboFuncion
            // 
            this.cboFuncion.DisplayMember = "Text";
            this.cboFuncion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncion.ForeColor = System.Drawing.Color.Black;
            this.cboFuncion.FormattingEnabled = true;
            this.cboFuncion.ItemHeight = 16;
            this.cboFuncion.Location = new System.Drawing.Point(66, 191);
            this.cboFuncion.Name = "cboFuncion";
            this.cboFuncion.Size = new System.Drawing.Size(244, 22);
            this.cboFuncion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboFuncion.TabIndex = 5;
            // 
            // btnBuscarRep
            // 
            this.btnBuscarRep.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscarRep.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscarRep.Location = new System.Drawing.Point(316, 133);
            this.btnBuscarRep.Name = "btnBuscarRep";
            this.btnBuscarRep.Size = new System.Drawing.Size(30, 22);
            this.btnBuscarRep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscarRep.TabIndex = 3;
            this.btnBuscarRep.Text = "...";
            this.btnBuscarRep.Click += new System.EventHandler(this.btnBuscarRep_Click);
            // 
            // txtArchivo
            // 
            // 
            // 
            // 
            this.txtArchivo.Border.Class = "TextBoxBorder";
            this.txtArchivo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtArchivo.DisabledBackColor = System.Drawing.Color.White;
            this.txtArchivo.ForeColor = System.Drawing.Color.Blue;
            this.txtArchivo.Location = new System.Drawing.Point(66, 133);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.PreventEnterBeep = true;
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(244, 22);
            this.txtArchivo.TabIndex = 2;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(12, 133);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(48, 22);
            this.labelX5.TabIndex = 38;
            this.labelX5.Text = "Archivo:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(12, 191);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(48, 22);
            this.labelX4.TabIndex = 35;
            this.labelX4.Text = "Función:";
            // 
            // txtRuta
            // 
            // 
            // 
            // 
            this.txtRuta.Border.Class = "TextBoxBorder";
            this.txtRuta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRuta.DisabledBackColor = System.Drawing.Color.White;
            this.txtRuta.ForeColor = System.Drawing.Color.Red;
            this.txtRuta.Location = new System.Drawing.Point(66, 163);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.PreventEnterBeep = true;
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(412, 22);
            this.txtRuta.TabIndex = 4;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(12, 163);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(48, 22);
            this.labelX3.TabIndex = 32;
            this.labelX3.Text = "Ruta:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTitulo.Border.Class = "TextBoxBorder";
            this.txtTitulo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTitulo.DisabledBackColor = System.Drawing.Color.White;
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.Location = new System.Drawing.Point(66, 105);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PreventEnterBeep = true;
            this.txtTitulo.Size = new System.Drawing.Size(244, 22);
            this.txtTitulo.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 105);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(48, 22);
            this.labelX2.TabIndex = 31;
            this.labelX2.Text = "Titulo:";
            // 
            // txtCod_rep
            // 
            this.txtCod_rep.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCod_rep.Border.Class = "TextBoxBorder";
            this.txtCod_rep.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCod_rep.DisabledBackColor = System.Drawing.Color.White;
            this.txtCod_rep.ForeColor = System.Drawing.Color.Black;
            this.txtCod_rep.Location = new System.Drawing.Point(66, 77);
            this.txtCod_rep.Name = "txtCod_rep";
            this.txtCod_rep.PreventEnterBeep = true;
            this.txtCod_rep.Size = new System.Drawing.Size(74, 22);
            this.txtCod_rep.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 77);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(48, 22);
            this.labelX1.TabIndex = 34;
            this.labelX1.Text = "Codigo:";
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.BackColor = System.Drawing.Color.White;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.ForeColor = System.Drawing.Color.Black;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPrimero,
            this.btnAnterior,
            this.btnSiguiente,
            this.btnUltimo,
            this.btnBuscar,
            this.btnNuevo,
            this.btnGuardar,
            this.btnEliminar,
            this.btnDeshacer});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(487, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 45;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnPrimero
            // 
            this.btnPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimero.Image")));
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Text = "btnPrimero";
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Text = "btnAnterior";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Text = "btnSiguiente";
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Text = "btnUltimo";
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Text = "btnBuscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarRep_Click);
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
            // btnDeshacer
            // 
            this.btnDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshacer.Image")));
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Text = "btnDeshacer";
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"Crystal Report|*.Rpt\"";
            // 
            // FrmR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 396);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.btnEFiltro);
            this.Controls.Add(this.btnAFiltro);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.cboFuncion);
            this.Controls.Add(this.btnBuscarRep);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtCod_rep);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FrmR";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FrmR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnEFiltro;
        private DevComponents.DotNetBar.ButtonX btnAFiltro;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdDatos;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboFuncion;
        private DevComponents.DotNetBar.ButtonX btnBuscarRep;
        private DevComponents.DotNetBar.Controls.TextBoxX txtArchivo;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRuta;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTitulo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCod_rep;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnPrimero;
        private DevComponents.DotNetBar.ButtonItem btnAnterior;
        private DevComponents.DotNetBar.ButtonItem btnSiguiente;
        private DevComponents.DotNetBar.ButtonItem btnUltimo;
        private DevComponents.DotNetBar.ButtonItem btnBuscar;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private DevComponents.DotNetBar.ButtonItem btnEliminar;
        private DevComponents.DotNetBar.ButtonItem btnDeshacer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn Tipo;
    }
}