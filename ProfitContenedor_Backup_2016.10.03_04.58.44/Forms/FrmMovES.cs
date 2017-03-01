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
    public partial class FrmMovES : DevComponents.DotNetBar.Metro.MetroForm
    {
        List<RenglonesDG3> ES12 = new List<RenglonesDG3>();
        string lActivo;
        public FrmMovES()
        {
            InitializeComponent();
        }

        public FrmMovES(string gActivo)
        {
            lActivo = gActivo;
            InitializeComponent();
        }

        void CargarMovimiento()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var H = context.pSeleccionarGIT_MovES(lActivo.Trim()).ToList();
                    ES12.Clear();

                    foreach (var item in H)
                    {
                        ES12.Add(new RenglonesDG3
                        {
                            id_movimiento = item.id_mov,
                            autoriza = item.autorizacion,
                            date = item.fecha.ToShortDateString(),
                            activo = item.id_activo,
                            desde = item.desde.ToShortDateString(),
                            hasta = Convert.ToDateTime(item.hasta).ToShortDateString (),
                            confirmar_salida = Convert.ToDateTime(item.confirm_sal).ToLongDateString (),
                            confirmar_entrada = Convert.ToDateTime(item.confirm_ent).ToLongDateString (),
                            status = Convert.ToSByte (item.status),
                        });
                    }
                    grdDatos2.DataSource = "";
                    grdDatos2.DataSource = ES12;
                    grdDatos2.AutoGenerateColumns = false;
                    grdDatos2.Refresh();
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

        private void FrmMovES_Load(object sender, EventArgs e)
        {
            grdDatos2.AutoGenerateColumns = false;
            CargarMovimiento();
        }
    }
}

    
