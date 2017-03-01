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
using DevComponents.DotNetBar.Controls;
using System.Xml.Linq;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.Xml;

namespace ProfitContenedor
{
    public partial class FrmACom : DevComponents.DotNetBar.Metro.MetroForm
    {
        string Co_usu;
        Int32 Tip;
        string Emp;
        string Grupo;
        
        public List<Acom> Ac = new List<Acom>();

        decimal Total;

        public FrmACom()
        {
            InitializeComponent();
            //InicializarGrid();  
        }

        //private void InicializarGrid()
        //{
        //   try
        //    {
        //        DataGridViewMaskedTextBoxAdvColumn oc = grdDatos.Columns[0] as DataGridViewMaskedTextBoxAdvColumn;
        //        if (oc != null)
        //        {
                    
        //        }
        //    }
        //    catch (Exception ex1)
        //    {
        //        MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        public FrmACom(string Usuario_Actual, Int32 Tipo)
        {
            Co_usu = Usuario_Actual;
            Tip = Tipo;
            InitializeComponent();
        }

        private void FrmACom_Load(object sender, EventArgs e)
        {
            try
            {
                txtCo_empresa.Enabled = Tip == 1;
                txtCo_alma.Enabled = Tip == 1;
                btnGODC.Enabled = Tip == 1;
                btnCorreo.Enabled = Tip == 1;
                btnExportarXml.Enabled = Tip == 1;
                btnImportarXml.Enabled = Tip == 1;
                btnODCPreview.Enabled = Tip == 1;
                

                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var Pstock = context.pSeleccionarPantalla_Stock(Co_usu.Trim()).ToList();
                    if (Pstock.Count == 0)
                    {
                        MessageBox.Show("Debe configurar la pantalla para el usuario activo.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnCargar.Enabled = false;
                    }
                    else
                    {
                        txtCo_empresa.Text = Pstock[0].Emp_Art.Trim();
                        txtCo_alma.Text = Pstock[0].Almacen.Trim();
                        txtAlm_des.Text = context.pSeleccionarAlmacenEmpresa(Pstock[0].Almacen.Trim(), txtCo_empresa.Text).FirstOrDefault().alm_des.Trim();
                        Emp = Pstock[0].Emp_Art.Trim();
                        Grupo = context.Emp_asoc.FirstOrDefault(s => s.asociada.Trim() == txtCo_empresa.Text.Trim()).grupo.Trim();
                    }
                }

                txtDesde.Value = new DateTime(System.DateTime.Today.Year, 1, 1);
                txtHasta.Value = System.DateTime.Today;

                CargarTablas();
                
                grdDatos.DataSource = "";
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

        private void CargarTablas()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    
                    cboLinea.DataSource = context.pSeleccionarTablasArticulos(Grupo, "Lin_Art", null).AsParallel().ToList();
                    cboLinea.DisplayMember = "Descrip";
                    cboLinea.ValueMember = "Codigo";
                    cboLinea.SelectedIndex = -1;

                    cboSub_lin.DataSource = null;
                    cboSub_lin.DisplayMember = "";
                    cboSub_lin.ValueMember = "";
                    cboSub_lin.SelectedIndex = -1;

                    cboColores.DataSource = context.pSeleccionarTablasArticulos(Grupo, "Colores", null).AsParallel().ToList();
                    cboColores.DisplayMember = "Descrip";
                    cboColores.ValueMember = "Codigo";
                    cboColores.SelectedIndex = -1;

                    cboCat_art.DataSource = context.pSeleccionarTablasArticulos(Grupo, "Cat_Art", null).AsParallel().ToList();
                    cboCat_art.DisplayMember = "Descrip";
                    cboCat_art.ValueMember = "Codigo";
                    cboCat_art.SelectedIndex = -1;

                    cboProce.DataSource = context.pSeleccionarTablasArticulos(Grupo, "Proceden", null).AsParallel().ToList();
                    cboProce.DisplayMember = "Descrip";
                    cboProce.ValueMember = "Codigo";
                    cboProce.SelectedIndex = -1;
                    
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

        private void txtCo_empresa_Leave(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    Grupo = context.Emp_asoc.FirstOrDefault(s => s.asociada.Trim() == txtCo_empresa.Text.Trim()).grupo.Trim();
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
            
            CargarTablas();
        }

        private void lblLinea_Click(object sender, EventArgs e)
        {
            cboLinea.SelectedIndex = -1;
        }

        private void lblSub_linea_Click(object sender, EventArgs e)
        {
            cboSub_lin.SelectedIndex = -1;
        }

        private void lblColores_Click(object sender, EventArgs e)
        {
            cboColores.SelectedIndex = -1;
        }

        private void lblCat_art_Click(object sender, EventArgs e)
        {
            cboCat_art.SelectedIndex = -1;
        }

        private void lblProceden_Click(object sender, EventArgs e)
        {
            cboProce.SelectedIndex = -1;
        }

        private void cboLinea_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboLinea.Items.Count > 0 && cboLinea.SelectedIndex > -1)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        cboSub_lin.DataSource = context.pSeleccionarTablasArticulos(Grupo, "Sub_lin", cboLinea.SelectedValue.ToString()).AsParallel().ToList(); ;
                        cboSub_lin.DisplayMember = "Descrip";
                        cboSub_lin.ValueMember = "Codigo";
                        cboSub_lin.SelectedIndex = -1;
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboLinea.SelectedIndex = -1;
            cboSub_lin.SelectedIndex = -1;
            cboColores.SelectedIndex = -1;
            cboCat_art.SelectedIndex = -1;
            cboProce.SelectedIndex = -1;
            grdDatos.DataSource = "";
            grdDatos.Refresh();
            Ac.Clear();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Ac.Count>0)
                {
                    if (MessageBox.Show("Desea cargar datos?. Recuerde que los valores ingresados se perderán.", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        labelX2.Visible = true;
                        labelX2.ForeColor = Color.Blue;
                        CargarDatos();
                        labelX2.Visible = false;
                    }
                }
                else
                {
                    labelX2.Visible = true;
                    labelX2.ForeColor = Color.Blue;
                    CargarDatos();
                    labelX2.Visible = false;
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

        private void CargarDatos()
        {
            Total = 0;
            using (Profit_RGEntities context = new Profit_RGEntities())
            {
                
                
                string Co_lin = cboLinea.SelectedIndex == -1 ? null : cboLinea.SelectedValue.ToString().Trim();
                string Co_subl = cboSub_lin.SelectedIndex == -1 ? null : cboSub_lin.SelectedValue.ToString().Trim();
                string Co_col = cboColores.SelectedIndex == -1 ? null : cboColores.SelectedValue.ToString().Trim();
                string Co_cat = cboCat_art.SelectedIndex == -1 ? null : cboCat_art.SelectedValue.ToString().Trim();
                string Cod_proc = cboProce.SelectedIndex == -1 ? null : cboProce.SelectedValue.ToString().Trim();

                string Grupo = context.pObtenerGrupo(txtCo_empresa.Text.Trim()).AsParallel().FirstOrDefault().grupo.Trim();

                var Acompras = context.pAnalisisCompras(Grupo, txtCo_alma.Text.Trim(),txtDesde.Value, txtHasta.Value, Co_lin, Co_subl, Co_col, Co_cat, Cod_proc).AsParallel().ToList();
               
                Ac.Clear();
                foreach (var item in Acompras)
                {
                    Ac.Add(new Acom
                    {
                        A = "+",
                        co_art = item.co_art.Trim(),
                        art_des = item.art_des.Trim(),
                        comentario = item.comentario.Trim(),
                        lc_descrip2 = item.LC_DESCRIP2.Trim(),
                        referencia = item.referencia,
                        ene = item.Ene,
                        feb = item.Feb,
                        mar = item.Mar,
                        abr = item.Abr,
                        may = item.May,
                        jun = item.Jun,
                        jul = item.Jul,
                        ago = item.Ago,
                        sep = item.Sep,
                        oct = item.Oct,
                        nov = item.Nov,
                        dic = item.Dic,
                        stock_act = item.stock_act,
                        stock_lle = item.stock_lle,
                        uni_ventas = item.Uni_ventas,
                        costo = item.Costo,
                        sugerido = item.Sugerido,
                        comprar = item.Comprar,
                        total = item.Total,
                        comment = item.comment,
                        imagen = item.imagen
                    });
                }

                grdDatos.DataSource = "";
                grdDatos.AutoGenerateColumns = false;
                grdDatos.DataSource = Ac;
            }
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {   
                DataGridViewButtonXCell cell = grdDatos.CurrentCell as DataGridViewButtonXCell;
                if (cell != null)
                {
                    DataGridViewButtonXColumn bc = grdDatos.Columns[e.ColumnIndex] as DataGridViewButtonXColumn;

                    if (bc != null)
                    {
                        switch (e.ColumnIndex)
                        {
                            case 14:
                                FrmOdcA Fodca = new FrmOdcA(Grupo, grdDatos[0, e.RowIndex].Value.ToString());
                                Fodca.Show(this);
                                break;
                            case 17:
                                FrmFD Fd = new FrmFD(Grupo, grdDatos[0, e.RowIndex].Value.ToString(), txtDesde.Value, txtHasta.Value);
                                Fd.Show(this);
                                break;
                            case 19:
                                Ac[grdDatos.CurrentCell.RowIndex].comprar = Ac[grdDatos.CurrentCell.RowIndex].sugerido;
                                Ac[grdDatos.CurrentCell.RowIndex].total = Ac[grdDatos.CurrentCell.RowIndex].sugerido * Ac[grdDatos.CurrentCell.RowIndex].costo;
                                Total = Ac.Sum(a => a.total);
                                grdDatos.Refresh();
                                break;
                        }
                    }
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void grdDatos_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 20)
                {
                    Ac[grdDatos.CurrentCell.RowIndex].total = Ac[grdDatos.CurrentCell.RowIndex].comprar * Ac[grdDatos.CurrentCell.RowIndex].costo;
                    Total = Ac.Sum(a => a.total);
                    grdDatos.Refresh();
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGODC_Click(object sender, EventArgs e)
        {
            FrmGodc Fgodc = new FrmGodc(this, txtCo_empresa.Text.Trim());
            Fgodc.Show(this);
        }

        private void txtCo_alma_Leave(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    txtAlm_des.Text = context.pSeleccionarAlmacenEmpresa(txtCo_alma.Text.Trim(), txtCo_empresa.Text).AsParallel().FirstOrDefault().alm_des.Trim();
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

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                string Co_lin = cboLinea.SelectedIndex == -1 ? null : cboLinea.SelectedValue.ToString().Trim();
                string Co_subl = cboSub_lin.SelectedIndex == -1 ? null : cboSub_lin.SelectedValue.ToString().Trim();
                string Co_col = cboColores.SelectedIndex == -1 ? null : cboColores.SelectedValue.ToString().Trim();
                string Co_cat = cboCat_art.SelectedIndex == -1 ? null : cboCat_art.SelectedValue.ToString().Trim();
                string Cod_proc = cboProce.SelectedIndex == -1 ? null : cboProce.SelectedValue.ToString().Trim();

                List<Acom> Acdep = Ac.Where(a => a.comprar > 0).ToList();

                FrmAcEmail Face = new FrmAcEmail(Acdep, Grupo, txtCo_alma.Text.Trim(), txtDesde.Value, txtHasta.Value, Co_lin, Co_subl, Co_col, Co_cat, Cod_proc);

                Face.Show(this);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarXml_Click(object sender, EventArgs e)
        {
            try
            {
                string Co_lin = cboLinea.SelectedIndex == -1 ? "" : "[" + cboLinea.SelectedValue.ToString().Trim() + "]";
                string Co_subl = cboSub_lin.SelectedIndex == -1 ? "" : "[" + cboSub_lin.SelectedValue.ToString().Trim() + "]";
                string Co_col = cboColores.SelectedIndex == -1 ? "" : "[" + cboColores.SelectedValue.ToString().Trim() + "]";
                string Co_cat = cboCat_art.SelectedIndex == -1 ? "" : "[" + cboCat_art.SelectedValue.ToString().Trim() + "]";
                string Cod_proc = cboProce.SelectedIndex == -1 ? "" : "[" + cboProce.SelectedValue.ToString().Trim() + "]";

                var AcomXml = new XElement("Acompras",
                from i in Ac
                select new XElement("Articulo",
                            new XElement("co_art", i.co_art.Trim()),
                            new XElement("art_des", i.art_des.Trim()),
                            new XElement("comentario", i.comentario.Trim()),
                            new XElement("lc_descrip2", i.lc_descrip2.Trim()),
                            new XElement("referencia", i.referencia.Trim()),
                            new XElement("ene", i.ene),
                            new XElement("feb", i.feb),
                            new XElement("mar", i.mar),
                            new XElement("abr", i.abr),
                            new XElement("may", i.may),
                            new XElement("jun", i.jun),
                            new XElement("jul", i.jul),
                            new XElement("ago", i.ago),
                            new XElement("sep", i.sep),
                            new XElement("oct", i.oct),
                            new XElement("nov", i.nov),
                            new XElement("dic", i.dic),
                            new XElement("stock_act", i.stock_act),
                            new XElement("stock_lle", i.stock_lle),
                            new XElement("uni_ventas", i.uni_ventas),
                            new XElement("costo", i.costo),
                            new XElement("sugerido", i.sugerido),
                            new XElement("comprar", i.comprar),
                            new XElement("total", i.total),
                            new XElement("A", "+"),
                            new XElement("orden", i.orden),
                            new XElement("comment", i.comment),
                            new XElement("imagen", i.imagen)));

                string Fecha = ((DateTime.Now.Day < 10) ? "0" : "") + DateTime.Now.Day.ToString() +
                               ((DateTime.Now.Month < 10) ? "0" : "") + DateTime.Now.Month.ToString() +
                               (DateTime.Now.Year.ToString());

                string Hora = ((DateTime.Now.Hour < 10) ? "0" : "") + DateTime.Now.Hour.ToString() +
                              ((DateTime.Now.Minute < 10) ? "0" : "") + DateTime.Now.Minute.ToString() +
                              ((DateTime.Now.Second < 10) ? "0" : "") + DateTime.Now.Second.ToString();

                string Fname = @"\\172.16.1.4\Profit\Publicaciones\Profit Expansion\Xml Files\" + Co_lin + Co_subl + Co_col + Co_cat + Cod_proc + " " + Fecha + " " + Hora + ".xml";
                AcomXml.Save(Fname);

                MessageBox.Show("Archivo Xml generado: " + Environment.NewLine + Fname,"Profit Expansion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GenerarArchivo(Boolean GenerarArchivo)
        {
            try
            {
                string Co_lin = cboLinea.SelectedIndex == -1 ? null : cboLinea.SelectedValue.ToString().Trim();
                string Co_subl = cboSub_lin.SelectedIndex == -1 ? null : cboSub_lin.SelectedValue.ToString().Trim();
                string Co_col = cboColores.SelectedIndex == -1 ? null : cboColores.SelectedValue.ToString().Trim();
                string Co_cat = cboCat_art.SelectedIndex == -1 ? null : cboCat_art.SelectedValue.ToString().Trim();
                string Cod_proc = cboProce.SelectedIndex == -1 ? null : cboProce.SelectedValue.ToString().Trim();
                string Grupo;
                string Archivo;

                pSeleccionarParametros_Result p = new pSeleccionarParametros_Result();
                //Programa e = new Programa();
                pSeleccionarReportes_Result r = new pSeleccionarReportes_Result();
                //List<pSeleccionarValores_prog_Result> v = new List<pSeleccionarValores_prog_Result>();
                //string returnValue = null;

                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    p = context.pSeleccionarParametros().FirstOrDefault();
                    r = context.pSeleccionarReportes("006").FirstOrDefault();
                    Grupo = context.pObtenerGrupo(txtCo_empresa.Text.Trim()).AsParallel().FirstOrDefault().grupo.Trim();
                }

                DataSet ds = new DataSet();
                ds.Tables.Add("pAnalisisCompras");
                ds.Tables[0].Columns.Add("A", typeof(string));
                ds.Tables[0].Columns.Add("co_art", typeof(string));
                ds.Tables[0].Columns.Add("art_des", typeof(string));
                ds.Tables[0].Columns.Add("referencia", typeof(string));
                ds.Tables[0].Columns.Add("comentario", typeof(string));
                ds.Tables[0].Columns.Add("lc_descrip2", typeof(string));
                ds.Tables[0].Columns.Add("ene", typeof(decimal));
                ds.Tables[0].Columns.Add("feb", typeof(decimal));
                ds.Tables[0].Columns.Add("mar", typeof(decimal));
                ds.Tables[0].Columns.Add("abr", typeof(decimal));
                ds.Tables[0].Columns.Add("may", typeof(decimal));
                ds.Tables[0].Columns.Add("jun", typeof(decimal));
                ds.Tables[0].Columns.Add("jul", typeof(decimal));
                ds.Tables[0].Columns.Add("ago", typeof(decimal));
                ds.Tables[0].Columns.Add("sep", typeof(decimal));
                ds.Tables[0].Columns.Add("oct", typeof(decimal));
                ds.Tables[0].Columns.Add("nov", typeof(decimal));
                ds.Tables[0].Columns.Add("dic", typeof(decimal));
                ds.Tables[0].Columns.Add("uni_ventas", typeof(decimal));
                ds.Tables[0].Columns.Add("sugerido", typeof(decimal));
                ds.Tables[0].Columns.Add("orden", typeof(Int32));
                ds.Tables[0].Columns.Add("costo", typeof(decimal));
                ds.Tables[0].Columns.Add("comprar", typeof(decimal));
                ds.Tables[0].Columns.Add("total", typeof(decimal));

                ds.Tables[0].Clear();

                List<Acom> ListaAc = Ac.Where(a => a.comprar > 0).ToList();

                if (ListaAc.Count == 0)
                {
                    MessageBox.Show("Sin datos para mostrar.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    for (int i = 0; i < ListaAc.Count; i++)
                    {
                        DataRow row = ds.Tables[0].NewRow();
                        row["co_art"] = ListaAc[i].co_art;
                        row["art_des"] = ListaAc[i].art_des;
                        row["referencia"] = ListaAc[i].referencia;
                        row["comentario"] = ListaAc[i].comentario;
                        row["LC_DESCRIP2"] = ListaAc[i].lc_descrip2;
                        row["Costo"] = ListaAc[i].costo;
                        row["Comprar"] = ListaAc[i].comprar;
                        row["Total"] = ListaAc[i].costo * ListaAc[i].comprar;

                        ds.Tables[0].Rows.Add(row);
                        ds.Tables[0].AcceptChanges();
                    }

                    string Filename = r.ruta + @"\" + r.Archivo;
                    CrystalDecisions.CrystalReports.Engine.ReportDocument oRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                    oRpt.Load(@Filename);
                    oRpt.SetDataSource(ds);

                    if (GenerarArchivo == false)
                    {
                        FrmRep Fr = new FrmRep(ds, r.Archivo, false);
                        Fr.ShowDialog();
                    }
                    else
                    {
                        Archivo = "";
                        Archivo = @p.ruta_pdf + @"\" + r.Archivo.Replace(".rpt", "").Trim() + " " + System.DateTime.Now.ToFileTime() + ".pdf";
                        oRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Archivo.TrimEnd());
                    }
                    oRpt.Close();
                    oRpt.Dispose();
                }
            }
            catch (EntitySqlException ex)
            {
                MessageBox.Show(ex.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex0)
            {
                MessageBox.Show(ex0.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnODCPreview_Click(object sender, EventArgs e)
        {
            GenerarArchivo(false);
        }

        private void btnImportarXml_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    XElement root = XElement.Load(openFileDialog1.FileName.Trim());
                    IEnumerable<XElement> XmlAcom = root.Elements();
                    
                    Ac.Clear();
                    foreach (var item in XmlAcom)
                    {
                        Ac.Add(new Acom
                        {
                            co_art = item.Element("co_art").Value,
                            art_des = item.Element("art_des").Value,
                            comentario = item.Element("comentario").Value,
                            lc_descrip2 = item.Element("lc_descrip2").Value,
                            referencia = item.Element("referencia").Value,
                            ene = Convert.ToDecimal(item.Element("ene").Value),
                            feb = Convert.ToDecimal(item.Element("feb").Value),
                            mar = Convert.ToDecimal(item.Element("mar").Value),
                            abr = Convert.ToDecimal(item.Element("abr").Value),
                            may = Convert.ToDecimal(item.Element("may").Value),
                            jun = Convert.ToDecimal(item.Element("jun").Value),
                            jul = Convert.ToDecimal(item.Element("jul").Value),
                            ago = Convert.ToDecimal(item.Element("ago").Value),
                            sep = Convert.ToDecimal(item.Element("sep").Value),
                            oct = Convert.ToDecimal(item.Element("oct").Value),
                            nov = Convert.ToDecimal(item.Element("nov").Value),
                            dic = Convert.ToDecimal(item.Element("dic").Value),
                            stock_act = Convert.ToDecimal(item.Element("stock_act").Value),
                            stock_lle = Convert.ToDecimal(item.Element("stock_lle").Value),
                            uni_ventas = Convert.ToDecimal(item.Element("uni_ventas").Value),
                            sugerido = Convert.ToDecimal(item.Element("sugerido").Value),
                            costo = Convert.ToDecimal(item.Element("costo").Value),
                            comprar = Convert.ToDecimal(item.Element("comprar").Value),
                            total = Convert.ToDecimal(item.Element("total").Value),
                            A = item.Element("A").Value,
                            orden = Convert.ToInt32(item.Element("orden").Value),
                            comment = item.Element("comment").Value,
                            imagen = item.Element("imagen").Value
                        });
                    }
                    grdDatos.AutoGenerateColumns = false;
                    grdDatos.DataSource = "";
                    grdDatos.DataSource = Ac;
                    grdDatos.Refresh();
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void grdDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Ac[e.RowIndex].imagen.Trim().Length>0)
                    Imagen.Load(Ac[e.RowIndex].imagen);
                else
                {
                    Imagen.Image = null;
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdDatos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                 if (Ac.Count>0 && e.RowIndex>-1)
                 {
                     e.CellStyle.ForeColor = Ac[e.RowIndex].uni_ventas == 0 ? Color.Red : Color.Black;
                     e.CellStyle.BackColor = Ac[e.RowIndex].uni_ventas == 0 ? Color.LightGray: Color.White;
                 }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}