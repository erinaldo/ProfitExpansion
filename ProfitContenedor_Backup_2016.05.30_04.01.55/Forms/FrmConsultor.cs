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
    public partial class FrmConsultor : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmConsultor()
        {
            InitializeComponent();
        }
        Boolean Nuevo = false;
        pSeleccionarGIT_Consultor_Result consultor1 = new pSeleccionarGIT_Consultor_Result ();
        private void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                txtCo_consultor.Enabled = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var pubi4 = context.pObtenerTablaStr(txtCo_consultor.Text.Trim(), "co_consultor", p, "GIT_Consultor").ToList();
                    if (pubi4.Count > 0)
                    {
                        consultor1 = context.pSeleccionarGIT_Consultor(pubi4[0].Trim()).FirstOrDefault();
                        txtCo_consultor.Text = consultor1.co_consultor;
                        txtDescripcion.Text = consultor1.nombre;
                        //var Imagen = ImagenBD.BytesToImage(Usuario.ilustracion)
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
            txtCo_consultor.Text = "";
            txtDescripcion.Text = "";
            txtBuscar.Text = "";
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
            LimpiarControles();
            Nuevo = true;
            txtCo_consultor.Enabled = true;
        }
        void Guardar(Boolean Tipo1)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    if (Tipo1 == true)
                    {
                        context.pGIT_ConsultorInsertar(txtCo_consultor.Text.Trim(), txtDescripcion.Text.Trim());
                    }
                    else
                    {
                        context.pGIT_ConsultorActualizar(txtCo_consultor.Text.Trim(), txtDescripcion.Text.Trim(), consultor1.Rowguid);
                    }
                    Navegar(5);
                    MessageBox.Show(this, "Los datos fueron registrados exitosamente.", Application.ProductName, MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (EntityException ex1)
            {
                MessageBox.Show(this, ex1.InnerException.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(this, ex1.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar(Nuevo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea eliminar este registro?", "Profit Contenedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        context.pGIT_ConsultorEliminar(consultor1.Rowguid);
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

        private void Buscar()
        {
            try
            {
                Nuevo = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    pSeleccionarGIT_Ubicaciones_Result Ubicacion1 = new pSeleccionarGIT_Ubicaciones_Result();
                    var pubi1 = context.GIT_Consultor.Where(xD => xD.co_consultor == txtBuscar.Text.Trim()).ToList();

                    if (pubi1.Count > 0)
                    {
                        consultor1 = context.pSeleccionarGIT_Consultor(pubi1[0].co_consultor.Trim().ToUpper()).FirstOrDefault();
                        txtCo_consultor.Text = consultor1.co_consultor.Trim();
                        txtDescripcion.Text = consultor1.nombre.Trim();
                        txtBuscar.Text = "";
                        txtCo_consultor.Focus();
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
        private void txtBuscar_LostFocus(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void FrmConsultor_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    AutoCompleteStringCollection buscar2 = new AutoCompleteStringCollection();
                    List<GIT_Consultor> Li = context.GIT_Consultor.ToList();
                    foreach (var item in Li)
                    {
                        buscar2.Add(item.co_consultor.Trim());
                    }
                    txtBuscar.AutoCompleteCustomSource = buscar2;
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
    }
}

    
