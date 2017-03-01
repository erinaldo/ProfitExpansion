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
    public partial class FrmPCP : DevComponents.DotNetBar.Metro.MetroForm
    {
        List<SalidaPCP> pcpClass = new List<SalidaPCP>();
        public FrmPCP()
        {
            InitializeComponent();
        }

        private void FrmPCP_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Profit_RGEntities())
                {
                    timer1.Start();
                    timer1.Interval = 10000;
                    var X = Screen.PrimaryScreen.Bounds.Width;
                    var Y = Screen.PrimaryScreen.Bounds.Height;
                    this.DesktopLocation = new Point(X - this.Width, Y - this.Height - 40);
                    grdSalida.DataSource = "";
                    grdSalida.AutoGenerateColumns = false;
                    var L = context.pConfirmarSalidaPCP().Count();
                    if(L > 0)
                    {
                        grdSalida.DataSource = "";
                        CargarSalidas();
                    }
                    else
                    {
                        labelX1.Text = "";
                        lbl_noti.Text = "No hay Salidas para hoy.";
                        //MessageBox.Show("No hay salidas pendientes","Profit Expansion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        //this.Hide();
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
        void CargarSalidas()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                  
                    var G = context.pConfirmarSalidaPCP().ToList();
                    pcpClass.Clear();

                    foreach (var item in G)
                    {
                        pcpClass.Add(new SalidaPCP
                        {
                            id_movimiento = item.ID,
                            gerente = item.Gerente,
                            empleado = item.Empleado,
                            autorizacion = item.Razon,
                            activo = item.Activo,
                            desde = Convert.ToDateTime (item.Desde).ToString (),
                            hasta = Convert.ToDateTime(item.Hasta).ToString (),
                            salida = Convert.ToDateTime (item.Salida).ToString (), 
                            
                        });
                    }

                    grdSalida.DataSource = "";
                    grdSalida.DataSource = pcpClass;
                    grdSalida.AutoGenerateColumns = false;
                    grdSalida.Refresh();
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

       

        private void grdSalida_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try 
            {
               
                // grdSalida.Rows[e.RowIndex].Cells[6].Style.BackColor  = Color.LawnGreen;
              //  grdSalida.Columns[6].DefaultCellStyle.BackColor = Color.LawnGreen;
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
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try

            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    //SpeechSynthesizer hello = new SpeechSynthesizer();
                    //hello.Speak ("Hello Jesus");
                  
                             
                        
                            if ((MessageBox.Show(this, "Desea confirmar la Autorizacion?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                            {
                                Int32 i = 0;
                                foreach (DataGridViewRow item in grdSalida.Rows)
                                {
                                    //grdSalida.Rows[i].Cells[7].Value.ToString() == "S" 
                                    // (grdSalida[7, i].Value.ToString() == "S")
                                    if (item.Cells[7].Value != null)

                                    {
                                        context.pConfirmarFecha_pcp(Convert.ToInt32(grdSalida.Rows[i].Cells[0].Value));
                                        // grdSalida.DataSource = "";
                                        // CargarSalidas();
                                    }
                                    i++;
                                    
                                }
                                grdSalida.DataSource = "";
                                CargarSalidas();
                            }
                            else
                            {
                                DialogResult = DialogResult.None;
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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refsh_Click(object sender, EventArgs e)
        {
            CargarSalidas();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarSalidas();
        }
    }
}
