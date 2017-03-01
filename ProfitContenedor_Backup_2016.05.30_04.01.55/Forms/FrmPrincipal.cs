using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core;

namespace ProfitContenedor
{
    public partial class FrmPrincipal : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        string Co_usu;

        public FrmPrincipal(String Co_usuario)
        {
            try
            {
                InitializeComponent();
                Co_usu = Co_usuario;
                HabilitarBotones(Co_usuario);
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

        public void HabilitarBotones(String Co_usuario)
        {
            using (Profit_RGEntities context = new Profit_RGEntities())
            {
                var U = context.Usuarios.First(u => u.co_usuario == Co_usuario);
                MetroEmpresas.Enabled = U.p_emp >= 0;
                MetroEmpresas.Tag = U.p_emp;
                MetroNavieras.Enabled = U.p_nav >= 0;
                MetroNavieras.Tag = U.p_nav;
                MetroUsuarios.Enabled = U.p_usu >= 0;
                MetroUsuarios.Tag = U.p_usu;
                MetroContenedores.Enabled = U.p_con >= 0;
                MetroContenedores.Tag = U.p_con;
                MetroMonitor.Enabled = U.p_mco >= 0;
                MetroMonitor.Tag = U.p_mco;
                MetroPStock.Enabled = U.p_pst >= 0;
                MetroPStock.Tag = U.p_pst;
                MetroArticulos.Enabled = U.p_art >= 0;
                MetroArticulos.Tag = U.p_art;
                MetroClaves.Enabled = U.p_clave >= 0;
                MetroClaves.Tag = U.p_clave;
                MetroEntrega.Enabled = U.p_malm >= 0;
                MetroEntrega.Tag = U.p_malm;
                MetroOrdenes.Enabled = U.p_ord >= 0;
                MetroOrdenes.Tag = U.p_ord;
                MetroCxC.Enabled = U.p_cxc >= 0;
                MetroCxC.Tag = U.p_cxc;
                MetroPrepP.Enabled = U.p_pped >= 0;
                MetroPrepP.Tag = U.p_pped;
                MetroRegRep.Enabled = U.p_regrep >= 0;
                MetroRegRep.Tag = U.p_regrep;
                MetroEnvRep.Enabled = U.p_envrep >= 0;
                MetroEnvRep.Tag = U.p_envrep;
                MetroRep.Enabled = U.p_rep >= 0;
                MetroRep.Tag = U.p_rep;
                MetroL_Cred.Enabled = U.p_lcre >= 0;
                MetroL_Cred.Tag = U.p_lcre;
                MetroCompras.Enabled = U.p_com >= 0;
                MetroCompras.Tag = U.p_com;
                this.Refresh();
            }
        }

        private void MetroEmpresas_Click(object sender, EventArgs e)
        {
            FrmEmp Femp = new FrmEmp();
            Femp.Show();
        }

        private void MetroNavieras_Click(object sender, EventArgs e)
        {
            FrmNaviera Fn = new FrmNaviera();
            Fn.Show();
        }

        private void MetroContenedores_Click(object sender, EventArgs e)
        {
            FrmCont Fc = new FrmCont();
            Fc.Show();
        }

        private void MetroMonitor_Click(object sender, EventArgs e)
        {
            FrmMonitor Fm = new FrmMonitor();
            Fm.Show();
        }

        private void MetroUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios Fu = new FrmUsuarios();
            Fu.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MetroPStock_Click(object sender, EventArgs e)
        {
            FrmPantalla_Stock Fps = new FrmPantalla_Stock();
            Fps.Show();
        }

        private void MetroArticulos_Click(object sender, EventArgs e)
        {
            FrmArt Fart = new FrmArt(Co_usu, Convert.ToInt32(MetroArticulos.Tag));
            Fart.Show();
        }

        private void MetroClaves_Click(object sender, EventArgs e)
        {
            FrmClave Fclave = new FrmClave();
            Fclave.Show();
        }

        private void MetroEntrega_Click(object sender, EventArgs e)
        {
            FrmEntrega Fentrega = new FrmEntrega(Co_usu);
            Fentrega.Show();
        }

        private void MetroOrdenes_Click(object sender, EventArgs e)
        {
            FrmOrd Fo = new FrmOrd();
            Fo.Show();
        }

        private void MetroFact_imp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modulo en construccion...", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void MetroCxC_Click(object sender, EventArgs e)
        {
            FrmCxC Fcxc = new FrmCxC(Co_usu);
            Fcxc.Show();
        }

        private void MetroPrepP_Click(object sender, EventArgs e)
        {
            FrmPrepped Fp = new FrmPrepped(Co_usu, Convert.ToInt32(MetroPrepP.Tag));
            Fp.Show();
        }

        private void MetroReport_Click(object sender, EventArgs e)
        {
            FrmReportes Fr = new FrmReportes();
            Fr.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MetroEnvRep_Click(object sender, EventArgs e)
        {
            FrmProgramas Fp = new FrmProgramas(Co_usu, Convert.ToInt32(MetroEnvRep.Tag));
            Fp.Show();
        }

        private void MetroL_Cred_Click(object sender, EventArgs e)
        {
            FrmL_Credito Flc = new FrmL_Credito(Co_usu, Convert.ToInt32(MetroPrepP.Tag));
            Flc.Show();
        }

        private void MetroRegRep_Click(object sender, EventArgs e)
        {
            FrmR Fr = new FrmR(Co_usu,Convert.ToInt32(MetroRegRep.Tag));
            Fr.Show();
        }

        private void MetroCompras_Click(object sender, EventArgs e)
        {
            FrmACom Facom = new FrmACom(Co_usu, Convert.ToInt32(MetroCompras.Tag));
            Facom.Show();
        }
    }
}
