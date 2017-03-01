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
    public partial class FrmAddSupervisados : DevComponents.DotNetBar.Metro.MetroForm
    {

        string co_usuario;
        public FrmAddSupervisados()
        {
            InitializeComponent();
        }
        public FrmAddSupervisados(string usuario)
        {
            co_usuario = usuario;
            InitializeComponent();
        }

        List<pSeleccionarSupervisados_Result> lista13 = new List<pSeleccionarSupervisados_Result>();
        List<plistarNomina_Result> lista12 = new List<plistarNomina_Result>();
        List<pSelecionarEmpresaNomina_Result> LstEmp = new List<pSelecionarEmpresaNomina_Result>();

        private void FrmAddSupervisados_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Profit_RGEntities())
                {
                    LstEmp = context.pSelecionarEmpresaNomina().ToList();
                    cbo_nomina.DataSource = LstEmp; 
                    cbo_nomina.ValueMember = "cod_empresa";
                    cbo_nomina.DisplayMember = "desc_empresa";
                    
                    
                    //cbo_nomina.SelectedIndex = 0;
                    //Cargarcombos();                                       
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

       
        void Cargarcombos()
        {
            try
            {
                using (var context = new Profit_RGEntities())
                {
                    var a = context.plistarNomina(LstEmp[cbo_nomina.SelectedIndex].cod_empresa.ToUpper().Trim());

                    cbo_listar.DataSource = a.ToList();
                    cbo_listar.DisplayMember = "nombre_completo";
                    cbo_listar.ValueMember = "cod_emp";

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

        private void cbo_nomina_SelectedValueChanged(object sender, EventArgs e)
        {

            
        }
        
        void Guardar()
        {
            try
            {
                using (var context = new Profit_RGEntities())
                {
                    //cbo_listar.SelectionMode = SelectionMode.MultiExtended;

                    //cbo_listar.SetSelected(cbo_listar.SelectedIndex,true);

                    foreach (var i in cbo_listar.SelectedItems)
                    {
                       
                            //cbo_listar.SelectedIndex = cbo_listar.SelectedItems.Count ;
                            var f = cbo_nomina.SelectedValue.ToString();
                            var g = cbo_listar.SelectedValue.ToString();
                            var t = co_usuario;
                            var u = cbo_listar.Text;
                            // MessageBox.Show("Hay: " + cbo_listar.SelectedItems.Count + " Usuarios Seleccionados");
                            context.pInsertarSupervisados(f,g,t,u);
                            //if  (context.pSeleccionarSupervisadosAll().Where(x =>x.cod_emp.ToString () == cbo_listar.SelectedValue.ToString ()).Count() > 0)
                            //{
                            //    MessageBox.Show("Ya el Registro Existe");      
                            //}

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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               
                   // MessageBox.Show("El codigo del empleado es:" + cbo_listar.SelectedValue);
                    Guardar();
                   
                
                MessageBox.Show(this, "Se ha guardado la información satisfactoriamente.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void CleanControls()
        {
            //cbo_nomina.SelectedItem = -1;
            //cbo_listar.SelectedItem = -1;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CleanControls();
        }

        private void cbo_listar_KeyDown(object sender, KeyEventArgs e)
        {
            Boolean t = true;
            cbo_listar.SelectedItem = t;
         
            // MessageBox.Show("" + cbo_listar.SelectedValue);

        }

        private void cbo_nomina_Click(object sender, EventArgs e)
        {
           
        }

        private void cbo_nomina_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_nomina.SelectedIndex >= 0)
                Cargarcombos();
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
