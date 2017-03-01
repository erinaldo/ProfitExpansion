///<summary>
///     Escritorio principal de Profit Expansion
///  <paramref name="Co_usuario"/> Codigo del usuario que inicia sesion, proviene del formulario Login
/// </summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.Entity.Core;
using System.Linq;

namespace ProfitContenedor
{
    public partial class FrmEscritorio : DevComponents.DotNetBar.RibbonForm
    {
        public FrmEscritorio()
        {
            InitializeComponent();
        }

        string Co_usu;

        public FrmEscritorio(String Co_usuario)
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

        /// <summary>
        /// Obtiene los permisos del usuario activo
        /// <paramref name="Co_usuario" /> Codigo del usuario a consultar proviene del formulario login
        /// <see cref="Inicio del formulario" />
        /// </summary>
        /// <param name="Co_usuario">The co_usuario.</param>

        public void HabilitarBotones(String Co_usuario)
        {
            using (Profit_RGEntities context = new Profit_RGEntities())
            {
                var U = context.Usuarios.First(u => u.co_usuario == Co_usuario);
                #region TabConfiguracion
                btnUsuarios.Enabled = U.p_usu >= 0;
                btnUsuarios.Tag = U.p_usu;
                btnPStock.Enabled = U.p_pst >= 0;
                btnPStock.Tag = U.p_pst;
                btnReportes.Enabled = U.p_rep >= 0;
                btnReportes.Tag = U.p_rep;
                btnProgramas.Enabled = U.p_envrep >= 0;
                btnProgramas.Tag = U.p_envrep;
                btnLCredito.Enabled = U.p_lcre >= 0;
                btnLCredito.Tag = U.p_lcre;
                #endregion

                btnEmpresa.Enabled = U.p_emp >= 0;
                btnEmpresa.Tag = U.p_emp;
                btnNavieras.Enabled = U.p_nav >= 0;
                btnNavieras.Tag = U.p_nav;
                
                btnContenedores.Enabled = U.p_con >= 0;
                btnContenedores.Tag = U.p_con;
                btnMonitor.Enabled = U.p_mco >= 0;
                btnMonitor.Tag = U.p_mco;
                
                btnConsultaArt.Enabled = U.p_art >= 0;
                btnConsultaArt.Tag = U.p_art;
                btnGClaves.Enabled = U.p_clave >= 0;
                btnGClaves.Tag = U.p_clave;
                btnEMercancia.Enabled = U.p_malm >= 0;
                btnEMercancia.Tag = U.p_malm;
                btnODC.Enabled = U.p_ord >= 0;
                btnODC.Tag = U.p_ord;
                btnCxC.Enabled = U.p_cxc >= 0;
                btnCxC.Tag = U.p_cxc;
                btnPpedido.Enabled = U.p_pped >= 0;
                btnPpedido.Tag = U.p_pped;
                btnRegReportes.Enabled = U.p_regrep >= 0;
                btnRegReportes.Tag = U.p_regrep;

                btnCompras.Enabled = U.p_com >= 0;
                btnCompras.Tag = U.p_com;
                btnMetas.Enabled = U.p_metas >= 0;
                btnMetas.Tag = U.p_metas;

                btnConsultor.Enabled = U.p_cons >= 0;
                btnConsultor.Tag = U.p_cons;
                btnConsumibles.Enabled = U.p_consu >= 0;
                btnConsumibles.Tag = U.p_consu;
                btnActivos.Enabled = U.p_acti >= 0;
                btnActivos.Tag = U.p_acti;
                bntUbicacion.Enabled = U.p_ubi >= 0;
                bntUbicacion.Tag = U.p_ubi;
                btnAutorizar.Enabled = U.p_supervi >= 0;
                btnAutorizar.Tag = U.p_supervi;
                buttonItem1.Enabled = U.p_control >= 0;
                buttonItem1.Tag = U.p_control;
                
                
                
                

                this.Refresh();
            }
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            FrmEmp Femp = new FrmEmp();
            Femp.Show();
        }

