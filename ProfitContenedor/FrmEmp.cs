using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                        empresa = context.pSeleccionarEmpresa(pemp[0].Trim()).First();
                        txtCo_empresa.Text = empresa.co_empresa.Trim();
                        txtDes_emp.Text = empresa.des_emp.Trim();
                        txtEmail.Text = empresa.email.Trim();
                        txtClave.Text = MC.GetString(empresa.clave).Trim();
                        txtServidor.Text = empresa.servidor.Trim();
                        txtPuerto.Value = empresa.puerto;
                        OptSSL.CheckState = empresa.ssl == 1 ? CheckState.Checked : CheckState.Unchecked;
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
                                txtServidor.Text.Trim(), txtPuerto.Value,OptSSL.CheckState == CheckState.Checked ? 1 : 0,MC.GetBytes(txtClave.Text.Trim()));
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
                                txtServidor.Text.Trim(), txtPuerto.Value, OptSSL.CheckState == CheckState.Checked ? 1 : 0, Validador);
                        }
                        Navegar(5);
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
                        empresa = context.pSeleccionarEmpresa(pemp[0].co_empresa.Trim().ToUpper()).First();
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
    }
}
