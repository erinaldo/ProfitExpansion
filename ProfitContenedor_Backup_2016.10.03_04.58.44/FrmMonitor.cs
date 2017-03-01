using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitContenedor
{
    public partial class FrmMonitor : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmMonitor()
        {
            InitializeComponent();
            X2_Initialize();
        }
        List<pMonitorContenedores_Result> Monitor = new List<pMonitorContenedores_Result>();
                
        private void X2_Initialize()
        {
            DataGridViewButtonXColumn oc1 =
                grdDatos.Columns["nro_viaje"] as DataGridViewButtonXColumn;

            if (oc1 != null)
            {
                // Hook onto the following events so we can
                // demonstrate cell customization and click processing
                oc1.ToolTipText = "Haga clic aqui para ver el detalle";
                oc1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
                oc1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                oc1.Click += oc1_Click;
            }

            DataGridViewButtonXColumn oc2 =
                grdDatos.Columns["monto"] as DataGridViewButtonXColumn;

            if (oc2 != null)
            {
                // Hook onto the following events so we can
                // demonstrate cell customization and click processing
                oc2.ToolTipText = "Haga clic aqui para ver el detalle";
                oc2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
                oc2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
                oc2.Click += oc2_Click;
            }
        }

        private void oc1_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 Viaje = Convert.ToInt32(grdDatos[0, grdDatos.CurrentCell.RowIndex].Value);
                FrmRemb Fr = new FrmRemb(Viaje);
                Fr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sipca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void oc2_Click(object sender, EventArgs e)
        {
            try
            {
                List<pSeleccionarReng_emb_Result> pRemb = new List<pSeleccionarReng_emb_Result>(); 
                using(Profit_RGEntities context = new Profit_RGEntities())
	            {
                    Int32 Viaje = Convert.ToInt32(grdDatos[0, grdDatos.CurrentCell.RowIndex].Value);
                    pRemb = context.pSeleccionarReng_emb(Viaje).ToList();
	            }
                FrmEdoCta Fedo = new FrmEdoCta(pRemb);
                Fedo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sipca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMonitor_Load(object sender, EventArgs e)
        {
            txtDesde.Value = DateTime.Today.AddDays(-1);
            txtHasta.Value = DateTime.Today.AddDays(50);
            btnConsultar_Click(sender, e);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                grdDatos.AutoGenerateColumns = false;
                Monitor.Clear();
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    Monitor = context.pMonitorContenedores(txtDesde.Value, txtHasta.Value).ToList();
                    grdDatos.DataSource = Monitor.ToList();

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //FrmReport Fr = new FrmReport(txtDesde.Value,txtHasta.Value);
            //Fr.Show();
        }


        
    }
}
