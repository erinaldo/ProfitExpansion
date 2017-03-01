using DevComponents.DotNetBar.Controls;
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
    public partial class FrmODC : DevComponents.DotNetBar.Metro.MetroForm
    {
        Int32 Nro_viaje;
        DataGridView Gr;
        String Co_consig;

        public FrmODC(Int32 Viaje,DataGridView Grid,String Empresa)
        {
            Nro_viaje = Viaje;
            Gr = Grid;
            Co_consig = Empresa;
            InitializeComponent();
        }
        List<Rodc> Lrodc = new List<Rodc>();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                grdDatos.DataSource = "";
                grdDatos.AutoGenerateColumns = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var OdcInfo = context.pODCinfo(txtEmpresa.Text.Trim(), txtFact_num.Value).FirstOrDefault();
                    if (OdcInfo != null)
                    {
                        txtFecha.Text = OdcInfo.fec_emis.ToString();
                        lblStatus.Text = OdcInfo.anulada == 0 ? "ACTIVA" : "ANULADA";
                        txtProv.Text = "["+OdcInfo.co_cli.Trim() + "] - " + OdcInfo.prov_des.Trim();
                    }
                    var Detalle = context.pImportarODC(txtEmpresa.Text.Trim(), txtFact_num.Value).ToList();
                    Lrodc.Clear();
                    foreach (var item in Detalle)
                    {
                        Rodc Irodc = new Rodc();
                        Irodc.empresa = txtEmpresa.Text.Trim();
                        Irodc.fact_num = txtFact_num.Value;
                        Irodc.co_art=item.co_art.Trim();
                        Irodc.art_des = item.art_des.Trim();
                        Irodc.total_art = item.total_art;
                        Irodc.sel = false;
                        Irodc.total_imp = item.total_art;
                        Irodc.prec_vta = item.prec_vta;
                        Irodc.tasa = item.tasa;
                        Lrodc.Add(Irodc); 
                    }
                    grdDatos.DataSource=Lrodc;
                    grdDatos.Refresh();
                    btnSeleccionar.Text = "&Seleccionar todo...";
                }
            }
            catch (EntityCommandExecutionException ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FrmBuscar Fe = new FrmBuscar(txtEmpresa,txtDescrip,"Empresa");
                Fe.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtEmpresa_Leave(object sender, EventArgs e)
        {
            try
            {
                //ProfitDsTableAdapters.empresasTableAdapter emp = new ProfitDsTableAdapters.empresasTableAdapter();
                //ProfitDs.empresasDataTable Dt = new ProfitDs.empresasDataTable();
                //emp.Fill(Dt);
                List<Empresa> Dt = new List<Empresa>();
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    Dt = context.Empresas.ToList();
                }
                var Emp = Dt.FirstOrDefault(c => c.co_empresa.Trim() == txtEmpresa.Text.Trim());
                if (Emp == null)
                {
                    txtDescrip.Text = "NO ENCONTRADO";
                }
                else
                {
                    txtDescrip.Text = Emp.des_emp.Trim();
                }
            }
            catch (DataException ex0)
            {
                MessageBox.Show(ex0.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    foreach (var item in Lrodc)
                    {
                        if (item.sel == true)
                            context.pInsertarReng_emb(item.empresa.Trim(), Nro_viaje, item.fact_num, item.co_art.Trim(), item.art_des.Trim(), item.total_imp,item.prec_vta,item.tasa);
                    }
                    List<pSeleccionarReng_emb_Result> detalle = new List<pSeleccionarReng_emb_Result>();
                    detalle = context.pSeleccionarReng_emb(Nro_viaje).ToList();
                    Gr.DataSource = detalle;
                }
                this.Dispose();
            }
            catch (DataException ex0)
            {
                MessageBox.Show(ex0.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdDatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4 && grdDatos[3, e.RowIndex].Value.ToString().ToUpper() == "FALSE")
                {
                    grdDatos[4, e.RowIndex].Value = grdDatos[3, e.RowIndex].Value;
                }
                if (e.ColumnIndex == 4 && grdDatos[3, e.RowIndex].Value.ToString().ToUpper() == "TRUE")
                {
                    var Imp = Convert.ToDecimal(grdDatos[4, e.RowIndex].Value.ToString());
                    var Dis = Convert.ToDecimal(grdDatos[2, e.RowIndex].Value.ToString());
                    grdDatos[4, e.RowIndex].Value = Imp > Dis ? Dis : Imp;
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Lrodc.Count() > 0)
                {
                    foreach (var item in Lrodc)
                    {
                        item.sel = btnSeleccionar.Text.Trim() == "&Seleccionar todo...";
                    }
                    grdDatos.Refresh();
                    btnSeleccionar.Text = btnSeleccionar.Text.Trim() == "&Seleccionar todo..." ? "&Quitar todo..." : "&Seleccionar todo...";
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmODC_Load(object sender, EventArgs e)
        {
            txtEmpresa.Text = Co_consig;
            txtEmpresa_Leave(sender, e);

        }

        private void txtFact_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnConsultar_Click(sender, e);
        }
    }
}
