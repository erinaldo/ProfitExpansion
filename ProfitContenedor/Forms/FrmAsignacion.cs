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

    public partial class FrmAsignacion : DevComponents.DotNetBar.Metro.MetroForm
    {
        int i;
        string lActivo;
     //   int asig12;
      //  string asig33;
        pSeleccionarGIT_Asign_Equipo_Result asigna1 = new pSeleccionarGIT_Asign_Equipo_Result();
        List<pSeleccionarGIT_Asign_Equipo_Result> asinga = new List<pSeleccionarGIT_Asign_Equipo_Result>();
        List <RenglonesDG> renglon1 = new List<RenglonesDG>();
        public FrmAsignacion()
        {
            InitializeComponent();
        }

        public FrmAsignacion(string pActivo)
        {
            lActivo = pActivo;
           // asig33 = id_asigna43;
            InitializeComponent();
        }

        public void FrmAsignacion_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                        grddatos1.DataSource = "";
                        grddatos1.AutoGenerateColumns = false;
                        CargarCombos();
                        if (context.pSeleccionarGIT_Asign_Equipo(lActivo.Trim ()).Count ()  > 0)
                        {
                            
                            CargarAsignaciones();
                        }
                        else if (context.pSeleccionarGIT_Asign_Equipo(lActivo.Trim()).Count() <= 0)
                        {
                            CargarCombos();
                            //    renglon1.Add("1", "000002", "H1",lActivo.Trim (),new DateTime (DateTime.Now.Ticks), new DateTime(DateTime.Now.Ticks),"C001");
                            grddatos1.DataSource = "";
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
        void CargarCombos()
        {
            try
            {
                using (var context = new Profit_RGEntities())
                {
                    Empresa.DataSource = context.GIT_Ubicaciones.ToList();
                    Empresa.DisplayMember = "descrip";
                    Empresa.ValueMember = "co_ubic";

                    consul.DataSource = context.GIT_Consultor.ToList();
                    consul.DisplayMember = "nombre";
                    consul.ValueMember = "co_consultor";
                    
                    Empleado.DataSource = context.pSeleccionarEmpleados().ToList();
                    Empleado.DisplayMember = "nombre_completo".Trim();
                    Empleado.ValueMember = "cod_emp";

                   
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
        void CargarAsignaciones()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var G = context.pGitSeleccionarAsignacion(lActivo.Trim()).ToList();
                    renglon1.Clear();

                    foreach (var item in G)
                    {
                        renglon1.Add(new RenglonesDG
                        {
                            codigo = item.id_asign,
                            empleado = item.cod_emp,
                            empresa = item.co_empresa,
                            activo = item.id_activo.Trim(),
                            desde = item.desde,
                            hasta = item.hasta.Value,
                            consultor = item.co_consultor,
                            Rowguid = item.Rowguid.ToString ().ToUpper(),
                        });
                    }

                    grddatos1.DataSource = "";
                    grddatos1.DataSource = renglon1;
                    grddatos1.AutoGenerateColumns = false;
                    grddatos1.Refresh();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Profit_RGEntities())
                {
                   Boolean buscar98 = false ;
            //  Boolean buscar90 = false; 

                    foreach (var item in renglon1)
                    {
                        //  buscar90 = context.pSeleccionarGIT_Asign_Equipo(item.activo.Trim ()).Count(u => u.Rowguid.ToString () == item.Rowguid.ToUpper ()) > 0;

                        var DG0 = grddatos1.Rows[grddatos1.Rows.Count - 1].Cells[0].Value;
                        var DG1 = grddatos1.Rows[grddatos1.Rows.Count - 1].Cells[1].Value;
                        var DG2 = grddatos1.Rows[grddatos1.Rows.Count - 1].Cells[2].Value;
                        var DG3 = grddatos1.Rows[grddatos1.Rows.Count - 1].Cells[3].Value;
                        var DG4 = grddatos1.Rows[grddatos1.Rows.Count - 1].Cells[4].Value;
                        var DG5 = grddatos1.Rows[grddatos1.Rows.Count - 1].Cells[5].Value;
                        var DG6 = grddatos1.Rows[grddatos1.Rows.Count - 1].Cells[6].Value;
                        var DG7 = grddatos1.Rows[grddatos1.Rows.Count - 1].Cells[7].Value;

                        buscar98 = context.GIT_Asign_Equipo.Count(u => u.id_asign == item.codigo) > 0;
                        
                        if (buscar98 == true )
                        {
                            var h = context.pSeleccionarEmpleados().Where(x => x.cod_emp == item.empleado).Select(x => x.nombre_completo).FirstOrDefault();
                            context.pGIT_Asign_EquipoActualizar(item.empleado, item.empresa,
                            item.activo, item.desde, item.hasta, item.consultor,Guid.Parse(item.Rowguid), h.ToString ());
  
                        }
                        else
                        {
                            var h = context.pSeleccionarEmpleados().Where(x => x.cod_emp == item.empleado).Select(x => x.nombre_completo).FirstOrDefault();
                            context.pGIT_Asign_EquipoInsertar(DG1.ToString(), DG2.ToString(), DG3.ToString(), Convert.ToDateTime(DG4),
                              Convert.ToDateTime(DG5), DG6.ToString(), DG6.ToString());
                           
                          //context.pGIT_Asign_EquipoInsertar(
                          //item.empleado, item.empresa,
                          //item.activo, item.desde, item.hasta, item.consultor,h.ToString ());
                          // context.pActualizarGIT_id_asign(item.activo,item.codigo);
                        }
                   }
                   // CargarAsignaciones();
                }
                MessageBox.Show(this, "Se ha guardado la información satisfactoriamente.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnAgregarR_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    grddatos1.DataSource = "";
                    
                    renglon1.Add(new RenglonesDG
                    {
                        codigo = 0,
                        empleado = "",
                        empresa = "",
                        activo = lActivo.Trim(),
                        desde = new DateTime(DateTime.Now.Ticks),
                        hasta = new DateTime(DateTime.Now.Ticks),
                        consultor = ""
                    });
                    grddatos1.DataSource = renglon1;
                    grddatos1.AutoGenerateColumns = true;
                    grddatos1.Refresh();
                }
                
            }
            catch (Exception ex1)
            {
                MessageBox.Show(this, ex1.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
             try
            {
                if (renglon1.Count > 0)
                {
                    if (MessageBox.Show(this, "Desea eliminar este renglón?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        foreach (var item in renglon1)
                        {
                            var J = grddatos1.CurrentRow.Cells[7].Value;
                            using (var context = new Profit_RGEntities())
                            {
                                renglon1.RemoveAt(grddatos1.CurrentCell.RowIndex);
                                context.pGIT_Asign_EquipoEliminar(Guid.Parse(J.ToString()));
                                grddatos1.DataSource = "";
                                grddatos1.DataSource = renglon1;
                                grddatos1.CurrentCell = grddatos1[0, renglon1.Count - 1];

                            }
                            CargarAsignaciones();
                        }
                    }
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(this, "Su registro ha sido eliminado satisfactoriamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grddatos1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //grddatos1.DataSource = "";
                //grddatos1.Refresh();
                //grddatos1.DataSource = renglon1;
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
