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
    public partial class FrmE2 : DevComponents.DotNetBar.Metro.MetroForm
    {

        Int32 Ped;
        String Emp;
        public FrmE2()
        {
            InitializeComponent();
        }

        public FrmE2(String Empresa,Int32 Pedido)
        {
            Ped = Pedido;
            Emp = Empresa;

            InitializeComponent();
        }

        private void FrmE2_Load(object sender, EventArgs e)
        {
            try
            {
                labelX3.Text = "Empresa: " + Emp + " - Pedido: " + Ped.ToString();
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var le = context.pTrabAlm("E").ToList();
                    var lr = context.pTrabAlm("R").ToList();
                    cboEntrega.DataSource = le;
                    cboEntrega.DisplayMember = "nombre_completo";
                    cboEntrega.ValueMember = "nombre_completo";
                    cboRecibe.DataSource = lr;
                    cboRecibe.DisplayMember = "nombre_completo";
                    cboRecibe.ValueMember = "nombre_completo";
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

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea realmente ejecutar esta accion?", "Profit Expasion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        context.pActualizarPedido(Emp, Ped, cboEntrega.SelectedValue.ToString().Trim(), cboRecibe.SelectedValue.ToString().Trim());
                        this.Dispose();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}