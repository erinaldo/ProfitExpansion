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
                    var ClaveBD = MC.GetString(context.pSeleccionarUsuario(txtUsuario.Text.Trim()).First().clave);
                    var ClaveIn = txtClave.Text.Trim();
                    if (ClaveIn != ClaveBD)
                    {
                        MessageBox.Show("Clave o nombre de Usuario invalidos", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        this.Hide();
                        FrmPrincipal Fp = new FrmPrincipal(txtUsuario.Text.Trim());
                        Fp.Show();
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
                MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
