using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using DevComponents.DotNetBar.Controls;

namespace ProfitContenedor
{
    public partial class FrmEntrega : DevComponents.DotNetBar.Metro.MetroForm
    {
        string Co_usu;
        Profit_E.pPedidosAlmDataTable DtP = new Profit_E.pPedidosAlmDataTable();
        Profit_E.pRengPedAlmDataTable DtRp = new Profit_E.pRengPedAlmDataTable();
        private Background _Background1 =  new Background(Color.White, Color.FromArgb(238, 244, 251), 45);
        private Background _Background2 = new Background(Color.FromArgb(249, 249, 234));

        Profit_E Ds = new Profit_E();

        public FrmEntrega()
        {
            InitializeComponent();
        }

        public FrmEntrega(String Co_usuario)
        {
            Co_usu = Co_usuario;
            InitializeComponent();
 
            GridPanel panel = superGridControl1.PrimaryGrid;
            panel.AutoGenerateColumns = false;
            panel.Name = "pPedidosAlm";
            panel.ShowToolTips = true;
            panel.MinRowHeight = 20;
            panel.DefaultVisualStyles.GroupByStyles.Default.Background = _Background1;
            panel.SelectionGranularity = SelectionGranularity.Cell;
            superGridControl1.DataBindingComplete += SuperGridControl1DataBindingComplete;
            
        }

        internal class PedidoButton : GridButtonXEditControl
        { 
            public PedidoButton()
            {
                Click += PedidoButtonClick;
            }

