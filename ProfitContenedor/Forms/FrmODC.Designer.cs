namespace ProfitContenedor
{
    partial class FrmODC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtFact_num = new DevComponents.Editors.IntegerInput();
            this.txtDescrip = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmpresa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnConsultar = new DevComponents.DotNetBar.ButtonX();
            this.grdDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.co_art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.art_des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sel = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.total_imp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fact_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImportar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtProv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtFecha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblStatus = new DevComponents.DotNetBar.LabelX();
            this.btnSeleccionar = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtFact_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 41);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 17);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "# Orden:";
            // 
            // txtFact_num
            // 
            this.txtFact_num.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFact_num.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtFact_num.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFact_num.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtFact_num.ForeColor = System.Drawing.Color.Black;
            this.txtFact_num.Location = new System.Drawing.Point(93, 38);
            this.txtFact_num.Name = "txtFact_num";
            this.txtFact_num.Size = new System.Drawing.Size(65, 20);
            this.txtFact_num.TabIndex = 0;
            this.txtFact_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFact_num_KeyDown);
            // 
            // txtDescrip
            // 
            this.txtDescrip.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDescrip.Border.Class = "TextBoxBorder";
            this.txtDescrip.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescrip.DisabledBackColor = System.Drawing.Color.White;
            this.txtDescrip.Enabled = false;
            this.txtDescrip.ForeColor = System.Drawing.Color.Black;
            this.txtDescrip.Location = new System.Drawing.Point(164, 12);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(228, 20);
            this.txtDescrip.TabIndex = 2;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmpresa.Border.Class = "TextBoxBorder";
            this.txtEmpresa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpresa.DisabledBackColor = System.Drawing.Color.White;
            this.txtEmpresa.ForeColor = System.Drawing.Color.Black;
            this.txtEmpresa.Location = new System.Drawing.Point(93, 12);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(65, 20);
            this.txtEmpresa.TabIndex = 1;
            this.txtEmpresa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpresa_KeyDown);
            this.txtEmpresa.Leave += new System.EventHandler(this.txtEmpresa_Leave);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(12, 12);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "Empresa:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConsultar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConsultar.Location = new System.Drawing.Point(164, 38);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(103, 20);
            this.btnConsultar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.co_art,
            this.art_des,
            this.total_art,
            this.sel,
            this.total_imp,
            this.empresa,
            this.fact_num});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatos.Location = new System.Drawing.Point(12, 119);
            this.grdDatos.Name = "grdDatos";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdDatos.Size = new System.Drawing.Size(726, 333);
            this.grdDatos.TabIndex = 8;
            this.grdDatos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellEndEdit);
            // 
            // co_art
            // 
            this.co_art.DataPropertyName = "co_art";
            this.co_art.HeaderText = "Codigo";
            this.co_art.Name = "co_art";
            this.co_art.ReadOnly = true;
            this.co_art.Width = 120;
            // 
            // art_des
            // 
            this.art_des.DataPropertyName = "art_des";
            this.art_des.HeaderText = "Descripción";
            this.art_des.Name = "art_des";
            this.art_des.ReadOnly = true;
            this.art_des.Width = 350;
            // 
            // total_art
            // 
            this.total_art.DataPropertyName = "total_art";
            dataGridViewCellStyle2.Format = "N2";
            this.total_art.DefaultCellStyle = dataGridViewCellStyle2;
            this.total_art.HeaderText = "Cantidad";
            this.total_art.Name = "total_art";
            this.total_art.ReadOnly = true;
            this.total_art.Width = 80;
            // 
            // sel
            // 
            this.sel.Checked = true;
            this.sel.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.sel.CheckValue = "N";
            this.sel.DataPropertyName = "sel";
            this.sel.HeaderText = "S.";
            this.sel.Name = "sel";
            this.sel.Width = 30;
            // 
            // total_imp
            // 
            this.total_imp.DataPropertyName = "total_imp";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.total_imp.DefaultCellStyle = dataGridViewCellStyle3;
            this.total_imp.HeaderText = "Importar";
            this.total_imp.Name = "total_imp";
            this.total_imp.Width = 80;
            // 
            // empresa
            // 
            this.empresa.HeaderText = "empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            this.empresa.Visible = false;
            // 
            // fact_num
            // 
            this.fact_num.HeaderText = "Orden";
            this.fact_num.Name = "fact_num";
            this.fact_num.ReadOnly = true;
            this.fact_num.Visible = false;
            // 
            // btnImportar
            // 
            this.btnImportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportar.Location = new System.Drawing.Point(582, 458);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportar.TabIndex = 9;
            this.btnImportar.Text = "&Importar";
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Location = new System.Drawing.Point(663, 458);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "C&ancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 93);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 17);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Proveedor:";
            // 
            // txtProv
            // 
            this.txtProv.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtProv.Border.Class = "TextBoxBorder";
            this.txtProv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProv.DisabledBackColor = System.Drawing.Color.White;
            this.txtProv.Enabled = false;
            this.txtProv.ForeColor = System.Drawing.Color.Black;
            this.txtProv.Location = new System.Drawing.Point(93, 93);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(299, 20);
            this.txtProv.TabIndex = 7;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(12, 67);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 17);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Fecha:";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(164, 67);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(37, 17);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "Status:";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFecha.Border.Class = "TextBoxBorder";
            this.txtFecha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFecha.DisabledBackColor = System.Drawing.Color.White;
            this.txtFecha.Enabled = false;
            this.txtFecha.ForeColor = System.Drawing.Color.Black;
            this.txtFecha.Location = new System.Drawing.Point(93, 64);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(65, 20);
            this.txtFecha.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(205, 67);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 17);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSeleccionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSeleccionar.Location = new System.Drawing.Point(633, 93);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(105, 23);
            this.btnSeleccionar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSeleccionar.TabIndex = 8;
            this.btnSeleccionar.Text = "&Seleccionar todo...";
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2013;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // FrmODC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 522);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtProv);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtFact_num);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmODC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Ordenes de Compra";
            this.Load += new System.EventHandler(this.FrmODC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFact_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput txtFact_num;
        public DevComponents.DotNetBar.Controls.TextBoxX txtDescrip;
        public DevComponents.DotNetBar.Controls.TextBoxX txtEmpresa;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnConsultar;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdDatos;
        private DevComponents.DotNetBar.ButtonX btnImportar;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.DotNetBar.Controls.TextBoxX txtProv;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX5;
        public DevComponents.DotNetBar.Controls.TextBoxX txtFecha;
        private DevComponents.DotNetBar.LabelX lblStatus;
        private DevComponents.DotNetBar.ButtonX btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_art;
        private System.Windows.Forms.DataGridViewTextBoxColumn art_des;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_art;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_imp;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fact_num;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}