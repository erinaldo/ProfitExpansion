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
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;
using System.IO;
using System.Net.Mime;

namespace ProfitContenedor
{
    public partial class FrmProgramas : DevComponents.DotNetBar.Metro.MetroForm
    {
        Boolean Nuevo = false;
        string Usuario_Act;
        Int32 Tip;
        List<Val_prog> Vp = new List<Val_prog>();
        Programa programa = new Programa();
        string Concurrencia = "";
        string Archivo = "";
        List<Programa> P = new List<Programa>();

        public FrmProgramas()
        {
            InitializeComponent();
        }

        public FrmProgramas(string Usuario_Actual, Int32 Tipo)
        {
            Usuario_Act = Usuario_Actual;
            Tip = Tipo;
            InitializeComponent();
        }

        private void FrmProgramas_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    cboReporte.DataSource = context.pSeleccionarReportes(null).ToList();
                    cboReporte.ValueMember = "cod_rep";
                    cboReporte.DisplayMember = "titulo";

                    P = context.Programas.ToList();

                    cboList.DataSource = P;
                    cboList.ValueMember = "id_evento";
                    cboList.DisplayMember = "Descrip";
                }
                Navegar(0);
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
                    
                    var preg = context.pObtenerTablaInt(txtId_evento.Value, "id_evento", p, "programas").ToList();
                    
