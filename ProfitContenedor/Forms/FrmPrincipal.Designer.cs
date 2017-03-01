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
            this.MetroParametros = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroUsuarios = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroPStock = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroRegRep = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroEnvRep = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroL_Cred = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.MetroArticulos = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroClaves = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroEntrega = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroPrepP = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroCxC = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroRep = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.MetroEmpresas = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroNavieras = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroCompras = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroOrdenes = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.MetroFact_imp = new DevComponents.DotNetBar.Metro.MetroTileItem();
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
            metroTileFrame1.Text = "Vea aqui los contenedores por llegar";
            metroTileFrame1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            // 
            // 
            // 
            metroTileFrame1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            metroTileFrame1.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2013;
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
            this.metroTilePanel1.DragDropSupport = true;
            this.metroTilePanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTilePanel1.ForeColor = System.Drawing.Color.Black;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3,
            this.itemContainer4,
            this.itemContainer1});
            this.metroTilePanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.metroTilePanel1.Location = new System.Drawing.Point(0, 0);
            this.metroTilePanel1.MultiLine = true;
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.ApplicationScroll;
            this.metroTilePanel1.Size = new System.Drawing.Size(1089, 605);
            this.metroTilePanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.metroTilePanel1.TabIndex = 2;
            this.metroTilePanel1.Text = "metroTilePanel1";
            this.metroTilePanel1.ThemeAware = true;
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
            this.MetroParametros,
            this.MetroUsuarios,
            this.MetroPStock,
            this.MetroRegRep,
            this.MetroEnvRep,
            this.MetroL_Cred});
            this.itemContainer3.Text = "Configuración";
            this.itemContainer3.ThemeAware = true;
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.TitleStyle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer3.TitleStyle.TextColor = System.Drawing.Color.Black;
            this.itemContainer3.TitleText = "Configuración";
            // 
            // MetroParametros
            // 
            this.MetroParametros.Image = global::ProfitContenedor.Properties.Resources.Box_Config_48;
            this.MetroParametros.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroParametros.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroParametros.Name = "MetroParametros";
            this.MetroParametros.SymbolColor = System.Drawing.Color.Empty;
            this.MetroParametros.Text = "Parametros";
            this.MetroParametros.ThemeAware = true;
            this.MetroParametros.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.MetroParametros.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroParametros.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroParametros.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroParametros.Visible = false;
            // 
            // MetroUsuarios
            // 
            this.MetroUsuarios.Image = global::ProfitContenedor.Properties.Resources.People_64;
            this.MetroUsuarios.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroUsuarios.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroUsuarios.Name = "MetroUsuarios";
            this.MetroUsuarios.SymbolColor = System.Drawing.Color.Empty;
            this.MetroUsuarios.Text = "Usuarios";
            this.MetroUsuarios.ThemeAware = true;
            this.MetroUsuarios.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
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
            this.MetroPStock.ThemeAware = true;
            this.MetroPStock.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.MetroPStock.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroPStock.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroPStock.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroPStock.Click += new System.EventHandler(this.MetroPStock_Click);
            // 
            // MetroRegRep
            // 
            this.MetroRegRep.Image = global::ProfitContenedor.Properties.Resources.Custom_reports_48;
            this.MetroRegRep.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroRegRep.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroRegRep.Name = "MetroRegRep";
            this.MetroRegRep.SymbolColor = System.Drawing.Color.Empty;
            this.MetroRegRep.Text = "Registro de Reportes";
            this.MetroRegRep.ThemeAware = true;
            this.MetroRegRep.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.MetroRegRep.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroRegRep.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroRegRep.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroRegRep.Click += new System.EventHandler(this.MetroRegRep_Click);
            // 
            // MetroEnvRep
            // 
            this.MetroEnvRep.Image = global::ProfitContenedor.Properties.Resources.Android_Gmail_48;
            this.MetroEnvRep.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroEnvRep.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroEnvRep.Name = "MetroEnvRep";
            this.MetroEnvRep.SymbolColor = System.Drawing.Color.Empty;
            this.MetroEnvRep.Text = "Envios de Reportes";
            this.MetroEnvRep.ThemeAware = true;
            this.MetroEnvRep.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.MetroEnvRep.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroEnvRep.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroEnvRep.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroEnvRep.Click += new System.EventHandler(this.MetroEnvRep_Click);
            // 
            // MetroL_Cred
            // 
            this.MetroL_Cred.Image = global::ProfitContenedor.Properties.Resources.Dollar_48;
            this.MetroL_Cred.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroL_Cred.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroL_Cred.Name = "MetroL_Cred";
            this.MetroL_Cred.SymbolColor = System.Drawing.Color.Empty;
            this.MetroL_Cred.Text = "Limites de Credito";
            this.MetroL_Cred.ThemeAware = true;
            this.MetroL_Cred.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.MetroL_Cred.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroL_Cred.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroL_Cred.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroL_Cred.Click += new System.EventHandler(this.MetroL_Cred_Click);
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
            this.MetroEntrega,
            this.MetroPrepP,
            this.MetroCxC,
            this.MetroRep});
            this.itemContainer4.Text = "Utilidades";
            this.itemContainer4.ThemeAware = true;
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
            this.MetroArticulos.ThemeAware = true;
            this.MetroArticulos.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
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
            this.MetroClaves.ThemeAware = true;
            this.MetroClaves.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
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
            this.MetroEntrega.ThemeAware = true;
            this.MetroEntrega.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            this.MetroEntrega.TileSize = new System.Drawing.Size(140, 120);
            // 
            // 
            // 
            this.MetroEntrega.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroEntrega.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroEntrega.Click += new System.EventHandler(this.MetroEntrega_Click);
            // 
            // MetroPrepP
            // 
            this.MetroPrepP.Image = global::ProfitContenedor.Properties.Resources.Packing_48;
            this.MetroPrepP.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroPrepP.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroPrepP.Name = "MetroPrepP";
            this.MetroPrepP.SymbolColor = System.Drawing.Color.Empty;
            this.MetroPrepP.Text = "Preparar Pedido";
            this.MetroPrepP.ThemeAware = true;
            this.MetroPrepP.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            this.MetroPrepP.TileSize = new System.Drawing.Size(140, 120);
            // 
            // 
            // 
            this.MetroPrepP.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroPrepP.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroPrepP.Click += new System.EventHandler(this.MetroPrepP_Click);
            // 
            // MetroCxC
            // 
            this.MetroCxC.Image = global::ProfitContenedor.Properties.Resources.Credit_card_48;
            this.MetroCxC.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroCxC.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroCxC.Name = "MetroCxC";
            this.MetroCxC.SymbolColor = System.Drawing.Color.Empty;
            this.MetroCxC.Text = "CxC Consolidada";
            this.MetroCxC.ThemeAware = true;
            this.MetroCxC.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            this.MetroCxC.TileSize = new System.Drawing.Size(140, 120);
            // 
            // 
            // 
            this.MetroCxC.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroCxC.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroCxC.Click += new System.EventHandler(this.MetroCxC_Click);
            // 
            // MetroRep
            // 
            this.MetroRep.Image = global::ProfitContenedor.Properties.Resources.Reports_48;
            this.MetroRep.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroRep.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroRep.Name = "MetroRep";
            this.MetroRep.SymbolColor = System.Drawing.Color.Empty;
            this.MetroRep.Text = "Reportes";
            this.MetroRep.ThemeAware = true;
            this.MetroRep.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            this.MetroRep.TileSize = new System.Drawing.Size(140, 120);
            // 
            // 
            // 
            this.MetroRep.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroRep.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroRep.Click += new System.EventHandler(this.MetroReport_Click);
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
            this.MetroCompras,
            this.MetroOrdenes,
            this.MetroFact_imp,
            this.MetroContenedores,
            this.MetroMonitor});
            this.itemContainer1.Text = "Importaciones";
            this.itemContainer1.ThemeAware = true;
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
            this.MetroEmpresas.ThemeAware = true;
            this.MetroEmpresas.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
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
            this.MetroNavieras.ThemeAware = true;
            this.MetroNavieras.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            this.MetroNavieras.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroNavieras.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroNavieras.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroNavieras.Click += new System.EventHandler(this.MetroNavieras_Click);
            // 
            // MetroCompras
            // 
            this.MetroCompras.Image = ((System.Drawing.Image)(resources.GetObject("MetroCompras.Image")));
            this.MetroCompras.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroCompras.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroCompras.Name = "MetroCompras";
            this.MetroCompras.SymbolColor = System.Drawing.Color.Empty;
            this.MetroCompras.Text = "Compras";
            this.MetroCompras.ThemeAware = true;
            this.MetroCompras.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            this.MetroCompras.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroCompras.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroCompras.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroCompras.Click += new System.EventHandler(this.MetroCompras_Click);
            // 
            // MetroOrdenes
            // 
            this.MetroOrdenes.Image = ((System.Drawing.Image)(resources.GetObject("MetroOrdenes.Image")));
            this.MetroOrdenes.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroOrdenes.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroOrdenes.Name = "MetroOrdenes";
            this.MetroOrdenes.SymbolColor = System.Drawing.Color.Empty;
            this.MetroOrdenes.Text = "Ordenes";
            this.MetroOrdenes.ThemeAware = true;
            this.MetroOrdenes.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            this.MetroOrdenes.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroOrdenes.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroOrdenes.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroOrdenes.Click += new System.EventHandler(this.MetroOrdenes_Click);
            // 
            // MetroFact_imp
            // 
            this.MetroFact_imp.Image = ((System.Drawing.Image)(resources.GetObject("MetroFact_imp.Image")));
            this.MetroFact_imp.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroFact_imp.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroFact_imp.Name = "MetroFact_imp";
            this.MetroFact_imp.SymbolColor = System.Drawing.Color.Empty;
            this.MetroFact_imp.Text = "Facturas de Importacion";
            this.MetroFact_imp.ThemeAware = true;
            this.MetroFact_imp.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            this.MetroFact_imp.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.MetroFact_imp.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroFact_imp.TileStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.MetroFact_imp.Visible = false;
            this.MetroFact_imp.Click += new System.EventHandler(this.MetroFact_imp_Click);
            // 
            // MetroContenedores
            // 
            this.MetroContenedores.Image = ((System.Drawing.Image)(resources.GetObject("MetroContenedores.Image")));
            this.MetroContenedores.ImageIndent = new System.Drawing.Point(0, -6);
            this.MetroContenedores.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroContenedores.Name = "MetroContenedores";
            this.MetroContenedores.SymbolColor = System.Drawing.Color.Empty;
            this.MetroContenedores.Text = "Contenedores";
            this.MetroContenedores.ThemeAware = true;
            this.MetroContenedores.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
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
            this.MetroMonitor.ThemeAware = true;
            this.MetroMonitor.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            this.MetroMonitor.TileSize = new System.Drawing.Size(248, 120);
            // 
            // 
            // 
            this.MetroMonitor.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MetroMonitor.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.MetroMonitor.Click += new System.EventHandler(this.MetroMonitor_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 605);
            this.Controls.Add(this.metroTilePanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profit Expansion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroEmpresas;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroNavieras;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroContenedores;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroMonitor;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroUsuarios;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroPStock;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroArticulos;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroClaves;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroEntrega;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroOrdenes;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroFact_imp;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroPrepP;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroCxC;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroRep;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroEnvRep;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroRegRep;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroParametros;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroL_Cred;
        public DevComponents.DotNetBar.Metro.MetroTileItem MetroCompras;
    }
}