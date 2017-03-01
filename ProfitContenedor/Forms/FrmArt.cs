using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;
using System.Data.Entity.Core;

namespace ProfitContenedor
{
    public partial class FrmArt : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmArt()
        {
            InitializeComponent();
        }

        string Emp;
        string Co_usu;
        Int32 N;

        public FrmArt(string Co_usuario,int Nivel)
        {
            InitializeComponent();
            Co_usu = Co_usuario;
            N = Nivel;
        }

        private void FrmArt_Load(object sender, EventArgs e)
        {
            try
            {
                cboTipoBus.SelectedIndex = 0;
                txtCo_empresa.Enabled = N == 1;
                txtCo_alma.Enabled = N == 1;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var Pstock = context.pSeleccionarPantalla_Stock(Co_usu.Trim()).ToList();
                    if (Pstock.Count == 0)
                    {
                        MessageBox.Show("Debe configurar la pantalla para el usuario activo.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnBuscar.Enabled = false;
                    }
                    else
                    {
                        txtCo_empresa.Text = Pstock[0].Emp_Art.Trim();
                        txtCo_alma.Text = Pstock[0].Almacen.Trim();
                        txtAlm_des.Text = context.pSeleccionarAlmacenEmpresa(Pstock[0].Almacen.Trim(), txtCo_empresa.Text).FirstOrDefault().alm_des.Trim();
                        Emp = Pstock[0].Emp_Art.Trim();
                        txtCo_art.Focus();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCo_art.Text.Trim().Length > 0)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        if (cboTipoBus.SelectedIndex == 0)
                        {
                            GrdStock.AutoGenerateColumns = false;
                            var lEmpAut = context.pSeleccionarEmpresasCA(Co_usu.Trim()).ToList();
                            List<Stock> LStock = new List<Stock>();
                            foreach (var item in lEmpAut)
                            {
                                var lstStock = context.pSeleccionarStock(item.co_empresa.Trim(), txtCo_alma.Text.Trim(), txtCo_art.Text.Trim()).ToList();
                                if (lstStock.Count > 0)
                                {
                                    LStock.Add(new Stock
                                    {
                                        empresa = item.co_empresa,
                                        stock_act = lstStock[0].STOCK_ACT,
                                        stock_com = lstStock[0].STOCK_COM,
                                        stock_dis = lstStock[0].STOCK_DIS,
                                        stock_lle = lstStock[0].STOCK_Lle
                                    });
                                }
                            }
                            GrdStock.DataSource = LStock;
                            txtCo_art_Leave(sender, e);
                        }
                        else
                        {
                            grdArt.AutoGenerateColumns = false;
                            List<pSeleccionarArticuloDescrip_Result> Lart = new List<pSeleccionarArticuloDescrip_Result>();
                            Lart = context.pSeleccionarArticuloDescrip(txtCo_empresa.Text.Trim(), "'%" + txtCo_art.Text.Trim() + "%'").ToList();
                            grdArt.DataSource = Lart;

                        }
                    }
                    if (grdArt.RowCount > 0)
                    {
                        grdArt.Focus();
                        grdArt.CurrentCell = grdArt[0, 0];
                        txtCo_art_Leave(sender, e);
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

        private void txtCo_alma_Leave(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var a = context.pSeleccionarAlmacenEmpresa(txtCo_alma.Text.Trim(), Emp).FirstOrDefault();
                    if (a == null)
                        txtAlm_des.Text = "NO ENCONTRADO";
                    else
                        txtAlm_des.Text = a.alm_des.Trim();
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

        private void GrdStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GrdStock.RowCount > 0)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        GrdFact.AutoGenerateColumns = false;
                        string em = GrdStock[0, e.RowIndex].Value.ToString();

                        GrdFact.DataSource = context.pUltimasFacturas(em, txtCo_alma.Text.Trim(), cboTipoBus.SelectedIndex == 0 ? txtCo_art.Text.Trim() : grdArt[0,grdArt.CurrentCell.RowIndex].Value.ToString().Trim());
                        GrdPed.AutoGenerateColumns = false;
                        GrdPed.DataSource = context.pPedidosPendientes(em, txtCo_alma.Text.Trim(), cboTipoBus.SelectedIndex == 0 ? txtCo_art.Text.Trim() : grdArt[0, grdArt.CurrentCell.RowIndex].Value.ToString().Trim());
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

        private void GrdStock_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            GrdStock_CellClick(sender, e);
        }

        private void txtCo_art_KeyDown(object sender, KeyEventArgs e)
        {
            if (cboTipoBus.SelectedIndex == 0)
            {
                if (e.KeyCode == Keys.F2)
                {
                    FrmBuscar Fe = new FrmBuscar(txtCo_art, txtArt_des, "Articulo");
                    Fe.Show();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    txtCo_art_Leave(sender, e);
                    btnBuscar_Click(sender, e);
                }
            }
        }

        private void txtCo_art_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCo_art.Text.Trim().Length > 0)
                {
                    if (cboTipoBus.SelectedIndex == 0)
                    {
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            var art = context.pSeleccionarArticulo(Emp, txtCo_art.Text.Trim()).FirstOrDefault();
                            if (art == null)
                            {
                                txtArt_des.Text = "NO ENCONTRADO";
                                txtP1.Value = 0;
                                txtP2.Value = 0;
                                txtP3.Value = 0;
                                txtP4.Value = 0;
                                txtUe.Value = 0;
                            }
                            else
                            {
                                txtArt_des.Text = art.art_des.Trim();
                                txtP1.Value = Convert.ToDouble(art.p1);
                                txtP2.Value = Convert.ToDouble(art.p2);
                                txtP3.Value = Convert.ToDouble(art.p3);
                                txtP4.Value = Convert.ToDouble(art.p4);
                                txtUe.Value = Convert.ToDouble(art.uni_relac);
                            }
                        }
                    }
                    else
                    {
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            var art = context.pSeleccionarArticulo(Emp, grdArt[0, grdArt.CurrentCell.RowIndex].Value.ToString().Trim()).FirstOrDefault();
                            if (art == null)
                            {
                                txtArt_des.Text = "NO ENCONTRADO";
                                txtP1.Value = 0;
                                txtP2.Value = 0;
                                txtP3.Value = 0;
                                txtP4.Value = 0;
                                txtUe.Value = 0;
                            }
                            else
                            {
                                txtArt_des.Text = art.art_des.Trim();
                                txtP1.Value = Convert.ToDouble(art.p1);
                                txtP2.Value = Convert.ToDouble(art.p2);
                                txtP3.Value = Convert.ToDouble(art.p3);
                                txtP4.Value = Convert.ToDouble(art.p4);
                                txtUe.Value = Convert.ToDouble(art.uni_relac);
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

        private void txtCo_empresa_Leave(object sender, EventArgs e)
        {
            Emp = txtCo_empresa.Text.Trim();
        }

        private void grdArt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdArt.RowCount > 0)
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    txtCo_art_Leave(sender, e);
                    GrdStock.AutoGenerateColumns = false;
                    var lEmpAut = context.pSeleccionarEmpresasCA(Co_usu.Trim()).ToList();
                    List<Stock> LStock = new List<Stock>();
                    foreach (var item in lEmpAut)
                    {
                        var lstStock = context.pSeleccionarStock(item.co_empresa.Trim(), txtCo_alma.Text.Trim(), grdArt[0, e.RowIndex].Value.ToString().Trim()).ToList();
                        if (lstStock.Count > 0)
                        {
                            LStock.Add(new Stock
                            {
                                empresa = item.co_empresa,
                                stock_act = lstStock[0].STOCK_ACT,
                                stock_com = lstStock[0].STOCK_COM,
                                stock_dis = lstStock[0].STOCK_DIS,
                                stock_lle = lstStock[0].STOCK_Lle
                            });
                        }
                    }
                    GrdStock.DataSource = LStock;    
                }
            }
        }

        private void cboTipoBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCo_art.Text = "";
            GrdStock.DataSource = "";
            GrdFact.DataSource = "";
            GrdPed.DataSource = "";
            txtArt_des.Text = "--";
            txtP1.Value = 0;
            txtP2.Value = 0;
            txtP3.Value = 0;
            txtP4.Value = 0;
            txtUe.Value = 0;
        }

        private void grdArt_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            grdArt_CellClick(sender, e);
        }

        private void btnHprecios_Click(object sender, EventArgs e)
        {
            if (cboTipoBus.SelectedIndex == 0)
            {
                Fhprecios Fh = new Fhprecios(txtCo_art.Text.Trim());
                Fh.Show();
            }
            else
            {
                if (grdArt.RowCount>0)
                {
                    Fhprecios Fh = new Fhprecios(grdArt[0, grdArt.CurrentCell.RowIndex].Value.ToString().Trim());
                    Fh.Show();    
                }
            }
        }
    }
}