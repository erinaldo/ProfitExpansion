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
    public partial class FrmUp : DevComponents.DotNetBar.Metro.MetroForm
    {

        String Porigen = null;
        String Cod = null;
        public FrmUp()
        {
            InitializeComponent();
        }

        public FrmUp(string PantallaOrigen,string Codigo)
        {
            Porigen = PantallaOrigen;
            Cod = Codigo;
            InitializeComponent();
        }

        private void FrmUp_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
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

        private void CargarDatos()
        {
            switch (Porigen.Trim())
            {
                case "Usuarios":
                    lbl1.Text = "Programas:";
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        cbo1.DataSource = context.pSeleccionarProgramasSA(Cod).ToList();
                        cbo1.DisplayMember = "Descrip";
                        cbo1.ValueMember = "id_evento";
                        grdDatos.DataSource = "";
                        grdDatos.AutoGenerateColumns = false;
                        grdDatos.DataSource = context.pSeleccionarProgramasCA(Cod).ToList();
                        //grdDatos.Columns.Add("Codigo", "Evento");
                        grdDatos.Columns[0].DataPropertyName = "id_evento";
                        grdDatos.Columns[0].HeaderText = "Evento";
                        //grdDatos.Columns.Add("Descrip", "Descripción");
                        grdDatos.Columns[1].DataPropertyName = "descrip";
                        grdDatos.Columns[1].HeaderText = "Descripción";
                        grdDatos.Columns[1].Width = 320;
                    }
                    break;
                case "Programas":
                    lbl1.Text = "Usuarios:";
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        cbo1.DataSource = context.pSeleccionarUsuariosPrgSA(Convert.ToInt32(Cod)).ToList();
                        cbo1.DisplayMember = "Nombre";
                        cbo1.ValueMember = "co_usuario";
                        grdDatos.DataSource = "";
                        grdDatos.AutoGenerateColumns = false;
                        grdDatos.DataSource = context.pSeleccionarUsuariosPrgCA(Convert.ToInt32(Cod)).ToList();
                        //grdDatos.Columns.Add("Codigo", "Codigo");
                        grdDatos.Columns[0].DataPropertyName = "co_usuario";
                        grdDatos.Columns[0].HeaderText = "Codigo";
                        //grdDatos.Columns.Add("Descrip", "Nombre");
                        grdDatos.Columns[1].DataPropertyName = "nombre";
                        grdDatos.Columns[1].HeaderText = "Nombre";
                        grdDatos.Columns[1].Width = 320;
                    }
                    break;
            }
            grdDatos.Refresh();
        }

        private void btnAgregarR_Click(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    switch (Porigen.Trim())
                    {
                        case "Usuarios":
                            context.pInsertarUsu_Prg(Cod, Convert.ToInt32(cbo1.SelectedValue.ToString()));
                            break;
                        case "Programas":
                            context.pInsertarUsu_Prg(cbo1.SelectedValue.ToString(),Convert.ToInt32(Cod));
                            break;
                    }
                }
                CargarDatos();
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

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Desea eliminar este registro?","Profit Expansion",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        switch (Porigen.Trim())
                        {
                            case "Usuarios":
                                context.pEliminarUsu_Prg(Cod.Trim(), Convert.ToInt32(grdDatos[0, grdDatos.CurrentCell.RowIndex].Value.ToString()));
                                break;
                            case "Programas":
                                context.pEliminarUsu_Prg(grdDatos[0,grdDatos.CurrentCell.RowIndex].Value.ToString(), Convert.ToInt32(Cod));
                                break;
                        }
                    }
                    CargarDatos();
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