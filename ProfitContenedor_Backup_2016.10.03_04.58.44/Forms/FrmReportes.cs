using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Printing;
using CrystalDecisions;
using System.Net.Mail;
using System.Net.Mime;
using System.Linq;
using DevComponents.DotNetBar.Controls;

namespace ProfitContenedor
{
    public partial class FrmReportes : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        string StoreProcedure = "";

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //if (cboReporte.SelectedIndex > -1)
                //Imprimir(cboReporte.Text.ToString());
        }

        private static void Imprimir(string Funcion, string Reporte)
        {
            try
            {
                string returnValue = null;

                // Look for the name in the connectionStrings section.
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["ProfitContenedor.Properties.Settings.Profit_RGConnectionString"];

                // If found, return the connection string.
                if (settings != null)
                    returnValue = settings.ConnectionString;

                //SqlConnection sqlConn = new SqlConnection("Server=172.16.1.4;uid=profit;password=profit;initial catalog=Profit_RG;");
                SqlConnection sqlConn = new SqlConnection(returnValue);

                SqlCommand comd;
                comd = new SqlCommand();
                comd.Connection = sqlConn;
                comd.CommandType = CommandType.StoredProcedure;
                comd.CommandText = Funcion;

                using(Profit_RGEntities context = new Profit_RGEntities())
	            {
		            var filtros = context.Filtros.Where(f => f.cod_rep == Reporte).ToList();
                    foreach (var item in filtros)
                    {
                        switch (item.tipo.Trim())
                        {
                            case "Char":
                                comd.Parameters.Add(item.nombre_par, SqlDbType.Char);
                                //comd.Parameters[comd.Parameters.Count-1].Value = Identificador;
                                break;
                        }
                    }
	            }
                

                

                



                SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                sqlAdapter.SelectCommand = comd;
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "pRepResumenVentasGerencial");

                FrmRep Fr = new FrmRep(ds, "RepResumenVentasGerencial.rpt", false);
                Fr.ShowDialog();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnExportar_Click(object sender, EventArgs e)
        //{
        //    ExportaryEnviar();
        //}

        //private void ExportaryEnviar()
        //{
        //    try
        //    {
        //        string Identificador = cboGrupo.Text.ToString();
        //        string returnValue = null;

        //        // Look for the name in the connectionStrings section.
        //        ConnectionStringSettings settings =
        //            ConfigurationManager.ConnectionStrings["ProfitContenedor.Properties.Settings.Profit_RGConnectionString"];

        //        // If found, return the connection string.
        //        if (settings != null)
        //            returnValue = settings.ConnectionString;

        //        //SqlConnection sqlConn = new SqlConnection("Server=172.16.1.4;uid=profit;password=profit;initial catalog=Profit_RG;");
        //        SqlConnection sqlConn = new SqlConnection(returnValue);

        //        SqlCommand comd;
        //        comd = new SqlCommand();
        //        comd.Connection = sqlConn;
        //        comd.CommandType = CommandType.StoredProcedure;
        //        comd.CommandText = "pRepResumenVentasGerencial";

        //        comd.Parameters.Add("@Grupo", SqlDbType.Char);
        //        comd.Parameters[0].Value = Identificador;

        //        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
        //        sqlAdapter.SelectCommand = comd;
        //        DataSet ds = new DataSet();
        //        sqlAdapter.Fill(ds, "pRepResumenVentasGerencial");

        //        string Filename = "\\\\172.16.1.4\\Profit\\Publicaciones\\Profit Expansion\\Reportes\\RepResumenVentasGerencial.rpt";
        //        CrystalDecisions.CrystalReports.Engine.ReportDocument oRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
        //        oRpt.Load(Filename);
        //        oRpt.SetDataSource(ds);

        //        string ArchPDF = "\\\\172.16.1.4\\Profit\\Publicaciones\\Profit Expansion\\Reportes\\PDF\\" + Identificador.TrimEnd() + System.DateTime.Now.ToFileTime() + ".pdf";
        //        oRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, ArchPDF.TrimEnd());

        //        switch (Identificador)
        //        {
        //            case "STARGAS":
        //                Enviar("gerencia@stargas.com.ve", "omacazana@stargas.com.ve", "profitexpansion@stargas.com.ve", "J311377140", 587, "smtp.gmail.com", true, Identificador, ArchPDF);
        //                break;
        //            case "OVERLAND":
        //                Enviar("gerencia@stargas.com.ve", "l.gutierrez@overlanddevenezuela.com", "profitexpansion@stargas.com.ve", "J311377140", 587, "smtp.gmail.com", true, Identificador, ArchPDF);
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    catch (Exception ex1)
        //    {
        //        MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        public static bool Enviar(string Gerencia, string Gerente, string Remitente, string Clave, Int32 Puerto, string Servidor, bool Ssl, string Grupo, string ArchivoPDF)
        {
            
            //Ruta de archivo adjunto (Si lo lleva)
            string PathFile = ArchivoPDF;

            //Creo el mensaje del mail.
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            //Agrego los destinatarios, pueden ir varios
            if (Gerencia.Trim().Length > 0)
                msg.To.Add(Gerencia.Trim());
            if (Gerencia.Trim().Length > 0)
                msg.CC.Add(Gerente.Trim());

            //Agrego la direccion del que manda el email, puede ser falsa o verdadera, pero si es falsa puede que el servidor de correo lo detecte como spam, tambien depende de las credenciales que se ponen mas abajo
            msg.From = new MailAddress(Remitente.Trim(), "Profit Expansion", System.Text.Encoding.UTF8);

            string Mensaje;

            //Pongo el asunto
            msg.Subject = "Resumen de Ventas Gerencial " + Grupo.TrimEnd() + " " + System.DateTime.Now.ToString();

            //El tipo de codificacion del Asunto 
            msg.SubjectEncoding = System.Text.Encoding.UTF8;

            Mensaje = "Resumen de Ventas Diario...";

            //Escribo el mensaje Y su codificacion
            msg.Body = Mensaje;

            msg.BodyEncoding = System.Text.Encoding.UTF8;

            //Especifico si va ha ser interpertado con HTML
            msg.IsBodyHtml = true;

            //Agrego el archivo que puse en la ruta anterior "PathFile", y su tipo.
            Attachment Data = new Attachment(PathFile, MediaTypeNames.Application.Pdf);

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
            try
            {
                //Envio el mensaje
                client.Send(msg);
                MessageBox.Show("Correo enviado..." + Environment.NewLine + "A: " + (Gerencia.Trim().Length == 0 ? "NO DISPONIBLE" : Gerencia.Trim()) +
                    Environment.NewLine + "CC: " + (Gerente.Trim().Length == 0 ? "NO DISPONIBLE" : Gerente.Trim()), "Profit Expansion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    //var grupos = context.Emp_asoc.Select(emp => emp.grupo).Distinct().ToList();
                    //cboGrupo.DataSource = grupos;
                    //cboGrupo.DisplayMember = "grupo";
                    var reportes = context.Reportes.ToList();
                    cboReporte.DataSource = reportes;
                    cboReporte.DisplayMember = "titulo";
                    cboReporte.ValueMember = "cod_rep";

                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboReporte_Click(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var filtros = context.Filtros.Where(f => f.cod_rep == cboReporte.SelectedValue.ToString()).ToList();
                    var reporte = context.Reportes.Where(r => r.cod_rep.Trim() == cboReporte.SelectedValue.ToString().Trim()).First();
                    StoreProcedure = reporte.funcion.Trim();


                    foreach (var item in filtros)
                    {
                        switch (item.tipo.Trim())
                        {
                            case "Char" :
                                TextBox F1 = new System.Windows.Forms.TextBox();
                                F1.Location = new System.Drawing.Point(cboReporte.Left, cboReporte.Top+30);
                                F1.Name = "F1";
                                F1.Size = new System.Drawing.Size(88, 21);
                                F1.TabIndex = 0;
                                F1.Text = "";
                                Controls.Add(F1);

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
    }
}