        private void btnNavieras_Click(object sender, EventArgs e)
        {
            FrmNaviera Fn = new FrmNaviera();
            Fn.Show();
        }

        private void btnContenedores_Click(object sender, EventArgs e)
        {
            FrmCont Fc = new FrmCont();
            Fc.Show();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            FrmMonitor Fm = new FrmMonitor();
            Fm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios Fu = new FrmUsuarios();
            Fu.Show();
        }

        private void btnPStock_Click(object sender, EventArgs e)
        {
            FrmPantalla_Stock Fps = new FrmPantalla_Stock();
            Fps.Show();
        }

        private void btnConsultaArt_Click(object sender, EventArgs e)
        {
            FrmArt Fart = new FrmArt(Co_usu, Convert.ToInt32(btnConsultaArt.Tag));
            Fart.Show();
        }

        private void btnGClaves_Click(object sender, EventArgs e)
        {
            FrmClave Fclave = new FrmClave();
            Fclave.Show();
        }

        private void btnEMercancia_Click(object sender, EventArgs e)
        {
            FrmEntrega Fentrega = new FrmEntrega(Co_usu);
            Fentrega.Show();
        }

        private void btnODC_Click(object sender, EventArgs e)
        {
            FrmOrd Fo = new FrmOrd();
            Fo.Show();
        }

        private void btnCxC_Click(object sender, EventArgs e)
        {
            FrmCxC Fcxc = new FrmCxC(Co_usu);
            Fcxc.Show();
        }

        private void btnPpedido_Click(object sender, EventArgs e)
        {
            FrmPrepped Fp = new FrmPrepped(Co_usu, Convert.ToInt32(btnPpedido.Tag));
            Fp.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes Fr = new FrmReportes();
            Fr.Show();
        }

        private void btnProgramas_Click(object sender, EventArgs e)
        {
            FrmProgramas Fp = new FrmProgramas(Co_usu, Convert.ToInt32(btnProgramas.Tag));
            Fp.Show();
        }

        private void btnLCredito_Click(object sender, EventArgs e)
        {
            FrmL_Credito Flc = new FrmL_Credito(Co_usu, Convert.ToInt32(btnLCredito.Tag));
            Flc.Show();
        }

        private void btnRegReportes_Click(object sender, EventArgs e)
        {
            FrmR Fr = new FrmR(Co_usu, Convert.ToInt32(btnRegReportes.Tag));
            Fr.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmACom Facom = new FrmACom(Co_usu, Convert.ToInt32(btnCompras.Tag));
            Facom.Show();
        }

        private void btnCambioUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"Desea realmente cambiar de usuario?","Profit Expansion",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)
                == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
                Frmlogin Fl = new Frmlogin();
                Fl.Show();    
            }
            
        }

        private void FrmEscritorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnMetas_Click(object sender, EventArgs e)
        {
            FrmMetasVtas Fmv = new FrmMetasVtas(Co_usu, Convert.ToInt32(btnMetas.Tag));
            Fmv.Show();
        }

        private void bntUbicacion_Click(object sender, EventArgs e)
        {
            FrmUbicacion ubi1 = new FrmUbicacion();
            ubi1.Show();
        }

        private void btnConsultor_Click(object sender, EventArgs e)
        {
            FrmConsultor consult12 = new FrmConsultor();
            consult12.Show();
        }

        private void btnCampos_log_Click(object sender, EventArgs e)
        {
            FrmCamposLogicos campos14 = new FrmCamposLogicos();
            campos14.Show();
        }

        private void btnCat_acti_Click(object sender, EventArgs e)
        {
            FrmCatalogo_Activo cat12 = new FrmCatalogo_Activo();
            cat12.Show();
        }

        private void btn_asignacion_Click(object sender, EventArgs e)
        {
            FrmAsignacion asign34 = new FrmAsignacion();
            asign34.Show();
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            FrmActivos acti123 = new FrmActivos();
            acti123.Show();
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            FrmAutorizaG hy = new FrmAutorizaG(Co_usu);
            hy.Show();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            FrmPCPE_S PE = new FrmPCPE_S();
            PE.Show();
            this.Hide();
        }
    }
}