            private void PedidoButtonClick(object sender, EventArgs e)
            {

                if (EditorCell.GridRow[2].Value.ToString().StartsWith("<<PEDIDO ANULADO>>") == false && EditorCell.GridRow[2].Value.ToString().StartsWith("--RETIRADO--") == false)
                {
                    int Pedido = Convert.ToInt32(EditorCell.GridRow[0].Value);
                    string Empresa = EditorCell.GridRow[4].Value.ToString();

                    FrmE2 Fe2 = new FrmE2(Empresa, Pedido);
                    Fe2.Show();
                }
                else
                {
                    if (EditorCell.GridRow[2].Value.ToString().StartsWith("<<PEDIDO ANULADO>>")== true)
                        MessageBox.Show("El pedido se encuentra anulado, NO ENTREGAR MERCANCIA.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("El pedido ya ha sido retirado.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void SuperGridControl1DataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            GridPanel panel = e.GridPanel;

            panel.GroupByRow.Visible = true;

            switch (panel.DataMember)
            {
                case "pPedidosAlm":
                    CustomizePedPanel(panel);
                    break;

                case "pRengPedAlm":
                    CustomizeRengPanel(panel);
                    break;
                case "pPedidosRet":
                    CustomizePedPanel(panel);
                    break;

                case "pRengPedRet":
                    CustomizeRengPanel(panel);
                    break;

            }
        }

        private void CustomizePedPanel(GridPanel panel)
        {
            panel.FrozenColumnCount = 1;
            panel.ColumnHeader.RowHeight = 30;

            panel.Columns[0].CellStyles.Default.Background =
                new Background(Color.AliceBlue);

            foreach (GridColumn column in panel.Columns)
                column.ColumnSortMode = ColumnSortMode.Multiple;

            panel.Columns[0].Visible = true;
            panel.Columns[0].HeaderText = "Pedido";
            panel.Columns[0].Width = 100;
            panel.Columns[1].HeaderText = "Fecha";
            panel.Columns[1].Width = 100;
            panel.Columns[2].HeaderText = "Cliente";
            panel.Columns[2].Width = 500;
            panel.Columns[3].HeaderText = "Zona";
            panel.Columns[3].Width = 200;
            panel.Columns[0].EditorType = typeof(PedidoButton);   
        }

        private void CustomizeRengPanel(GridPanel panel)
        {
            panel.ShowRowGridIndex = true;
            panel.ShowRowDirtyMarker = true;
            panel.ColumnHeader.RowHeight = 30;

            panel.Columns[0].CellStyles.Default.Background =
                new Background(Color.Beige);

            panel.Caption = new GridCaption();

            panel.Caption.Text = String.Format("Renglones ({0}) para el cliente <font color=\"Maroon\"><i>\"{1}</i>\"</font>",
                panel.Rows.Count, ((GridRow)panel.Parent)["Cli_des"].Value);

            panel.DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft;
            panel.DefaultVisualStyles.GroupByStyles.Default.Background = _Background2;

            panel.Columns[0].Visible = false;
            panel.Columns[1].HeaderText = "Renglon";
            panel.Columns[1].Width = 60;
            panel.Columns[2].HeaderText = "Codigo";
            panel.Columns[2].Width = 100;
            panel.Columns[3].HeaderText = "Descripcion";
            panel.Columns[3].Width = 350;
            panel.Columns[4].HeaderText = "Cantidad";
            panel.Columns[4].Width = 80;
            panel.Columns[5].HeaderText = "Ubicacion";
            panel.Columns[5].Width = 120;
        }

        private void FrmEntrega_Load(object sender, EventArgs e)
        {
            try
            {
                txtDesde.Value = System.DateTime.Today.Date.AddDays((Convert.ToInt32(System.DateTime.Today.DayOfWeek - 1))*-1);
                txtHasta.Value = System.DateTime.Today.Date;
                timer1_Tick(sender, e);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var Ds = new Profit_E();
                
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var ue = context.Usu_Emp.Where(uem => uem.co_usuario == Co_usu.Trim()).ToList();
                    foreach (var item in ue)
                    {
                        if (item.co_empresa.Trim() == "STAR01" || item.co_empresa.Trim() == "SERVICE")
                        {

                            if (chkPend.CheckState == CheckState.Checked)
                            {
                                List<pPedidosAlm_Result> ped = new List<pPedidosAlm_Result>();
                                ped = context.pPedidosAlm(item.co_empresa, txtDesde.Value, txtHasta.Value,false).ToList();
                                foreach (var p in ped)
                                {
                                    var r = Ds.Tables["pPedidosAlm"].NewRow();
                                    r["Fact_num"] = p.fact_num;
                                    r["Fec_emis"] = p.fec_emis;
                                    r["Cli_des"] = p.cli_des.Trim();
                                    r["Zon_des"] = p.zon_des.Trim();
                                    r["Empresa"] = item.co_empresa.Trim();

                                    Ds.Tables["pPedidosAlm"].Rows.Add(r);
                                }
                                var rped = context.pRengPedAlm(item.co_empresa, txtDesde.Value, txtHasta.Value);
                                foreach (var p in rped)
                                {
                                    var rp = Ds.Tables["pRengPedAlm"].NewRow();
                                    rp["Fact_num"] = p.fact_num;
                                    rp["Reng_num"] = p.reng_num;
                                    rp["Co_art"] = p.co_art.Trim();
                                    rp["Art_des"] = p.art_des.Trim();
                                    rp["Total_art"] = p.total_art;
                                    rp["Ubicacion"] = p.ubicacion.Trim();

                                    Ds.Tables["pRengPedAlm"].Rows.Add(rp);
                                }

                                superGridControl1.PrimaryGrid.DataSource = Ds;
                                superGridControl1.PrimaryGrid.DataMember = "pPedidosAlm";
                            }
                            if (chkAnu.CheckState == CheckState.Checked)
                            {
                                List<pPedidosAlm_Result> ped = new List<pPedidosAlm_Result>();
                                ped = context.pPedidosAlm(item.co_empresa, txtDesde.Value, txtHasta.Value,true).ToList();
                                foreach (var p in ped)
                                {
                                    var r = Ds.Tables["pPedidosAlm"].NewRow();
                                    r["Fact_num"] = p.fact_num;
                                    r["Fec_emis"] = p.fec_emis;
                                    r["Cli_des"] = p.cli_des.Trim();
                                    r["Zon_des"] = p.zon_des.Trim();
                                    r["Empresa"] = item.co_empresa.Trim();

                                    Ds.Tables["pPedidosAlm"].Rows.Add(r);
                                }
                                var rped = context.pRengPedAlm(item.co_empresa, txtDesde.Value, txtHasta.Value);
                                foreach (var p in rped)
                                {
                                    var rp = Ds.Tables["pRengPedAlm"].NewRow();
                                    rp["Fact_num"] = p.fact_num;
                                    rp["Reng_num"] = p.reng_num;
                                    rp["Co_art"] = p.co_art.Trim();
                                    rp["Art_des"] = p.art_des.Trim();
                                    rp["Total_art"] = p.total_art;
                                    rp["Ubicacion"] = p.ubicacion.Trim();

                                    Ds.Tables["pRengPedAlm"].Rows.Add(rp);
                                }

                                superGridControl1.PrimaryGrid.DataSource = Ds;
                                superGridControl1.PrimaryGrid.DataMember = "pPedidosAlm";
                            }
                            if (chkRet.CheckState == CheckState.Checked)
                            {
                                List<pPedidosRet_Result> ped = new List<pPedidosRet_Result>();
                                ped = context.pPedidosRet(item.co_empresa, txtDesde.Value, txtHasta.Value).ToList();
                                foreach (var p in ped)
                                {
                                    var r = Ds.Tables["pPedidosRet"].NewRow();
                                    r["Fact_num"] = p.fact_num;
                                    r["Fec_emis"] = p.fec_emis;
                                    r["Cli_des"] = p.cli_des.Trim();
                                    r["Zon_des"] = p.zon_des.Trim();
                                    r["Empresa"] = item.co_empresa.Trim();

                                    Ds.Tables["pPedidosRet"].Rows.Add(r);
                                }
                                var rped = context.pRengPedRet(item.co_empresa, txtDesde.Value, txtHasta.Value);
                                foreach (var p in rped)
                                {
                                    var rp = Ds.Tables["pRengPedRet"].NewRow();
                                    rp["Fact_num"] = p.fact_num;
                                    rp["Reng_num"] = p.reng_num;
                                    rp["Co_art"] = p.co_art.Trim();
                                    rp["Art_des"] = p.art_des.Trim();
                                    rp["Total_art"] = p.total_art;
                                    rp["Ubicacion"] = p.ubicacion.Trim();

                                    Ds.Tables["pRengPedRet"].Rows.Add(rp);
                                }

                                superGridControl1.PrimaryGrid.DataSource = Ds;
                                superGridControl1.PrimaryGrid.DataMember = "pPedidosRet";
                            }                            
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnActualizar_Click(sender, e);
        }

        private void chkPend_CheckedChanged(object sender, EventArgs e)
        {
            btnActualizar_Click(sender, e);
        }

        private void chkRet_CheckedChanged(object sender, EventArgs e)
        {
            btnActualizar_Click(sender, e);
        }
    }
}