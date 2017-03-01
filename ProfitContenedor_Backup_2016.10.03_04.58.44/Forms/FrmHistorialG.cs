using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitContenedor
{
    
    public partial class FrmHistorialG : DevComponents.DotNetBar.Metro.MetroForm
    {
        string user1;
        List<Historial> Hist12 = new List<Historial>();
        List<pSeleccionarGIT_Mov1Grid_Result> grid1 = new List<pSeleccionarGIT_Mov1Grid_Result>();

        public FrmHistorialG()
        {
            InitializeComponent();
        }
        public FrmHistorialG(string user)
        {
            user1 = user;
            InitializeComponent();
            
        }
       
        private void FrmHistorialG_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    grdDatosH.AutoGenerateColumns = false;
                    grdDatosH.DataSource = "";
                    CargarHistorial();
                   // RowsColor();
                   // BuscarColor();
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
        void CargarHistorial()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var G = context.pSeleccionarGIT_Mov1Grid(user1.Trim()).ToList();
                    Hist12.Clear();
                    foreach (var item in G)
                    {
                        Hist12.Add(new Historial
                        {
                            cod = item.id_mov,
                            razon = item.autorizacion,
                            activo = item.id_activo,
                            desde = item.desde.ToShortDateString (),
                            hasta = item.hasta.Value.ToShortDateString (),
                            status = item.status.ToString (),  
                        });
                    }

                    grdDatosH.DataSource = "";
                    grdDatosH.DataSource = Hist12;
                    grdDatosH.AutoGenerateColumns = false;
                    grdDatosH.Refresh();
                   
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

        //public void BuscarColor()
        //{
        //    try
        //    {
        //        using (Profit_RGEntities context = new Profit_RGEntities())
        //        {
        //            foreach (DataGridViewRow row in grdDatosH.Rows)
        //            {

        //                DataGridViewLinkColumn JA = grdDatosH.Columns["status1"] as DataGridViewLinkColumn;
        //                string h = JA.Text;

        //               // string codigo = Convert.ToString(row.Cells["status1"].Value);
        //               // string val = grdDatosH.Rows[i].Cells[5].Value.ToString();
        //                if (JA.ToString () == "Activo")
        //                {
        //                    grdDatosH.Columns["status1"].DefaultCellStyle.BackColor = Color.GreenYellow;
        //                }
        //                else if (JA.ToString () == "Anulado")
        //                {
        //                    grdDatosH.Columns["status1"].DefaultCellStyle.BackColor = Color.Red;
        //                }

        //            }

        //        }

        //    }
        //    catch (EntityException ex)
        //    {
        //        MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex1)
        //    {
        //        MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public void RowsColor()
        //{
        //    try
        //    {
        //        for (int i = 0; i < grdDatosH.Rows.Count; i++)
        //        {
        //            string val = grdDatosH.Rows[i].Cells["status1"].Value.ToString();
                   
        //            {
        //                if (val == "Activo")

        //                    grdDatosH.Columns[5].DefaultCellStyle.BackColor = Color.GreenYellow;


        //                else if (val == "Anulado")

        //                    grdDatosH.Columns[5].DefaultCellStyle.BackColor = Color.Red;
        //            }

        //        }
        //    }
        //    catch (EntityException ex)
        //    {
        //        MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex1)
        //    {
        //        MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void grdDatosH_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                var K = grdDatosH.Rows[e.RowIndex].Cells["status1"].Value.ToString ();
                if  (K == "Activo")
                {
                    grdDatosH.Rows[e.RowIndex].Cells["status1"].Style.BackColor = Color.GreenYellow;
                }
                else if (K == "Anulado")
                {
                    grdDatosH.Rows[e.RowIndex].Cells["status1"].Style.BackColor = Color.Red;
         

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

        private void grdDatosH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new Profit_RGEntities())
            {
                var P = grdDatosH.Rows[e.RowIndex].Cells[5].Selected;
                var K = grdDatosH.Rows[e.RowIndex].Cells["status1"].Value.ToString();
                var L = context.pValidarAnulado(Convert.ToInt32(grdDatosH.Rows[e.RowIndex].Cells[0].Value)).Count();
                if (L > 0 && P)
                {
                    //Si pcp ya confirmo la salida el gerente no puede anular la salida.
                    MessageBox.Show("No se puede anular el registro seleccionado", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    
                    if (K == "Activo" && P)
                    {
                        if ((MessageBox.Show(this, "Desea anular la Autorizacion?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                        {
                            context.pGitCambiarStatus(grdDatosH.Rows[e.RowIndex].Cells["ACTIVO1"].Value.ToString(), Convert.ToDateTime(grdDatosH.Rows[e.RowIndex].Cells["desde1"].Value),
                              Convert.ToDateTime(grdDatosH.Rows[e.RowIndex].Cells["hasta1"].Value));
                            CargarHistorial();
                        }
                        else
                        {
                            DialogResult = DialogResult.None;
                            // this.Hide ();
                        }
                    }
                    else if (K == "Anulado")
                    {
                        MessageBox.Show("No puede modificar este Registro", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
        }
    }
}
