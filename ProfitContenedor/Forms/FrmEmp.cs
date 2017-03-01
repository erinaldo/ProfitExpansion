using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitContenedor
{
    public partial class FrmEmp : DevComponents.DotNetBar.Metro.MetroForm
    {
        Boolean Nuevo = false;
        byte[] Validador;

        public FrmEmp()
        {
            InitializeComponent();
        }

        private void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    pSeleccionarEmpresa_Result empresa = new pSeleccionarEmpresa_Result();
                    var pemp = context.pObtenerTablaStr(txtCo_empresa.Text.Trim(), "co_empresa", p, "Empresas").ToList();
                    if (pemp.Count > 0)
                    {
                        empresa = context.pSeleccionarEmpresa(pemp[0].Trim()).FirstOrDefault();
                        txtCo_empresa.Text = empresa.co_empresa.Trim();
                        txtDes_emp.Text = empresa.des_emp.Trim();
                        txtEmail.Text = empresa.email.Trim();
                        txtClave.Text = MC.GetString(empresa.clave).Trim();
                        txtServidor.Text = empresa.servidor.Trim();
                        txtPuerto.Value = empresa.puerto;
                        OptSSL.CheckState = empresa.ssl == 1 ? CheckState.Checked : CheckState.Unchecked;
                        txtAlma.Text = empresa.almacen.Trim();
                        txtCo_moneda.Text = empresa.moneda.Trim();
                        txtFpago.Text = empresa.forma_pag.Trim();
                        txtCo_tran.Text = empresa.co_tran.Trim();
                        txtCo_sucu.Text = empresa.co_sucu.Trim();
                        txtNomina.Text = empresa.nomina == null ? "" : empresa.nomina.Trim();
                        txtContab.Text = empresa.contab == null ? "" : empresa.contab.Trim();

                        
                        pSeleccionarAlmacenEmpresa_Result a = context.pSeleccionarAlmacenEmpresa(txtAlma.Text.Trim(), txtCo_empresa.Text.Trim()).FirstOrDefault();
                        txtAlm_des.Text = a == null ? "NO ENCONTRADO" : a.alm_des.Trim();

                        pSeleccionarFormaPago_Result b = context.pSeleccionarFormaPago(txtCo_empresa.Text.Trim(), txtFpago.Text.Trim()).FirstOrDefault();
                        txtFpDescrip.Text = b == null ? "NO ENCONTRADO" : b.cond_des.Trim();

                        pSeleccionarMoneda_Result c = context.pSeleccionarMoneda(txtCo_empresa.Text.Trim(), txtCo_moneda.Text.Trim()).FirstOrDefault();
                        txtMoneda.Text = c == null ? "NO ENCONTRADO" : c.mone_des.Trim();
                        
                        pSeleccionarTransporte_Result d = context.pSeleccionarTransporte(txtCo_empresa.Text.Trim(), txtCo_tran.Text.Trim()).FirstOrDefault();
                        txtDes_tran.Text = d == null ? "NO ENCONTRADO" : d.des_tran.Trim();
                        
                        pSeleccionarSucursal_Result f = context.pSeleccionarSucursal(txtCo_empresa.Text.Trim(), txtCo_sucu.Text.Trim()).FirstOrDefault();
                        txtSucursal.Text = f == null ? "NO ENCONTRADO" : f.sucu_des.Trim();

                        Validador = empresa.validador;
                    }
                    else
                    {
                        if (empresa.validador != null)
                            LimpiarControles();
                        else
                            Validador = null;
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
            txtCo_empresa.Text = "";
            txtDes_emp.Text = "";
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
            try
            {
                Nuevo = true;
                LimpiarControles();
                txtCo_empresa.Focus();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Nuevo == true)
                {
                    if (superValidator1.Validate() == true)
                    {
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            context.pInsertarEmpresa(txtCo_empresa.Text.Trim(), txtDes_emp.Text.Trim(), txtEmail.Text.Trim(),
                                txtServidor.Text.Trim(), txtPuerto.Value,OptSSL.CheckState == CheckState.Checked ? 1 : 0,
                                MC.GetBytes(txtClave.Text.Trim()),
                                txtAlma.Text.Trim(),
                                txtCo_tran.Text.Trim(), 
                                txtFpago.Text.Trim(),
                                txtCo_moneda.Text.Trim(),
                                txtCo_sucu.Text.Trim(),
                                txtNomina.Text.Trim(),
                                txtContab.Text.Trim());
                        }
                        Navegar(5);
                    }
                }
                else
                {
                    if (superValidator1.Validate() == true)
                    {
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            context.pActualizarEmpresa(txtCo_empresa.Text.Trim(), txtDes_emp.Text.Trim(), txtEmail.Text.Trim(), MC.GetBytes(txtClave.Text.Trim()),
                                txtServidor.Text.Trim(), txtPuerto.Value, OptSSL.CheckState == CheckState.Checked ? 1 : 0,
                                txtAlma.Text.Trim(), Validador,
                                txtCo_tran.Text.Trim(),
                                txtFpago.Text.Trim(),
                                txtCo_moneda.Text.Trim(),
                                txtCo_sucu.Text.Trim(),
                                txtNomina.Text.Trim(),
                                txtContab.Text.Trim());
                        }
                        Navegar(5);
                    }
                }
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
                if (MessageBox.Show("Desea eliminar este registro?", "Profit Contenedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        context.pEliminarEmpresa(Validador);
                        Navegar(2);
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

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            Navegar(5);
        }

        private void FrmEmp_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                    List<Empresa> Le = context.Empresas.ToList();
                    foreach (var item in Le)
                    {
                        source.Add(item.co_empresa.Trim());
                    }
                                        
                    txtBuscar.AutoCompleteCustomSource = source;

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
            Navegar(0);

        }

        private void txtBuscar_LostFocus(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                Nuevo = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    pSeleccionarEmpresa_Result empresa = new pSeleccionarEmpresa_Result();
                    var pemp = context.Empresas.Where(em => em.co_empresa == txtBuscar.Text.Trim()).ToList();
                    if (pemp.Count > 0)
                    {
                        empresa = context.pSeleccionarEmpresa(pemp[0].co_empresa.Trim().ToUpper()).FirstOrDefault();
                        txtCo_empresa.Text = empresa.co_empresa.Trim();
                        txtDes_emp.Text = empresa.des_emp.Trim();
                        txtEmail.Text = empresa.email.Trim();
                        txtClave.Text = MC.GetString(empresa.clave).Trim();
                        txtServidor.Text = empresa.servidor.Trim();
                        txtPuerto.Value = empresa.puerto;
                        OptSSL.CheckState = empresa.ssl == 1 ? CheckState.Checked : CheckState.Unchecked;
                        Validador = empresa.validador;
                        txtBuscar.Text = "";
                        txtCo_empresa.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El registro no existe", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBuscar.Focus();
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

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void txtAlma_Leave(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var a = context.pSeleccionarAlmacenEmpresa(txtAlma.Text.Trim(), txtCo_empresa.Text.Trim()).FirstOrDefault();
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

        private void txtCo_moneda_Leave(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    pSeleccionarMoneda_Result c = context.pSeleccionarMoneda(txtCo_empresa.Text.Trim(), txtCo_moneda.Text.Trim()).FirstOrDefault();
                    txtMoneda.Text = c == null ? "NO ENCONTRADO" : c.mone_des.Trim();
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

        private void txtFpago_Leave(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    pSeleccionarFormaPago_Result b = context.pSeleccionarFormaPago(txtCo_empresa.Text.Trim(), txtFpago.Text.Trim()).FirstOrDefault();
                    txtFpDescrip.Text = b == null ? "NO ENCONTRADO" : b.cond_des.Trim();
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

        private void txtCo_tran_Leave(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    pSeleccionarTransporte_Result d = context.pSeleccionarTransporte(txtCo_empresa.Text.Trim(), txtCo_tran.Text.Trim()).FirstOrDefault();
                    txtDes_tran.Text = d == null ? "NO ENCONTRADO" : d.des_tran.Trim();
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

        private void txtCo_sucu_Leave(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    pSeleccionarSucursal_Result f = context.pSeleccionarSucursal(txtCo_empresa.Text.Trim(), txtCo_sucu.Text.Trim()).FirstOrDefault();
                    txtSucursal.Text = f == null ? "NO ENCONTRADO" : f.sucu_des.Trim();
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
