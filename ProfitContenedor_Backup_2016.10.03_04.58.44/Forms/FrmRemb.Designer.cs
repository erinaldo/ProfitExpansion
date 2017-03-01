namespace ProfitContenedor
{
    partial class FrmRemb
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
            this.grdDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fact_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.art_des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguid = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.fact_num,
            this.co_art,
            this.art_des,
            this.total_art,
            this.rowguid});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(854, 385);
            this.grdDatos.TabIndex = 1;
            // 
            // empresa
            // 
            this.empresa.DataPropertyName = "empresa";
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            this.empresa.Width = 70;
            // 
            // fact_num
            // 
            this.fact_num.DataPropertyName = "fact_num";
            this.fact_num.HeaderText = "Orden";
            this.fact_num.Name = "fact_num";
            this.fact_num.ReadOnly = true;
            this.fact_num.Width = 80;
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
            this.art_des.Width = 450;
            // 
            // total_art
            // 
            this.total_art.DataPropertyName = "total_art";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.total_art.DefaultCellStyle = dataGridViewCellStyle2;
            this.total_art.HeaderText = "Cantidad";
            this.total_art.Name = "total_art";
            this.total_art.ReadOnly = true;
            this.total_art.Width = 70;
            // 
            // rowguid
            // 
            this.rowguid.DataPropertyName = "rowguid";
            this.rowguid.HeaderText = "rowguid";
            this.rowguid.Name = "rowguid";
            this.rowguid.ReadOnly = true;
            this.rowguid.Visible = false;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2013;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // FrmRemb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 385);
            this.Controls.Add(this.grdDatos);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRemb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del embarque";
            this.Load += new System.EventHandler(this.FrmRemb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Controls.DataGridViewX grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fact_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_art;
        private System.Windows.Forms.DataGridViewTextBoxColumn art_des;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_art;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguid;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}