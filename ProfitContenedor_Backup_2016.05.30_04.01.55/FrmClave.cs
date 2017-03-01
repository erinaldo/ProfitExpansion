using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;

namespace ProfitContenedor
{
    public partial class FrmClave : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmClave()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try 
	        {	        
		        if (MessageBox.Show("Desea generar una nueva clave?","Profit Expansion",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    string Clave = Passwords.GeneradorPassword.GetPassword();
                    Clipboard.SetDataObject(Clave);
                    using(Profit_RGEntities context = new Profit_RGEntities())
	                {
                        context.pInsertarGene_Claves(Clave.Trim(),cboUsuario.SelectedValue.ToString().Trim(),cboEmpresa.SelectedValue.ToString().Trim(),txtFec_Venc.Value,txtCantidad.Value);
           		        GrdDatos.AutoGenerateColumns= false;
                        GrdDatos.DataSource = context.pSeleccionarGene_Claves().ToList();

                        GrdDatos.CurrentCell = GrdDatos[0,GrdDatos.RowCount -1];
	                }
                }
	        }
	        catch (EntityException ex0)
            {
                MessageBox.Show(ex0.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FrmClave_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var Lu = context.pUsuariosProfit().ToList();
                    cboUsuario.DataSource = Lu;
                    cboUsuario.DisplayMember = "last_name";
                    cboUsuario.ValueMember = "employee_i";

                    cboEmpresa.DataSource = context.Empresas.ToList();
                    cboEmpresa.DisplayMember = "des_emp";
                    cboEmpresa.ValueMember = "co_empresa";

                    GrdDatos.AutoGenerateColumns = false;
                    GrdDatos.DataSource = context.pSeleccionarGene_Claves().ToList();
                }

                txtFec_Venc.Value = System.DateTime.Now;
            }
            catch (EntityException ex0)
            {
                MessageBox.Show(ex0.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GrdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GrdDatos.RowCount > 0)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        GrdDatosDoc.AutoGenerateColumns = false;
                        GrdDatosDoc.DataSource = context.pSeleccionarDocumentosClave(GrdDatos[0, GrdDatos.CurrentCell.RowIndex].Value.ToString().Trim(),
                                                                                     GrdDatos[7, GrdDatos.CurrentCell.RowIndex].Value.ToString().Trim(),
                                                                                     GrdDatos[2, GrdDatos.CurrentCell.RowIndex].Value.ToString().Trim()).ToList();
                    }
                }
            }
            catch (EntityException ex0)
            {
                MessageBox.Show(ex0.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (GrdDatos.RowCount > 0)
                {
                    if (MessageBox.Show("Desea anular esta clave?", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (GrdDatos[6, GrdDatos.CurrentCell.RowIndex].Value.ToString() != "ANU")
                        {
                            using (Profit_RGEntities context = new Profit_RGEntities())
                            {
                                context.pAnulaClave(GrdDatos[8, GrdDatos.CurrentCell.RowIndex].Value.ToString().Trim());
                                GrdDatos.AutoGenerateColumns = false;
                                GrdDatos.DataSource = context.pSeleccionarGene_Claves().ToList();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La clave ya ha sido anulada!", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch (EntityException ex0)
            {
                MessageBox.Show(ex0.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}