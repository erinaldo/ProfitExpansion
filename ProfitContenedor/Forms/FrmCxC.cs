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
    public partial class FrmCxC : DevComponents.DotNetBar.Metro.MetroForm
    {
        string Usuario_Act;

        public FrmCxC()
        {
            InitializeComponent();
        }

        public FrmCxC(string Usuario_Actual)
        {
            Usuario_Act = Usuario_Actual;
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {

                    lblCli_des.Text = context.pConsultaRifCliente(txtRif.Text.Trim()).FirstOrDefault();

                    List<pSeleccionarEmpresasCA_Result> Lca = new List<pSeleccionarEmpresasCA_Result>();
                    Lca = context.pSeleccionarEmpresasCA(Usuario_Act).ToList();
                    List<pEstadisticasCxC_Result> Lcxc_Est = new List<pEstadisticasCxC_Result>();
                    List<pDocumentos_CxC_Result> Lcxc_Doc = new List<pDocumentos_CxC_Result>();
                    List<pDocumentos_CxC_Result> Lc = new List<pDocumentos_CxC_Result>();

                    if (Lca.Count() > 0)
                    {
                        foreach (var item in Lca)
                        {
                            Lcxc_Est.Add(context.pEstadisticasCxC(item.co_empresa.Trim(), txtRif.Text.Trim()).FirstOrDefault());
                            Lc = context.pDocumentos_CxC(item.co_empresa.Trim(), txtRif.Text.Trim()).ToList();
       
                            if (Lc.Count()>0)
                            {
                                foreach (var item0 in Lc)
                                {
                                    Lcxc_Doc.Add(item0);
                                }
                            }
                        }
                        grdDatosEst.AutoGenerateColumns = false;
                        grdDatosEst.DataSource = "";
                        grdDatosEst.DataSource = Lcxc_Est;

                        grdDatosDoc.AutoGenerateColumns = false;
                        grdDatosDoc.DataSource = "";
                        grdDatosDoc.DataSource = Lcxc_Doc;

                    }
                    else
                    {
                        MessageBox.Show("El usuario no posee empresas asociadas.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
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

        private void FrmCxC_Load(object sender, EventArgs e)
        {

        }

        private void txtRif_TextChanged(object sender, EventArgs e)
        {
            lblCli_des.Text = "";
        }
    }
}