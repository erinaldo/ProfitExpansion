using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.Entity.Core;
using System.Linq;

namespace ProfitContenedor
{
    public partial class FrmFD : DevComponents.DotNetBar.Metro.MetroForm
    {
        string GrupoE;
        string Art;
        DateTime DesdeF;
        DateTime HastaF;
        
        public FrmFD()
        {
            InitializeComponent();
        }

        public FrmFD(string Grupo,string Co_art,DateTime Desde,DateTime Hasta)
        {
            GrupoE = Grupo;
            Art = Co_art;
            DesdeF = Desde;
            HastaF = Hasta;
            InitializeComponent();
        }

        private void FrmFD_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    grdDatos.AutoGenerateColumns = false;
                    grdDatos.DataSource = context.pSeleccionar_FactDev(GrupoE, Art,DesdeF,HastaF).AsParallel().ToList();
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