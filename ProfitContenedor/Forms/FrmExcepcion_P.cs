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
    public partial class FrmExcepcion_P : DevComponents.DotNetBar.Metro.MetroForm
    {

        string Usuario_Act;
        Int32 Tip;
        enum Orden
        {
            Alfabetico = 1,
            Aleatorio = 0
        }

        public FrmExcepcion_P()
        {
            InitializeComponent();
        }
        public FrmExcepcion_P(string Usuario_Actual,Int32 Tipo)
        {
            Usuario_Act = Usuario_Actual;
            Tip = Tipo;
            InitializeComponent();
        }

        List<pNomiAsistentes_Result> Lprep = new List<pNomiAsistentes_Result>();
        List<pSeleccionarExcepcion_P_Result> Lexp = new List<pSeleccionarExcepcion_P_Result>();
        private void FrmExcepcion_P_Load(object sender, EventArgs e)
        {
            btnNuevo.Enabled = Tip == 1;
            btnEliminar.Enabled = Tip == 1;
            btnGuardar.Enabled = Tip == 1;
            ActualizarDatos();
            
        }

        private void ActualizarDatos()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {

                    Lprep.Clear();
                    Lprep = context.pNomiAsistentes(2).ToList();
                    cboPreparador.DataSource = Lprep;
                    cboPreparador.ValueMember = "cod_emp";
                    cboPreparador.DisplayMember = "nombre_completo";

                    Lexp = context.pSeleccionarExcepcion_P().OrderByDescending(o=>o.fe_us_in).ToList();
                    grdDatos.AutoGenerateColumns = false;
                    grdDatos.DataSource = Lexp;
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
            panel1.Visible = true;
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            cboPreparador.SelectedIndex = -1;
            chkInactivar.CheckState = CheckState.Checked;
            txtMotivo.Text = "";
            cboPreparador.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboPreparador.SelectedIndex > -1)
                {
                    Int32 i = cboPreparador.SelectedIndex;
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        context.pInsertarExcepcion_P(Lprep[i].Nomina, Lprep[i].cod_emp, 
                                                     Lprep[i].nombre_completo, chkActivar.CheckState==CheckState.Checked, 
                                                     System.DateTime.Now, txtMotivo.Text.Trim());
                        
                        ActualizarDatos();
                        LimpiarControles();
                        panel1.Visible = false;
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
                            Lexp[i].fecha.Date >= System.DateTime.Today)
                        {
                            context.pEliminarExcepcion_P(Lexp[i].rowguid);
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