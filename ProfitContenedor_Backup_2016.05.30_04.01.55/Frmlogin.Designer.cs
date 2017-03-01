namespace ProfitContenedor
{
    partial class Frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
            this.txtUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtClave = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUsuario.Border.Class = "TextBoxBorder";
            this.txtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(272, 164);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(126, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtClave.Border.Class = "TextBoxBorder";
            this.txtClave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtClave.ForeColor = System.Drawing.Color.Black;
            this.txtClave.Location = new System.Drawing.Point(272, 204);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(126, 20);
            this.txtClave.TabIndex = 1;
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.ForeColor = System.Drawing.Color.Black;
            this.picAvatar.Location = new System.Drawing.Point(193, 162);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(63, 63);
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAceptar.Location = new System.Drawing.Point(221, 258);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Location = new System.Drawing.Point(302, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(598, 329);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtUsuario;
        private DevComponents.DotNetBar.Controls.TextBoxX txtClave;
        private System.Windows.Forms.PictureBox picAvatar;
        private DevComponents.DotNetBar.ButtonX btnAceptar;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
    }
}