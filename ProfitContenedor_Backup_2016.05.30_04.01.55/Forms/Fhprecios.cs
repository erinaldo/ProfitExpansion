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
    public partial class Fhprecios : DevComponents.DotNetBar.Metro.MetroForm
    {
        string Articulo;
        public Fhprecios()
        {
            InitializeComponent();
        }

        public Fhprecios(string Co_art)
        {
            InitializeComponent();
            Articulo = Co_art.Trim();
        }

        private void Fhprecios_Load(object sender, EventArgs e)
        {
            try
            {
                grdDatos.AutoGenerateColumns = false;
                using(Profit_RGEntities context = new Profit_RGEntities())
	            {
                    grdDatos.DataSource = context.Precios.Where(a => a.co_art.Trim() == Articulo.Trim()).OrderByDescending(o => o.fec_emis).ToList();
                    radGridView1.DataSource = context.Precios.Where(a => a.co_art.Trim() == Articulo.Trim()).OrderByDescending(o => o.fec_emis).ToList();
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