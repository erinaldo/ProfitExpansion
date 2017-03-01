using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;
using System.Data.Entity.Core;

namespace ProfitContenedor
{
    public partial class FrmOdcA : DevComponents.DotNetBar.Metro.MetroForm
    {
        string GrupoE;
        string Art;

        public FrmOdcA()
        {
            InitializeComponent();
        }

        public FrmOdcA(string Grupo,string Co_art)
        {
            GrupoE = Grupo;
            Art = Co_art;
            InitializeComponent();
        }

        private void FrmOdcA_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    grdDatos.AutoGenerateColumns = false;
                    grdDatos.DataSource = context.pSeleccionar_OrdenesAbiertas(GrupoE, Art).AsParallel().ToList();
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