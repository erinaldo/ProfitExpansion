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
    public partial class FrmCatalogo_Activo : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmCatalogo_Activo()
        {
            InitializeComponent();
        }
        Boolean Nuevo = false;
        pSeleccionarGIT_Catalalogo_Activo_Result catalogo1 = new pSeleccionarGIT_Catalalogo_Activo_Result();
        private void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                txtCo_catalogo.Enabled = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var pubi = context.pObtenerTablaStr(txtCo_catalogo.Text.Trim(), "id_cat_activo", p, "GIT_Catalogo_Activo").ToList();
                    if (pubi.Count > 0)
                    {
                        catalogo1 = context.pSeleccionarGIT_Catalalogo_Activo(pubi[0].Trim ()).FirstOrDefault();
                        txtCo_catalogo.Text = catalogo1.id_cat_activo;
                        txtDescripcionC.Text = catalogo1.descripcion;
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
            txtCo_catalogo.Text = "";
            txtDescripcionC.Text = "";
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
            txtCo_catalogo.Enabled = true;
        }
        void Guardar(Boolean Tipo1)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    if (Tipo1 == true)
                    {
                        context.pGIT_Catalogo_ActivoInsertar(txtCo_catalogo.Text.Trim(), txtDescripcionC.Text.Trim());
                    }
                    else
                    {
                        context.pGIT_Catalogo_ActivoActualizar(txtCo_catalogo.Text.Trim(), txtDescripcionC.Text.Trim(), catalogo1.Rowguid);
                    }
                    Navegar(5);
                    MessageBox.Show(this, "Los datos fueron registrados exitosamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        context.pGIT_Campos_LogicosEliminar(catalogo1.Rowguid);
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
        private void txtBuscar_LostFocus(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }
        private void FrmCatalogo_Activo_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    AutoCompleteStringCollection buscar1 = new AutoCompleteStringCollection();
                    List<GIT_Catalogo_Activo> Li = context.GIT_Catalogo_Activo.ToList();
                    foreach (var item in Li)
                    {
                        buscar1.Add(item.id_cat_activo.Trim());
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
                    pSeleccionarGIT_Catalalogo_Activo_Result catalogo1 = new pSeleccionarGIT_Catalalogo_Activo_Result();
                    var pubi1 = context.GIT_Catalogo_Activo.Where(o => o.id_cat_activo == txtBuscar.Text.Trim()).ToList();

                    if (pubi1.Count > 0)
                    {
                        catalogo1 = context.pSeleccionarGIT_Catalalogo_Activo(pubi1[0].id_cat_activo.Trim().ToUpper()).FirstOrDefault();
                        txtCo_catalogo.Text = catalogo1.id_cat_activo.Trim();
                        txtDescripcionC.Text = catalogo1.descripcion.Trim();
                        txtBuscar.Text = "";
                        txtCo_catalogo.Focus();
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
