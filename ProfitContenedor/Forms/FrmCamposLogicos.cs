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
    public partial class FrmCamposLogicos : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmCamposLogicos()
        {
            InitializeComponent();
        }
        pSeleccionarGIT_CamposLogicos_Result  campos1 = new pSeleccionarGIT_CamposLogicos_Result();

        private void FrmCamposLogicos_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    AutoCompleteStringCollection buscar2 = new AutoCompleteStringCollection();
                    List<GIT_Campos_Logicos> Li = context.GIT_Campos_Logicos.ToList();
                    foreach (var item in Li)
                    {
                        buscar2.Add(item.co_campo.Trim());
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
        Boolean Nuevo = false;
       
        private void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                txtCo_campos.Enabled = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var pubi4 = context.pObtenerTablaStr(txtCo_campos.Text.Trim(), "co_campo", p, "GIT_Campos_Logicos").ToList();
                    if (pubi4.Count > 0)
                    {
                        campos1 = context.pSeleccionarGIT_CamposLogicos(pubi4[0].Trim()).FirstOrDefault();
                        txtCo_campos.Text = campos1.co_campo;
                        txtDescripcion.Text = campos1.descrip;
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
            txtCo_campos.Text = "";
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
            txtCo_campos.Enabled = true;
        }
        void Guardar(Boolean Tipo1)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    if (Tipo1 == true)
                    {
                        context.pGIT_Campos_LogicosInsertar(txtCo_campos.Text.Trim(), txtDescripcion.Text.Trim());
                    }
                    else
                    {
                        context.pGIT_Campos_LogicosActualizar(txtCo_campos.Text.Trim(), txtDescripcion.Text.Trim(), campos1.Rowguid);
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
                        context.pGIT_Campos_LogicosEliminar(campos1.Rowguid);
                        Navegar(1);
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
                    pSeleccionarGIT_CamposLogicos_Result campos1 = new pSeleccionarGIT_CamposLogicos_Result();
                    var pubi1 = context.GIT_Campos_Logicos.Where(xD => xD.co_campo == txtBuscar.Text.Trim()).ToList();

                    if (pubi1.Count > 0)
                    {
                        campos1 = context.pSeleccionarGIT_CamposLogicos(pubi1[0].co_campo.Trim().ToUpper()).FirstOrDefault();
                        txtCo_campos.Text = campos1.co_campo.Trim();
                        txtDescripcion.Text = campos1.descrip.Trim();
                        txtBuscar.Text = "";
                        txtCo_campos.Focus();
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
