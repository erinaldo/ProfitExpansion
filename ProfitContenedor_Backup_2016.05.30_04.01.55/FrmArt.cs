using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;

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

        public FrmArt(string Co_usuario)
        {
            InitializeComponent();
            Co_usu = Co_usuario;    
        }

        private void FrmArt_Load(object sender, EventArgs e)
        {
            try
            {
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
                        txtCo_alma.Text = Pstock[0].Almacen.Trim();
                        txtAlm_des.Text = context.pSeleccionarAlmacenEmpresa(Pstock[0].Almacen.Trim(), Pstock[0].Emp_Art.Trim()).First().alm_des.Trim();
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
                txtCo_art_Leave(sender, e);
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    GrdStock.AutoGenerateColumns = false;
                    var lEmpAut = context.pSeleccionarEmpresasCA(Co_usu.Trim()).ToList();
                    List<Stock> LStock = new List<Stock>();
                    foreach (var item in lEmpAut)
                    {
                        var lstStock = context.pSeleccionarStock(item.co_empresa.Trim(), txtCo_alma.Text.Trim(), txtCo_art.Text.Trim()).ToList();
                        if (lstStock.Count > 0)
                        {
                            LStock.Add(new Stock { empresa = item.co_empresa,
                                                   stock_act = lstStock[0].STOCK_ACT, 
                                                   stock_com = lstStock[0].STOCK_COM,
                                                   stock_dis = lstStock[0].STOCK_DIS,
                                                   stock_lle = lstStock[0].STOCK_Lle,
                                        });
                        }
                    }
                    
                    GrdStock.DataSource = LStock;
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
                    var a = context.pSeleccionarAlmacenEmpresa(txtCo_alma.Text.Trim(), Emp).First();
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

                        GrdFact.DataSource = context.pUltimasFacturas(em, txtCo_alma.Text.Trim(), txtCo_art.Text.Trim());
                        GrdPed.AutoGenerateColumns = false;
                        GrdPed.DataSource = context.pPedidosPendientes(em, txtCo_alma.Text.Trim(), txtCo_art.Text.Trim());
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

        private void txtCo_art_Leave(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var art = context.pSeleccionarArticulo(Emp, txtCo_art.Text.Trim()).First();
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