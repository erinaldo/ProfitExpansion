using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitContenedor
{
    public partial class Frmlogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Frmlogin()
        { 
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var ClaveBD = MC.GetString(context.pSeleccionarUsuario(txtUsuario.Text.Trim()).FirstOrDefault().clave);
                    var ClaveIn = txtClave.Text.Trim();
                    var RDV = context.pSeleccionarUsuario(txtUsuario.Text.Trim()).First().co_rdv.Trim();
                    var Tipo = context.pSeleccionarUsuario(txtUsuario.Text.Trim()).First().tipo;
                    if (ClaveIn != ClaveBD)
                    {
                        MessageBox.Show("Clave o nombre de Usuario invalidos", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        if (Tipo == 5)
                        {
                            this.Hide();
                            FrmPCPE_S PCP = new FrmPCPE_S();
                            PCP.Show();
                           

                        }
                        else
                        {
                            this.Hide();
                            FrmEscritorio Fe = new FrmEscritorio(txtUsuario.Text.Trim());
                            Fe.Show();
                        }
                        

                        //FrmPrincipal Fp = new FrmPrincipal(txtUsuario.Text.Trim());
                        //Fp.Show();

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

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Trim().Length > 0)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        var U = context.pSeleccionarUsuario(txtUsuario.Text.Trim()).ToList();
                        if (U.Count == 0)
                        {
                            btnAceptar.Enabled = false;
                            MessageBox.Show("Usuario no existe.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            picAvatar.Image = ImagenBD.BytesToImage(U[0].ilustracion);
                            btnAceptar.Enabled = true;
                        }
                    }
                }
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAceptar_Click(sender, e);
        }

        private void picAvatar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //if (e.Button == MouseButtons.Right)
                //{
                //    long memory;
                //    //Process[] notepads;
                //    var notepads = Process.GetProcessById(7640, "SISTEMAS");
                //    memory = notepads.PeakPagedMemorySize64;

                //    MessageBox.Show(this, (memory/1024).ToString());
                //}

            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
    }
}
