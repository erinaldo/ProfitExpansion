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
    public partial class FrmOrd : DevComponents.DotNetBar.Metro.MetroForm
    {

        Boolean Nuevo = false;
        byte[] Validador;
        List<pSeleccionarOrdenes_Reng_Result> detalle = new List<pSeleccionarOrdenes_Reng_Result>();
        List<pSeleccionarArticulo_Result> articulos = new List<pSeleccionarArticulo_Result>();
        TextBox Tc = new TextBox();
        TextBox Td = new TextBox();


        public FrmOrd()
        {
            InitializeComponent();
            Tc.TextChanged += Tc_TextChanged;
            Td.TextChanged += Td_TextChanged;
        }

        void Td_TextChanged(object sender, EventArgs e)
        {
            if (detalle[grdDatos.CurrentCell.RowIndex].art_des.Trim() != Td.Text.Trim() && Td.Text.Trim().Length>0)
            {
                detalle[grdDatos.CurrentCell.RowIndex].art_des = Td.Text.Trim() ?? detalle[grdDatos.CurrentCell.RowIndex].art_des;
                grdDatos.DataSource = "";
                grdDatos.DataSource = detalle;
            }
            Td.Text = "";
        }

        void Tc_TextChanged(object sender, EventArgs e)
        {
            if (detalle[grdDatos.CurrentCell.RowIndex].co_art.Trim() != Tc.Text.Trim() && Tc.Text.Trim().Length > 0)
            {
                detalle[grdDatos.CurrentCell.RowIndex].co_art = Tc.Text.Trim() ?? detalle[grdDatos.CurrentCell.RowIndex].co_art;
                grdDatos.DataSource = "";
                grdDatos.DataSource = detalle;
            }
            Tc.Text = "";
        }

        private void FrmOrd_Load(object sender, EventArgs e)
        {
            try
            {
                txtFact_num.Value = 0;
                Navegar(3);
                grdDatos.AutoGenerateColumns = false;
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                grdDatos.AutoGenerateColumns = false;

                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    pSeleccionarOrdenes_Result ordenes = new pSeleccionarOrdenes_Result();
                    var pord = context.pObtenerTablaInt(txtFact_num.Value, "fact_num", p, "Ordenes").ToList();
                    var iPord = context.Ordenes.ToList();
                    if (pord.Count()>0)
                    {
                        ordenes = context.pSeleccionarOrdenes(pord[0].Value).FirstOrDefault();
                        txtFact_num.Value = ordenes.fact_num;
                        txtEmpresa.Text = ordenes.empresa.Trim();
                        articulos = context.pSeleccionarArticulo(txtEmpresa.Text.Trim(), null).ToList();
                        txtEmp_des.Text = context.pSeleccionarEmpresa(ordenes.empresa.Trim()).FirstOrDefault().des_emp.Trim();
                        txtProv.Text = ordenes.co_prov.Trim();
                        txtProv_des.Text = ordenes.prov_des.Trim();
                        txtFecha.Value = ordenes.fecha;
                        txtObserv.Text = ordenes.observ.Trim();
                        Validador = ordenes.validador;
                        lblStatus.Text = ordenes.anulado == true ? "ANULADO" : ordenes.status == 0 ? "Sin procesar" : ordenes.status == 1 ? "Parc.Procesada" : "Procesada";
                        CargarDetalle(context, pord[0].Value);
                    }
                    else
                    {
                        if (iPord.Count() == 0)
                        {
                            MessageBox.Show("No existen registros que mostrar. Se iniciara en modo agregar!", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (ordenes.validador != null)
                                LimpiarControles();
                            else
                                Validador = null;
                            NuevoRegistro();
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

        private void LimpiarControles()
        {
            lblStatus.Text = "Sin procesar.";
            txtFact_num.Value = 0;
            txtEmpresa.Text = "";
            txtEmp_des.Text = "";
            txtProv.Text = "";
            txtProv_des.Text = "";
            txtFecha.Value = System.DateTime.Today;
            txtObserv.Text = "";
            Validador = null;
            detalle.Clear();
            grdDatos.DataSource = "";
        }

        private void CargarDetalle(Profit_RGEntities context, Int32? Orden)
        {
            detalle = context.pSeleccionarOrdenes_Reng(Orden).ToList();
            grdDatos.DataSource = detalle;
            txtTotal.Value = Convert.ToDouble(detalle.Sum(a => a.reng_neto).Value);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            Navegar(0);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Navegar(1);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Navegar(2);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            Navegar(3);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoRegistro();
        }

        private void NuevoRegistro()
        {
            Nuevo = true;
            LimpiarControles();
            NuevoRenglon();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Nuevo == true)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {

                        int Factura = Convert.ToInt32(context.pObtenerProximoConsecutivo("Ord_num",true).FirstOrDefault().Value);
                        context.pInsertarOrdenes(Factura, txtEmpresa.Text.Trim(), txtProv.Text.Trim(),
                                                    txtProv_des.Text.Trim(), txtFecha.Value, txtObserv.Text.Trim(),
                                                    0, Convert.ToDecimal(txtTotal.Value));
                        foreach (var item in detalle)
                        {
                            if (item.co_art.Trim().Length>0)
                                context.pInsertarOrdenes_Reng(Factura, item.reng_num, item.co_art.Trim(),
                                                            item.art_des.Trim(), item.total_art,
                                                            item.precio, item.total_art);
                        }
                    }
                }
                else
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {

                        int Factura = txtFact_num.Value;
                        context.pActualizarOrdenes(Factura, txtEmpresa.Text.Trim(), txtProv.Text.Trim(),
                                                    txtProv_des.Text.Trim(), txtFecha.Value, txtObserv.Text.Trim(),
                                                    0,false,Convert.ToDecimal(txtTotal.Value),Validador);
                        context.pEliminarReng_Ordenes(Factura);
                        foreach (var item in detalle)
                        {
                            if (item.co_art.Trim().Length > 0)
                            context.pInsertarOrdenes_Reng(Factura, item.reng_num, item.co_art.Trim(),
                                                       item.art_des.Trim(), item.total_art,
                                                       item.precio, item.total_art);
                        }
                    }
                }
                Navegar(5);
                MessageBox.Show(this, "Se ha guardado la informacion satisfactoriamente.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    context.pEliminarOrdenes(Validador);
                    Navegar(5);
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

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            Navegar(5);
        }
        
        private void btnAgregarR_Click(object sender, EventArgs e)
        {
            try
            {
                NuevoRenglon();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NuevoRenglon()
        {
            try
            {
                Int32 r = detalle.Count() + 1;
                pSeleccionarOrdenes_Reng_Result Renglon = new pSeleccionarOrdenes_Reng_Result();
                Renglon.reng_num = r;
                Renglon.co_art = "";
                Renglon.art_des = "";
                Renglon.fact_num = txtFact_num.Value;
                Renglon.total_art = 0.00m;
                Renglon.precio = 0.00m;
                Renglon.reng_neto = 0.00m;
                Renglon.pendiente = Renglon.total_art;

                detalle.Add(Renglon);
                grdDatos.DataSource = "";
                grdDatos.DataSource = detalle;
                grdDatos.Refresh();
                grdDatos.CurrentCell = grdDatos[1, detalle.Count() - 1];
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea quitar este renglon?", "Profit Expansion", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    int row = grdDatos.CurrentCell.RowIndex;
                    if (row > 0 && detalle[row].pendiente==detalle[row].total_art)
                    {
                        detalle.RemoveAt(grdDatos.CurrentCell.RowIndex);
                        int i = 1;
                        foreach (var item in detalle)
                        {
                            item.reng_num = i;
                            i++;
                        }
                        grdDatos.DataSource = "";
                        grdDatos.DataSource = detalle;
                        grdDatos.Refresh();
                        grdDatos.CurrentCell = grdDatos[1, row - 1];
                    }
                    else
                    {
                        if (detalle[row].pendiente != detalle[row].total_art)
                            MessageBox.Show(this, "No se puede eliminar un renglon parcial/totalmente procesado!", "Proft Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (row == 0)
                            {
                                MessageBox.Show(this, "No se puede dejar el detalle sin renglones!", "Proft Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }                     
                    }
                    
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtEmpresa_Leave(object sender, EventArgs e)
        {
            try
            {
                List<Empresa> Dt = new List<Empresa>();
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    Dt = context.Empresas.ToList();
                
                    var Emp = Dt.FirstOrDefault(c => c.co_empresa.Trim() == txtEmpresa.Text.Trim());
                    if (Emp == null)
                    {
                        txtEmp_des.Text = "NO ENCONTRADO";
                    }
                    else
                    {
                        txtEmp_des.Text = Emp.des_emp.Trim();
                        articulos = context.pSeleccionarArticulo(txtEmpresa.Text.Trim(), null).ToList();
                    }
                }
            }
            catch (DataException ex0)
            {
                MessageBox.Show(ex0.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtProv_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpresa.TextLength != 0 && txtEmp_des.Text.Trim().Length>0 && txtEmp_des.Text != "NO ENCONTRADO")
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        txtProv_des.Text = context.pSeleccionarProv(txtEmpresa.Text.Trim(), txtProv.Text.Trim()).FirstOrDefault().prov_des.Trim();
                    }
                }
                else
                {
                    MessageBox.Show("Debe elegir una empresa primero!", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmpresa.Focus();
                }
            }
            catch (DataException ex0)
            {
                MessageBox.Show(ex0.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FrmBuscar Fe = new FrmBuscar(txtEmpresa, txtEmp_des, "Empresa");
                Fe.Text = "Empresas";
                Fe.Show();
            }
        }

        private void txtProv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FrmBuscar Fe = new FrmBuscar(txtProv, txtProv_des, "Proveedor",txtEmpresa.Text.Trim());
                Fe.Text = "Proveedores";
                Fe.Show();
            }
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (grdDatos.RowCount > 0 && grdDatos.RowCount>-1)
            {
                int icolumn = grdDatos.CurrentCell.ColumnIndex;
                int irow = grdDatos.CurrentCell.RowIndex;


                if (keyData == Keys.Enter)
                {
                    if (icolumn == grdDatos.Columns.Count - 1 || icolumn == 4)
                    {
                        if (MessageBox.Show("Desea agregar un nuevo renglon?", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                        {
                            NuevoRenglon();
                            grdDatos.CurrentCell = grdDatos[1, irow + 1];
                        }
                        else
                        {
                            grdDatos.CurrentCell = grdDatos[1, irow];
                        }
                    }
                    else
                    {
                        grdDatos.CurrentCell = grdDatos[icolumn == 1 ? 3 : icolumn + 1, irow];
                    }
                    return true;
                }
                if (keyData == Keys.F2 && txtEmpresa.Focused==false && txtProv.Focused==false)
                {
                    if (icolumn == 1)
                    {
                        FrmBuscar Fb = new FrmBuscar(Tc, Td, "Articulo", txtEmpresa.Text.Trim());
                        Fb.Text = "Articulos";
                        Fb.Show();
                        return true;
                    }
                    else
                    {
                        return base.ProcessCmdKey(ref msg, keyData);
                    }
                }
                else
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void grdDatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (txtEmpresa.TextLength > 0 && detalle.Count() > -1 && detalle.Count()>e.RowIndex)
                {
                    switch (e.ColumnIndex)
                    {
                        case 1:
                            using (Profit_RGEntities context = new Profit_RGEntities())
                            {
                                string sArt_des = articulos.FirstOrDefault(a => a.co_art.Trim() == grdDatos[1, e.RowIndex].Value.ToString().Trim()).art_des.Trim();
                                detalle[e.RowIndex].art_des = sArt_des;
                            }
                            break;
                        case 3:
                        case 4:
                            grdDatos[5,e.RowIndex].Value = Convert.ToDecimal(detalle[e.RowIndex].total_art * detalle[e.RowIndex].precio);
                            grdDatos[6, e.RowIndex].Value = detalle[e.RowIndex].validador == null ?
                                                            Convert.ToDecimal(detalle[e.RowIndex].total_art) :
                                                            Convert.ToDecimal(detalle[e.RowIndex].pendiente);
                            txtTotal.Value = Convert.ToDouble(detalle.Sum(a => a.reng_neto).Value);
                            break;
                    }
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}