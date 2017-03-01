using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitContenedor
{
    public partial class FrmUsuarios : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        #region Variables
        Boolean Nuevo = false;
        byte[] Validador;
        List<EmpresaCSA> LempresaCA = new List<EmpresaCSA>();
        List<EmpresaCSA> LempresaSA = new List<EmpresaCSA>();
        int? P_emp = -1;
        int? P_nav = -1;
        int? P_usu = -1;
        int? P_con = -1;
        int? P_mco = -1;
        int? P_pst = -1;
        int? P_art = -1;
        int? P_clave = -1;
        int? P_malm = -1;
        int? P_ord = -1;
        int? P_pped = -1;
        int? P_cxc = -1;
        int? P_regrep = -1;
        int? P_envrep = -1;
        int? P_rep = -1;
        int? P_lcre = -1;
        int? P_com = -1;
        int? P_metas = -1;
        int? P_ubi = -1;
        int? P_cons = -1;
        int? P_camp_L = -1;
        int? P_acti = -1;
        int? P_consum = -1;
        int? P_caso = -1;
        int? P_control = -1;
        int? P_supervi = -1;
            

        Image avatar = null;
        #endregion

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            using (var context = new Profit_RGEntities())
            {
                cbo_profit.DataSource = context.pUsuariosProfit().ToList();
                cbo_profit.ValueMember = "employee_i";
                cbo_profit.DisplayMember = "last_name";
               
            }
            Navegar(3);
        }

        private void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                txtCo_usuario.Enabled = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    pSeleccionarUsuario_Result Usuario = new pSeleccionarUsuario_Result();
                    var pusu = context.pObtenerTablaStr(txtCo_usuario.Text.Trim(),"co_usuario",p,"Usuarios").ToList();
                    if (pusu.Count > 0)
                    {
                        Usuario = context.pSeleccionarUsuario(pusu[0].Trim()).FirstOrDefault();
                        txtCo_usuario.Text = Usuario.co_usuario.Trim();
                        cbo_profit.SelectedValue  = Usuario.co_profit;
                        txtNombre.Text = Usuario.nombre.Trim();
                        txtClave.Text = MC.GetString(Usuario.clave).ToString();
                        txtClaveR.Text = MC.GetString(Usuario.clave).ToString();
                        cboNivel.SelectedIndex = Usuario.tipo;
                        txtRdv.Text = Usuario.co_rdv.Trim();
                        chkP_emp.CheckState = Usuario.p_emp == -1 ? CheckState.Unchecked : Usuario.p_emp == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_nav.CheckState = Usuario.p_nav == -1 ? CheckState.Unchecked : Usuario.p_nav == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_usu.CheckState = Usuario.p_usu == -1 ? CheckState.Unchecked : Usuario.p_usu == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_con.CheckState = Usuario.p_con == -1 ? CheckState.Unchecked : Usuario.p_con == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_emp.CheckState = Usuario.p_emp == -1 ? CheckState.Unchecked : Usuario.p_emp == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_mco.CheckState = Usuario.p_mco == -1 ? CheckState.Unchecked : Usuario.p_mco == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_pst.CheckState = Usuario.p_pst == -1 ? CheckState.Unchecked : Usuario.p_pst == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_art.CheckState = Usuario.p_art == -1 ? CheckState.Unchecked : Usuario.p_art == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        ChkP_clave.CheckState = Usuario.p_clave == -1 ? CheckState.Unchecked : Usuario.p_clave == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_malm.CheckState = Usuario.p_malm == -1 ? CheckState.Unchecked : Usuario.p_malm == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_ord.CheckState = Usuario.p_ord == -1 ? CheckState.Unchecked : Usuario.p_ord == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_pped.CheckState = Usuario.p_pped == -1 ? CheckState.Unchecked : Usuario.p_pped == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_cxc.CheckState = Usuario.p_cxc == -1 ? CheckState.Unchecked : Usuario.p_cxc == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_RegRep.CheckState = Usuario.p_regrep == -1 ? CheckState.Unchecked : Usuario.p_regrep == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_EnvRep.CheckState = Usuario.p_envrep == -1 ? CheckState.Unchecked : Usuario.p_envrep == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_Rep.CheckState = Usuario.p_rep == -1 ? CheckState.Unchecked : Usuario.p_rep == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        ChkP_lcre.CheckState = Usuario.p_lcre == -1 ? CheckState.Unchecked : Usuario.p_lcre == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_com.CheckState = Usuario.p_com == -1 ? CheckState.Unchecked : Usuario.p_com == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_metas.CheckState = Usuario.p_metas == -1 ? CheckState.Unchecked : Usuario.p_metas == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_ubi.CheckState = Usuario.p_ubi == -1 ? CheckState.Unchecked : Usuario.p_ubi == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_consu.CheckState = Usuario.p_cons == -1 ? CheckState.Unchecked : Usuario.p_cons == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_camp_L.CheckState = Usuario.p_camp_L == -1 ? CheckState.Unchecked : Usuario.p_camp_L == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_acti.CheckState = Usuario.p_acti == -1 ? CheckState.Unchecked : Usuario.p_acti == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_consum.CheckState = Usuario.p_consu == -1 ? CheckState.Unchecked : Usuario.p_consu == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkP_caso.CheckState = Usuario.p_caso == -1 ? CheckState.Unchecked : Usuario.p_caso == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chkJcontrol.CheckState = Usuario.p_control == -1 ? CheckState.Unchecked : Usuario.p_control == 0 ? CheckState.Indeterminate : CheckState.Checked;
                        chksupervi.CheckState = Usuario.p_supervi == -1 ? CheckState.Unchecked : Usuario.p_supervi == 0 ? CheckState.Indeterminate : CheckState.Checked;

                        //var Imagen = ImagenBD.BytesToImage(Usuario.ilustracion);

                        Validador = Usuario.validador;
                        CargarDetalle();
                    }
                    else
                    {
                        if (Usuario.validador != null)
                            LimpiarControles();
                        else
                            Validador = null;
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

        private void CargarDetalle()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    LempresaSA.Clear();
                    LempresaCA.Clear();
                        
                    if (Nuevo == true)
                    {
                        foreach (var item in context.pSeleccionarEmpresasSA(null).ToList())
                        {
                            LempresaSA.Add(new EmpresaCSA { Co_empresa = item.co_empresa, Emp_des = item.des_emp });
                        }
                    }
                    else
                    {
                        foreach (var item in context.pSeleccionarEmpresasSA(txtCo_usuario.Text.Trim()).ToList())
                        {
                            LempresaSA.Add(new EmpresaCSA { Co_empresa = item.co_empresa, Emp_des = item.des_emp });
                        }
                        foreach (var item in context.pSeleccionarEmpresasCA(txtCo_usuario.Text.Trim()).ToList())
                        {
                            LempresaCA.Add(new EmpresaCSA { Co_empresa = item.co_empresa, Emp_des = item.des_emp });
                        }
                    }
                }

                lstEmpresaSA.DataSource = LempresaSA.ToList();
                lstEmpresaSA.ValueMember = "co_empresa";
                lstEmpresaSA.DisplayMember = "emp_des";

                lstEmpresaCA.DataSource = LempresaCA.ToList();
                lstEmpresaCA.ValueMember = "co_empresa";
                lstEmpresaCA.DisplayMember = "emp_des";


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

        private void LimpiarControles()
        {
            txtCo_usuario.Text = "";
            txtNombre.Text = "";
            txtRdv.Text = "";
            txtClave.Text = "";
            txtClaveR.Text = "";
            cboNivel.SelectedIndex = 0;
            avatar = imageList1.Images[0];

            chkP_emp.CheckState = CheckState.Unchecked;
            chkP_nav.CheckState = CheckState.Unchecked;
            chkP_usu.CheckState = CheckState.Unchecked;
            chkP_con.CheckState = CheckState.Unchecked;
            chkP_mco.CheckState = CheckState.Unchecked;
            chkP_cxc.CheckState = CheckState.Unchecked;
            chkP_pst.CheckState = CheckState.Unchecked;
            chkP_art.CheckState = CheckState.Unchecked;
            chkP_ord.CheckState = CheckState.Unchecked;
            ChkP_clave.CheckState = CheckState.Unchecked;
            chkP_malm.CheckState = CheckState.Unchecked;
            chkP_pped.CheckState = CheckState.Unchecked;
            ChkP_lcre.CheckState = CheckState.Unchecked;
            chkP_com.CheckState = CheckState.Unchecked;
            chkJcontrol.CheckState = CheckState.Unchecked;
            chksupervi.CheckState = CheckState.Unchecked;
            P_emp = -1;
            P_nav = -1;
            P_usu = -1;
            P_con = -1;
            P_mco = -1;
            P_pst = -1;
            P_art = -1;
            P_clave = -1;
            P_malm = -1;
            P_ord = -1;
            P_pped = -1;
            P_cxc = -1;
            P_lcre = -1;
            P_com = -1;
            P_ubi = -1;
            P_cons = -1;
            P_camp_L = -1;
            P_acti = -1;
            P_consum = -1;
            P_caso = -1;
            P_control = -1;
            P_supervi = -1;
            






        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            Navegar(0);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Navegar(1);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Navegar(2);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            Navegar(3);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            Nuevo = true;
            txtCo_usuario.Enabled = true;
            Validador = null;
            CargarDetalle();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (superValidator1.Validate() == true)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        var i = 0;
                        bool Encontrado = false;
                        while (i <= lstAvatar.Items.Count && Encontrado==false )
                        {
                            if (lstAvatar.Items[i].Selected == true)
                            {
                                avatar = imageList1.Images[i];
                                Encontrado = true;
                            }
                            i++;
                        }
                        if (Encontrado == false)
                            MessageBox.Show("Debe seleccionar un imagen de Usuario!", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        else
                        {
                            if (Nuevo == true)
                            {
                                context.pInsertarUsuario(txtCo_usuario.Text.Trim(), txtNombre.Text.Trim(), cboNivel.SelectedIndex,
                                                        MC.GetBytes(txtClaveR.Text.Trim()), txtRdv.Text.Trim(), ImagenBD.ImagenToByte(avatar),
                                                        P_nav, P_emp, P_con, P_mco, P_usu, P_pst, P_art, P_clave, P_malm, P_ord, P_pped, P_cxc, 
                                                        P_regrep, P_envrep, P_rep,P_lcre, P_com, P_metas,P_ubi,P_cons,P_camp_L,P_acti, P_cons,P_caso,cbo_profit.SelectedValue.ToString (),P_control,P_supervi);
                            }
                            else
                            {
                                context.pActualizarUsuarios(txtCo_usuario.Text.Trim(), txtNombre.Text.Trim(), cboNivel.SelectedIndex,
                                                        txtRdv.Text.Trim(), MC.GetBytes(txtClaveR.Text.Trim()), ImagenBD.ImagenToByte(avatar), Validador,
                                                        P_nav, P_emp, P_con, P_mco, P_usu, P_pst, P_art, P_clave, P_malm, P_ord, P_pped, P_cxc,
                                                        P_regrep, P_envrep, P_rep, P_lcre, P_com, P_metas, P_ubi, P_cons, P_camp_L, P_acti, P_cons, P_caso,cbo_profit.SelectedValue.ToString (),P_control,P_supervi);
                            }
                            context.pEliminarUsu_Emp(txtCo_usuario.Text.Trim());
                            foreach (var item in LempresaCA)
                            {
                                context.pInsertarUsu_Emp(txtCo_usuario.Text.Trim(), item.Co_empresa);
                            }
                        } 
                    }
                    Navegar(5);
                    FrmPrincipal Fp = new FrmPrincipal();
                    Fp.HabilitarBotones(txtCo_usuario.Text.Trim());

                    MessageBox.Show(this, "Se ha guardado la informacion satisfactoriamente.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (MessageBox.Show("Desea eliminar el usuario seleccionado?", "Profit Expansion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        context.pEliminarUsuario(Validador);
                        Navegar(3);
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

        private void btnA_Click(object sender, EventArgs e)
        {
            if (lstEmpresaSA.Items.Count > 0)
            {
                LempresaCA.Add(new EmpresaCSA { Co_empresa = lstEmpresaSA.SelectedValue.ToString(), Emp_des = lstEmpresaSA.Text.Trim() });
                LempresaSA.RemoveAt(lstEmpresaSA.SelectedIndex);

                lstEmpresaSA.DataSource = LempresaSA.ToList();
                lstEmpresaSA.ValueMember = "co_empresa";
                lstEmpresaSA.DisplayMember = "emp_des";

                lstEmpresaCA.DataSource = LempresaCA.ToList();
                lstEmpresaCA.ValueMember = "co_empresa";
                lstEmpresaCA.DisplayMember = "emp_des";
            }
        }

        private void btnAT_Click(object sender, EventArgs e)
        {
            if (lstEmpresaSA.Items.Count > 0)
            {
                foreach (var item in LempresaSA)
                {
                    LempresaCA.Add(new EmpresaCSA { Co_empresa = item.Co_empresa, Emp_des = item.Emp_des });
                }
                LempresaSA.Clear();

                lstEmpresaSA.DataSource = LempresaSA.ToList();
                lstEmpresaSA.ValueMember = "co_empresa";
                lstEmpresaSA.DisplayMember = "emp_des";

                lstEmpresaCA.DataSource = LempresaCA.ToList();
                lstEmpresaCA.ValueMember = "co_empresa";
                lstEmpresaCA.DisplayMember = "emp_des";
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            if (lstEmpresaCA.Items.Count > 0)
            {
                LempresaSA.Add(new EmpresaCSA { Co_empresa = lstEmpresaCA.SelectedValue.ToString(), Emp_des = lstEmpresaCA.Text.Trim() });
                LempresaCA.RemoveAt(lstEmpresaCA.SelectedIndex);

                lstEmpresaSA.DataSource = LempresaSA.ToList();
                lstEmpresaSA.ValueMember = "co_empresa";
                lstEmpresaSA.DisplayMember = "emp_des";

                lstEmpresaCA.DataSource = LempresaCA.ToList();
                lstEmpresaCA.ValueMember = "co_empresa";
                lstEmpresaCA.DisplayMember = "emp_des";
            }
        }

        private void btnQT_Click(object sender, EventArgs e)
        {
            if (lstEmpresaCA.Items.Count > 0)
            {
                foreach (var item in LempresaCA)
                {
                    LempresaSA.Add(new EmpresaCSA { Co_empresa = item.Co_empresa, Emp_des = item.Emp_des });
                }
                LempresaCA.Clear();

                lstEmpresaSA.DataSource = LempresaSA.ToList();
                lstEmpresaSA.ValueMember = "co_empresa";
                lstEmpresaSA.DisplayMember = "emp_des";

                lstEmpresaCA.DataSource = LempresaCA.ToList();
                lstEmpresaCA.ValueMember = "co_empresa";
                lstEmpresaCA.DisplayMember = "emp_des";
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            Navegar(4);
        }

        private void chkP_emp_CheckedChanged(object sender, EventArgs e)
        {
            P_emp = chkP_emp.CheckState == CheckState.Unchecked ? -1 : chkP_emp.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_nav_CheckedChanged(object sender, EventArgs e)
        {
            P_nav = chkP_nav.CheckState == CheckState.Unchecked ? -1 : chkP_nav.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_usu_CheckedChanged(object sender, EventArgs e)
        {
            P_usu = chkP_usu.CheckState == CheckState.Unchecked ? -1 : chkP_usu.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_con_CheckedChanged(object sender, EventArgs e)
        {
            P_con = chkP_con.CheckState == CheckState.Unchecked ? -1 : chkP_con.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_mco_CheckedChanged(object sender, EventArgs e)
        {
            P_mco = chkP_mco.CheckState == CheckState.Unchecked ? -1 : chkP_mco.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_pst_CheckedChanged(object sender, EventArgs e)
        {
            P_pst = chkP_pst.CheckState == CheckState.Unchecked ? -1 : chkP_pst.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_art_CheckedChanged(object sender, EventArgs e)
        {
            P_art = chkP_art.CheckState == CheckState.Unchecked ? -1 : chkP_art.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void ChkP_clave_CheckedChanged(object sender, EventArgs e)
        {
            P_clave = ChkP_clave.CheckState == CheckState.Unchecked ? -1 : ChkP_clave.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_malm_CheckedChanged(object sender, EventArgs e)
        {
            P_malm = chkP_malm.CheckState == CheckState.Unchecked ? -1 : chkP_malm.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_ord_CheckedChanged(object sender, EventArgs e)
        {
            P_ord = chkP_ord.CheckState == CheckState.Unchecked ? -1 : chkP_ord.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_pped_CheckedChanged(object sender, EventArgs e)
        {
            P_pped = chkP_pped.CheckState == CheckState.Unchecked ? -1 : chkP_pped.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_cxc_CheckedChanged(object sender, EventArgs e)
        {
            P_cxc = chkP_cxc.CheckState == CheckState.Unchecked ? -1 : chkP_cxc.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_RegRep_CheckedChanged(object sender, EventArgs e)
        {
            P_regrep = chkP_RegRep.CheckState == CheckState.Unchecked ? -1 : chkP_RegRep.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_EnvRep_CheckedChanged(object sender, EventArgs e)
        {
            P_envrep = chkP_EnvRep.CheckState == CheckState.Unchecked ? -1 : chkP_EnvRep.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_Rep_CheckedChanged(object sender, EventArgs e)
        {
            P_rep = chkP_Rep.CheckState == CheckState.Unchecked ? -1 : chkP_Rep.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void ChkP_lcre_CheckedChanged(object sender, EventArgs e)
        {
            P_lcre = ChkP_lcre.CheckState == CheckState.Unchecked ? -1 : ChkP_lcre.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void btnAccesoProgramas_Click(object sender, EventArgs e)
        {
            FrmUp Fup = new FrmUp("Usuarios", txtCo_usuario.Text);
            Fup.Show();
        }

        private void chkP_com_CheckedChanged(object sender, EventArgs e)
        {
            P_com = chkP_com.CheckState == CheckState.Unchecked ? -1 : chkP_com.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_metas_CheckedChanged(object sender, EventArgs e)
        {
            P_metas = chkP_metas.CheckState == CheckState.Unchecked ? -1 : chkP_metas.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_ubi_CheckedChanged(object sender, EventArgs e)
        {
            P_ubi = chkP_ubi.CheckState == CheckState.Unchecked ? -1 : chkP_ubi.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_consu_CheckedChanged(object sender, EventArgs e)
        {
            P_cons = chkP_consu.CheckState == CheckState.Unchecked ? -1 : chkP_consu.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_camp_L_CheckedChanged(object sender, EventArgs e)
        {
            P_camp_L = chkP_camp_L.CheckState == CheckState.Unchecked ? -1 : chkP_camp_L.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_equi_CheckedChanged(object sender, EventArgs e)
        {
            P_acti = chkP_acti.CheckState == CheckState.Unchecked ? -1 : chkP_acti.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_consum_CheckedChanged(object sender, EventArgs e)
        {
            P_consum = chkP_consum.CheckState == CheckState.Unchecked ? -1 : chkP_consum.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chkP_caso_CheckedChanged(object sender, EventArgs e)
        {
            P_caso = chkP_caso.CheckState == CheckState.Unchecked ? -1 : chkP_caso.CheckState == CheckState.Indeterminate ? 0 : 1;
        }
        private void chkJcontrol_CheckedChanged(object sender, EventArgs e)
        {
            P_control = chkJcontrol.CheckState == CheckState.Unchecked ? -1 : chkJcontrol.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void chksupervi_CheckedChanged(object sender, EventArgs e)
        {
            P_supervi = chksupervi.CheckState == CheckState.Unchecked ? -1 : chksupervi.CheckState == CheckState.Indeterminate ? 0 : 1;
        }

        private void btn_add_supervisoados_Click(object sender, EventArgs e)
        {
            FrmAddSupervisados ip = new FrmAddSupervisados(txtCo_usuario.Text);
            ip.Show();
        }

        private void btnJP_Click(object sender, EventArgs e)
        {
            FrmJPCheck jesus = new FrmJPCheck();
            jesus.Show();
        }

        private void cbo_profit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtNombre.Text = Convert.ToString(cbo_profit.Text);
                //    if (cbo_profit.SelectedIndex >= 0)
                //        using (var context = new Profit_RGEntities())
                //        {
                //            cbo_profit.DataSource = context.pUsuariosProfit().ToList();
                //            cbo_profit.ValueMember = "employee_i";
                //            cbo_profit.DisplayMember = "last_name";
                //            txtNombre.Text = cbo_profit.SelectedValue.ToString();
                //        }
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
