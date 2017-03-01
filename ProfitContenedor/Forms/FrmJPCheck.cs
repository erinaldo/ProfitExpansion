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
    public partial class FrmJPCheck : DevComponents.DotNetBar.Metro.MetroForm
    {
    
        public FrmJPCheck()
        {
            InitializeComponent();
        }

        private void FrmJPCheck_Load(object sender, EventArgs e)
        {
            try
            {

                using (var context = new Profit_RGEntities())
                {
                    cbo_supervi.DataSource = context.pSeleccionarSupervisor().ToList();
                    cbo_supervi.DisplayMember = "nombre";
                    cbo_supervi.ValueMember = "co_usuario";
                    MostrarDatos();
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

        void MostrarDatos()
        {
            try
            {
                 using (var context = new Profit_RGEntities())
                {
                    cbo_listsuper.DataSource = context.pMostrarSupervisados(cbo_supervi.SelectedValue.ToString()).ToList ();
                    cbo_listsuper.DisplayMember = "nombre";
                    
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
        private void cbo_listsuper_KeyDown(object sender, KeyEventArgs e)
        {
            //Boolean t = true;
            //cbo_listsuper.SelectedItem = t;
        }

        private void cbo_supervi_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_supervi.SelectedIndex != -1)
                {
                    MostrarDatos();
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
