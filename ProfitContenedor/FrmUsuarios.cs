using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Navegar(3);
        }

        private void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    pSeleccionarUsuario_Result Usuario = new pSeleccionarUsuario_Result();
                    var pusu = context.pObtenerTablaStr(txtCo_usuario.Text.Trim(),"co_usuario",p,"Usuarios").ToList();
                    if (pusu.Count > 0)
                    {
                        Usuario = context.pSeleccionarUsuario(pusu[0].Trim()).First();
                        txtCo_usuario.Text = Usuario.co_usuario.Trim();
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
            txtClaveR.Text = "";
            cboNivel.SelectedIndex = 0;
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
                        Image avatar = null;
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
                                                         P_nav,P_emp,P_con,P_mco,P_usu,P_pst,P_art,P_clave,P_malm);
                            }
                            else
                            {
                                context.pActualizarUsuarios(txtCo_usuario.Text.Trim(), txtNombre.Text.Trim(), cboNivel.SelectedIndex,
                                                             txtRdv.Text.Trim(), MC.GetBytes(txtClaveR.Text.Trim()), ImagenBD.ImagenToByte(avatar), Validador,
                                                             P_nav, P_emp, P_con, P_mco, P_usu, P_pst, P_art,P_clave,P_malm);
                            }

                            context.pEliminarUsu_Emp(txtCo_usuario.Text.Trim());
                            foreach (var item in LempresaCA)
                            {
                                context.pInsertarUsu_Emp(txtCo_usuario.Text.Trim(), item.Co_empresa);
                            }
                        } 
                    }
                    Navegar(5);
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
    }
}