                    if (preg.Count > 0)
                    {
                        Int32 id = preg[0].Value;
                        programa = context.Programas.Where(pr => pr.id_evento == id).FirstOrDefault();
                        cboList.Text = programa.descrip;
                        
                        Int32 Acceso = context.pSeleccionarProgramasCA(Usuario_Act).Count(pr => pr.id_evento == id);
                        CargarDatos();
                        AccesoControles(Acceso>0);
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

        private void CargarDatos()
        {
            txtId_evento.Value = programa.id_evento;
            txtDescrip.Text = programa.descrip.Trim();
            txtGrupo.Text = programa.Grupo.Trim();
            txtDesde.Value = programa.inicio;
            txtHasta.Value = programa.fin;
            txtHora.Value = new DateTime(1, 1, 0001, programa.hora.Hours, programa.hora.Minutes, programa.hora.Seconds);
            cboHabilitado.Text = programa.Habilitado == true ? "Si" : "No";
            Concurrencia = programa.concurrencia;
            txtUeje.Text = programa.ultima_ejecucion.ToString();

            cboTipo.Text = programa.Tipo.Trim();
            btnImprimir.Enabled = programa.Tipo.Trim() != "DIV";
            btnEnviar.Enabled = programa.Tipo.Trim() != "DIV";

            lnkPara.LinkVisited = false;
            lnkCopia.LinkVisited = false;
            lnkOculto.LinkVisited = false;

            switch (programa.concurrencia.Trim())
            {
                case "D":
                    optDiario.CheckState = CheckState.Checked;
                    break;
                case "L":
                    optLaboral.CheckState = CheckState.Checked;
                    break;
                case "S":
                    optSemanal.CheckState = CheckState.Checked;
                    break;
                case "Q":
                    optQuincenal.CheckState = CheckState.Checked;
                    break;
                case "M":
                    optMensual.CheckState = CheckState.Checked;
                    break;
                case "F":
                    optFinMes.CheckState = CheckState.Checked;
                    break;
            }

            chkLunes.CheckState = programa.lunes == true ? CheckState.Checked : CheckState.Unchecked;
            chkMartes.CheckState = programa.martes == true ? CheckState.Checked : CheckState.Unchecked;
            chkMiercoles.CheckState = programa.miercoles == true ? CheckState.Checked : CheckState.Unchecked;
            chkJueves.CheckState = programa.jueves == true ? CheckState.Checked : CheckState.Unchecked;
            chkViernes.CheckState = programa.viernes == true ? CheckState.Checked : CheckState.Unchecked;
            chkSabado.CheckState = programa.sabado == true ? CheckState.Checked : CheckState.Unchecked;
            chkDomingo.CheckState = programa.domingo == true ? CheckState.Checked : CheckState.Unchecked;

            txtPara.Text = programa.Para.Trim();
            txtCopia.Text = programa.Copia.Trim();
            txtOculto.Text = programa.Oculto.Trim();

            using (Profit_RGEntities context = new Profit_RGEntities())
            {
                string Titulo = context.pSeleccionarReportes(programa.cod_rep.Trim()).FirstOrDefault().titulo;
                cboReporte.Text = Titulo;

                var Val_prog = context.pSeleccionarValores_prog(programa.id_evento).ToList();
                Vp.Clear();

                foreach (var item in Val_prog)
                {
                    Vp.Add(new Val_prog
                    {
                        parametro = item.parametro.Trim(),
                        Val_char = item.valor_char,
                        Val_int = item.valor_int,
                        Val_dec = item.valor_dec,
                        Val_date = item.valor_date,
                        Val_time = item.valor_time == null ? new TimeSpan(0, 0, 0) : new TimeSpan(item.valor_time.Value.Hours, item.valor_time.Value.Minutes, item.valor_time.Value.Seconds),
                        Val_bit = item.valor_bit
                    });
                }

                grdDatos.AutoGenerateColumns = false;
                grdDatos.DataSource = "";
                grdDatos.DataSource = Vp;
                grdDatos.Refresh();
            }
        }

        private void AccesoControles(bool Habilitado)
        {
           
            

            btnNuevo.Enabled = Tip == 1;
            btnGuardar.Enabled = Tip == 1;
            btnEliminar.Enabled = Tip == 1;
            btnDeshacer.Enabled = Tip == 1;
            btnAccesoProgramas.Enabled = Tip == 1;
            btnImprimir.Enabled = Habilitado;
            btnEnviar.Enabled = Habilitado;

            txtDescrip.Enabled = Tip == 1 && Habilitado;
            txtGrupo.Enabled = Tip == 1 && Habilitado;
            txtDesde.Enabled = Tip == 1 && Habilitado;
            txtHasta.Enabled = Tip == 1 && Habilitado;
            txtHora.Enabled = Tip == 1 && Habilitado;
            cboTipo.Enabled = Tip == 1 && Habilitado;
            cboHabilitado.Enabled = Tip == 1 && Habilitado;

            optDiario.Enabled = Tip == 1 && Habilitado;
            optLaboral.Enabled = Tip == 1 && Habilitado;
            optSemanal.Enabled = Tip == 1 && Habilitado;
            optQuincenal.Enabled = Tip == 1 && Habilitado;
            optMensual.Enabled = Tip == 1 && Habilitado;
            optFinMes.Enabled = Tip == 1 && Habilitado;

            chkLunes.Enabled = Tip == 1 && Habilitado;
            chkMartes.Enabled = Tip == 1 && Habilitado;
            chkMiercoles.Enabled = Tip == 1 && Habilitado;
            chkJueves.Enabled = Tip == 1 && Habilitado;
            chkViernes.Enabled = Tip == 1 && Habilitado;
            chkSabado.Enabled = Tip == 1 && Habilitado;
            chkDomingo.Enabled = Tip == 1 && Habilitado;

            txtPara.Enabled = Tip == 1 && Habilitado;
            txtCopia.Enabled = Tip == 1 && Habilitado;
            txtOculto.Enabled = Tip == 1 && Habilitado;

            cboReporte.Enabled = Tip == 1 && Habilitado;

            grdDatos.Enabled = Tip == 1 && Habilitado;
            btnAFiltro.Enabled = Tip == 1 && Habilitado;
            btnEFiltro.Enabled = Tip == 1 && Habilitado;

            lnkPara.Enabled = programa.Tipo.Trim() != "DIV" && Habilitado;
            lnkCopia.Enabled = programa.Tipo.Trim() != "DIV" && Habilitado;
            lnkOculto.Enabled = programa.Tipo.Trim() != "DIV" && Habilitado;

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

        private void LimpiarControles()
        {
            txtId_evento.Value = 0;
            txtDescrip.Text = "";
            txtGrupo.Text = "";
            txtDesde.Value = System.DateTime.Today;
            txtHasta.Value = System.DateTime.Today;
            txtHora.Value = new DateTime(1, 1, 0001, 7, 0, 0);
            cboHabilitado.Text = "No";
            cboTipo.Text = "PDF";

            optDiario.CheckState = CheckState.Checked;
            chkLunes.CheckState = CheckState.Unchecked;
            chkMartes.CheckState = CheckState.Unchecked;
            chkMiercoles.CheckState = CheckState.Unchecked;
            chkJueves.CheckState = CheckState.Unchecked;
            chkViernes.CheckState = CheckState.Unchecked;
            chkSabado.CheckState = CheckState.Unchecked;
            chkDomingo.CheckState = CheckState.Unchecked;

            txtPara.Text = "";
            txtCopia.Text = "";
            txtOculto.Text = "";

            cboReporte.SelectedIndex = -1;

            Vp.Clear();
            grdDatos.DataSource = "";
            grdDatos.DataSource = Vp;
            grdDatos.Refresh();

        }

        private void btnAFiltro_Click(object sender, EventArgs e)
        {
            Vp.Add(new Val_prog
            {
                parametro = "",
                Val_char = null,
                Val_int = null,
                Val_dec = null,
                Val_date = null,
                Val_time = new TimeSpan (0,0,0),
                Val_bit = null
            });
            grdDatos.DataSource = "";
            grdDatos.DataSource = Vp;
            grdDatos.Refresh();
            grdDatos.CurrentCell = grdDatos[1, Vp.Count() - 1];
            grdDatos.Refresh();
        }

        private void btnEFiltro_Click(object sender, EventArgs e)
        {
            if (grdDatos.RowCount > 0)
            {
                if (MessageBox.Show("Desea realmente eliminar este registro?", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    Vp.RemoveAt(grdDatos.CurrentCell.RowIndex);
            }
            grdDatos.DataSource = "";
            grdDatos.DataSource = Vp;
            grdDatos.Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo = true;
            programa = null;
            if (chkHeredar.CheckState == CheckState.Unchecked)
            {
                LimpiarControles();
            }
            chkHeredar.CheckState = CheckState.Unchecked;
            txtId_evento.Value = 0;
            txtDescrip.SelectAll();
            txtDescrip.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Tipo = cboTipo.SelectedItem.ToString();

                if (Nuevo == true)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        context.pInsertarProgramas
                            (txtDescrip.Text.Trim(), txtDesde.Value, txtHasta.Value, new TimeSpan(txtHora.Value.Hour,txtHora.Value.Minute,txtHora.Value.Second),
                            chkLunes.CheckState == CheckState.Checked ? true : false,
                            chkMartes.CheckState == CheckState.Checked ? true : false,
                            chkMiercoles.CheckState == CheckState.Checked ? true : false,
                            chkJueves.CheckState == CheckState.Checked ? true : false,
                            chkViernes.CheckState == CheckState.Checked ? true : false,
                            chkSabado.CheckState == CheckState.Checked ? true : false,
                            chkDomingo.CheckState == CheckState.Checked ? true : false,
                            cboReporte.SelectedValue.ToString(), txtPara.Text.Trim(),
                            txtCopia.Text.Trim(), txtOculto.Text.Trim(), txtGrupo.Text.Trim(),
                            cboHabilitado.SelectedItem.ToString() == "Si" ? true : false, Concurrencia, null, Tipo, null);

                            Int32? Id = context.Programas.OrderByDescending(p => p.id_evento).FirstOrDefault().id_evento;

                        foreach (var item in Vp)
                        {
                            context.pInsertarValores_prog(Id, item.parametro.Trim(), 
                                    item.Val_char.Trim(), item.Val_int, item.Val_dec,
                                    item.Val_date, new TimeSpan(item.Val_time.Value.Hours, item.Val_time.Value.Minutes, item.Val_time.Value.Seconds), item.Val_bit);
                        }

                        P = context.Programas.ToList();
                        context.pInsertarUsu_Prg(Usuario_Act,Id);
                        Navegar(3);
                        //cboList.DataSource = P;
                        //cboList.ValueMember = "id_evento";
                        //cboList.DisplayMember = "Descrip";
                    }
                }
                else
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        context.pActualizarProgramas(txtDescrip.Text.Trim(), txtDesde.Value, txtHasta.Value, new TimeSpan(txtHora.Value.Hour, txtHora.Value.Minute, txtHora.Value.Second),
                            chkLunes.CheckState == CheckState.Checked ? true : false,
                            chkMartes.CheckState == CheckState.Checked ? true : false,
                            chkMiercoles.CheckState == CheckState.Checked ? true : false,
                            chkJueves.CheckState == CheckState.Checked ? true : false,
                            chkViernes.CheckState == CheckState.Checked ? true : false,
                            chkSabado.CheckState == CheckState.Checked ? true : false,
                            chkDomingo.CheckState == CheckState.Checked ? true : false,
                            cboReporte.SelectedValue.ToString(), txtPara.Text.Trim(),
                            txtCopia.Text.Trim(), txtOculto.Text.Trim(), txtGrupo.Text.Trim(),
                            cboHabilitado.SelectedItem.ToString() == "Si" ? true : false, Concurrencia, null, Tipo, null, programa.rowguid);
                        context.pEliminarValores_prog(programa.id_evento);
                        
                        foreach (var item in Vp)
                        {
                            context.pInsertarValores_prog(programa.id_evento, item.parametro.Trim(),
                                    item.Val_char.Trim(), item.Val_int, item.Val_dec,
                                    item.Val_date, new TimeSpan(item.Val_time.Value.Hours, item.Val_time.Value.Minutes, item.Val_time.Value.Seconds), item.Val_bit);
                        }
                    }
                    MessageBox.Show(this, "Se ha guardado la información satisfactoriamente.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea realmente eliminar este registro?", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        context.pEliminarProgramas(programa.rowguid);
                        Navegar(1);
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

        private void optDiario_CheckedChanged(object sender, EventArgs e)
        {
            Diario();
            Concurrencia = "D";
        }

        private void Diario()
        {
            if (Tip == 1)
            {
                chkLunes.Enabled = true;
                chkMartes.Enabled = true;
                chkMiercoles.Enabled = true;
                chkJueves.Enabled = true;
                chkViernes.Enabled = true;
                chkSabado.Enabled = true;
                chkDomingo.Enabled = true;

                chkLunes.CheckState = CheckState.Unchecked;
                chkMartes.CheckState = CheckState.Unchecked;
                chkMiercoles.CheckState = CheckState.Unchecked;
                chkJueves.CheckState = CheckState.Unchecked;
                chkViernes.CheckState = CheckState.Unchecked;
            }
        }

        private void optLaboral_CheckedChanged(object sender, EventArgs e)
        {
            Laboral();
            Concurrencia = "D";
        }

        private void Laboral()
        {
            if (Tip == 1)
            {
                chkLunes.Enabled = false;
                chkMartes.Enabled = false;
                chkMiercoles.Enabled = false;
                chkJueves.Enabled = false;
                chkViernes.Enabled = false;
                chkLunes.CheckState = CheckState.Checked;
                chkMartes.CheckState = CheckState.Checked;
                chkMiercoles.CheckState = CheckState.Checked;
                chkJueves.CheckState = CheckState.Checked;
                chkViernes.CheckState = CheckState.Checked;
                chkSabado.Enabled = false;
                chkDomingo.Enabled = false;    
            }
        }

        private void optSemanal_CheckedChanged(object sender, EventArgs e)
        {
            Diario();
            Concurrencia = "S";
        }

        private void optQuincenal_CheckedChanged(object sender, EventArgs e)
        {
            Diario();
            Concurrencia = "Q";
        }

        private void optMensual_CheckedChanged(object sender, EventArgs e)
        {
            Diario();
            Concurrencia = "M";
        }

        private void optFinMes_CheckedChanged(object sender, EventArgs e)
        {
            Diario();
            Concurrencia = "F";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            GenerarArchivo(programa.id_evento,false);
        }

        void GenerarArchivo(Int32 Id_evento,Boolean GenerarArchivo)
        {
            try
            {
                pSeleccionarParametros_Result p = new pSeleccionarParametros_Result();
                Programa e = new Programa();
                pSeleccionarReportes_Result r = new pSeleccionarReportes_Result();
                List<pSeleccionarValores_prog_Result> v = new List<pSeleccionarValores_prog_Result>();
                string returnValue = null;

                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    p = context.pSeleccionarParametros().FirstOrDefault();
                    e = context.Programas.Where(ev => ev.id_evento == Id_evento).FirstOrDefault();
                    r = context.pSeleccionarReportes(e.cod_rep.Trim()).FirstOrDefault();
                    v = context.pSeleccionarValores_prog(e.id_evento).ToList();
                }

                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["ProfitContenedor.Properties.Settings.Profit_RGConnectionString"];

                if (settings != null)
                    returnValue = settings.ConnectionString;

                SqlConnection sqlConn = new SqlConnection(returnValue);

                SqlCommand comd;
                comd = new SqlCommand();
                comd.Connection = sqlConn;
                comd.CommandType = CommandType.StoredProcedure;
                comd.CommandText = r.funcion.Trim();

                foreach (var item in v)
                {
                    switch (item.tipo.Trim())
                    {
                        case "Char":
                            comd.Parameters.Add(item.parametro.Trim(), SqlDbType.Char);
                            comd.Parameters[comd.Parameters.Count - 1].Value = item.valor_char;
                            break;
                        case "Int":
                            comd.Parameters.Add(item.parametro.Trim(), SqlDbType.Int);
                            comd.Parameters[comd.Parameters.Count - 1].Value = item.valor_int;
                            break;
                        case "Decimal":
                            comd.Parameters.Add(item.parametro.Trim(), SqlDbType.Decimal);
                            comd.Parameters[comd.Parameters.Count - 1].Value = item.valor_dec;
                            break;
                        case "DateTime":
                            comd.Parameters.Add(item.parametro.Trim(), SqlDbType.DateTime);
                            comd.Parameters[comd.Parameters.Count - 1].Value = item.valor_date;
                            break;
                        case "Time":
                            comd.Parameters.Add(item.parametro.Trim(), SqlDbType.Time);
                            comd.Parameters[comd.Parameters.Count - 1].Value = item.valor_time;
                            break;
                        case "Bit":
                            comd.Parameters.Add(item.parametro.Trim(), SqlDbType.Bit);
                            comd.Parameters[comd.Parameters.Count - 1].Value = item.valor_bit;
                            break;
                    }
                }

                SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                sqlAdapter.SelectCommand = comd;
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, r.funcion.Trim());

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Sin datos para mostrar.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
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

                        //string Fecha = ((DateTime.Now.Day < 10) ? "0" : "") + DateTime.Now.Day.ToString() +
                        //      ((DateTime.Now.Month < 10) ? "0" : "") + DateTime.Now.Month.ToString() +
                        //      (DateTime.Now.Year.ToString());

                        //string Hora = ((DateTime.Now.Hour < 10) ? "0" : "") + DateTime.Now.Hour.ToString() +
                        //              ((DateTime.Now.Minute < 10) ? "0" : "") + DateTime.Now.Minute.ToString() +
                        //              ((DateTime.Now.Second < 10) ? "0" : "") + DateTime.Now.Second.ToString();

                        switch (e.Tipo.Trim())
                        {
                            case "PDF":
                                //Archivo = @p.ruta_pdf + @"\" + e.descrip.Trim() + " F[" + Fecha + "] H[" + Hora + "].pdf";
                                Archivo = @p.ruta_pdf + @"\" + e.descrip.Trim() + ".pdf";
                                oRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Archivo.TrimEnd());
                                break;
                            case "XLS":
                                Archivo = @p.ruta_pdf + @"\" + e.descrip.Trim() + ".xls";
                                oRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.ExcelRecord, Archivo.TrimEnd());
                                break;
                        }
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

        void EnviarCorreo(Int32 Id_evento, string Asunto, string To, string CC, string CCO, string Remitente, string Clave, Int32 Puerto, string Servidor, bool Ssl, string Grupo, string Archivo, string Tipo)
        {
            try
            {
                //Ruta de archivo adjunto (Si lo lleva)
                string PathFile = Archivo;

                //Creo el mensaje del mail.
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

                //Agrego los destinatarios, pueden ir varios
                foreach (var item in To.Split(new Char[] { ',' }))
                {
                    if (item.Trim().Length > 0)
                        msg.To.Add(item.Trim());
                }
                foreach (var item in CC.Split(new Char[] { ',' }))
                {
                    if (item.Trim().Length > 0)
                        msg.CC.Add(item.Trim());
                }
                foreach (var item in CCO.Split(new Char[] { ',' }))
                {
                    if (item.Trim().Length > 0)
                        msg.Bcc.Add(item.Trim());
                }

                //Agrego la direccion del que manda el email, puede ser falsa o verdadera, pero si es falsa puede que el servidor de correo lo detecte como spam, tambien depende de las credenciales que se ponen mas abajo
                msg.From = new MailAddress(Remitente.Trim(), "Profit Expansion", System.Text.Encoding.UTF8);

                //using (Profit_RGEntities context = new Profit_RGEntities())
                //{
                //    Asunto = context.Programas.Where(p => p.id_evento == Id_evento).FirstOrDefault().descrip.Trim();
                //}

                //Pongo el asunto
                msg.Subject = Asunto + " " + Grupo.TrimEnd();

                //El tipo de codificacion del Asunto 
                msg.SubjectEncoding = System.Text.Encoding.UTF8;

                string fichero = @"C:\Profit\Publicaciones\Profit Expansion Servicios\HtmlBody.html";
                string contenido = String.Empty;

                using (StreamReader lector = new StreamReader(fichero))
                {
                    while (lector.Peek() > -1)
                    {
                        string linea = lector.ReadLine();
                        if (!String.IsNullOrEmpty(linea))
                        {
                            contenido = contenido + linea;
                        }
                    }

                }

                //Escribo el mensaje Y su codificacion
                msg.Body = contenido;

                msg.BodyEncoding = System.Text.Encoding.UTF8;

                //Especifico si va ha ser interpertado con HTML
                msg.IsBodyHtml = true;

                //Agrego el archivo que puse en la ruta anterior "PathFile", y su tipo.

                Attachment Data;
                switch (Tipo.Trim())
                {
                    case "XLS":
                        Data = new Attachment(PathFile, MediaTypeNames.Application.Octet);
                        break;
                    case "PDF":
                        Data = new Attachment(PathFile, MediaTypeNames.Application.Pdf);
                        break;
                    default:
                        Data = null;
                        break;
                }

                //Obtengo las propiedades del archivo.
                ContentDisposition disposition = Data.ContentDisposition;
                disposition.CreationDate = System.IO.File.GetCreationTime(PathFile);
                disposition.ModificationDate = System.IO.File.GetLastWriteTime(PathFile);
                disposition.ReadDate = System.IO.File.GetLastAccessTime(PathFile);

                ////Agrego el archivo al mensaje
                msg.Attachments.Add(Data);

                //Creo un objeto de tipo cliente de correo (Por donde se enviara el correo)
                SmtpClient client = new SmtpClient();

                //Si no voy a usar credenciales pongo false, Pero la mayoria de servidores exigen las credenciales para evitar el spam
                client.UseDefaultCredentials = true;

                //Como voy a utilizar credenciales las pongo
                client.Credentials = new System.Net.NetworkCredential(Remitente.Trim(), Clave.Trim());
                //Si fuera gmail seria 587 el puerto, si es un servidor outlook casi siempre el puerto 25, yo utilizo un servidor propio de correo
                client.Port = Puerto;
                //client.Port = 25;

                //identifico el cliente que voy a utilizar
                client.Host = Servidor.Trim();

                //Si fuera a utilizar gmail esto deberia ir en true, esto es un certificado de seguridad
                client.EnableSsl = Ssl;
                //client.EnableSsl = false;

                //Envio el mensaje
                client.Send(msg);
                //MessageBox.Show("Correo enviado..." + Environment.NewLine + "A: " + (Gerencia.Trim().Length == 0 ? "NO DISPONIBLE" : Gerencia.Trim()) +
                //    Environment.NewLine + "CC: " + (Gerente.Trim().Length == 0 ? "NO DISPONIBLE" : Gerente.Trim()), "Profit Expansion",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Archivo = "";
                msg.Dispose();
                client.Dispose();
                //return true;
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                MessageBox.Show(ex.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //EventLog.WriteEntry(Application.ProductName, "Enviar Correo: " + ex.ToString(), EventLogEntryType.Error, 234);
                //return false;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea enviar el reporte por correo?", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    GenerarArchivo(programa.id_evento, true);
                    List<pSeleccionarParametros_Result> param = new List<pSeleccionarParametros_Result>();
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        param = context.pSeleccionarParametros().ToList();
                    }

                    EnviarCorreo(programa.id_evento,
                                    programa.descrip.Trim(),
                                    programa.Para.Trim(),
                                    programa.Copia.Trim(),
                                    programa.Oculto.Trim(),
                                    param[0].email.Trim(),
                                    param[0].password.Trim(),
                                    param[0].puerto,
                                    param[0].servidor.Trim(),
                                    param[0].ssl,
                                    programa.Grupo.Trim(), Archivo, programa.Tipo.Trim());

                    MessageBox.Show("Correo enviado...", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkPara_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea enviar el reporte por correo?", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    GenerarArchivo(programa.id_evento, true);

                    List<pSeleccionarParametros_Result> param = new List<pSeleccionarParametros_Result>();
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        param = context.pSeleccionarParametros().ToList();
                    }

                    EnviarCorreo(programa.id_evento,
                                    programa.descrip.Trim(),
                                    txtPara.Text.Trim(),
                                    "",
                                    "",
                                    param[0].email.Trim(),
                                    param[0].password.Trim(),
                                    param[0].puerto,
                                    param[0].servidor.Trim(),
                                    param[0].ssl,
                                    programa.Grupo.Trim(), Archivo, programa.Tipo.Trim());

                    MessageBox.Show("Correo enviado...", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkCopia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea enviar el reporte por correo?", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    GenerarArchivo(programa.id_evento, true);
                    List<pSeleccionarParametros_Result> param = new List<pSeleccionarParametros_Result>();
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        param = context.pSeleccionarParametros().ToList();
                    }

                    EnviarCorreo(programa.id_evento,
                                    programa.descrip.Trim(),
                                    "",
                                    txtCopia.Text.Trim(),
                                    "",
                                    param[0].email.Trim(),
                                    param[0].password.Trim(),
                                    param[0].puerto,
                                    param[0].servidor.Trim(),
                                    param[0].ssl,
                                    programa.Grupo.Trim(), Archivo, programa.Tipo.Trim());

                    MessageBox.Show("Correo enviado...", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkOculto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea enviar el reporte por correo?", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    GenerarArchivo(programa.id_evento, true);
                    List<pSeleccionarParametros_Result> param = new List<pSeleccionarParametros_Result>();
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        param = context.pSeleccionarParametros().ToList();
                    }

                    EnviarCorreo(programa.id_evento,
                                    programa.descrip.Trim(),
                                    "",
                                    "",
                                    txtOculto.Text.Trim(),
                                    param[0].email.Trim(),
                                    param[0].password.Trim(),
                                    param[0].puerto,
                                    param[0].servidor.Trim(),
                                    param[0].ssl,
                                    programa.Grupo.Trim(), Archivo, programa.Tipo.Trim());

                    MessageBox.Show("Correo enviado...","Profit Expansion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }


            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ubicar()
        {
            try
            {
                if (cboList.SelectedIndex > -1)
                {
                    Nuevo = false;
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        Int32 Id = P[cboList.SelectedIndex].id_evento;
                        var preg = context.Programas.Where(pr => pr.id_evento == Id).ToList();
                        if (preg.Count > 0)
                        {
                            programa = context.Programas.Where(pr => pr.id_evento == Id).FirstOrDefault();
                            CargarDatos();
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

        private void cboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ubicar();
        }

        private void btnAccesoProgramas_Click(object sender, EventArgs e)
        {
            FrmUp Fup = new FrmUp("Programas", programa.id_evento.ToString());
            Fup.Show();
        }            
    }
}