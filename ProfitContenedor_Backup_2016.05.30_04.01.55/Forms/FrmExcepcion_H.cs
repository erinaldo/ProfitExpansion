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
    public partial class FrmExcepcion_H : DevComponents.DotNetBar.Metro.MetroForm
    {
        string Usuario_Act;
        Int32 Tip;
        List<pSeleccionarExcepcion_H_Result> Lh = new List<pSeleccionarExcepcion_H_Result>(); 
        public FrmExcepcion_H()
        {
            InitializeComponent();
        }
        public FrmExcepcion_H(string Usuario_Actual,Int32 Tipo)
        {
            Usuario_Act = Usuario_Actual;
            Tip = Tipo;
            InitializeComponent();
        }

        private void FrmExcepcion_H_Load(object sender, EventArgs e)
        {
            txtFechaHora.MinDate = System.DateTime.Today;
            btnNuevo.Enabled = Tip == 1;
            btnEliminar.Enabled = Tip == 1;
            btnGuardar.Enabled = Tip == 1;
            txtFechaHora.Visible = false;
            txtFechaHora.Value = System.DateTime.Now;
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    Lh.Clear();
                    Lh = context.pSeleccionarExcepcion_H().OrderByDescending(o => o.fe_us_in).ToList();
                    grdDatos.AutoGenerateColumns = false;
                    grdDatos.DataSource = Lh;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtFechaHora.Visible = true;
            txtFechaHora.Value = System.DateTime.Now;
            txtFechaHora.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    context.pInsertarExcepcion_H(txtFechaHora.Value);
                    ActualizarDatos();
                    txtFechaHora.Visible = false;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdDatos.RowCount > 0)
                {
                    Int32 i = grdDatos.CurrentCell.RowIndex;
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        if (MessageBox.Show("Desea eliminar este registro?", "Profit Expansion",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes &&
                            Lh[i].fecha.Date >= System.DateTime.Today)
                        {
                            context.pEliminarExcepcion_P(Lh[i].rowguid);
                            ActualizarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Solo puede eliminar registros futuros o del dia en curso!", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
    }
}