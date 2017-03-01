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
    public partial class FrmNaviera : DevComponents.DotNetBar.Metro.MetroForm
    {
        Boolean Nuevo = false;
        byte[] Validador;

        public FrmNaviera()
        {
            InitializeComponent();
        }

        private void FrmNaviera_Load(object sender, EventArgs e)
        {
            Navegar(0); 
        }

        private void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    pSeleccionarNaviera_Result naviera = new pSeleccionarNaviera_Result();
                    var pnav = context.pObtenerTablaStr(txtCo_naviera.Text.Trim(),"co_naviera",p,"naviera").ToList();
                    if (pnav.Count>0)
                    {
                        naviera = context.pSeleccionarNaviera(pnav[0].Trim()).First();
                        txtCo_naviera.Text = naviera.co_naviera.Trim();
                        txtNavi_des.Text = naviera.navi_des.Trim();
                        txtEmpresa.Text = naviera.empresa.Trim();
                        txtEmp_des.Text = naviera.emp_des.Trim();
                        txtCo_prov.Text = naviera.co_prov.Trim();
                        txtProv_des.Text = naviera.prov_des.Trim();
                        Validador = naviera.validador;
                    }
                    else
                    {
                        if (naviera.validador != null)
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
            txtCo_naviera.Text = "";
            txtNavi_des.Text = "";
            txtEmpresa.Text = "";
            txtEmp_des.Text = "";
            txtCo_prov.Text = "";
            txtProv_des.Text = "";
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

        private void txtCo_prov_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (txtEmpresa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe elegir una empresa.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmpresa.Focus();
                }
                else
                {
                    FrmBuscar Fe = new FrmBuscar(txtCo_prov, txtProv_des, "Shipper", txtEmpresa.Text.Trim());
                    Fe.Show();
                }
            }
        }

        private void txtCo_prov_Leave(object sender, EventArgs e)
        {
            try
            {
                pSeleccionarProv_Result shipper = new pSeleccionarProv_Result();
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    shipper = context.pSeleccionarProv(txtEmpresa.Text.Trim()).Where(s => s.co_prov == txtCo_prov.Text.Trim()).First();
                }
                if (shipper == null)
                {
                    txtProv_des.Text = "NO ENCONTRADO";
                }
                else
                {
                    txtProv_des.Text = shipper.prov_des.Trim();
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

        private void txtEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FrmBuscar Fe = new FrmBuscar(txtEmpresa, txtEmp_des, "Empresa");
                Fe.Show();
            }
        }

        private void txtEmpresa_Leave(object sender, EventArgs e)
        {
            try
            {
                //ProfitDsTableAdapters.empresasTableAdapter emp = new ProfitDsTableAdapters.empresasTableAdapter();
                //ProfitDs.empresasDataTable Dt = new ProfitDs.empresasDataTable();
                //emp.Fill(Dt);
                //var Emp = Dt.Where(c => c.cod_emp.Trim() == txtEmpresa.Text.Trim()).First();
                using(Profit_RGEntities context = new Profit_RGEntities())
                {
                    var Emp = context.pSeleccionarEmpresa(txtEmpresa.Text.Trim()).First();
                    if (Emp == null)
                    {
                        txtEmp_des.Text = "NO ENCONTRADO";
                    }
                    else
                    {
                        txtEmp_des.Text = Emp.des_emp.Trim();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Nuevo = true;
                LimpiarControles();
                txtCo_naviera.Focus();
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
                            context.pInsertarNaviera(txtCo_naviera.Text.Trim(), txtNavi_des.Text.Trim(), 
                                                    txtEmpresa.Text.Trim(), txtEmp_des.Text.Trim(), 
                                                    txtCo_prov.Text.Trim(), txtProv_des.Text.Trim());
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
                            context.pActualizarNaviera(txtCo_naviera.Text.Trim(), txtNavi_des.Text.Trim(),
                                                        txtEmpresa.Text.Trim(), txtEmp_des.Text.Trim(),
                                                        txtCo_prov.Text.Trim(), txtProv_des.Text.Trim(), Validador);
                        }
                        Navegar(5);
                    }
                }
            }
            catch (DataException ex0)
            {
                MessageBox.Show(ex0.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        context.pEliminarNaviera(Validador);
                        Navegar(2);
                    }                
                }
            }
            catch (DataException ex0)
            {
                MessageBox.Show(ex0.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
