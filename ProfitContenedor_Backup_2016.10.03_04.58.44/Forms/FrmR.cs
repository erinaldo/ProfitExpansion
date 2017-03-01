using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using System.Data.Entity.Core;
using System.Linq;

namespace ProfitContenedor
{
    public partial class FrmR : DevComponents.DotNetBar.Metro.MetroForm
    {

        List<Filtro_rep> F = new List<Filtro_rep>();
        Boolean Nuevo = false;
        string Usuario_Act;
        Int32 Tip;
        pSeleccionarReportes_Result reporte = new pSeleccionarReportes_Result();
        
        public FrmR()
        {
            InitializeComponent();
        }

        public FrmR(string Usuario_Actual, Int32 Tipo)
        {
            Usuario_Act = Usuario_Actual;
            Tip = Tipo;
            InitializeComponent();
        }

        private void FrmR_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var Sp = context.pSeleccionarSP_Reportes().ToList();
                    cboFuncion.ValueMember = "Name";
                    cboFuncion.DisplayMember = "Name";
                    cboFuncion.DataSource = Sp;
                }
                F.Clear();
                Navegar(0);

                btnNuevo.Enabled = Tip == 1;
                btnGuardar.Enabled = Tip == 1;
                btnEliminar.Enabled = Tip == 1;
                btnDeshacer.Enabled = Tip == 1;
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

        private void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var preg = context.pObtenerTablaStr(txtCod_rep.Text.Trim(), "cod_rep", p, "reportes").ToList();
                    if (preg.Count > 0)
                    {
                        reporte = context.pSeleccionarReportes(preg[0].Trim()).FirstOrDefault();
                        txtCod_rep.Text = reporte.cod_rep.Trim();
                        txtTitulo.Text = reporte.titulo.Trim();
                        txtArchivo.Text = reporte.Archivo.Trim();
                        txtRuta.Text = reporte.ruta.Trim();
                        cboFuncion.Text = reporte.funcion.Trim();


                        var Filtros = context.pSeleccionarFiltros(reporte.cod_rep.Trim()).ToList();
                        F.Clear();

                        foreach (var item in Filtros)
                        {
                            F.Add(new Filtro_rep { Nombre_par = item.nombre_par.Trim(), Tipo = item.tipo.Trim() });
                        }
                        grdDatos.DataSource = "";
                        grdDatos.DataSource = F;
                        grdDatos.AutoGenerateColumns = false;
                        grdDatos.Refresh();

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
            txtCod_rep.Text = "";
            txtArchivo.Text = "";
            txtRuta.Text = "";
            txtTitulo.Text = "";
            cboFuncion.SelectedIndex = -1;
            F.Clear();
            grdDatos.DataSource = "";
            grdDatos.DataSource = F;
            grdDatos.Refresh();

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

        private void btnBuscarRep_Click(object sender, EventArgs e)
        {
            //Stream myStream = null;
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Crystal Reports (*.rpt)|*.rpt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((openFileDialog.OpenFile()) != null)
                    {
                        txtArchivo.Text = Path.GetFileName(openFileDialog.FileName.Trim());
                        txtRuta.Text = Path.GetDirectoryName(openFileDialog.FileName.Trim());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnAFiltro_Click(object sender, EventArgs e)
        {
            F.Add(new Filtro_rep { Nombre_par = "", Tipo = "" });
            grdDatos.DataSource = "";
            grdDatos.DataSource = F;
            grdDatos.Refresh();
            grdDatos.CurrentCell = grdDatos[1, F.Count() - 1];
            grdDatos.Refresh();
        }

        private void btnEFiltro_Click(object sender, EventArgs e)
        {
            if (grdDatos.RowCount > 0)
            {
                if (MessageBox.Show("Desea realmente eliminar este registro?","Profit Expansion",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    F.RemoveAt(grdDatos.CurrentCell.RowIndex);
            }
            grdDatos.DataSource = "";
            grdDatos.DataSource = F;
            grdDatos.Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo = true;
            reporte = null;
            LimpiarControles();
            txtCod_rep.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Nuevo == true)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        context.pInsertarReportes(txtCod_rep.Text.Trim(), txtTitulo.Text.Trim(), txtRuta.Text.Trim(), txtArchivo.Text.Trim(), cboFuncion.Text.Trim());
                        foreach (var item in F)
                        {
                            context.pInsertarFiltros(txtCod_rep.Text.Trim(), item.Nombre_par.Trim(), item.Tipo.Trim());
                        }
                    }
                }
                else
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        context.pActualizarReportes(txtCod_rep.Text.Trim(), txtTitulo.Text.Trim(), txtRuta.Text.Trim(), txtArchivo.Text.Trim(), cboFuncion.Text.Trim(), reporte.rowguid);
                        context.pEliminarFiltros(reporte.cod_rep.Trim());
                        foreach (var item in F)
                        {
                            context.pInsertarFiltros(txtCod_rep.Text.Trim(), item.Nombre_par.Trim(), item.Tipo.Trim());
                        }
                    }
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea realmente eliminar este registro?","Profit Expansion",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        context.pEliminarReportes(reporte.rowguid);
                        Navegar(5);
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
            Navegar(5);
        }
    }
}