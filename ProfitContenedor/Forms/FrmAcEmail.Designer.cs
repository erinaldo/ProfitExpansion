namespace ProfitContenedor
{
    partial class FrmAcEmail
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
            this.txtPara = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnEnviar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblComentario = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // txtPara
            // 
            this.txtPara.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPara.Border.Class = "TextBoxBorder";
            this.txtPara.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPara.DisabledBackColor = System.Drawing.Color.White;
            this.txtPara.ForeColor = System.Drawing.Color.Black;
            this.txtPara.Location = new System.Drawing.Point(1, 12);
            this.txtPara.Multiline = true;
            this.txtPara.Name = "txtPara";
            this.txtPara.PreventEnterBeep = true;
            this.txtPara.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPara.Size = new System.Drawing.Size(346, 67);
            this.txtPara.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEnviar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEnviar.Location = new System.Drawing.Point(191, 85);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 37);
            this.btnEnviar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "&Enviar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(272, 85);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 37);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // progressBarX1
            // 
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Location = new System.Drawing.Point(1, 85);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee;
            this.progressBarX1.Size = new System.Drawing.Size(184, 17);
            this.progressBarX1.TabIndex = 3;
            this.progressBarX1.Text = "progressBarX1";
            this.progressBarX1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblComentario
            // 
            // 
            // 
            // 
            this.lblComentario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblComentario.Location = new System.Drawing.Point(1, 108);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(184, 13);
            this.lblComentario.TabIndex = 4;
            this.lblComentario.Text = "labelX1";
            this.lblComentario.Visible = false;
            // 
            // FrmAcEmail
            // 
            this.AcceptButton = this.btnEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(349, 127);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtPara);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAcEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar por correo";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtPara;
        private DevComponents.DotNetBar.ButtonX btnEnviar;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.LabelX lblComentario;
    }
}