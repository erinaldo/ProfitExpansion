using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Data.Entity.Core;
using System.Linq;

namespace ProfitContenedor
{
    public partial class FrmL_Credito : DevComponents.DotNetBar.Metro.MetroForm
    {
        string Usuario_Act;
        Int32 Tip;
        Boolean Nuevo = false;
        byte[] Validador;

        public FrmL_Credito()
        {
            InitializeComponent();
        }

        public FrmL_Credito(string Usuario_Actual, Int32 Tipo)
        {
            Usuario_Act = Usuario_Actual;
            Tip = Tipo;
            InitializeComponent();

            string url = @"https://s3.amazonaws.com/dolartoday/data.json";
            var conexion = new WebClient();
            string json = conexion.DownloadString(new Uri(url));

            JObject rss = JObject.Parse(json);
            decimal rssTitle = (decimal)rss["USD"]["transferencia"];

            txtUSD.Text = rssTitle.ToString();
        }

        void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    pSeleccionarLim_Credito_Result LCredito = new pSeleccionarLim_Credito_Result();
                    var plcre = context.pObtenerTablaInt(txtId_tab.Value, "id_tab", p, "Lim_Credito").ToList();
                    if (plcre.Count > 0)
                    {
                        LCredito = context.pSeleccionarLim_Credito().FirstOrDefault(l => l.id_tab == plcre[0].Value);
                        txtId_tab.Value = LCredito.id_tab;
                        txtAutorizaN1.Text = LCredito.autoriza1.Trim();
                        ObtenerNombre(1);
                        txtAutorizaN2.Text = LCredito.autoriza2.Trim();
                        ObtenerNombre(2);
                        txtGrupo.Text = LCredito.grupo.Trim();
                        txtTipo_cli.Text = LCredito.tip_cli.Trim();
                        ObtenerDescripcionTipo();
                        txtDesdeUSD.Value = Convert.ToDouble(LCredito.desde);
                        txtHastaUSD.Value = Convert.ToDouble(LCredito.hasta);
                        Validador = LCredito.validador;
                    }
                    else
                    {
                        if (LCredito.validador != null)
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

        private void LimpiarControles()
        {
            txtId_tab.Value = 0;
            txtAutorizaN1.Text = "";
            txtNombre1.Text = "";
            txtAutorizaN2.Text = "";
            txtNombre2.Text = "";
            txtGrupo.Text = "";
            txtTipo_cli.Text = "";
            txtDes_tipo.Text = "";
            txtDesdeUSD.Value = 0.00d;
            txtHastaUSD.Value = 0.00d;
            txtDesdeBS.Value = 0.00d;
            txtHastaBS.Value = 0.00d;
        }

        private void FrmL_Credito_Load(object sender, EventArgs e)
        {
            Navegar(3);
            if (Validador==null)
            {
                MessageBox.Show("No hay registros que mostrar, se pasará a modo agregar.","Profit Expansion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnNuevo_Click(sender, e);
            }
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            Nuevo = true;
            Validador = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            { 
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    
                    if (Nuevo == true)
                    {
                        context.pInsertarLim_Credito(txtGrupo.Text.Trim(), txtTipo_cli.Text.Trim(), txtAutorizaN1.Text.Trim(), txtAutorizaN2.Text.Trim(), Convert.ToDecimal(txtDesdeUSD.Value), Convert.ToDecimal(txtHastaUSD.Value)); 
                    }
                    else
                    {
                        context.pActualizarLim_Credito(txtGrupo.Text.Trim(), txtTipo_cli.Text.Trim(), txtAutorizaN1.Text.Trim(), txtAutorizaN2.Text.Trim(), Convert.ToDecimal(txtDesdeUSD.Value), Convert.ToDecimal(txtHastaUSD.Value),Validador); 
                    }  
                }
                Navegar(5);
                MessageBox.Show(this, "Se ha guardado la informacion satisfactoriamente.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
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
                if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Profit Expansion",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        context.pEliminarLim_Credito(txtId_tab.Value);
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

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            Navegar(4);
        }

        private void txtDesdeUSD_ValueChanged(object sender, EventArgs e)
        {
            txtDesdeBS.Value = txtDesdeUSD.Value * txtUSD.Value;
        }

        private void txtHastaUSD_ValueChanged(object sender, EventArgs e)
        {
            txtHastaBS.Value = txtHastaUSD.Value * txtUSD.Value;
        }

        private void ObtenerNombre(int N)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    switch (N)
                    {
                        case 1:
                            txtNombre1.Text = context.Usuarios.Where(u => u.co_usuario.Trim() == txtAutorizaN1.Text.Trim()).FirstOrDefault().nombre.Trim();
                            break;
                        case 2:
                            txtNombre2.Text = context.Usuarios.Where(u => u.co_usuario.Trim() == txtAutorizaN2.Text.Trim()).FirstOrDefault().nombre.Trim();
                            break;
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

        private void txtTipo_cli_Leave(object sender, EventArgs e)
        {
            ObtenerDescripcionTipo();
        }

        private void ObtenerDescripcionTipo()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    txtDes_tipo.Text = context.pSeleccionarTipo_Cli(txtGrupo.Text.Trim()).FirstOrDefault(t => t.tip_cli.Trim() == txtTipo_cli.Text.Trim()).des_tipo.Trim();
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

        private void txtAutorizaN1_Leave(object sender, EventArgs e)
        {
            ObtenerNombre(1);
        }

        private void txtAutorizaN2_Leave(object sender, EventArgs e)
        {
            ObtenerNombre(2);
        }
    }
}