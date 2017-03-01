namespace ProfitContenedor
{
    partial class FrmEntradaPCP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntradaPCP));
            this.grdentradaPCP = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_entradas = new DevComponents.DotNetBar.LabelX();
            this.id_mov1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fec_entraga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdentradaPCP)).BeginInit();
            this.SuspendLayout();
            // 
            // grdentradaPCP
            // 
            this.grdentradaPCP.BackgroundColor = System.Drawing.Color.White;
            this.grdentradaPCP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdentradaPCP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdentradaPCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdentradaPCP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_mov1,
            this.empleado1,
            this.activo1,
            this.descrip,
            this.serial1,
            this.fec_entraga,
            this.Confirm});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdentradaPCP.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdentradaPCP.EnableHeadersVisualStyles = false;
            this.grdentradaPCP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.grdentradaPCP.Location = new System.Drawing.Point(1, 31);
            this.grdentradaPCP.Name = "grdentradaPCP";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdentradaPCP.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdentradaPCP.RowHeadersVisible = false;
            this.grdentradaPCP.Size = new System.Drawing.Size(830, 175);
            this.grdentradaPCP.TabIndex = 0;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(758, 3);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(67, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Text = "Aceptar";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_exit.Location = new System.Drawing.Point(687, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(67, 23);
            this.btn_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Salir";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_entradas
            // 
            // 
            // 
            // 
            this.lbl_entradas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_entradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entradas.Location = new System.Drawing.Point(196, 3);
            this.lbl_entradas.Name = "lbl_entradas";
            this.lbl_entradas.Size = new System.Drawing.Size(241, 23);
            this.lbl_entradas.TabIndex = 4;
            this.lbl_entradas.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // id_mov1
            // 
            this.id_mov1.DataPropertyName = "id_mov";
            this.id_mov1.HeaderText = "ID_mov";
            this.id_mov1.Name = "id_mov1";
            this.id_mov1.Visible = false;
            // 
            // empleado1
            // 
            this.empleado1.DataPropertyName = "empleado";
            this.empleado1.HeaderText = "Empleado";
            this.empleado1.Name = "empleado1";
            this.empleado1.ReadOnly = true;
            this.empleado1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.empleado1.Width = 230;
            // 
            // activo1
            // 
            this.activo1.DataPropertyName = "activo";
            this.activo1.HeaderText = "Activo";
            this.activo1.Name = "activo1";
            this.activo1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // descrip
            // 
            this.descrip.DataPropertyName = "descripcion";
            this.descrip.HeaderText = "Descripcion";
            this.descrip.Name = "descrip";
            this.descrip.ReadOnly = true;
            this.descrip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descrip.Width = 150;
            // 
            // serial1
            // 
            this.serial1.DataPropertyName = "serial";
            this.serial1.HeaderText = "Serial";
            this.serial1.Name = "serial1";
            this.serial1.ReadOnly = true;
            this.serial1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.serial1.Width = 150;
            // 
            // fec_entraga
            // 
            this.fec_entraga.DataPropertyName = "fecha_entrega";
            this.fec_entraga.HeaderText = "Fecha de Entrega";
            this.fec_entraga.Name = "fec_entraga";
            this.fec_entraga.ReadOnly = true;
            this.fec_entraga.Width = 130;
            // 
            // Confirm
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.NullValue = false;
            this.Confirm.DefaultCellStyle = dataGridViewCellStyle2;
            this.Confirm.HeaderText = "Confirmar";
            this.Confirm.Name = "Confirm";
            this.Confirm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Confirm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Confirm.Width = 65;
            // 
            // FrmEntradaPCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 208);
            this.Controls.Add(this.lbl_entradas);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.grdentradaPCP);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEntradaPCP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmEntradaPCP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdentradaPCP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX grdentradaPCP;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.LabelX lbl_entradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mov1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fec_entraga;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Confirm;
    }
}