namespace ProfitContenedor
{
    partial class FrmOdcA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fact_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_emis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empresa,
            this.Fact_num,
            this.Fec_emis,
            this.Total_art,
            this.Pendiente});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(449, 198);
            this.grdDatos.TabIndex = 0;
            // 
            // Empresa
            // 
            this.Empresa.DataPropertyName = "empresa";
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // Fact_num
            // 
            this.Fact_num.DataPropertyName = "fact_num";
            dataGridViewCellStyle1.Format = "N0";
            this.Fact_num.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fact_num.HeaderText = "Numero";
            this.Fact_num.Name = "Fact_num";
            this.Fact_num.ReadOnly = true;
            this.Fact_num.Width = 80;
            // 
            // Fec_emis
            // 
            this.Fec_emis.DataPropertyName = "fec_emis";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Fec_emis.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fec_emis.HeaderText = "Fecha";
            this.Fec_emis.Name = "Fec_emis";
            this.Fec_emis.ReadOnly = true;
            this.Fec_emis.Width = 80;
            // 
            // Total_art
            // 
            this.Total_art.DataPropertyName = "total_art";
            dataGridViewCellStyle3.Format = "N2";
            this.Total_art.DefaultCellStyle = dataGridViewCellStyle3;
            this.Total_art.HeaderText = "Total";
            this.Total_art.Name = "Total_art";
            this.Total_art.ReadOnly = true;
            this.Total_art.Width = 80;
            // 
            // Pendiente
            // 
            this.Pendiente.DataPropertyName = "pendiente";
            dataGridViewCellStyle4.Format = "N2";
            this.Pendiente.DefaultCellStyle = dataGridViewCellStyle4;
            this.Pendiente.HeaderText = "Pendiente";
            this.Pendiente.Name = "Pendiente";
            this.Pendiente.ReadOnly = true;
            this.Pendiente.Width = 80;
            // 
            // FrmOdcA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 198);
            this.Controls.Add(this.grdDatos);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdcA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de Compra Abiertas";
            this.Load += new System.EventHandler(this.FrmOdcA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fact_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_emis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_art;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pendiente;
    }
}