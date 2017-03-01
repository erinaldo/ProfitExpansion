namespace ProfitContenedor
{
    partial class FrmPrincipal
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
            DevComponents.DotNetBar.Metro.MetroTileFrame metroTileFrame1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.MetroUsuarios = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroPStock = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem5 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.MetroArticulos = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroClaves = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroEntrega = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.MetroEmpresas = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroNavieras = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroContenedores = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroMonitor = new DevComponents.DotNetBar.Metro.MetroTileItem();
            metroTileFrame1 = new DevComponents.DotNetBar.Metro.MetroTileFrame();
            this.SuspendLayout();
            // 
            // metroTileFrame1
            // 
            metroTileFrame1.Image = ((System.Drawing.Image)(resources.GetObject("metroTileFrame1.Image")));
            metroTileFrame1.ImageIndent = new System.Drawing.Point(4, 0);
            metroTileFrame1.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            metroTileFrame1.Text = "Monitor de Contenedores";
            metroTileFrame1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive;
            // 
            // 
            // 
            metroTileFrame1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            metroTileFrame1.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // metroTilePanel1
            // 
            this.metroTilePanel1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopLeft;
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTilePanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTilePanel1.ForeColor = System.Drawing.Color.Black;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3,
            this.itemContainer4,
            this.itemContainer1});
            this.metroTilePanel1.Location = new System.Drawing.Point(0, 0);
            this.metroTilePanel1.MultiLine = true;
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.ApplicationScroll;
            this.metroTilePanel1.Size = new System.Drawing.Size(686, 572);
            this.metroTilePanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.metroTilePanel1.TabIndex = 2;
            this.metroTilePanel1.Text = "metroTilePanel1";
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.ItemSpacing = 8;
            this.itemContainer3.MultiLine = true;
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.MetroUsuarios,
            this.MetroPStock,
            this.metroTileItem5});
            this.itemContainer3.Text = "Configuración";
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.TitleStyle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer3.TitleStyle.TextColor = System.Drawing.Color.Black;
            this.itemContainer3.TitleText = "Configuración";
            // 
            // MetroUsuarios
            // 
            this.MetroUsuarios.Image = global::ProfitContenedor.Properties.Resources.People_64;
            this.MetroUsuarios.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroUsuarios.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroUsuarios.Name = "MetroUsuarios";
            this.MetroUsuarios.SymbolColor = System.Drawing.Color.Empty;
            this.MetroUsuarios.Text = "Usuarios";
            this.MetroUsuarios.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
            this.MetroUsuarios.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroUsuarios.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroUsuarios.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroUsuarios.Click += new System.EventHandler(this.MetroUsuarios_Click);
            // 
            // MetroPStock
            // 
            this.MetroPStock.Image = global::ProfitContenedor.Properties.Resources.Stock;
            this.MetroPStock.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroPStock.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroPStock.Name = "MetroPStock";
            this.MetroPStock.SymbolColor = System.Drawing.Color.Empty;
            this.MetroPStock.Text = "Pantalla Stock";
            this.MetroPStock.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
            this.MetroPStock.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroPStock.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroPStock.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroPStock.Click += new System.EventHandler(this.MetroPStock_Click);
            // 
            // metroTileItem5
            // 
            this.metroTileItem5.ImageIndent = new System.Drawing.Point(0, 8);
            this.metroTileItem5.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileItem5.Name = "metroTileItem5";
            this.metroTileItem5.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem5.Text = "Remote Desktop";
            this.metroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive;
            this.metroTileItem5.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.metroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem5.Visible = false;
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.ItemSpacing = 8;
            this.itemContainer4.MultiLine = true;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.MetroArticulos,
            this.MetroClaves,
            this.MetroEntrega});
            this.itemContainer4.Text = "Utilidades";
            // 
            // 
            // 
            this.itemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.TitleStyle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer4.TitleStyle.TextColor = System.Drawing.Color.Black;
            this.itemContainer4.TitleText = "Utilidades";
            // 
            // MetroArticulos
            // 
            this.MetroArticulos.Image = ((System.Drawing.Image)(resources.GetObject("MetroArticulos.Image")));
            this.MetroArticulos.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroArticulos.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroArticulos.Name = "MetroArticulos";
            this.MetroArticulos.SymbolColor = System.Drawing.Color.Empty;
            this.MetroArticulos.Text = "Consulta Articulos";
            this.MetroArticulos.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Rust;
            this.MetroArticulos.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroArticulos.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroArticulos.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroArticulos.Click += new System.EventHandler(this.MetroArticulos_Click);
            // 
            // MetroClaves
            // 
            this.MetroClaves.Image = ((System.Drawing.Image)(resources.GetObject("MetroClaves.Image")));
            this.MetroClaves.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroClaves.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroClaves.Name = "MetroClaves";
            this.MetroClaves.SymbolColor = System.Drawing.Color.Empty;
            this.MetroClaves.Text = "Generador de Claves";
            this.MetroClaves.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.PlumWashed;
            this.MetroClaves.TileSize = new System.Drawing.Size(140, 120);
            // 
            // 
            // 
            this.MetroClaves.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroClaves.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroClaves.Click += new System.EventHandler(this.MetroClaves_Click);
            // 
            // MetroEntrega
            // 
            this.MetroEntrega.Image = ((System.Drawing.Image)(resources.GetObject("MetroEntrega.Image")));
            this.MetroEntrega.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroEntrega.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroEntrega.Name = "MetroEntrega";
            this.MetroEntrega.SymbolColor = System.Drawing.Color.Empty;
            this.MetroEntrega.Text = "Entrega de Mercancia";
            this.MetroEntrega.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellow;
            this.MetroEntrega.TileSize = new System.Drawing.Size(140, 120);
            // 
            // 
            // 
            this.MetroEntrega.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroEntrega.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroEntrega.Click += new System.EventHandler(this.MetroEntrega_Click);
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.ItemSpacing = 8;
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.MetroEmpresas,
            this.MetroNavieras,
            this.MetroContenedores,
            this.MetroMonitor});
            this.itemContainer1.Text = "Importaciones";
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.TitleStyle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer1.TitleStyle.TextColor = System.Drawing.Color.Black;
            this.itemContainer1.TitleText = "Importaciones";
            // 
            // MetroEmpresas
            // 
            this.MetroEmpresas.Image = ((System.Drawing.Image)(resources.GetObject("MetroEmpresas.Image")));
            this.MetroEmpresas.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroEmpresas.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroEmpresas.Name = "MetroEmpresas";
            this.MetroEmpresas.SymbolColor = System.Drawing.Color.Empty;
            this.MetroEmpresas.Text = "Empresas";
            this.MetroEmpresas.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            this.MetroEmpresas.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroEmpresas.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroEmpresas.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroEmpresas.Click += new System.EventHandler(this.MetroEmpresas_Click);
            // 
            // MetroNavieras
            // 
            this.MetroNavieras.Image = ((System.Drawing.Image)(resources.GetObject("MetroNavieras.Image")));
            this.MetroNavieras.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroNavieras.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroNavieras.Name = "MetroNavieras";
            this.MetroNavieras.SymbolColor = System.Drawing.Color.Empty;
            this.MetroNavieras.Text = "Navieras";
            this.MetroNavieras.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            this.MetroNavieras.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroNavieras.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroNavieras.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroNavieras.Click += new System.EventHandler(this.MetroNavieras_Click);
            // 
            // MetroContenedores
            // 
            this.MetroContenedores.Image = ((System.Drawing.Image)(resources.GetObject("MetroContenedores.Image")));
            this.MetroContenedores.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroContenedores.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroContenedores.Name = "MetroContenedores";
            this.MetroContenedores.SymbolColor = System.Drawing.Color.Empty;
            this.MetroContenedores.Text = "Contenedores";
            this.MetroContenedores.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange;
            this.MetroContenedores.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroContenedores.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroContenedores.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroContenedores.Click += new System.EventHandler(this.MetroContenedores_Click);
            // 
            // MetroMonitor
            // 
            this.MetroMonitor.AutoRotateFramesInterval = 4000;
            this.MetroMonitor.Frames.Add(metroTileFrame1);
            this.MetroMonitor.Image = ((System.Drawing.Image)(resources.GetObject("MetroMonitor.Image")));
            this.MetroMonitor.ImageIndent = new System.Drawing.Point(4, 0);
            this.MetroMonitor.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.MetroMonitor.Name = "MetroMonitor";
            this.MetroMonitor.SymbolColor = System.Drawing.Color.Empty;
            this.MetroMonitor.Text = "Vea aqui los contenedores por llegar";
            this.MetroMonitor.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive;
            this.MetroMonitor.TileSize = new System.Drawing.Size(248, 120);
            // 
            // 
            // 
            this.MetroMonitor.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroMonitor.Click += new System.EventHandler(this.MetroMonitor_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 572);
            this.Controls.Add(this.metroTilePanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profit Expansion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroEmpresas;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroNavieras;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroContenedores;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroMonitor;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroUsuarios;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroPStock;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem5;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroArticulos;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroClaves;
        private DevComponents.DotNetBar.Metro.MetroTileItem MetroEntrega;
    }
}