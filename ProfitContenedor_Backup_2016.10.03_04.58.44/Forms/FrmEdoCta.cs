using ProfitContenedor;
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
    public partial class FrmEdoCta : DevComponents.DotNetBar.Metro.MetroForm
    {
        List<pSeleccionarReng_emb_Result> Ldetalle = new List<pSeleccionarReng_emb_Result>();

        public FrmEdoCta(List<pSeleccionarReng_emb_Result> Detalle)
        {
            Ldetalle = Detalle;
            InitializeComponent();
        }

        private void FrmEdoCta_Load(object sender, EventArgs e)
        {
            try
            {
                grdDatos.AutoGenerateColumns = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var Empresas = (from emp in Ldetalle
                                    select new
                                    {
                                        empresa = emp.empresa.Trim(),
                                        emp.nro_viaje
                                    }).Distinct().ToList();

                    List<EdoCta> Ledocta = new List<EdoCta>();
                    foreach (var item in Empresas)
                    {
                        var Ltemp = context.pEdoCtaxViaje(item.empresa.Trim(), item.nro_viaje).ToList();
                        foreach (var item0 in Ltemp)
	                    {
		                    Ledocta.Add(new EdoCta 
                            {
                                Empresa = item.empresa,
                                Co_prov =  item0.co_prov,
                                Prov_des = item0.prov_des,
                                Fact_num = item0.fact_num,
                                Monto = item0.monto,
                                Abono = item0.abono,
                                Saldo = item0.saldo
                            });
	                    }
                    }
                    grdDatos.DataSource = Ledocta.ToList();
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
