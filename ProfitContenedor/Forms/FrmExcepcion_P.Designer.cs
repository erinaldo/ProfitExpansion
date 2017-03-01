namespace ProfitContenedor
{
    partial class FrmExcepcion_P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExcepcion_P));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnImprimir = new DevComponents.DotNetBar.ButtonItem();
            this.btnDeshacer = new DevComponents.DotNetBar.ButtonItem();
            this.Bar = new DevComponents.DotNetBar.Bar();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonItem();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonItem();
            this.grdDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboPreparador = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.chkActivar = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkInactivar = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtMotivo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDeshacer});
            this.btnImprimir.Text = "btnDeshacer";
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshacer.Image")));
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Text = "btnDeshacer";
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
            this.Bar.Size = new System.Drawing.Size(736, 41);
            this.Bar.Stretch = true;
            this.Bar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Bar.TabIndex = 1;
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
            this.Empresa,
            this.Cod_emp,
            this.Nombre,
            this.Status,
            this.Fecha,
            this.Motivo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatos.Location = new System.Drawing.Point(0, 153);
            this.grdDatos.Name = "grdDatos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(736, 242);
            this.grdDatos.TabIndex = 4;
            // 
            // Empresa
            // 
            this.Empresa.DataPropertyName = "empresa";
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            this.Empresa.Width = 70;
            // 
            // Cod_emp
            // 
            this.Cod_emp.DataPropertyName = "cod_emp";
            this.Cod_emp.HeaderText = "Codigo";
            this.Cod_emp.Name = "Cod_emp";
            this.Cod_emp.ReadOnly = true;
            this.Cod_emp.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre_completo";
            this.Nombre.HeaderText = "Preparador";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Estado";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 70;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Width = 210;
            // 
            // cboPreparador
            // 
            this.cboPreparador.DisplayMember = "Text";
            this.cboPreparador.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPreparador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPreparador.ForeColor = System.Drawing.Color.Black;
            this.cboPreparador.FormattingEnabled = true;
            this.cboPreparador.ItemHeight = 16;
            this.cboPreparador.Location = new System.Drawing.Point(3, 25);
            this.cboPreparador.Name = "cboPreparador";
            this.cboPreparador.Size = new System.Drawing.Size(314, 22);
            this.cboPreparador.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboPreparador.TabIndex = 0;
            // 
            // chkActivar
            // 
            this.chkActivar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkActivar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkActivar.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkActivar.ForeColor = System.Drawing.Color.Black;
            this.chkActivar.Location = new System.Drawing.Point(324, 25);
            this.chkActivar.Name = "chkActivar";
            this.chkActivar.Size = new System.Drawing.Size(80, 21);
            this.chkActivar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkActivar.TabIndex = 1;
            this.chkActivar.Text = "Activar";
            this.chkActivar.TextColor = System.Drawing.Color.Green;
            // 
            // chkInactivar
            // 
            this.chkInactivar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkInactivar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkInactivar.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkInactivar.ForeColor = System.Drawing.Color.Black;
            this.chkInactivar.Location = new System.Drawing.Point(410, 25);
            this.chkInactivar.Name = "chkInactivar";
            this.chkInactivar.Size = new System.Drawing.Size(80, 21);
            this.chkInactivar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkInactivar.TabIndex = 2;
            this.chkInactivar.Text = "Inactivar";
            this.chkInactivar.TextColor = System.Drawing.Color.Red;
            // 
            // txtMotivo
            // 
            this.txtMotivo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMotivo.Border.Class = "TextBoxBorder";
            this.txtMotivo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMotivo.DisabledBackColor = System.Drawing.Color.White;
            this.txtMotivo.ForeColor = System.Drawing.Color.Black;
            this.txtMotivo.Location = new System.Drawing.Point(3, 72);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PreventEnterBeep = true;
            this.txtMotivo.Size = new System.Drawing.Size(730, 22);
            this.txtMotivo.TabIndex = 3;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 16);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Preparador:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(3, 53);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 16);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Motivo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.cboPreparador);
            this.panel1.Controls.Add(this.chkActivar);
            this.panel1.Controls.Add(this.txtMotivo);
            this.panel1.Controls.Add(this.chkInactivar);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 100);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // FrmExcepcion_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.Bar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExcepcion_P";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excepciones para preparadores";
            this.Load += new System.EventHandler(this.FrmExcepcion_P_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem btnImprimir;
        private DevComponents.DotNetBar.ButtonItem btnDeshacer;
        private DevComponents.DotNetBar.Bar Bar;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private DevComponents.DotNetBar.ButtonItem btnEliminar;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdDatos;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboPreparador;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkActivar;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkInactivar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMotivo;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.Panel panel1;

    }
}