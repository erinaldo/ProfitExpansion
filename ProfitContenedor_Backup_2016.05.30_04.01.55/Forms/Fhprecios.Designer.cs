namespace ProfitContenedor
{
    partial class Fhprecios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.grdDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Precio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Precio1,
            this.Precio2,
            this.Precio3,
            this.Precio4,
            this.Fecha});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatos.Location = new System.Drawing.Point(0, 0);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(456, 266);
            this.grdDatos.TabIndex = 0;
            // 
            // Precio1
            // 
            this.Precio1.DataPropertyName = "prec_vta1";
            dataGridViewCellStyle1.Format = "N2";
            this.Precio1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Precio1.HeaderText = "Precio 1";
            this.Precio1.Name = "Precio1";
            this.Precio1.ReadOnly = true;
            this.Precio1.Width = 70;
            // 
            // Precio2
            // 
            this.Precio2.DataPropertyName = "prec_vta2";
            dataGridViewCellStyle2.Format = "N2";
            this.Precio2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio2.HeaderText = "Precio 2";
            this.Precio2.Name = "Precio2";
            this.Precio2.ReadOnly = true;
            this.Precio2.Width = 70;
            // 
            // Precio3
            // 
            this.Precio3.DataPropertyName = "prec_vta3";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Format = "N2";
            this.Precio3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Precio3.HeaderText = "Precio 3";
            this.Precio3.Name = "Precio3";
            this.Precio3.ReadOnly = true;
            this.Precio3.Width = 70;
            // 
            // Precio4
            // 
            this.Precio4.DataPropertyName = "prec_vta4";
            dataGridViewCellStyle4.Format = "N2";
            this.Precio4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Precio4.HeaderText = "Precio 4";
            this.Precio4.Name = "Precio4";
            this.Precio4.ReadOnly = true;
            this.Precio4.Width = 70;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fec_emis";
            dataGridViewCellStyle5.Format = "g";
            dataGridViewCellStyle5.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle5;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(0, 272);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.DataType = typeof(double);
            gridViewTextBoxColumn1.FieldName = "prec_vta1";
            gridViewTextBoxColumn1.HeaderText = "Precio 1";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 48;
            gridViewTextBoxColumn2.DataType = typeof(double);
            gridViewTextBoxColumn2.FieldName = "prec_vta2";
            gridViewTextBoxColumn2.HeaderText = "Precio 2";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 48;
            gridViewTextBoxColumn3.DataType = typeof(double);
            gridViewTextBoxColumn3.FieldName = "prec_vta3";
            gridViewTextBoxColumn3.HeaderText = "Precio 3";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 48;
            gridViewTextBoxColumn4.DataType = typeof(double);
            gridViewTextBoxColumn4.FieldName = "prec_vta4";
            gridViewTextBoxColumn4.HeaderText = "Precio 4";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 48;
            gridViewTextBoxColumn5.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn5.FieldName = "fec_emis";
            gridViewTextBoxColumn5.HeaderText = "Fecha";
            gridViewTextBoxColumn5.Name = "column5";
            gridViewTextBoxColumn5.Width = 37;
            gridViewTextBoxColumn6.DataType = typeof(decimal);
            gridViewTextBoxColumn6.EnableExpressionEditor = true;
            gridViewTextBoxColumn6.Expression = "AVG(column3) ";
            gridViewTextBoxColumn6.FieldName = "prec_vta3";
            gridViewTextBoxColumn6.HeaderText = "column6";
            gridViewTextBoxColumn6.Name = "column6";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            sortDescriptor1.PropertyName = "fec_emis";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView1.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(456, 210);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "ControlDefault";
            // 
            // Fhprecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 494);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.grdDatos);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fhprecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico de precios";
            this.Load += new System.EventHandler(this.Fhprecios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}