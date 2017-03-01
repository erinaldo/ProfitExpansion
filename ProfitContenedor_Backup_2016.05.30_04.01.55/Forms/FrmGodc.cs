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
    public partial class FrmGodc : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmGodc()
        {
            InitializeComponent();
        }

        List<Acom> Ac = new List<Acom>();
        string Co_alma;
        string Emp;

        public FrmGodc(FrmACom Fowner,string Empresa)
        {
            Ac = Fowner.Ac;
            Emp = Empresa;
            Co_alma = Fowner.txtCo_alma.Text;
            InitializeComponent();
        }

        private void FrmGodc_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    cboEmpresa.DataSource = context.Emp_asoc.Where(a => a.co_empresa == Emp).ToList();
                    cboEmpresa.ValueMember = "asociada";
                    cboEmpresa.DisplayMember = "asociada";
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboEmpresa.SelectedIndex > -1)
                {
                    if (MessageBox.Show("Desea realmente generar una Orden de Compra?", "Profit Expansión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            Int32 Proximo = context.pObtenerPar_emp(cboEmpresa.SelectedValue.ToString().Trim ()).FirstOrDefault().ord_num.Value + 1;
                            string EmpDestino = cboEmpresa.SelectedValue.ToString();
                            decimal Saldo = Ac.Sum(a => a.comprar * a.costo) * 6.30m;
                            DateTime FechaCorta = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
                            DateTime FechaLarga = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second);

                            context.pInsertar_OrdenesCompra(EmpDestino, Proximo, true,"A", "B", "C", "0", "Profit Expansion", "ODC generada por Profit Expansión", Saldo,
                                FechaCorta, FechaCorta, "", "", "", "D", "", Saldo, Saldo, 0.00m, 0.00m, "", "", 0.00m, 0.00m, 0.00m, 0.00m, 0.00m,
                                false, false, 0.00m, 0.00m, FechaCorta, 0, 6.30m, "US$", "", 0, 12.0m, 8.00m, 27.00m, "", "", "", "", "", "", "", "", "999",
                                DateTime.Now, "999", FechaLarga, "", FechaLarga, "", "", "", 0.00m, 0.00m, 0.00m, 0.00m, 
                                " <IVA>" + Environment.NewLine + "<E>" + Saldo.ToString().Trim() + "</E>" + Environment.NewLine + "</IVA>",
                                0.00m, "", "", "", "", "", "", "E");

                            Int32 i = 1;
                            foreach (var item in Ac)
                            {
                                if (item.comprar > 0)
                                {
                                    string Uni_venta = context.pSeleccionarArticulo(Emp, item.co_art.Trim()).FirstOrDefault().uni_venta.Trim();
                                    string Comentario = context.pSeleccionarArticulo(Emp, item.co_art.Trim()).FirstOrDefault().comentario.Trim();
                                    context.pInsertar_OrdenesCompra_Reng(EmpDestino, Proximo, i, "", 0, 0, item.co_art.Trim(), Co_alma, item.comprar, 0.00m, item.comprar, Uni_venta,
                                        item.costo * 6.30m, "", "6", (item.comprar * item.costo) * 6.30m, item.costo * 6.30m, item.costo * 6.30m, item.costo, item.costo, 
                                        0.00m, 0.00m, item.costo, false, "", false, 0.00m, Comentario, 1.00m, 0.00m, 0.00m, "", FechaCorta, 0.00m, "", 0, 0, "", "", 0.00m, "", 
                                        0.00m, 0.00m);
                                    i++;
                                }
                            }

                            MessageBox.Show("Su Orden de Compra ha sido generada bajo el numero: [" + Proximo.ToString().Trim() + "]", "Profit Expansión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}