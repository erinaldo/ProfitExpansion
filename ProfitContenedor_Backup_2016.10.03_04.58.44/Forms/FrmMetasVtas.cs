using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.Entity.Core;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Configuration;

namespace ProfitContenedor
{
    public partial class FrmMetasVtas : DevComponents.DotNetBar.Metro.MetroForm
    {
        Boolean Nuevo = false;
        string Co_usu;
        Int32 Acceso;
        Metas_Vtas Meta = new Metas_Vtas();
        List<pSeleccionarEst_Diaria_Result> Le = new List<pSeleccionarEst_Diaria_Result>();
        
        public FrmMetasVtas()
        {
            InitializeComponent();
        }

        public FrmMetasVtas(string Usuario_Actual, Int32 Tipo)
        {
            Co_usu = Usuario_Actual;
            Acceso = Tipo;
            InitializeComponent();
        }
        public static bool RemoteFileExists(string url, int timeout)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                // El timeout es en milisegundos
                request.Timeout = timeout;
                // ************

                //Configurando el Request method HEAD, puede ser GET tambien.
                request.Method = "HEAD";
                //Obteniendo la respuesta
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //Regresa TRUE si el codigo de esdado es == 200
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                //Si ocurre una excepcion devuelve false
                return false;
            }
        }
        private void FrmMetasVtas_Load(object sender, EventArgs e)
        {
            try
            {

                string url = @"https://s3.amazonaws.com/dolartoday/data.json";

                WebClient conexion = new WebClient();
                string json = conexion.DownloadString(new Uri(url));

                //if (RemoteFileExists(url, 3000))
                //{
                //    MessageBox.Show("Falla en la conexion de Internet");
                //    CargarDatos();
                //}
                //else
                //{
                //    CargarDatos();
                //}
                JObject rss = JObject.Parse(json);
                decimal rssTitle = (decimal)rss["USD"]["transferencia"];

                txtUSD.Text = rssTitle.ToString();
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;


                Le.Clear();

                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var g = context.pSeleccionarGrupo().ToList();
                    cboGrupo.DataSource = g;
                    cboGrupo.ValueMember = "grupo";
                    cboGrupo.DisplayMember = "grupo";
                }
                grdDatos.AutoGenerateColumns = false;
                grdDivisa.AutoGenerateColumns = false;
                grdDatos.DataSource = "";
                grdDivisa.DataSource = "";

                Navegar(0);



            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CargarDatos();
                CargarDivisa();
            }

             
                
        }
       
        private void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var m = context.pObtenerTablaInt(txtId_meta.Value, "id_meta", p, "Metas_Vtas").ToList();

                    if (m.Count > 0)
                    {
                        Int32 id = m[0].Value;
                        Meta = context.Metas_Vtas.Where(me => me.id_meta == id).FirstOrDefault();

                        CargarDatos();
                        AccesoControles(Acceso > 0);
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

        private void AccesoControles(bool p)
        {
            try
            {
                btnPrimero.Enabled = p;
                btnAnterior.Enabled = p;
                btnSiguiente.Enabled = p;
                btnUltimo.Enabled = p;
                btnNuevo.Enabled = p;
                btnGuardar.Enabled = p;
                btnEliminar.Enabled = p;
                btnDeshacer.Enabled = p;
                btnAgregarR.Enabled = p;
                btnQuitar.Enabled = p;
                btnImprimir.Enabled = p;
                
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
            try
            {
                using(Profit_RGEntities context = new Profit_RGEntities())
	            {
		            txtId_meta.Value = Meta.id_meta;
                    cboGrupo.Text = Meta.grupo.Trim();
                    txtDesde.Value = Meta.desde;
                    txtHasta.Value = Meta.hasta;
                    txtMeta.Value = Convert.ToDouble(Meta.meta);
                    txtTasa.Value = Convert.ToDouble(Meta.tasa);
                    CalcularCambio();
                    Le.Clear();
                    //foreach (var item in context.pSeleccionarEst_Diaria(Meta.id_meta).ToList())
                    //{
                    //    Le.Add(new Estimacion
                    //    {
                    //        Fecha = item.fecha,
                    //        Porc = item.porc,
                    //        Diaria = Math.Round(Meta.meta,2) * Math.Round(item.porc, 3) / 100,
                    //        Tasa_aju = Math.Round(item.tasa_aju,2),
                    //        Diaria_aju = Math.Round(item.diaria_aju) //(item.tasa_aju * Convert.ToDecimal(txtDolar.Value)) * item.porc / 100
                    //    });
                    //};
                    Le = context.pSeleccionarEst_Diaria(Meta.id_meta).ToList();

                    grdDatos.DataSource = "";
                    grdDatos.DataSource = Le;
                    grdDatos.Refresh();

                    CargarDivisa();

                    CalcularTotales();
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Nuevo = true;
            LimpiarControles();
            cboGrupo.Focus();
            CargarDivisa();
            CalcularTotales();
        }

        private void LimpiarControles()
        {
            try
            {
                txtId_meta.Value = 0;
                cboGrupo.SelectedIndex = -1;
                txtDesde.Value = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, 1);
                txtHasta.Value = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.DaysInMonth(System.DateTime.Now.Year, System.DateTime.Now.Month));
                txtMeta.Value = 0;
                txtTasa.Value = 0;
                Le.Clear();
                grdDatos.DataSource = "";
                grdDatos.DataSource = Le;
                grdDatos.Refresh();
                cboGrupo.Focus();
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
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    if (Nuevo==true)
                    {
                        context.pInsertarMetas_Vtas(cboGrupo.Text, txtDesde.Value, txtHasta.Value,Convert.ToDecimal(txtMeta.Value),Convert.ToDecimal(txtTasa.Value));
                        Int32? Id = context.Metas_Vtas.OrderByDescending(p => p.id_meta).FirstOrDefault().id_meta;
                        foreach (var item in Le)
                        {
                            context.pInsertarEst_Diaria(item.fecha, Id, cboGrupo.SelectedText, item.porc,item.tasa_aju,item.diaria_aju);
                        }
                    }
                    else
                    {
                        context.pActualizarMetas_Vtas(cboGrupo.Text, txtDesde.Value, txtHasta.Value, Convert.ToDecimal(txtMeta.Value), Convert.ToDecimal(txtTasa.Value), Meta.rowguid);
                        context.pEliminarEst_Diaria(Meta.id_meta);
                        foreach (var item in Le)
                        {
                            context.pInsertarEst_Diaria(item.fecha, Meta.id_meta, cboGrupo.Text, item.porc, item.tasa_aju, item.diaria_aju);
                        }
                    }
                }
                MessageBox.Show(this, "Se ha guardado la información satisfactoriamente.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Navegar(5);
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
            if (MessageBox.Show("Desea realmente eliminar este registro?", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    context.pEliminarMetas_Vtas(Meta.rowguid);
                    Navegar(1);
                }
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            Navegar(5);
        }

        private void btnAgregarR_Click(object sender, EventArgs e)
        {
            try
            {
                Le.Add(new pSeleccionarEst_Diaria_Result
                    {
                        fecha = txtHasta.Value,
                        porc = 0.00m,
                        Diaria = 0.00m
                    });

                grdDatos.DataSource = "";
                grdDatos.DataSource = Le;
                grdDatos.Refresh();
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
                if (Le.Count>0)
                {
                    Le.RemoveAt(grdDatos.CurrentCell.RowIndex);
                }
                grdDatos.DataSource = "";
                grdDatos.DataSource = Le;
                grdDatos.Refresh();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                grdDatos.DataSource = null;
                Le.Clear();
                DateTime FechaTemp = txtDesde.Value;
                while (FechaTemp <= txtHasta.Value)
                {
                    if (FechaTemp.DayOfWeek != DayOfWeek.Saturday && FechaTemp.DayOfWeek != DayOfWeek.Sunday)
                    {
                        Le.Add(new pSeleccionarEst_Diaria_Result
                            {
                                fecha = FechaTemp,
                                porc = 0.00m,
                                Diaria = 0.00m,
                                tasa_aju = 0.00m,
                                diaria_aju = 0.00m
                            });
                    }
                    
                    FechaTemp = FechaTemp.AddDays(1);
                }
                grdDatos.DataSource = Le;
                grdDatos.Refresh();
                //grdDatos.CurrentCell = grdDatos[1, 0];
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtHasta_Leave(object sender, EventArgs e)
        {
            try
            {
                CargarDivisa();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDivisa()
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var Ldiv = context.Divisas.Where(x => x.fecha >= txtDesde.Value && x.fecha <= txtHasta.Value).OrderBy(y => y.fecha).OrderByDescending(x => x.fecha).ToList();

                    grdDivisa.DataSource = "";
                    grdDivisa.DataSource = Ldiv;
                    grdDivisa.Refresh();
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

        private void grdDatos_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if (e.RowIndex > -1)
                //{
                //    switch (e.ColumnIndex)
                //    {
                //        case 1:
                //            grdDatos[2, e.RowIndex].Value = (Meta.meta * Convert.ToDecimal(Le[e.RowIndex].Porc) / 100);
                //            grdDatos[4, e.RowIndex].Value =  ((Convert.ToDecimal(Le[e.RowIndex].Tasa_aju) * Convert.ToDecimal(txtDolar.Value)) * Convert.ToDecimal(Le[e.RowIndex].Porc) / 100);
                //            break;
                //        case 3:
                //            grdDatos[4, e.RowIndex].Value = ((Convert.ToDecimal(Le[e.RowIndex].Tasa_aju) * Convert.ToDecimal(txtDolar.Value)) * Convert.ToDecimal(Le[e.RowIndex].Porc) / 100);
                //            break;
                //        default:
                //            break;
                //    }
                //    txtP.Value = Convert.ToDouble(Le.Sum(X => X.Porc).ToString());
                //    txtD.Value = Convert.ToDouble(Le.Sum(X => X.Diaria).ToString());
                //}
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdDatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    switch (e.ColumnIndex)
                    {
                        case 1:
                            grdDatos[2, e.RowIndex].Value = Math.Round((Meta.meta * Convert.ToDecimal(Le[e.RowIndex].porc) / 100),2);
                            grdDatos[4, e.RowIndex].Value = Math.Round((Convert.ToDecimal(Le[e.RowIndex].tasa_aju) * Convert.ToDecimal(txtDolar.Value)) * Convert.ToDecimal(Le[e.RowIndex].porc) / 100,2);
                            break;
                        case 3:
                            grdDatos[4, e.RowIndex].Value = Math.Round(((Convert.ToDecimal(Le[e.RowIndex].tasa_aju) * Convert.ToDecimal(txtDolar.Value)) * Convert.ToDecimal(Le[e.RowIndex].porc) / 100),2);
                            break;
                    }
                    CalcularTotales();
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularTotales()
        {
            txtP.Value = Convert.ToDouble(Le.Sum(X => Math.Round(Convert.ToDouble(X.porc),3)).ToString());
            txtD.Value = Convert.ToDouble(Le.Sum(X => Math.Round(Convert.ToDouble(X.Diaria),2)).ToString());
        }

        private void txtMeta_Leave(object sender, EventArgs e)
        {
            try
            {
                CalcularCambio();
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

        private void CalcularCambio()
        {
            txtDolar.Value = Convert.ToDouble(Convert.ToDecimal(txtMeta.Value) / Convert.ToDecimal(txtTasa.Value));
        }

        private void txtTasa_Leave(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void txtMeta_Leave_1(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string returnValue = null;

                // Look for the name in the connectionStrings section.
                ConnectionStringSettings settings =
                    ConfigurationManager.ConnectionStrings["ProfitContenedor.Properties.Settings.Profit_RGConnectionString"];

                // If found, return the connection string.
                if (settings != null)
                    returnValue = settings.ConnectionString;

                //SqlConnection sqlConn = new SqlConnection("Server=172.16.1.4;uid=profit;password=profit;initial catalog=Profit_RG;");
                SqlConnection sqlConn = new SqlConnection(returnValue);


                SqlCommand comd;
                comd = new SqlCommand();
                comd.Connection = sqlConn;
                comd.CommandType = CommandType.StoredProcedure;
                comd.CommandText = "pRepResumenMetasVentas";

                comd.Parameters.Add("@Grupo", SqlDbType.NChar);
                comd.Parameters[0].Value = cboGrupo.Text.Trim();
                comd.Parameters.Add("@Desde", SqlDbType.DateTime);
                comd.Parameters[1].Value = txtDesde.Value;
                comd.Parameters.Add("@Hasta", SqlDbType.DateTime);
                comd.Parameters[2].Value = txtHasta.Value;


                SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                sqlAdapter.SelectCommand = comd;
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "pRepResumenMetasVentas");

                FrmRep Fr = new FrmRep(ds, "RepResumenMetasVtas.rpt", false);
                Fr.Show();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}