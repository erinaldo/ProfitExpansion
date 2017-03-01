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
    public partial class FrmUbicacion : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmUbicacion()
        {
            InitializeComponent();
        }
        Boolean Nuevo = false;
        pSeleccionarGIT_Ubicaciones_Result Ubicacion1 = new pSeleccionarGIT_Ubicaciones_Result();
        private void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                txtCo_ubicacion.Enabled = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var pubi = context.pObtenerTablaStr(txtCo_ubicacion.Text.Trim(), "co_ubic", p, "GIT_Ubicaciones").ToList();
                    if (pubi.Count > 0)
                    {
                        Ubicacion1 = context.pSeleccionarGIT_Ubicaciones(pubi[0].Trim()).FirstOrDefault();
                        txtCo_ubicacion.Text = Ubicacion1.co_ubic;
                        txtDescripcion.Text = Ubicacion1.descrip;
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
            txtCo_ubicacion.Text = "";
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
            txtCo_ubicacion.Enabled = true;
        }
        void Guardar(Boolean Tipo1)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    if (Tipo1 == true)
                    {
                        context.pGIT_UbicacionInsertar(txtCo_ubicacion.Text.Trim(), txtDescripcion.Text.Trim());
                    }
                    else
                    {
                        context.pGIT_UbicacionActualizar(txtCo_ubicacion.Text.Trim(), txtDescripcion.Text.Trim(), Ubicacion1.Rowguid);
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
                        context.pGIT_UbicacionEliminar(Ubicacion1.Rowguid);
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

        private void FrmUbicacion_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    AutoCompleteStringCollection buscar1 = new AutoCompleteStringCollection();
                    List<GIT_Ubicaciones> Li = context.GIT_Ubicaciones.ToList();
                    foreach (var item in Li)
                    {
                        buscar1.Add(item.co_ubic.Trim());
                    }
                    txtBuscar.AutoCompleteCustomSource = buscar1;
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
        private void txtBuscar_TextChanged(object sender, EventArgs e)
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
                    pSeleccionarGIT_Ubicaciones_Result Ubicacion1 = new pSeleccionarGIT_Ubicaciones_Result();
                    var pubi1 = context.GIT_Ubicaciones.Where(xD => xD.co_ubic == txtBuscar.Text.Trim()).ToList();

                    if (pubi1.Count > 0)
                    {
                        Ubicacion1 = context.pSeleccionarGIT_Ubicaciones(pubi1[0].co_ubic.Trim().ToUpper()).FirstOrDefault();
                        txtCo_ubicacion.Text = Ubicacion1.co_ubic.Trim();
                        txtDescripcion.Text = Ubicacion1.descrip.Trim();
                        txtBuscar.Text = "";
                        txtCo_ubicacion.Focus();
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
    }
}

        