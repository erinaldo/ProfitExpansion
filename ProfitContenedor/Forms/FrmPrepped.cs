using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Data.Entity.Core;

namespace ProfitContenedor
{
    public partial class FrmPrepped : DevComponents.DotNetBar.Metro.MetroForm
    {
        string Usuario_Act;
        Int32 Tip;
        string Newguid;
        List<pSeleccionarPed_Desp_Result> Lpendientes = new List<pSeleccionarPed_Desp_Result>();
        List<pPedidoEnProc_Info_Result> Lpinfo = new List<pPedidoEnProc_Info_Result>();
        List<DetPedido> Lpedido = new List<DetPedido>();
        List<pVerificarArticuloPedido_Result> Lverif = new List<pVerificarArticuloPedido_Result>();
        List<pSeleccionarPed_Desp_Result> Lest = new List<pSeleccionarPed_Desp_Result>();
        List<pSeleccionarPed_Desp_Result> LestTemp = new List<pSeleccionarPed_Desp_Result>();
        DateTime Desde = System.DateTime.Today.AddDays(-7);
        DateTime Hasta = System.DateTime.Now;

        enum Orden
        {
            Alfabetico = 1,
            Aleatorio = 0
        }

        public FrmPrepped()
        {
            InitializeComponent();
        }
        
        public FrmPrepped(string Usuario_Actual,Int32 Tipo)
        {
            Usuario_Act = Usuario_Actual;
            Tip = Tipo;
            using (Profit_RGEntities context = new Profit_RGEntities())
            {

                List<pSeleccionarExcepcion_H_Result> Lh = new List<pSeleccionarExcepcion_H_Result>();
                Lh = context.pSeleccionarExcepcion_H().Where(h => h.fecha.Date == System.DateTime.Today.Date).OrderByDescending(h => h.fecha).ToList();
                if (Lh.Count() > 0)
                {
                    Hasta = Lh[0].fecha;
                }
                else
                {
                    Hasta = System.DateTime.Now;
                }
            }
            InitializeComponent();
        }
        
        private void metroPreparar_Click(object sender, EventArgs e)
        {
            PrepararPedido();
        }
        
