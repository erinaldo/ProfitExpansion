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
    public partial class FrmEntradaPCP : DevComponents.DotNetBar.Metro.MetroForm
    {
        List<EntradaPCP> entradaPCP = new List<EntradaPCP>();
        public FrmEntradaPCP()
        {
            InitializeComponent();
        }
        string Usuario_actual = "";
        int Tipo = -1;
        public FrmEntradaPCP(string RDV, int TipoConsulta)
        {
            Usuario_actual = RDV.Trim();
            Tipo = TipoConsulta;
            if (Tipo == 1)
            {
                InitializeComponent();
            }
            else
            {
                InitializeComponent();
            }
        }

        void CargarEntradas()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {

                    var G = context.pConfirmarEntradaPCP2().ToList();
                    entradaPCP.Clear();

                    foreach (var item in G)
                    {
                        entradaPCP.Add(new EntradaPCP
                        {
                            id_mov = item.ID,
                            empleado = item.Empleado,
                            activo = item.Activo,
                            descripcion = item.Descripcion_del_Activo,
                            serial = item.serial,
                            fecha_entrega = Convert.ToDateTime (item.Hasta).ToShortDateString (),

                        });
                    }

                    grdentradaPCP.DataSource = "";
                    grdentradaPCP.DataSource = entradaPCP;
                    grdentradaPCP.AutoGenerateColumns = false;
                    grdentradaPCP.Refresh();
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

        private void FrmEntradaPCP_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Profit_RGEntities())
                {
                    timer1.Start();
                    timer1.Interval = 10000;
                    grdentradaPCP.DataSource = "";
                    grdentradaPCP.AutoGenerateColumns = false;

                    CargarEntradas();

                    //var X = Screen.PrimaryScreen.Bounds.Width;
                    //var Y = Screen.PrimaryScreen.Bounds.Height;
                    //this.DesktopLocation = new Point(X - this.Width, Y - this.Height - 235);
                    var oo = context.pConfirmarEntradaPCP2().Count();
                    if (oo <= 0)
                    {
                        lbl_entradas.Text = "No hay Entradas para Hoy";
                        buttonX1.Enabled = false;
                    }
                    else
                    {
                        lbl_entradas.Visible = true;
                        buttonX1.Enabled = true;
                       
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            CargarEntradas();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            using (Profit_RGEntities context = new Profit_RGEntities())
            {
                if ((MessageBox.Show(this, "Desea confirmar la entrada del Equipo?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    Int32 i = 0;
                    foreach (DataGridViewRow item in grdentradaPCP.Rows)
                    {
                        //grdSalida.Rows[i].Cells[7].Value.ToString() == "S" 
                        // (grdSalida[7, i].Value.ToString() == "S")
                        if (item.Cells[5].Value != null)

                        {
                            string a = Convert.ToString(item.Cells["Confirm"].Value);
                            if (a == "T")
                            {
                                context.pConfirmarFecha_pcp_entrada(Convert.ToInt32(grdentradaPCP.Rows[i].Cells[0].Value));
                                grdentradaPCP.DataSource = "";
                                CargarEntradas();
                            }                          
                            // grdSalida.DataSource = "";
                            // CargarSalidas();
                        }
                        i++;

                    }
                    grdentradaPCP.DataSource = "";
                    CargarEntradas();
                }
                else
                {
                    DialogResult = DialogResult.None;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarEntradas();
        }
    }
}
