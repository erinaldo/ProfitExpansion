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
    
    public partial class FrmSearch : DevComponents.DotNetBar.Metro.MetroForm
    {
        List<pBuscarActivobyName2_Result> Dato1 = new List<pBuscarActivobyName2_Result>();
        pSeleccionarID_Asignacion_Result asig21 = new pSeleccionarID_Asignacion_Result();
        List<GridBusqueda> buscar23 = new List<GridBusqueda>();
       // FrmActivos f = new FrmActivos();

        public string activo23;
        public string nombre;
        public FrmSearch()
        {
            InitializeComponent();
        }

        //public FrmSearch(FrmActivos activo)
        //{
        //    f = activo;
        //    InitializeComponent();
        //}


        pBuscarActivoByName_Result JAC = new pBuscarActivoByName_Result();
        
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            using (var context = new Profit_RGEntities())
            {
                cbo_empresa.DataSource = context.GIT_Ubicaciones.ToList();
                cbo_empresa.DisplayMember = "descrip";
                cbo_empresa.ValueMember = "co_ubic";
                cbo_empresa.SelectedIndex = 4;

            }
        }
        public void btn_search_Click(object sender, EventArgs e)
        {
            using (var context = new Profit_RGEntities())
            {
                Int32 i = 0;
                CargarGrid();
                foreach (DataGridViewRow item in Grd_busqueda.Rows)
                {
                    string G = Convert.ToString(item.Cells["name"].Value);
                    if (G == "DISPONIBLE")
                    {
                        Grd_busqueda.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                    }
                    i++;
                }
                
                
            }
        }

        void CargarGrid()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var H = context.pBuscarActivo(cbo_empresa.SelectedValue.ToString(), cbo_catalogo.SelectedValue.ToString()).ToList();
                    buscar23.Clear();

                    foreach (var item in H)
                    {
                        buscar23.Add(new GridBusqueda
                        {
                            activo = item.id_activo,
                            descripcion = item.descrip,
                            serial = item.serial,
                            adquisicion = item.fecha_adq.ToShortDateString(),
                            ubicacion = item.ubicacion,
                            catalogo = item.catalogo,
                            nombre = item.nombre,
                        });
                    }
                    Grd_busqueda.DataSource = "";
                    Grd_busqueda.DataSource = buscar23;
                    Grd_busqueda.AutoGenerateColumns = false;
                    Grd_busqueda.Refresh();
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

        private void cbo_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new Profit_RGEntities())
            {
                var y = context.pBuscarActivobyName2(cbo_empresa.SelectedValue.ToString()).ToList ();
              
                cbo_catalogo.DataSource = y;
                cbo_catalogo.DisplayMember = "descripcion";
                cbo_catalogo.ValueMember = "id_cat_activo";

            }
        }

        private void Grd_busqueda_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

        }

        private void Grd_busqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new Profit_RGEntities())
            {
                activo23 = Grd_busqueda.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.Hide();
               // f.Buscar(activo23);
                
            }
        }
    }
}