        private void PrepararPedido()
        {
            try
            {
                PanelCuliminar.Visible = false;
                PanelPreparar.Visible = true;
                PanelEst.Visible = false;
                circularProgress1.Visible = false;
                circularProgress1.IsRunning = false;
                GenerarCaptcha();
                txtCaptcha.Text = "";
                txtCaptcha.Focus();
                this.AcceptButton = btnCatpcha;
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizaEstadistica();
        }
        
        private void ActualizaEstadistica()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    Int32 Pendientes = 0;
                    Int32 EnProceso = 0;
                    Int32 Anulados = 0;
                    Int32 CulminadosCred = 0;
                    Int32 CulminadosPrep = 0;
                    List<pSeleccionarEmpresasCA_Result> Lca = new List<pSeleccionarEmpresasCA_Result>();
                    Lca = context.pSeleccionarEmpresasCA(Usuario_Act).ToList();

                    if (Lca.Count() > 0)
                    {
                        foreach (var item in Lca)
                        {
                            Pendientes += context.pSeleccionarPed_Desp(item.co_empresa.Trim(), Desde, Hasta, 2, 0, false).ToList().Count();
                            EnProceso += context.pSeleccionarPed_Desp(item.co_empresa.Trim(), Desde, Hasta, 2, 1, false).ToList().Count;
                            Anulados += context.pSeleccionarPed_Desp(item.co_empresa.Trim(), Desde, Hasta, 2, 0, true).ToList().Count;
                            CulminadosCred += context.pSeleccionarPed_Desp(item.co_empresa.Trim(), Desde, Hasta, 1, 2, false).ToList().Count;
                            CulminadosPrep += context.pSeleccionarPed_Desp(item.co_empresa.Trim(), Desde, Hasta, 0, 2, false).ToList().Count;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario no posee empresas asociadas.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cboPrepA.Items.Clear();
                    cboPrepD.Items.Clear();

                    foreach (var item in context.pNomiAsistentes(3).ToList())
                    {
                        cboPrepA.Items.Add(item.Susername.Trim());
                    }
                    foreach (var item in context.pNomiAsistentes(1).ToList())
                    {
                        cboPrepD.Items.Add(item.Susername.Trim());
                    }


                    metroPend.TitleText = '[' + Pendientes.ToString() + "] Pendientes";
                    metroEproc.TitleText = '[' + EnProceso.ToString() + "] En proceso";
                    metroAnu.TitleText = '[' + Anulados.ToString() + "] Anulados";
                    metroCCredito.TitleText = '[' + CulminadosCred.ToString() + "] Culm. Cred.";
                    metroCPrepago.TitleText = '[' + CulminadosPrep.ToString() + "] Culm. Prep.";
                }
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void FrmPrepped_Load(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = true;
                timer1_Tick(sender, e);
                MetroEx_P.Enabled = Tip == 1;
                MetroEx_H.Enabled = Tip == 1;

                cboPrepA.BackColor = Color.LightYellow;
                cboPrepD.BackColor = Color.LightGreen;

                //cboPrepA.Items.Clear();
                //cboPrepD.Items.Clear();

                //using (Profit_RGEntities context = new Profit_RGEntities())
                //{
                //    foreach (var item in context.pNomiAsistentes(3).ToList())
                //    {
                //        cboPrepA.Items.Add(item.Susername.Trim());
                //    }
                //    foreach (var item in context.pNomiAsistentes(1).ToList())
                //    {
                //        cboPrepD.Items.Add(item.Susername.Trim());
                //    }
                //}
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //ActualizaEstadistica();
        }
        
        void GenerarCaptcha()
        {
            Captcha C = new Captcha();
            Newguid = Guid.NewGuid().ToString().Substring(0, 4);
            pictureBox1.Image = C.Generar(Newguid);
        }
        
        private void btnCatpcha_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCaptcha.Text.Trim() == Newguid.Trim())
                {
                    timer2.Enabled = true;
                    timer2_Tick(sender, e);
                    circularProgress1.Visible = true;
                    circularProgress1.IsRunning = true;

                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        //Escoge preparador
                        //string Preparador;

                        var Lpreparador = context.pNomiAsistentes(1).ToList();

                        if (Lpreparador.Count() == 0)
                        {
                            MessageBox.Show("No existen preparadores disponibles.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            circularProgress1.IsRunning = false;
                            PanelPreparar.Visible = true;
                            return;
                        }
                        #region Escoge
                        //Escoge pedido
                        //Lpendientes.Clear();
                        //List<pSeleccionarEmpresasCA_Result> Lca = new List<pSeleccionarEmpresasCA_Result>();
                        //Lca = context.pSeleccionarEmpresasCA(Usuario_Act).ToList();
                        //if (Lca.Count() > 0)
                        //{
                        //    foreach (var item in Lca)
                        //    {
                        //        foreach (var item2 in context.pSeleccionarPed_Desp(item.co_empresa.Trim(), Desde,Hasta, 2, 0, false).ToList())
                        //        {
                        //            Lpendientes.Add(item2);
                        //        }
                        //    }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("El usuario no posee empresas asociadas.","Profit Expansion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        //    return;
                        //}
                        //var Lp = (from row in Lpendientes
                        //          orderby row.semana, row.P_trans, row.P_Condi, row.P_Zona
                        //          select row).ToList();
                        #endregion
                        Consultar(2, 0, false);
                        if (Lest.Count() > 0)
                        {
                            //Inserta Indicador de gestion
                            context.pInsertarIg_Pedido(
                                                        Lest[0].empresa,
                                                        Lpreparador[0].Nomina,
                                                        Lpreparador[0].cod_emp,
                                                        Lpreparador[0].nombre_completo,
                                                        System.DateTime.Now,
                                                        Lest[0].fact_num.Value,
                                                        System.DateTime.Now,
                                                        Convert.ToDateTime("01/01/1900"),
                                                        "",
                                                        false,
                                                        Lest[0].rowguid);
                            //Imprime ticket pedido

                            ImprimirTicket(Lest[0].rowguid.ToString());

                            //context.pMarcarPedidoImpreso(Lest[0].fact_num, Lest[0].empresa.Trim());

                            this.AcceptButton = null;
                        }
                        else
                        {
                            MessageBox.Show("No existe pedidos pendiente actualmente.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    
                    ActualizaEstadistica();
                    PanelPreparar.Visible = false;
                    PanelCuliminar.Visible = false;
                    PanelEst.Visible = false;
                    circularProgress1.Visible = false;
                    circularProgress1.IsRunning = false;
                    timer2.Enabled = false;
                }
                else
                {
                    MessageBox.Show(this, "ERROR", "Captcha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCaptcha.Focus();
                }
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  
        }

        private static void ImprimirTicket(string Identificador)
        {
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings["ProfitContenedor.Properties.Settings.Profit_RGConnectionString"];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;

            //SqlConnection sqlConn = new SqlConnection("Server=172.16.1.4;uid=profit;password=profit;initial catalog=Profit_RG;");
            SqlConnection sqlConn = new SqlConnection(returnValue);

            SqlCommand comd;
            comd = new SqlCommand();
            comd.Connection = sqlConn;
            comd.CommandType = CommandType.StoredProcedure;
            comd.CommandText = "pRepTicket_Pedido";

            comd.Parameters.Add("@Rowguid", SqlDbType.Char);
            comd.Parameters[0].Value = Identificador;

            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            sqlAdapter.SelectCommand = comd;
            DataSet ds = new DataSet();
            sqlAdapter.Fill(ds, "pRepTicket_Pedido");

            CrystalDecisions.CrystalReports.Engine.ReportDocument oRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

            string Filename = @"\\172.16.1.4\Profit\Publicaciones\Profit Expansion\Reportes\RepTicketPedido.rpt";
            oRpt.Load(Filename);

            string NombreImpresora = "";//Donde guardare el nombre de la impresora por defecto

            //Busco la impresora por defecto
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                PrinterSettings a = new PrinterSettings();
                a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
                if (a.IsDefaultPrinter)
                {
                    NombreImpresora = PrinterSettings.InstalledPrinters[i].ToString();
                }
            }

            oRpt.SetDataSource(ds);//Asigno la fuente de datos a mi reporte.
            oRpt.PrintOptions.PrinterName = NombreImpresora;//Asigno la impresora
            oRpt.PrintToPrinter(1, false, 0, 0);//Imprimo 1 copias
        }
        
        private void metroCulminar_Click(object sender, EventArgs e)
        {
            txtIdpedido.Text = "";
            lblNpedido.Text = "";
            lblCliente.Text = "";
            Lpedido.Clear();
            grdDatos.DataSource = "";
            txtCo_art.Text = "";
            lblArt_des.Text = "";
            txtTotal_art.Value = 0;
            txtBultos.Value = 0;
            txtUni_venta.Text = "";
            PanelPreparar.Visible = false;
            PanelCuliminar.Visible = true;
            PanelEst.Visible = false;
            txtIdpedido.Focus();
            this.AcceptButton = btnPedido;
        }
        
        private void btnPedido_Click(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    Lpinfo = context.pPedidoEnProc_Info(txtIdpedido.Text.Trim()).ToList();

                    if (Lpinfo.Count() > 0)
                    {
                        lblNpedido.Text = "["+Lpinfo[0].fact_num.Value.ToString()+"] "+Lpinfo[0].empresa.Trim();
                        lblCliente.Text = Lpinfo[0].cli_des.Trim();
                        Lpedido.Clear();

                        txtCo_art.Focus();
                        this.AcceptButton = null;
                    }
                    else
                    {
                        MessageBox.Show("No existe el pedido a culminar.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnCulminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea cerrar este pedido?", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (txtBultos.Value > 0)
                    {
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            foreach (var item in Lpedido)
                            {
                                context.pActualizaArticuloPreparado(item.co_art.Trim(), item.aux01, Lpinfo[0].fact_num.Value, Lpinfo[0].empresa.Trim());
                            }
                            context.pCulminarPedido(Lpinfo[0].empresa.Trim(), Lpinfo[0].fact_num.Value, (txtBultos.Value).ToString() + " BULTO(S)");
                            context.pMarcarPedidoImpreso(Lest[0].fact_num, Lest[0].empresa.Trim());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Se requiere los bultos o cajas preparadas!", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Lpinfo.Clear();
                    Lpedido.Clear();
                    PanelPreparar.Visible = false;
                    PanelCuliminar.Visible = false;
                    this.AcceptButton = null;

                    ActualizaEstadistica();
                }
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Lverif.Count()>0)
                {
                    if (Convert.ToDecimal(txtTotal_art.Value) > Lverif[0].total_art.Value)
                    {
                        MessageBox.Show("La cantidad empacada es superior a la requerida.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //txtTotal_art.Value = 0.00;
                        txtTotal_art.Focus();
                        return;
                    }
                    else if (Convert.ToDecimal(txtTotal_art.Value) < Lverif[0].total_art.Value)
                    {
                        var Answer = MessageBox.Show("La cantidad empacada es inferior a la requerida." + Environment.NewLine + "Desea continuar?", "Profit Expansion",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (Answer == System.Windows.Forms.DialogResult.No) 
                        {
                            txtTotal_art.Focus();
                            return;
                        }
                    }
                    DetPedido pedido = new DetPedido();
                    pedido.co_art = Lverif[0].co_art.Trim();
                    pedido.art_des = Lverif[0].art_des.Trim();
                    pedido.total_art = Lverif[0].total_art.Value;
                    pedido.aux01 = Convert.ToDecimal(txtTotal_art.Value);
                    Lpedido.Add(pedido);
                    grdDatos.DataSource = "";
                    grdDatos.DataSource = Lpedido;
                    grdDatos.Refresh();
                    grdDatos.CurrentCell = grdDatos[1, Lpedido.Count() - 1];
                    txtCo_art.Text = "";
                    lblArt_des.Text = "";
                    txtTotal_art.Value = 0;
                    txtCo_art.Focus();
                    this.AcceptButton = null;
                    grdDatos.Columns[0].HeaderText = "Codigo";
                    grdDatos.Columns[0].Width = 130;
                    grdDatos.Columns[1].HeaderText = "Descripcion";
                    grdDatos.Columns[1].Width = 370;
                    grdDatos.Columns[2].HeaderText = "Cant. Pedido";
                    grdDatos.Columns[2].Width = 120;
                    grdDatos.Columns[2].DefaultCellStyle.Format = "N2";
                    grdDatos.Columns[3].HeaderText = "Cant. Empacado";
                    grdDatos.Columns[3].Width = 120;
                    grdDatos.Columns[3].DefaultCellStyle.Format = "N2";
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void txtCo_art_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarArticulo();
            }
        }

        private void ValidarArticulo()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {

                    Lverif = context.pVerificarArticuloPedido(txtCo_art.Text.Trim(), Lpinfo[0].fact_num, Lpinfo[0].empresa.Trim()).ToList();
                    if (Lverif.Count() > 0)
                    {
                        txtUni_venta.Text = Lverif[0].uni_venta.Trim();
                        lblArt_des.Text = Lverif[0].art_des.Trim();
                        txtTotal_art.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El articulo chequeado no pertenece al pedido a culminar!.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCo_art.Text = "";
                    }
                }
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            circularProgress1.Value += 2;

            if (circularProgress1.Value >= circularProgress1.Maximum)
                ProgressRun.Execute();
        }
        
        private void ProgressRun_Executed(object sender, EventArgs e)
        {
            if (circularProgress1.Value >= circularProgress1.Maximum)
                circularProgress1.Value = 0;
        }
        
        private void Consultar(Int32 Condicion,Int32 Status,Boolean Anulado)
        {
            try
            {
                Lest.Clear();
                LestTemp.Clear();
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    List<pSeleccionarEmpresasCA_Result> Lca = new List<pSeleccionarEmpresasCA_Result>();
                    List<pSeleccionarPed_Desp_Result> Lpd = new List<pSeleccionarPed_Desp_Result>();
                    Lca = context.pSeleccionarEmpresasCA(Usuario_Act).ToList();
                    if (Lca.Count() > 0) 
                    {
                        foreach (var item in Lca)
                        {
                            Lpd=context.pSeleccionarPed_Desp(item.co_empresa.Trim(), Desde, Hasta, Condicion, Status, Anulado).ToList();
                            if (Lpd.Count()>0)
                            {
                                foreach (var item2 in Lpd)
                                {
                                    LestTemp.Add(item2);
                                }
                            }
                        }
                    }
                }

                Lest = (from p in LestTemp
                        orderby p.semana, p.P_trans,p.VIP, p.P_Condi, p.P_Zona
                        select p).ToList();

            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void metroPend_Click(object sender, EventArgs e)
        {
            PanelPreparar.Visible = false;
            PanelCuliminar.Visible = false;
            PanelEst.Visible = true;
            grdEst.DataSource = "";
            Consultar(2, 0, false);
            btnImprimir.Enabled = false;
            grdEst.AutoGenerateColumns = false;
            grdEst.DataSource = Lest;
            btnPreparar.Enabled = Tip == 1;
            metroPend.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
            metroEproc.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroAnu.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroCCredito.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroCPrepago.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            
        }
        
        private void metroEproc_Click(object sender, EventArgs e)
        {
            PanelPreparar.Visible = false;
            PanelCuliminar.Visible = false;
            PanelEst.Visible = true;
            grdEst.DataSource = "";
            Consultar(2, 1, false);
            btnImprimir.Enabled = true;
            grdEst.AutoGenerateColumns = false;
            grdEst.DataSource = Lest;
            btnPreparar.Enabled = false;

            metroPend.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroEproc.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
            metroAnu.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroCCredito.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroCPrepago.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
        }

        private void metroAnu_Click(object sender, EventArgs e)
        {
            PanelPreparar.Visible = false;
            PanelCuliminar.Visible = false;
            PanelEst.Visible = true;
            grdEst.DataSource = "";
            Consultar(2, 0, true);
            btnImprimir.Enabled = false;
            grdEst.AutoGenerateColumns = false;
            grdEst.DataSource = Lest;
            btnPreparar.Enabled = false;

            metroPend.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroEproc.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroAnu.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
            metroCCredito.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroCPrepago.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
        }

        private void metroCCredito_Click(object sender, EventArgs e)
        {
            PanelPreparar.Visible = false;
            PanelCuliminar.Visible = false;
            PanelEst.Visible = true;
            grdEst.DataSource = "";
            Consultar(1, 2, false);
            btnImprimir.Enabled = false;
            grdEst.AutoGenerateColumns = false;
            grdEst.DataSource = Lest;
            btnPreparar.Enabled = false;

            metroPend.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroEproc.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroAnu.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroCCredito.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
            metroCPrepago.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
        }

        private void metroCPrepago_Click(object sender, EventArgs e)
        {
            PanelPreparar.Visible = false;
            PanelCuliminar.Visible = false;
            PanelEst.Visible = true;
            grdEst.DataSource = "";
            Consultar(0, 2, false);
            btnImprimir.Enabled = false;
            grdEst.AutoGenerateColumns = false;
            grdEst.DataSource = Lest;
            btnPreparar.Enabled = false;

            metroPend.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroEproc.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroAnu.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroCCredito.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            metroCPrepago.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            PanelPreparar.Visible = false;
            PanelCuliminar.Visible = false;
            PanelEst.Visible = false;
            btnImprimir.Enabled = false;
            btnPreparar.Enabled = false;
        }

        private void txtIdpedido_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnPedido;
        }

        private void txtCo_art_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void txtTotal_art_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnAgregar;
        }

        private void txtBultos_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnCulminar;
        }

        private void txtBultos_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Desea quitar el articulo seleccionado?","Profit Expansion",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)== System.Windows.Forms.DialogResult.Yes)
                {
                    if (Lpedido.Count() > 1)
                    {
                        int row = grdDatos.CurrentCell.RowIndex;
                        grdDatos.DataSource = "";
                        Lpedido.RemoveAt(row);
                        grdDatos.DataSource = Lpedido;
                        grdDatos.Refresh();
                        grdDatos.CurrentCell = grdDatos[1, row - 1];
                        
                    }
                    //else if (Lpedido.Count() == 1 )
                    //{
                    //    Lpedido.Clear();
                    //    grdDatos.DataSource = "";

                    //}
                }
                
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Lest.Count()>0)
                {
                    ImprimirTicket(Lest[grdEst.CurrentCell.RowIndex].rowguid.ToString());
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MetroEx_P_Click(object sender, EventArgs e)
        {
            FrmExcepcion_P Fep = new FrmExcepcion_P(Usuario_Act, Tip);
            Fep.Show();
        }

        private void MetroEx_H_Click(object sender, EventArgs e)
        {
            FrmExcepcion_H Fh = new FrmExcepcion_H(Usuario_Act, Tip);
            Fh.Show();
        }

        private void btnPreparar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea realmente preparar este pedido?", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Lest.Count() > 0)
                    {
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            //Escoge preparador
                            //string Preparador;
                            List<pNomiAsistentes_Result> Lpreparador = context.pNomiAsistentes(1).ToList();
                            if (Lpreparador.Count() == 0)
                            {
                                MessageBox.Show("No existen preparadores disponibles.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            Int32 i = grdEst.CurrentCell.RowIndex;
                            //Inserta Indicador de gestion
                            context.pInsertarIg_Pedido(
                                                        Lest[i].empresa,
                                                        Lpreparador[0].Nomina,
                                                        Lpreparador[0].cod_emp,
                                                        Lpreparador[0].nombre_completo,
                                                        System.DateTime.Now,
                                                        Lest[i].fact_num.Value,
                                                        System.DateTime.Now,
                                                        Convert.ToDateTime("01/01/1900"),
                                                        "",
                                                        false,
                                                        Lest[i].rowguid);
                            //Imprime ticket pedido

                            ImprimirTicket(Lest[i].rowguid.ToString());
                            context.pMarcarPedidoImpreso(Lest[i].fact_num, Lest[i].empresa.Trim());
                        }
                    }
                }
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}