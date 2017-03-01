using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitContenedor
{
    public partial class FrmBuscar : DevComponents.DotNetBar.Metro.MetroForm
    {
        TextBox Tc = null;
        TextBox Td = null;
        string Tb = null;
        string Te = null;

        public FrmBuscar(TextBox Tcodigo, TextBox Tdescrip,string Tabla,string Empresa = "")
        {
            Tc = Tcodigo;
            Td = Tdescrip;
            Tb = Tabla;
            Te = Empresa;
            InitializeComponent();
            this.Width = 495;
            this.Height = 352;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdDatos.RowCount > 0)
                {
                    Tc.Text = grdDatos[0, grdDatos.CurrentCell.RowIndex].Value.ToString().Trim();
                    Td.Text = grdDatos[1, grdDatos.CurrentCell.RowIndex].Value.ToString().Trim();
                }
                btnCancelar_Click(sender, e);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmEmpresas_Load(object sender, EventArgs e)
        {
            try
            {
                grdDatos.AutoGenerateColumns = false;
                switch (Tb)
                {
                    case "Empresa":
                        List<Empresa> Dt = new List<Empresa>();
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            Dt = context.Empresas.ToList();
                        }
                        grdDatos.DataSource = (from c in Dt
                                               select new TablaB
                                               {
                                                   Codigo = c.co_empresa.Trim(),
                                                   Descrip = c.des_emp.Trim()
                                               }
                                               ).OrderBy(c => c.Codigo).ToList();
                        break;
                    case "Naviera":
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            grdDatos.DataSource = (from c in context.Navieras
                                                   select new TablaB
                                                   {
                                                       Codigo = c.co_naviera.Trim(),
                                                       Descrip = c.navi_des.Trim()
                                                   }
                                               ).OrderBy(c => c.Codigo).ToList();
                        }
                        break;
                    case "Shipper":
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            grdDatos.DataSource = (from c in context.pSeleccionarProv(Te.Trim())
                                                   select new TablaB
                                                   {
                                                       Codigo = c.co_prov.Trim(),
                                                       Descrip = c.prov_des.Trim()
                                                   }
                                               ).OrderBy(c => c.Codigo).ToList();
                        }
                        break;
                    case "Usuario":
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            grdDatos.DataSource = (from c in context.pSeleccionarUsuario(Te.Trim())
                                                   select new TablaB
                                                   {
                                                       Codigo = c.co_usuario.Trim(),
                                                       Descrip = c.nombre.Trim()
                                                   }
                                               ).OrderBy(c => c.Codigo).ToList();
                        }
                        break;
                    case "Pantalla_Stock":
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            grdDatos.DataSource = (from c in context.pSeleccionarPantalla_Stock(Te.Trim())
                                                   select new TablaB
                                                   {
                                                       Codigo = c.co_usuario.Trim(),
                                                       Descrip = c.Emp_Art.Trim()
                                                   }
                                               ).OrderBy(c => c.Codigo).ToList();
                        }
                        break;
                    case "Articulo":
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            grdDatos.DataSource = (from c in context.pSeleccionarArticulo(Te.Trim(),Tc.Text.Trim())
                                                   select new TablaB
                                                   {
                                                       Codigo = c.co_art.Trim(),
                                                       Descrip = c.art_des.Trim()
                                                   }
                                               ).OrderBy(c => c.Codigo).ToList();
                        }
                        break;
                    default:
                        break;
                }

            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DataException ex0)
            {
                MessageBox.Show(ex0.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (Tb)
                {
                    case "Empresa":
                        //ProfitDsTableAdapters.empresasTableAdapter emp = new ProfitDsTableAdapters.empresasTableAdapter();
                        //ProfitDs.empresasDataTable Dt = new ProfitDs.empresasDataTable();
                        //emp.Fill(Dt);
                        List<Empresa> Dt = new List<Empresa>();
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            Dt = context.Empresas.ToList();
                        }
                        if (OptCod.Checked == true)
                        {
                            grdDatos.DataSource = (from c in Dt
                                                   select new TablaB
                                                   {
                                                       Codigo = c.co_empresa.Trim(),
                                                       Descrip = c.des_emp.Trim()
                                                   }).Where(c => c.Codigo.Contains(txtBuscar.Text.Trim())).OrderBy(c => c.Codigo).ToList();
                        }
                        else
                        {
                            grdDatos.DataSource = (from c in Dt
                                                   select new TablaB
                                                   {
                                                       Codigo = c.co_empresa.Trim(),
                                                       Descrip = c.des_emp.Trim()
                                                   }).Where(c => c.Descrip.Contains(txtBuscar.Text.Trim())).OrderBy(c => c.Descrip).ToList();
                        }
                    break;
                    case "Naviera":
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            if (OptCod.Checked == true)
                            {
                                grdDatos.DataSource = (from c in context.Navieras
                                                       select new TablaB
                                                       {
                                                           Codigo = c.co_naviera.Trim(),
                                                           Descrip = c.navi_des.Trim()
                                                       }).Where(c => c.Codigo.Contains(txtBuscar.Text.Trim())).OrderBy(c => c.Codigo).ToList();
                            }
                            else
                            {
                                grdDatos.DataSource = (from c in context.Navieras
                                                       select new TablaB
                                                       {
                                                           Codigo = c.co_naviera.Trim(),
                                                           Descrip = c.navi_des.Trim()
                                                       }).Where(c => c.Descrip.Contains(txtBuscar.Text.Trim())).OrderBy(c => c.Descrip).ToList();
                            }
                        }
                    break;
                    case "Shipper":
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        if (OptCod.Checked == true)
                        {
                            grdDatos.DataSource = (from c in context.pSeleccionarProv(Te)
                                                   select new TablaB
                                                   {
                                                       Codigo = c.co_prov.Trim(),
                                                       Descrip = c.prov_des.Trim()
                                                   }).Where(c => c.Codigo.Contains(txtBuscar.Text.Trim())).OrderBy(c => c.Codigo).ToList();
                        }
                        else
                        {
                            grdDatos.DataSource = (from c in context.pSeleccionarProv(Te)
                                                   select new TablaB
                                                   {
                                                       Codigo = c.co_prov.Trim(),
                                                       Descrip = c.prov_des.Trim()
                                                   }).Where(c => c.Descrip.Contains(txtBuscar.Text.Trim())).OrderBy(c => c.Descrip).ToList();
                        }
                    }
                    break;
                    case "Usuario":
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        if (OptCod.Checked == true)
                        {
                            grdDatos.DataSource = (from c in context.pSeleccionarUsuario(Te.Trim())
                                                   select new TablaB
                                                   {
                                                       Codigo = c.co_usuario.Trim(),
                                                       Descrip = c.nombre.Trim()
                                                   }).Where(c => c.Codigo.Contains(txtBuscar.Text.Trim())).OrderBy(c => c.Codigo).ToList();
                        }
                        else
                        {
                            grdDatos.DataSource = (from c in context.pSeleccionarUsuario(Te.Trim())
                                                   select new TablaB
                                                   {
                                                       Codigo = c.co_usuario.Trim(),
                                                       Descrip = c.nombre.Trim()
                                                   }).Where(c => c.Descrip.Contains(txtBuscar.Text.Trim())).OrderBy(c => c.Descrip).ToList();
                        }
                    }
                    break;
                    case "Pantalla_Stock":
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        if (OptCod.Checked == true)
                        {
                            grdDatos.DataSource = (from c in context.pSeleccionarPantalla_Stock(Te.Trim())
                                                   select new TablaB
                                                   {
                                                       Codigo = c.co_usuario.Trim(),
                                                       Descrip = c.Emp_Art.Trim()
                                                   }).Where(c => c.Codigo.Contains(txtBuscar.Text.Trim())).OrderBy(c => c.Codigo).ToList();
                        }
                        else
                        {
                            grdDatos.DataSource = (from c in context.pSeleccionarPantalla_Stock(Te.Trim())
                                                    select new TablaB
                                                    {
                                                        Codigo = c.co_usuario.Trim(),
                                                        Descrip = c.Emp_Art.Trim()
                                                    }).Where(c => c.Descrip.Contains(txtBuscar.Text.Trim())).OrderBy(c => c.Descrip).ToList();
                        }
                    }
                    break;
                    case "Articulo":
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        if (OptCod.Checked == true)
                        {
                            grdDatos.DataSource = (from c in context.pSeleccionarArticulo(Te.Trim(), Tc.Text.Trim())
                                                   select new TablaB
                                                   {
                                                       Codigo = c.co_art.Trim(),
                                                       Descrip = c.art_des.Trim()
                                                   }).Where(c => c.Codigo.Contains(txtBuscar.Text.Trim())).OrderBy(c => c.Codigo).ToList();
                        }
                        else
                        {
                            grdDatos.DataSource = (from c in context.pSeleccionarArticulo(Te.Trim(), Tc.Text.Trim())
                                                   select new TablaB
                                                   {
                                                       Codigo = c.co_art.Trim(),
                                                       Descrip = c.art_des.Trim()
                                                   }).Where(c => c.Descrip.Contains(txtBuscar.Text.Trim())).OrderBy(c => c.Descrip).ToList();
                        }
                    }
                    break;
                    default:
                    break;
                }
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DataException ex0)
            {
                MessageBox.Show(ex0.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Tc.Text = grdDatos[0, e.RowIndex].Value.ToString().Trim();
                Td.Text = grdDatos[1, e.RowIndex].Value.ToString().Trim();
                
                btnCancelar_Click(sender, e);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
