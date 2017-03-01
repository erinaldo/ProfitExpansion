using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.Entity.Core;

namespace ProfitContenedor
{
    public partial class FrmPantalla_Stock : DevComponents.DotNetBar.Metro.MetroForm
    {

        Boolean Nuevo = false;
        byte[] Validador;

        public FrmPantalla_Stock()
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
                    pSeleccionarPantalla_Stock_Result pstock = new pSeleccionarPantalla_Stock_Result();
                    var ps = context.pObtenerTablaStr(txtUsuario.Text.Trim(), "co_usuario", p, "pantalla_stock").ToList();
                    if (ps.Count > 0)
                    {
                        pstock = context.pSeleccionarPantalla_Stock(ps[0].Trim()).FirstOrDefault();
                        txtUsuario.Text = pstock.co_usuario.Trim();
                        txtDes_Usuario.Text = context.Usuarios.First(u => u.co_usuario == txtUsuario.Text.Trim()).nombre.Trim();
                        txtEmpresa.Text = pstock.Emp_Art.Trim();
                        txtDes_emp.Text = context.Empresas.First(emp => emp.co_empresa == txtEmpresa.Text.Trim()).des_emp.Trim();
                        txtAlmacen.Text = pstock.Almacen.Trim();
                        txtDes_Alm.Text = context.pSeleccionarAlmacenEmpresa(txtAlmacen.Text.Trim(), txtEmpresa.Text.Trim()).FirstOrDefault().alm_des.Trim();
                        Validador = pstock.validador;
                    }
                    else
                    {
                        if (pstock.validador != null)
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
            txtUsuario.Clear();
            txtDes_Usuario.Clear();
            txtEmpresa.Clear();
            txtDes_emp.Clear();
            txtAlmacen.Clear();
            txtDes_Alm.Clear();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            Nuevo = true;
            Validador = null;
            txtUsuario.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    if (Nuevo == true)
                    {
                        context.pInsertarPantalla_Stock(txtUsuario.Text.Trim(), txtEmpresa.Text.Trim(), txtAlmacen.Text.Trim());
                    }
                    else
                    {
                        context.pActualizarPantalla_Stock(txtEmpresa.Text.Trim(), txtAlmacen.Text.Trim(), Validador);
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
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    if (MessageBox.Show("Desea eliminar este registro?", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        context.pEliminarPantalla_Stock(Validador);
                        Navegar(3);
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
            Navegar(4);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var usu = context.Usuarios.First(u => u.co_usuario == txtUsuario.Text.Trim());
                    if (usu == null)
                        txtDes_Usuario.Text = "NO ECONTRADO";
                    else
                        txtDes_Usuario.Text = usu.nombre.Trim();    
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

        private void txtEmpresa_Leave(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var em = context.Empresas.First(emp => emp.co_empresa == txtEmpresa.Text.Trim());
                    if (em == null)
                        txtDes_emp.Text = "NO ENCONTRADO";
                    else
                        txtDes_emp.Text = em.des_emp.Trim();
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

        private void txtAlmacen_Leave(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var a = context.pSeleccionarAlmacenEmpresa(txtAlmacen.Text.Trim(), txtEmpresa.Text.Trim()).FirstOrDefault();
                    if (a == null)
                        txtDes_Alm.Text = "NO ENCONTRADO";
                    else
                        txtDes_Alm.Text = a.alm_des.Trim();
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

        private void FrmPantalla_Stock_Load(object sender, EventArgs e)
        {
            Navegar(0);
            this.Width = 454;
            this.Height = 184;
        }

        private void txtEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FrmBuscar Fe = new FrmBuscar(txtEmpresa, txtDes_emp, "Empresa");
                Fe.Show();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FrmBuscar Fe = new FrmBuscar(txtUsuario, txtDes_Usuario, "Usuario");
                Fe.Show();
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Nuevo = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    pSeleccionarPantalla_Stock_Result pstock = new pSeleccionarPantalla_Stock_Result();
                    var ps = context.Usuarios.Where(u => u.co_usuario == txtBuscar.Text.Trim()).ToList();
                    if (ps.Count > 0)
                    {
                        pstock = context.pSeleccionarPantalla_Stock(ps[0].co_usuario.Trim()).FirstOrDefault();
                        txtUsuario.Text = pstock.co_usuario.Trim();
                        txtDes_Usuario.Text = context.Usuarios.First(u => u.co_usuario == txtUsuario.Text.Trim()).nombre.Trim();
                        txtEmpresa.Text = pstock.Emp_Art.Trim();
                        txtDes_emp.Text = context.Empresas.First(emp => emp.co_empresa == txtEmpresa.Text.Trim()).des_emp.Trim();
                        txtAlmacen.Text = pstock.Almacen.Trim();
                        txtDes_Alm.Text = context.pSeleccionarAlmacenEmpresa(txtAlmacen.Text.Trim(), txtEmpresa.Text.Trim()).FirstOrDefault().alm_des.Trim();
                        Validador = pstock.validador;
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
    }
}