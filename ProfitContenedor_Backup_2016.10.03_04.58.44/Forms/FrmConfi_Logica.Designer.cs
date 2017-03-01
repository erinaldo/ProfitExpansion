namespace ProfitContenedor
{
    partial class FrmConfi_Logica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfi_Logica));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonItem();
            this.btnAgregarR = new DevComponents.DotNetBar.ButtonItem();
            this.btnQuitar = new DevComponents.DotNetBar.ButtonItem();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radTxt_activo = new Telerik.WinControls.UI.RadTextBox();
            this.cbo_camposL = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.grd_CL = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.campo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxt_activo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_CL)).BeginInit();
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
            this.bar1.Size = new System.Drawing.Size(491, 41);
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
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.White;
            this.radLabel1.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Location = new System.Drawing.Point(12, 56);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(40, 18);
            this.radLabel1.TabIndex = 26;
            this.radLabel1.Text = "Activo:";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.White;
            this.radLabel2.ForeColor = System.Drawing.Color.Black;
            this.radLabel2.Location = new System.Drawing.Point(152, 56);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(81, 18);
            this.radLabel2.TabIndex = 27;
            this.radLabel2.Text = "Campo Logico:";
            // 
            // radTxt_activo
            // 
            this.radTxt_activo.BackColor = System.Drawing.Color.White;
            this.radTxt_activo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTxt_activo.Location = new System.Drawing.Point(58, 55);
            this.radTxt_activo.Name = "radTxt_activo";
            this.radTxt_activo.Size = new System.Drawing.Size(79, 23);
            this.radTxt_activo.TabIndex = 29;
            // 
            // cbo_camposL
            // 
            this.cbo_camposL.DisplayMember = "Text";
            this.cbo_camposL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_camposL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_camposL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_camposL.FormattingEnabled = true;
            this.cbo_camposL.ItemHeight = 16;
            this.cbo_camposL.Location = new System.Drawing.Point(239, 55);
            this.cbo_camposL.Name = "cbo_camposL";
            this.cbo_camposL.Size = new System.Drawing.Size(249, 22);
            this.cbo_camposL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_camposL.TabIndex = 30;
            // 
            // grd_CL
            // 
            this.grd_CL.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.grd_CL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grd_CL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_CL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.campo1,
            this.valor1,
            this.codigo,
            this.rowguid});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_CL.DefaultCellStyle = dataGridViewCellStyle1;
            this.grd_CL.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grd_CL.Location = new System.Drawing.Point(12, 98);
            this.grd_CL.Name = "grd_CL";
            this.grd_CL.RowHeadersVisible = false;
            this.grd_CL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grd_CL.Size = new System.Drawing.Size(476, 184);
            this.grd_CL.TabIndex = 31;
            // 
            // campo1
            // 
            this.campo1.DataPropertyName = "campo";
            this.campo1.HeaderText = "Campo";
            this.campo1.Name = "campo1";
            this.campo1.ReadOnly = true;
            this.campo1.Width = 220;
            // 
            // valor1
            // 
            this.valor1.DataPropertyName = "descripcion";
            this.valor1.HeaderText = "Valor";
            this.valor1.Name = "valor1";
            this.valor1.Width = 253;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "co_campo";
            this.codigo.HeaderText = "Co_Campo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // rowguid
            // 
            this.rowguid.DataPropertyName = "Rowguid";
            this.rowguid.HeaderText = "identificador";
            this.rowguid.Name = "rowguid";
            this.rowguid.ReadOnly = true;
            this.rowguid.Visible = false;
            // 
            // FrmConfi_Logica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 284);
            this.Controls.Add(this.grd_CL);
            this.Controls.Add(this.cbo_camposL);
            this.Controls.Add(this.radTxt_activo);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConfi_Logica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion Logica";
            this.Load += new System.EventHandler(this.FrmConfi_Logica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTxt_activo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_CL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnGuardar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox radTxt_activo;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_camposL;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_CL;
        private DevComponents.DotNetBar.ButtonItem btnAgregarR;
        private DevComponents.DotNetBar.ButtonItem btnQuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn campo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguid;
    }
}