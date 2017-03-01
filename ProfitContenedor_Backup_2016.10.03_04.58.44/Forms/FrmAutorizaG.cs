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
        pSeleccionarGIT_Movimiento_Result mov46 = new pSeleccionarGIT_Movimiento_Result();
        List<pBuscarEmpleadosG_Result> searchE = new List<pBuscarEmpleadosG_Result>();
        pSeleccionarNominaEmpleado_Result NOMI = new pSeleccionarNominaEmpleado_Result();
        pSeleccionarEmpleadoSupervisado_Result super = new pSeleccionarEmpleadoSupervisado_Result();
        List<pSeleccionarActivosbyUsuario_Result> JP = new List<pSeleccionarActivosbyUsuario_Result>();


        private void FrmAutorizaG_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Profit_RGEntities())
                {
                    System.DateTime D1 = System.DateTime.Now;
                    txt_fecha_actual_G.Text = D1.ToShortDateString();
                    txt_fecha_S.Text = D1.ToShortDateString();
                    radPageAutorizaG.Focus();

                    bloquearControles();
                    cargarcombo();


                    // date_desde.Value = DateTime.Now;
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

                if (codigo_usuario != "JP")
                {
                    //  cbo_select_asign.Visible = false;
                    searchE = context.pBuscarEmpleadosG(codigo_usuario).ToList();
                    cbo_empleados_G.DataSource = searchE;
                    cbo_empleados_G.ValueMember = "cod_emp";
                    cbo_empleados_G.DisplayMember = "nombre";

                    

                    PageSistemas.Enabled = false;
                    PageGerencia.Focus();
                }
                else 
                {
                    PageSistemas.Enabled = true;
                    //   lbl_seleccion.Visible = true;
                    searchE = context.pBuscarEmpleadosG(codigo_usuario).ToList();
                    cbo_empleados_G.DataSource = searchE;
                    cbo_empleados_G.ValueMember = "cod_emp";
                    cbo_empleados_G.DisplayMember = "nombre";

                    cbo_empleados_S.DataSource = context.pSeleccionarEmpleados().ToList();
                    cbo_empleados_S.ValueMember = "cod_emp";
                    cbo_empleados_S.DisplayMember = "nombre_completo";

                    cbo_activo_S.DataSource = context.pSeleccionarActivoSistemas().ToList();
                    cbo_activo_S.ValueMember = "Activo";
                    cbo_activo_S.DisplayMember = "Descripcion";
                }
            }
        }
        void bloquearControles()
                {
                    //  cbo_autorizado1.Enabled = false;
                    cbo_activo23.Enabled = false;
                    txt_fecha_actual_G.Enabled = false;
                    txt_razon_G.Enabled = false;
                    cbo_empleados_G.Enabled = false;
                    date_desde.Enabled = false;
                    date_hasta.Enabled = false;
                    btn_Procesar.Enabled = false;
            
                }
        void desbloquearcontroles()
                {
                    // cbo_autorizado1.Enabled = true;
                    txt_razon_G.Enabled = true;
                    cbo_activo23.Enabled = true;

                    btn_Procesar.Enabled = true;

                   // date_desde.Enabled = true;
                    date_desde.Value = DateTime.Now;

                    DateTime p = new DateTime(DateTime.Now.Ticks);

                    date_desde_S.Enabled = true;
                    date_desde_S.Value = DateTime.Now;

                    date_hasta_S.Enabled = true;
                    date_hasta_S.Value = p.AddDays(1);

                    date_hasta.Enabled = true;
                    date_hasta.Value = p.AddDays(1);
                    // date_hasta.Value = DateTime.Now.AddDays (1);

                    txt_razon_G.Enabled = true;
                    btn_Procesar.Enabled = true;
                    // radMultiColumnComboBox1.Enabled = true;
                    cbo_empleados_G.Enabled = true;
                }
        void nuevo()
                {
                    desbloquearcontroles();
                    // cbo_autorizado1.SelectedItem = "";
                    //  txt_activo.Text = "";
                    // date_desde.ResetValue();
                    // date_hasta1.ResetValue();
                }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

       
        private void btn_Historial_Click(object sender, EventArgs e)
        {
            FrmHistorialG histo1 = new FrmHistorialG(codigo_usuario);
            histo1.Show();
        }
        /// <summary>
        /// Cargar el Combo para la autorizacion del movimiento.
        /// </summary>
        /// <param name="Codigo del Empleado"></param>
        /// <param name="e"></param>
        private void cbo_empleados_G_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Profit_RGEntities())
                {
                  

                    var d = context.pseleccionarActivo_Asign_Super(searchE[cbo_empleados_G.SelectedIndex].cod_emp).Count();
                    if (d > 0)
                    {
                       
                        var b = searchE[cbo_empleados_G.SelectedIndex].cod_emp.Trim().ToString();
                        cbo_activo23.DataSource = context.pSeleccionarEmpleadoSupervisado(b).ToList();
                        cbo_activo23.DisplayMember = "Datos";
                        cbo_activo23.ValueMember = "id_activo";
                        
                        // cbo_activo23.Text = context.pSeleccionarEmpleadoSupervisado(b).ToList().ToString ();
                    }
                    else
                    {
                        MessageBox.Show("El empelado no tiene activos Asignados", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbo_empleados_G.SelectedItem = -1;
                        cbo_activo23.SelectedItem = -1;
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
        /// <summary>
        /// Procesar la autorizacion tanto para Jesus Parra como para los Gerentes por cada Dpto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var V = context.pValidarSalida(cbo_activo23.SelectedValue.ToString().Trim()).Count();
                    var T = string.IsNullOrEmpty(txt_razon_S.Text); 
                    if (MessageBox.Show("Desea Procesar la Autorizacion?.", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (codigo_usuario == "JP")
                        {
                            if (string.IsNullOrWhiteSpace(txt_razon_S.Text))
                            {
                                
                                var b = searchE[cbo_empleados_G.SelectedIndex].cod_emp.Trim().ToString();
                                var o = context.GIT_Asign_Equipo.Where(x => x.cod_emp.ToString() == cbo_empleados_G.SelectedValue.ToString()).FirstOrDefault().nomina.ToString();
                                context.pInsertarGit_Gerencia(Convert.ToDateTime(txt_fecha_actual_G.Text), cbo_activo23.SelectedValue.ToString (),
                                Convert.ToDateTime(date_desde.Value), Convert.ToDateTime(date_hasta.Value), txt_razon_G.Text, codigo_usuario, cbo_empleados_G.SelectedValue.ToString(), o);
                                MessageBox.Show(this, "Su Autorizacion Fue procesada.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                bloquearControles();
                            }
                            else if (V > 0 && T)
                            {
                                MessageBox.Show("El activo tiene una salida registrada que no ha retornado.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                               
                                // var c = JP[cbo_activo_S.SelectedIndex].id_activo;

                                
                                context.pInsertarGit_Gerencia(Convert.ToDateTime(txt_fecha_S.Text), cbo_activo_S.SelectedValue.ToString(),
                                Convert.ToDateTime(date_desde_S.Value), Convert.ToDateTime(date_hasta_S.Value), txt_razon_S.Text, codigo_usuario, cbo_empleados_S.SelectedValue.ToString(), 
                                context.pSeleccionarNominaEmpleado(cbo_empleados_S.Text.Trim (),cbo_empleados_S.SelectedValue.ToString ()).FirstOrDefault ().Empresa.ToString ());
                                MessageBox.Show(this, "Su Autorizacion Fue procesada.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }     
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(txt_razon_G.Text))
                            {
                                MessageBox.Show("Debe ingresar la razon del movimiento.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            //else if (date_hasta.Value < date_desde.Value)
                            //{
                            //    MessageBox.Show("La fecha de entrega no puede ser menor a la fecha de salida.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            //}
                            // else if (date_desde.Value != DateTime.Now)
                            //{
                            //     MessageBox.Show("La autorizacion debe realizarse el mismo dia que el activo va a salir.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            //}
                            else if (V > 0)
                            {
                                MessageBox.Show("El Activo tiene una salida registrada que no ha Retornado.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else if (cbo_activo23.Text == "" && cbo_empleados_G.Text == "")
                            {
                                MessageBox.Show("Llene el formulario correctamente.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                var b = cbo_empleados_G.SelectedValue.ToString();
                                var y = cbo_empleados_G.SelectedText.ToString();
                                //var p = from i in context.GIT_Asign_Equipo
                                //        where (i.cod_emp == cbo)
                                var o = context.GIT_Asign_Equipo.Where(x => x.cod_emp.ToString() == cbo_empleados_G.SelectedValue.ToString()).FirstOrDefault ().nomina.ToString();
                                context.pInsertarGit_Gerencia(Convert.ToDateTime(txt_fecha_actual_G.Text), cbo_activo23.SelectedValue.ToString (),
                                Convert.ToDateTime(date_desde.Value), Convert.ToDateTime(date_hasta.Value), txt_razon_G.Text,codigo_usuario,cbo_empleados_G.SelectedValue.ToString (), o);
                                MessageBox.Show(this, "Su Autorizacion Fue procesada.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                               bloquearControles();
                            }
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
    }
}
