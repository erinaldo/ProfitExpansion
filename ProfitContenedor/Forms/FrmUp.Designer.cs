namespace ProfitContenedor
{
    partial class FrmUp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUp));
            this.cbo1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.grdDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnAgregarR = new DevComponents.DotNetBar.ButtonItem();
            this.btnQuitar = new DevComponents.DotNetBar.ButtonItem();
            this.lbl1 = new DevComponents.DotNetBar.LabelX();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo1
            // 
            this.cbo1.DisplayMember = "Text";
            this.cbo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1.ForeColor = System.Drawing.Color.Black;
            this.cbo1.FormattingEnabled = true;
            this.cbo1.ItemHeight = 16;
            this.cbo1.Location = new System.Drawing.Point(0, 72);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(443, 22);
            this.cbo1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo1.TabIndex = 0;
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
            this.Codigo,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdDatos.Location = new System.Drawing.Point(0, 100);
            this.grdDatos.Name = "grdDatos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(443, 296);
            this.grdDatos.TabIndex = 1;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.BackColor = System.Drawing.Color.White;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.ForeColor = System.Drawing.Color.Black;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAgregarR,
            this.btnQuitar});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(443, 41);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 13;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
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
            // lbl1
            // 
            // 
            // 
            // 
            this.lbl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl1.Location = new System.Drawing.Point(0, 52);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(75, 14);
            this.lbl1.TabIndex = 14;
            this.lbl1.Text = "labelX1";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Column1";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 320;
            // 
            // FrmUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 396);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.cbo1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FrmUp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion de Acceso a Programas de Envios";
            this.Load += new System.EventHandler(this.FrmUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo1;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdDatos;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnAgregarR;
        private DevComponents.DotNetBar.ButtonItem btnQuitar;
        private DevComponents.DotNetBar.LabelX lbl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}