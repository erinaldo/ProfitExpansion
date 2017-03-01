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
    public partial class FrmPCPE_S : DevComponents.DotNetBar.Metro.MetroForm
    {
        List<SalidaPCP> pcpClass = new List<SalidaPCP>();
        List<EntradaPCP> entradaPCP = new List<EntradaPCP>();
        public FrmPCPE_S()
        {
            InitializeComponent();
        }
        string Usuario_actual = "";
        int Tipo = -1;
        public FrmPCPE_S(string RDV, int TipoConsulta)
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
      
        private void FrmPCPE_S_Load(object sender, EventArgs e)
        {
            using (var context = new Profit_RGEntities())
            {
                grdentradaPCP.DataSource = "";
                grdentradaPCP.AutoGenerateColumns = false;
                grdSalida.DataSource = "";
                grdSalida.AutoGenerateColumns = false;

                CargarEntradas();
                CargarSalidas();
                timer1.Start();
                timer1.Interval = 30000;

                var oo = grdentradaPCP.RowCount;
                if (oo > 0)
                {
                    lbl_entradas.Visible = false;
                    labelX1.Visible = true;
                    labelX1.Text = "Entradas para Hoy:";
                }
                else
                {
                    labelX1.Visible = false;
                    lbl_entradas.Visible = true;
                    lbl_entradas.Text = "No hay Entradas para Hoy";
                }
               

                var L = grdentradaPCP.RowCount;
                if (L < 0)
                {
                    labelX2.Visible = false;
                    lbl_noti.Text = "No hay Salidas para hoy.";
                    
                }
                else
                {
                    labelX2.Visible = true;
                    lbl_noti.Visible = false;


                    //MessageBox.Show("No hay salidas pendientes","Profit Expansion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    //this.Hide();
                }

                var X = Screen.PrimaryScreen.Bounds.Width;
                var Y = Screen.PrimaryScreen.Bounds.Height;
                this.DesktopLocation = new Point(X - this.Width, Y - this.Height - 40);
               

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
                            desde = Convert.ToDateTime(item.Desde).ToString(),
                            hasta = Convert.ToDateTime(item.Hasta).ToString(),
                            salida = Convert.ToDateTime(item.Salida).ToString(),

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
        void CargarEntradas()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {

                    var G = context.pConfirmarEntradaPCP().ToList();
                    entradaPCP.Clear();

                    foreach (var item in G)
                    {
                        entradaPCP.Add(new EntradaPCP
                        {
                            id_mov = item.ID,
                            empleado = item.Empleado,
                            activo = item.Activo,
                            descripcion = item.Descripcion,
                            serial = item.Serial,

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
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            CargarSalidas();
            CargarEntradas();


            var oo = grdentradaPCP.RowCount;
            if (oo > 0)
            {
                lbl_entradas.Visible = false;
                labelX1.Visible = true;
                labelX1.Text = "Entradas para Hoy:";
            }
            else
            {
                labelX1.Visible = false;
                lbl_entradas.Visible = true;
                lbl_entradas.Text = "No hay Entradas para Hoy";
            }

            var L = grdentradaPCP.RowCount;
            if (L < 0)
            {
                lbl_noti.Text = "No hay Salidas para hoy.";
                labelX2.Visible = false;
            }
            else
            {
                labelX2.Visible = true;
                lbl_noti.Visible = false;

                //MessageBox.Show("No hay salidas pendientes","Profit Expansion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                //this.Hide();
            }
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
                            context.pConfirmarFecha_pcp_entrada(Convert.ToInt32(grdentradaPCP.Rows[i].Cells[0].Value));
                            // grdSalida.DataSource = "";
                            // CargarSalidas();
                        }
                        i++;

                    }
                    grdentradaPCP.DataSource = "";
                    CargarEntradas();
                    Refrescar();
                }
                else
                {
                    DialogResult = DialogResult.None;
                }
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

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Desea salir de la Aplicacion?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            // this.Close();
            Application.Exit();
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            FrmEntradaPCP JA = new FrmEntradaPCP();
            JA.Show();
        }
    }
}
