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
    public partial class FrmMantActivo : DevComponents.DotNetBar.Metro.MetroForm
    {
        string lActivo;
        int i;
        pSeleccionarGIT_Mantenimiento_Result mtto12 = new pSeleccionarGIT_Mantenimiento_Result();
        List<pSeleccionarGIT_Mantenimiento_Result> mtto13 = new List<pSeleccionarGIT_Mantenimiento_Result>();
        List<RenglonesDG2> mtto55 = new List<RenglonesDG2>();
        public FrmMantActivo()
        {
            InitializeComponent();
        }
        public FrmMantActivo(string gActivo)
        {
            lActivo = gActivo;
            InitializeComponent();
        }
        private void FrmMantActivo_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                        grdDatos.DataSource = "";
                        grdDatos.AutoGenerateColumns = false;
                    CargarCombo();
                        
                        
                    if (context.pSeleccionarGIT_Mantenimiento(lActivo.Trim()).Count() > 0)
                    {

                        CargarMantenimiento();
                    }
                    else if (context.pSeleccionarGIT_Asign_Equipo(lActivo.Trim()).Count() <= 0)
                    {
                        CargarCombo();
                        //    renglon1.Add("1", "000002", "H1",lActivo.Trim (),new DateTime (DateTime.Now.Ticks), new DateTime(DateTime.Now.Ticks),"C001");
                        grdDatos.DataSource = "";
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
        
        void CargarCombo()
        {
            try
            {
                using (var context = new Profit_RGEntities())
                {
                    IT_personal.DataSource = context.GIT_Consultor.ToList();
                    IT_personal.DisplayMember = "nombre";
                    IT_personal.ValueMember = "co_consultor";
                    
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
        void CargarMantenimiento()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var H = context.pSeleccionarGIT_Mantenimiento(lActivo.Trim()).ToList();
                    mtto55.Clear();

                    foreach (var item in H)
                    {
                        mtto55.Add(new RenglonesDG2
                        {
                            codigoM = item.id_mtto,
                            idactivo = item.id_activo,
                            fec_emis = item.fecha,
                            observacion = item.observacion,
                            valor = item.valor.ToString(),
                            asesor = item.asesor_ext,
                            consultor = item.co_consultor,
                            problema = item.problema,
                            solucion = item.solucion,
                            Rowguid = item.Rowguid.ToString ().ToUpper (),
                        });
                    }
                    grdDatos.DataSource = "";
                    grdDatos.DataSource = mtto55;
                    grdDatos.AutoGenerateColumns = false;
                    grdDatos.Refresh();
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
       //public Profit_RGEntities buscar_mtto()
       // {
       //     try
       //     {
       //         using (var context = new Profit_RGEntities())
       //         {
       //             var a = from n in context.GIT_Mantenimiento where n.id_mtto == context.pSeleccionarGIT_IDmtto().Count() select n.id_mtto;
       //         }
       //         return buscar_mtto();
       //     }
       //     catch (Exception)
       //     {

       //         throw;
       //     }
           
       // }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    Boolean buscar99 = false;
                    foreach (var item in mtto55)
                    {
                        buscar99 = context.pSeleccionarGIT_Mantenimiento(item.idactivo.Trim ()).Count(u => u.Rowguid.ToString().ToUpper () == item.Rowguid.ToUpper ()) > 0;
                        //   buscar99 = context.GIT_Mantenimiento.Count(i => i.id_mtto == item.codigoM) > 0;
                        //  var a = from n in context.GIT_Mantenimiento where n.id_mtto == item.codigoM select n.id_mtto;
                     
                        
                            if (buscar99 == false ) //&& context.pSeleccionarGIT_Mantenimiento(lActivo).Select (x => x.Rowguid).Count() <= 0)
                            {
                                context.pGIT_MantenimientoInsertar(item.idactivo, item.fec_emis, item.observacion, Convert.ToDecimal(item.valor), item.asesor, item.consultor,
                                item.problema, item.solucion);
                            }
                            else
                            {
                                context.pGIT_MantenimientoActualizar(item.idactivo, item.fec_emis, item.observacion, Convert.ToDecimal(item.valor), item.asesor, item.consultor,
                                item.problema, item.solucion, Guid.Parse(item.Rowguid));
                            }
                        
                    }
                  //  CargarMantenimiento();
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
                    grdDatos.DataSource = "";

                    mtto55.Add(new RenglonesDG2
                    {
                        codigoM = 0,
                        idactivo = lActivo.Trim(),
                        fec_emis = new DateTime(DateTime.Now.Ticks),
                        observacion = "",
                        valor = "" ,
                        asesor = "",
                        consultor = "",
                        problema = "",
                        solucion = ""
                    });
                    grdDatos.DataSource = mtto55;
                    grdDatos.AutoGenerateColumns = false;
                    grdDatos.Refresh();
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
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtto55.Count > 0)
                {
                    if (MessageBox.Show(this, "Desea eliminar este renglón?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        foreach (var item in mtto55)
                        {
                            var i = grdDatos.CurrentRow.Cells[9].Value;
                            using (var context = new Profit_RGEntities())
                            {
                                
                                mtto55.RemoveAt(grdDatos.CurrentCell.RowIndex);
                                context.pGIT_MantenimientoEliminar(Guid.Parse (i.ToString ()));
                                grdDatos.DataSource = "";
                                grdDatos.DataSource = mtto55;
                                grdDatos.CurrentCell = grdDatos[0, mtto55.Count - 1];
                                
                            }
                            
                        }
                        CargarMantenimiento();
                    }
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(this, "El renglon ha sido eliminado satisfactoriamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}