using ProfitContenedor;
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
    public partial class FrmRemb : DevComponents.DotNetBar.Metro.MetroForm
    {
        Int32 Nro_viaje;
        public FrmRemb(Int32 Viaje)
        {
            Nro_viaje = Viaje;
            InitializeComponent();
        }

        private void FrmRemb_Load(object sender, EventArgs e)
        {
            try
            {
                grdDatos.AutoGenerateColumns = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    grdDatos.DataSource = context.pSeleccionarReng_emb(Nro_viaje).ToList();
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
    }
}
