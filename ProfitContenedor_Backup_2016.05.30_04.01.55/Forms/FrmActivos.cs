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
    public partial class FrmActivos : DevComponents.DotNetBar.Metro.MetroForm
    {
        
        public FrmActivos()
        {
            InitializeComponent();
        }
        

        Boolean Nuevo = false;
        pSeleccionarGIT_Activo_Result acti1 = new pSeleccionarGIT_Activo_Result();
        pSeleccionarID_Asignacion_Result asig21 = new pSeleccionarID_Asignacion_Result();
        private void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                txtCo_activo.Enabled = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var pubi = context.pObtenerTablaStr(txtCo_activo.Text.Trim(), "id_activo", p, "GIT_Activo").ToList();
                    if (pubi.Count > 0)
                    {
                        
                        acti1 = context.pSeleccionarGIT_Activo(pubi[0].Trim()).FirstOrDefault();
                        asig21 = context.pSeleccionarID_Asignacion(pubi[0].Trim()).FirstOrDefault();
                        txtCo_activo.Text = acti1.id_activo;
                        txt_descrip.Text = acti1.descrip;
                        txt_modelo.Text = acti1.modelo;
                        txt_serial.Text = acti1.serial;
                        txt_valor.Text = acti1.valor.ToString ();
                        var a = context.pBuscarAsignacionActivo(acti1.id_activo).FirstOrDefault().Value;
                        if (a == 0)
                        {
                            txt_asigna54.Text = "0";
                            MessageBox.Show( "El activo no tiene Asignaciones","Profit Expansion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            FrmAsignacion Asi = new FrmAsignacion(acti1.id_activo.Trim());
                            Asi.Show();
                        }
                        else
                        {
                            txt_asigna54.Text = asig21.id_asign.ToString();
                        }
                        
                        cbo_Cat.SelectedItem = acti1.id_cat_activo;
                        cbo_ubic.SelectedItem = acti1.co_ubic;
                        date_fec_adqui.Value  = acti1.fecha_adq;
                        date_fec_regis.Value = acti1.fecha_reg;
                        date_fec_reti.Value = acti1.fecha_reti.Value;
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
            
            txtCo_activo.Text = "";
            txt_descrip.Text = "";
            txt_modelo.Text = "";
            txt_serial.Text = "";
            txt_valor.Text = "";
            txt_asigna54.Text = "";
            cbo_Cat.SelectedItem = null;
            cbo_ubic.SelectedItem = "";
            date_fec_adqui.ResetValue ();
            date_fec_regis.ResetValue ();
            date_fec_reti.ResetValue ();
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
            txtCo_activo.Enabled = true;
            txtCo_activo.Focus();
           
        }
        void Guardar(Boolean Tipo1)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    if (Tipo1 == true)
                    {
                        context.pGIT_ActivoInsertar (txtCo_activo.Text.Trim(),txt_descrip.Text.Trim (),txt_serial.Text.Trim (),
                            txt_modelo.Text.Trim (),Convert.ToDecimal(txt_valor.Text.Trim ()),date_fec_regis.Value,date_fec_adqui.Value, date_fec_reti.Value ,
                            cbo_ubic.SelectedValue.ToString(),cbo_Cat.SelectedValue.ToString());
                       
                    }
                    else
                    {
                        context.pGIT_ActivoActualizar (txtCo_activo.Text.Trim(), txt_descrip.Text.Trim(), txt_serial.Text.Trim(),
                            txt_modelo.Text.Trim(), Convert.ToDecimal(txt_valor.Text.Trim ()), date_fec_regis.Value, date_fec_adqui.Value, date_fec_reti.Value,
                            cbo_ubic.SelectedValue.ToString(), Convert.ToInt32 (txt_asigna54.Text), cbo_Cat.SelectedValue.ToString(),acti1.Rowguid);
                    }
              
                    MessageBox.Show(this, "Los datos fueron registrados exitosamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (EntityException ex1)
            {
                MessageBox.Show(this, ex1.InnerException.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(this, ex1.InnerException.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        context.pGIT_ActivoEliminar(acti1.Rowguid);
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

        private void FrmActivos_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    cbo_Cat.DataSource = context.GIT_Catalogo_Activo.ToList();
                    cbo_Cat.DisplayMember = "descripcion".Trim ();
                    cbo_Cat.ValueMember = "id_cat_activo";

                    cbo_ubic.DataSource = context.GIT_Ubicaciones.ToList();
                    cbo_ubic.DisplayMember = "descrip".Trim ();
                    cbo_ubic.ValueMember = "co_ubic";

                    
                    

                    AutoCompleteStringCollection buscar1 = new AutoCompleteStringCollection();
                    List<GIT_Activo> Li = context.GIT_Activo.ToList(); ;
                    foreach (var item in Li)
                    {
                        buscar1.Add(item.id_activo.Trim());
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
                    var pubi1 = context.GIT_Activo.Where(xD => xD.id_activo == txtBuscar.Text.Trim()).ToList();

                    if (pubi1.Count > 0)
                    {
                        acti1 = context.pSeleccionarGIT_Activo(pubi1[0].id_activo.Trim().ToUpper()).FirstOrDefault();
                        txtCo_activo.Text = acti1.id_activo;
                        txt_descrip.Text = acti1.descrip;
                        txt_modelo.Text = acti1.modelo;
                        txt_serial.Text = acti1.serial;
                        txt_valor.Text = acti1.valor.ToString();
                        txt_asigna54.Text = acti1.id_asign.ToString();
                        cbo_Cat.SelectedItem = acti1.id_cat_activo;
                        cbo_ubic.SelectedItem = acti1.co_ubic;
                        date_fec_adqui.Value = acti1.fecha_adq;
                        date_fec_regis.Value = acti1.fecha_reg;
                        date_fec_reti.Value = acti1.fecha_reti.Value;
                        txtBuscar.Text = "";
                        txtCo_activo.Focus();
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

        
        public void btn_asign12_Click(object sender, EventArgs e)
        {
            FrmAsignacion ASG = new FrmAsignacion(acti1.id_activo.Trim());
            ASG.Show();
         //   txtCo_activo.Text = ASG.grddatos1.CurrentRow.Cells["Activo"].ToString();
           // using (Profit_RGEntities context = new Profit_RGEntities())
           // {
           //     ASG.grddatos1.DataSource = context.pSeleccionarGIT_Asignaciones().ToList ();
           // }
                
        }

        private void btn_movES_Click(object sender, EventArgs e)
        {
            FrmMovES mov12 = new FrmMovES(txtCo_activo.Text);
            mov12.Show();
        }

        private void btn_mtto_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMantActivo lli = new FrmMantActivo(acti1.id_activo.Trim());
                lli.Show();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(this, ex1.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
          //  txtCo_activo.Text = lli.grddatos2.CurrentRow.Cells["Activo"].Value.ToString();
        }

        private void txt_asigna54_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_asigna54.Text != "0")
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        
                       // context.pActualizarGIT_id_asign(acti1.id_activo, asig21.id_asign);
                        txt_asigna54.Text = context.pSeleccionarID_Asignacion(acti1.id_activo.Trim()).FirstOrDefault().Nombre;
                    }
                }
                
            }
            catch (Exception ex1)
            {
                MessageBox.Show(this, ex1.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
