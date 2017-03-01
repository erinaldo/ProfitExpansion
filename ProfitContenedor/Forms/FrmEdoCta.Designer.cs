namespace ProfitContenedor
{
    partial class FrmEdoCta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prov_des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fact_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
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
            this.empresa,
            this.co_prov,
            this.prov_des,
            this.fact_num,
            this.monto,
            this.abono,
            this.saldo});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(917, 439);
            this.grdDatos.TabIndex = 0;
            // 
            // empresa
            // 
            this.empresa.DataPropertyName = "empresa";
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            this.empresa.Width = 70;
            // 
            // co_prov
            // 
            this.co_prov.DataPropertyName = "co_prov";
            this.co_prov.HeaderText = "Codigo";
            this.co_prov.Name = "co_prov";
            this.co_prov.ReadOnly = true;
            this.co_prov.Width = 70;
            // 
            // prov_des
            // 
            this.prov_des.DataPropertyName = "prov_des";
            this.prov_des.HeaderText = "Nombre";
            this.prov_des.Name = "prov_des";
            this.prov_des.ReadOnly = true;
            this.prov_des.Width = 300;
            // 
            // fact_num
            // 
            this.fact_num.DataPropertyName = "fact_num";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fact_num.DefaultCellStyle = dataGridViewCellStyle2;
            this.fact_num.HeaderText = "Orden";
            this.fact_num.Name = "fact_num";
            this.fact_num.ReadOnly = true;
            this.fact_num.Width = 70;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.monto.DefaultCellStyle = dataGridViewCellStyle3;
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 80;
            // 
            // abono
            // 
            this.abono.DataPropertyName = "abono";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.abono.DefaultCellStyle = dataGridViewCellStyle4;
            this.abono.HeaderText = "Abono";
            this.abono.Name = "abono";
            this.abono.ReadOnly = true;
            this.abono.Width = 80;
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.saldo.DefaultCellStyle = dataGridViewCellStyle5;
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2013;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // FrmEdoCta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 439);
            this.Controls.Add(this.grdDatos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEdoCta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado de cuenta de Ordenes";
            this.Load += new System.EventHandler(this.FrmEdoCta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn prov_des;
        private System.Windows.Forms.DataGridViewTextBoxColumn fact_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}