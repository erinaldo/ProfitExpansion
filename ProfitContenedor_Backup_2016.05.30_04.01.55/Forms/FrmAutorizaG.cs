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
    public partial class FrmAutorizaG : DevComponents.DotNetBar.Metro.MetroForm
    {
        string codigo_usuario;
        public FrmAutorizaG()
        {
            InitializeComponent();

        }
        public FrmAutorizaG(string user)
        {
            codigo_usuario = user;
            InitializeComponent();
        }
        Boolean Nuevo = false;
        pSeleccionarGIT_MovimientoES_Result mov45 = new pSeleccionarGIT_MovimientoES_Result();
        pSeleccionarGIT_Movimiento_Result mov46 = new  pSeleccionarGIT_Movimiento_Result();
        List<pBuscarEmpleadosG_Result> searchE = new List<pBuscarEmpleadosG_Result>();
        pSeleccionarEmpleadoSupervisado_Result super = new pSeleccionarEmpleadoSupervisado_Result();
       
        
        private void FrmAutorizaG_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Profit_RGEntities ())
                {
                    bloquearControles();
                    cargarcombo();
                   

                    txt_fecha.Text = DateTime.Now.ToLongDateString().ToString();
                    //Frmlogin KL = new Frmlogin();
                    //labelX1.Text = KL.txtUsuario.Text.Trim ().ToString ();
                    
                  
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
        private void cargarcombo()
        {
            using (var context = new Profit_RGEntities())
            {
                searchE = context.pBuscarEmpleadosG(codigo_usuario).ToList();
                cbo_autorizado1.DataSource = searchE;
                cbo_autorizado1.ValueMember = "cod_emp";
                cbo_autorizado1.DisplayMember = "nombre";

            }

        }
        void bloquearControles()
        {
            cbo_autorizado1.Enabled = false;
            txt_razon.Enabled = false;
            txt_activo.Enabled = false;
            date_desde.Enabled = false;
            date_hasta.Enabled = false;
            txt_fecha.Enabled = false;

        }
        void desbloquearcontroles()
        {
            cbo_autorizado1.Enabled = true;
            txt_razon.Enabled = true;
            txt_activo.Enabled = true;
            date_desde.Enabled = true;
            date_hasta.Enabled = true;
            txt_fecha.Enabled = true;
        }
        void nuevo()
        {
            desbloquearcontroles();
            cbo_autorizado1.SelectedItem = "";
            txt_activo.Text = "";
            txt_razon.Text = "";
            date_desde.ResetValue();
            date_hasta.ResetValue();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    if (MessageBox.Show("Desea Procesar la Autorizacion?.", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        
                            if (string.IsNullOrWhiteSpace(txt_razon.Text))
                            {
                                MessageBox.Show("Debe ingresar la razon del movimiento.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else
                            {
                                context.pInsertarGit_Gerencia (Convert.ToDateTime(txt_fecha.Text), txt_activo.Text, Convert.ToDateTime(date_desde.Value), Convert.ToDateTime(date_hasta.Value), txt_razon.Text);
                                MessageBox.Show(this, "Su Autorizacion Fue procesada.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                    }
                    else
                    {
                       // this.Hide();
                        DialogResult = DialogResult.None;
                    }
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }
        private void btn_historial_Click(object sender, EventArgs e)
        {
            FrmHistorialG histo1 = new FrmHistorialG(codigo_usuario);
            histo1.Show();
        }

        private void cbo_autorizado1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {                
                using (var context = new Profit_RGEntities())
                {
                    var d = context.pseleccionarActivo_Asign_Super(searchE[cbo_autorizado1.SelectedIndex].cod_emp).Count();
                    if (d > 0)
                    {
                        var b = searchE[cbo_autorizado1.SelectedIndex].cod_emp.Trim().ToString();
                        var c = context.pSeleccionarEmpleadoSupervisado(b).FirstOrDefault().id_activo;
                        txt_activo.Text = c;
                    }
                    else
                    {
                        MessageBox.Show("El empelado no tiene activos Asignados","Profit Expansion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        cbo_autorizado1.SelectedItem  = -1;
                        txt_activo.Text = "";
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
