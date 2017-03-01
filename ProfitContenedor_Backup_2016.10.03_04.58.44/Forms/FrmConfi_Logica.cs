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
    public partial class FrmConfi_Logica : DevComponents.DotNetBar.Metro.MetroForm
    {
        pSeleccionarConf_Logica_Result CL = new pSeleccionarConf_Logica_Result();
        List<Conf_LogicaDG> CLO = new List<Conf_LogicaDG>();
        /// <summary>
        /// Se trae el id_activo del formulario de Activo. 
        /// </summary>
        /// <param name="activo"></param>
        /// <param name="activo1"></param>
        string activo;
        public FrmConfi_Logica(string activo1)
        {
            InitializeComponent();
            activo = activo1;
        }

        public FrmConfi_Logica()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cargar el Formulario con sus ComboBoxy TextBox..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConfi_Logica_Load(object sender, EventArgs e)
        {
            using (var context = new Profit_RGEntities())
            {
                grd_CL.DataSource = "";
                grd_CL.AutoGenerateColumns = false;

                radTxt_activo.Text = activo;
                radTxt_activo.ReadOnly = true;

                cbo_camposL.DataSource = context.GIT_Campos_Logicos.ToList();
                cbo_camposL.DisplayMember = "descrip";
                cbo_camposL.ValueMember = "co_campo";

                CargarDG();
            }
        }
        /// <summary>
        /// Guarda la informacion del formulario en GIT_Config_Logica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Profit_RGEntities())
                {
                    Boolean buscar98 = false;
                    //  Boolean buscar90 = false; 

                    foreach (var item in CLO)
                    {
                         buscar98 = context.pConf_LogicaDGV(activo).Count(u => u.Rowguid.ToString().ToUpper() == item.Rowguid.ToUpper()) > 0;
                        // buscar90 = context.pSeleccionarGIT_Asign_Equipo(item.activo.Trim ()).Count(u => u.Rowguid.ToString () == item.Rowguid.ToUpper ()) > 0;
                        if (buscar98)
                        {
                            context.pGIT_Config_LogicaActualizar(radTxt_activo.Text, item.campo, item.descripcion, Guid.Parse(item.Rowguid));
                        }
                        else
                        {
                            context.pGIT_Config_LogicaInsertar(radTxt_activo.Text, item.campo, item.descripcion);
                        }
                    }
                }
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
    
        /// <summary>
        /// Valida si hay datos repetidos en la tabla GIT_Config_Logica y carga el formulario.. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CargarDG()

        {
            using (var context = new Profit_RGEntities())
            {
                var T = context.pConf_LogicaDGV(activo.Trim()).ToList();
                CLO.Clear();

                foreach (var item in T)
                {
                    CLO.Add(new Conf_LogicaDG
                    {
                        activo = item.id_activo,
                        campo = item.co_campo,
                        descripcion = item.valor,
                        Rowguid = item.Rowguid.ToString (),
                    });

                    grd_CL.DataSource = "";
                    grd_CL.DataSource = CLO;
                    grd_CL.AutoGenerateColumns = false;
                    grd_CL.Refresh();
                }
            }

        }
        private void btnAgregarR_Click(object sender, EventArgs e)
        {
            try
            {

                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    grd_CL.DataSource = "";

                    CLO.Add(new Conf_LogicaDG
                    {
                        campo = cbo_camposL.SelectedValue.ToString(),
                        descripcion = ""
                    });

                    grd_CL.DataSource = "";
                    grd_CL.DataSource = CLO;
                    grd_CL.AutoGenerateColumns = false;
                    grd_CL.Refresh();
                }

            }
            catch (Exception ex1)
            {
                MessageBox.Show(this, ex1.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CLO.Count > 0)
                {
                    if (MessageBox.Show(this, "Desea eliminar este renglón?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        foreach (var item in CLO)
                        {
                            using (var context = new Profit_RGEntities())
                            {
                                var Y = grd_CL.CurrentRow.Cells[3].Value;
                                CLO.RemoveAt(grd_CL.CurrentCell.RowIndex);
                                context.pGIT_Config_LogicaEliminar(Guid.Parse(Y.ToString()));
                                grd_CL.DataSource = "";
                                grd_CL.DataSource = CLO;
                                grd_CL.CurrentCell = grd_CL[0, CLO.Count - 1];

                            }
                            CargarDG();
                        }
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
