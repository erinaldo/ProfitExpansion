namespace ProfitContenedor
{
    partial class FrmClave
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGenerar = new DevComponents.DotNetBar.ButtonX();
            this.cboUsuario = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboEmpresa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.GrdDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_venc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant_Gen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_usu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rowguid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFec_Venc = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtCantidad = new DevComponents.Editors.IntegerInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnAnular = new DevComponents.DotNetBar.ButtonX();
            this.GrdDatosDoc = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Tipo_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_emis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Co_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_bru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_imp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFec_Venc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDatosDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGenerar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGenerar.Location = new System.Drawing.Point(533, 53);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(117, 22);
            this.btnGenerar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cboUsuario
            // 
            this.cboUsuario.DisplayMember = "Text";
            this.cboUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.ItemHeight = 16;
            this.cboUsuario.Location = new System.Drawing.Point(12, 53);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(121, 22);
            this.cboUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboUsuario.TabIndex = 4;
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.DisplayMember = "Text";
            this.cboEmpresa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.ItemHeight = 16;
            this.cboEmpresa.Location = new System.Drawing.Point(139, 53);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(177, 22);
            this.cboEmpresa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboEmpresa.TabIndex = 5;
            // 
            // GrdDatos
            // 
            this.GrdDatos.AllowUserToAddRows = false;
            this.GrdDatos.AllowUserToResizeColumns = false;
            this.GrdDatos.AllowUserToResizeRows = false;
            this.GrdDatos.BackgroundColor = System.Drawing.Color.White;
            this.GrdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Co_usuario,
            this.Empresa,
            this.Fec_venc,
            this.Cantidad,
            this.Cant_Gen,
            this.Status,
            this.co_usu,
            this.Rowguid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.GrdDatos.Location = new System.Drawing.Point(12, 105);
            this.GrdDatos.MultiSelect = false;
            this.GrdDatos.Name = "GrdDatos";
            this.GrdDatos.RowHeadersVisible = false;
            this.GrdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdDatos.Size = new System.Drawing.Size(708, 262);
            this.GrdDatos.TabIndex = 6;
            this.GrdDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDatos_CellClick);
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "clave";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.Clave.DefaultCellStyle = dataGridViewCellStyle1;
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Width = 110;
            // 
            // Co_usuario
            // 
            this.Co_usuario.DataPropertyName = "last_name";
            this.Co_usuario.HeaderText = "Usuario";
            this.Co_usuario.Name = "Co_usuario";
            this.Co_usuario.ReadOnly = true;
            this.Co_usuario.Width = 110;
            // 
            // Empresa
            // 
            this.Empresa.DataPropertyName = "empresa";
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            this.Empresa.Width = 120;
            // 
            // Fec_venc
            // 
            this.Fec_venc.DataPropertyName = "fec_venc";
            this.Fec_venc.HeaderText = "Fecha Venc.";
            this.Fec_venc.Name = "Fec_venc";
            this.Fec_venc.ReadOnly = true;
            this.Fec_venc.Width = 110;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 80;
            // 
            // Cant_Gen
            // 
            this.Cant_Gen.DataPropertyName = "Cant_gene";
            this.Cant_Gen.HeaderText = "Cant. Gen.";
            this.Cant_Gen.Name = "Cant_Gen";
            this.Cant_Gen.ReadOnly = true;
            this.Cant_Gen.Width = 90;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "anulada";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 60;
            // 
            // co_usu
            // 
            this.co_usu.DataPropertyName = "co_usuario";
            this.co_usu.HeaderText = "Co_usuario";
            this.co_usu.Name = "co_usu";
            this.co_usu.ReadOnly = true;
            this.co_usu.Visible = false;
            // 
            // Rowguid
            // 
            this.Rowguid.DataPropertyName = "rowguid";
            this.Rowguid.HeaderText = "Rowguid";
            this.Rowguid.Name = "Rowguid";
            this.Rowguid.ReadOnly = true;
            this.Rowguid.Visible = false;
            this.Rowguid.Width = 200;
            // 
            // txtFec_Venc
            // 
            // 
            // 
            // 
            this.txtFec_Venc.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtFec_Venc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFec_Venc.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtFec_Venc.ButtonDropDown.Visible = true;
            this.txtFec_Venc.IsPopupCalendarOpen = false;
            this.txtFec_Venc.Location = new System.Drawing.Point(323, 53);
            // 
            // 
            // 
            this.txtFec_Venc.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtFec_Venc.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFec_Venc.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtFec_Venc.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtFec_Venc.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtFec_Venc.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtFec_Venc.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtFec_Venc.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtFec_Venc.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtFec_Venc.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtFec_Venc.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFec_Venc.MonthCalendar.DisplayMonth = new System.DateTime(2014, 3, 1, 0, 0, 0, 0);
            this.txtFec_Venc.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtFec_Venc.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtFec_Venc.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtFec_Venc.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtFec_Venc.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtFec_Venc.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFec_Venc.MonthCalendar.TodayButtonVisible = true;
            this.txtFec_Venc.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtFec_Venc.Name = "txtFec_Venc";
            this.txtFec_Venc.Size = new System.Drawing.Size(117, 22);
            this.txtFec_Venc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtFec_Venc.TabIndex = 7;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 31);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 16);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "Usuario:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(139, 31);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 16);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "Empresa:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(323, 31);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 16);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "Vencimiento:";
            // 
            // txtCantidad
            // 
            // 
            // 
            // 
            this.txtCantidad.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtCantidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCantidad.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtCantidad.Location = new System.Drawing.Point(447, 53);
            this.txtCantidad.MaxValue = 10;
            this.txtCantidad.MinValue = 1;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ShowUpDown = true;
            this.txtCantidad.Size = new System.Drawing.Size(80, 22);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.Value = 1;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(447, 31);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 16);
            this.labelX5.TabIndex = 11;
            this.labelX5.Text = "Nro Doc.:";
            // 
            // btnAnular
            // 
            this.btnAnular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAnular.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAnular.Location = new System.Drawing.Point(656, 53);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(64, 22);
            this.btnAnular.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAnular.TabIndex = 1;
            this.btnAnular.Text = "Anular";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // GrdDatosDoc
            // 
            this.GrdDatosDoc.AllowUserToAddRows = false;
            this.GrdDatosDoc.BackgroundColor = System.Drawing.Color.White;
            this.GrdDatosDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDatosDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo_doc,
            this.Nro_doc,
            this.Fec_emis,
            this.Co_cli,
            this.Cli_des,
            this.Monto_bru,
            this.Monto_imp,
            this.Monto_net,
            this.Descrip,
            this.Anulado});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdDatosDoc.DefaultCellStyle = dataGridViewCellStyle6;
            this.GrdDatosDoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.GrdDatosDoc.Location = new System.Drawing.Point(12, 396);
            this.GrdDatosDoc.Name = "GrdDatosDoc";
            this.GrdDatosDoc.RowHeadersVisible = false;
            this.GrdDatosDoc.Size = new System.Drawing.Size(708, 128);
            this.GrdDatosDoc.TabIndex = 6;
            // 
            // Tipo_doc
            // 
            this.Tipo_doc.DataPropertyName = "tipo_doc";
            this.Tipo_doc.HeaderText = "Tipo Doc.";
            this.Tipo_doc.Name = "Tipo_doc";
            this.Tipo_doc.ReadOnly = true;
            this.Tipo_doc.Width = 80;
            // 
            // Nro_doc
            // 
            this.Nro_doc.DataPropertyName = "nro_doc";
            this.Nro_doc.HeaderText = "Nro. Doc";
            this.Nro_doc.Name = "Nro_doc";
            this.Nro_doc.ReadOnly = true;
            this.Nro_doc.Width = 80;
            // 
            // Fec_emis
            // 
            this.Fec_emis.DataPropertyName = "fec_emis";
            this.Fec_emis.HeaderText = "Fecha Doc.";
            this.Fec_emis.Name = "Fec_emis";
            this.Fec_emis.ReadOnly = true;
            this.Fec_emis.Width = 90;
            // 
            // Co_cli
            // 
            this.Co_cli.DataPropertyName = "co_cli";
            this.Co_cli.HeaderText = "Codigo";
            this.Co_cli.Name = "Co_cli";
            this.Co_cli.ReadOnly = true;
            this.Co_cli.Width = 80;
            // 
            // Cli_des
            // 
            this.Cli_des.DataPropertyName = "cli_des";
            this.Cli_des.HeaderText = "Cliente";
            this.Cli_des.Name = "Cli_des";
            this.Cli_des.ReadOnly = true;
            this.Cli_des.Width = 200;
            // 
            // Monto_bru
            // 
            this.Monto_bru.DataPropertyName = "monto_bru";
            dataGridViewCellStyle3.Format = "n2";
            this.Monto_bru.DefaultCellStyle = dataGridViewCellStyle3;
            this.Monto_bru.HeaderText = "Monto Bruto";
            this.Monto_bru.Name = "Monto_bru";
            this.Monto_bru.ReadOnly = true;
            // 
            // Monto_imp
            // 
            this.Monto_imp.DataPropertyName = "monto_imp";
            dataGridViewCellStyle4.Format = "n2";
            this.Monto_imp.DefaultCellStyle = dataGridViewCellStyle4;
            this.Monto_imp.HeaderText = "Monto Imp.";
            this.Monto_imp.Name = "Monto_imp";
            this.Monto_imp.ReadOnly = true;
            // 
            // Monto_net
            // 
            this.Monto_net.DataPropertyName = "monto_imp";
            dataGridViewCellStyle5.Format = "n2";
            this.Monto_net.DefaultCellStyle = dataGridViewCellStyle5;
            this.Monto_net.HeaderText = "Monto Neto";
            this.Monto_net.Name = "Monto_net";
            this.Monto_net.ReadOnly = true;
            // 
            // Descrip
            // 
            this.Descrip.DataPropertyName = "descrip";
            this.Descrip.HeaderText = "Descripcion";
            this.Descrip.Name = "Descrip";
            this.Descrip.ReadOnly = true;
            this.Descrip.Width = 200;
            // 
            // Anulado
            // 
            this.Anulado.DataPropertyName = "anulado";
            this.Anulado.HeaderText = "Status";
            this.Anulado.Name = "Anulado";
            this.Anulado.ReadOnly = true;
            this.Anulado.Width = 80;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(12, 81);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(94, 17);
            this.labelX6.TabIndex = 9;
            this.labelX6.Text = "Claves generadas...";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(12, 373);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(136, 17);
            this.labelX7.TabIndex = 9;
            this.labelX7.Text = "Documentos relacionados...";
            // 
            // FrmClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 536);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtFec_Venc);
            this.Controls.Add(this.GrdDatosDoc);
            this.Controls.Add(this.GrdDatos);
            this.Controls.Add(this.cboEmpresa);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnGenerar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Contraseñas para Documentos de Profit Administrativo";
            this.Load += new System.EventHandler(this.FrmClave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFec_Venc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDatosDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnGenerar;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboUsuario;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboEmpresa;
        private DevComponents.DotNetBar.Controls.DataGridViewX GrdDatos;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtFec_Venc;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.IntegerInput txtCantidad;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnAnular;
        private DevComponents.DotNetBar.Controls.DataGridViewX GrdDatosDoc;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_emis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Co_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_des;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_bru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_imp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_net;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Co_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_venc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_Gen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_usu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rowguid;
    }
}