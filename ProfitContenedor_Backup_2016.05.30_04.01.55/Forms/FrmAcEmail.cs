using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
using System.Data.Entity.Core;
using System.Configuration;
using System.Data.SqlClient;

namespace ProfitContenedor
{
    public partial class FrmAcEmail : DevComponents.DotNetBar.Metro.MetroForm
    {
        string Archivo = "";
        List<Acom> ListaAc = new List<Acom>();
        string Gr;
        string Al;
        DateTime De;
        DateTime Ha;
        //string Li;
        string Sl;
        string Cl;
        string Ct;
        string Pr;

        public FrmAcEmail()
        {
            InitializeComponent();
        }

        public FrmAcEmail(List<Acom> Ac, string Grupo, string Almacen,DateTime Desde,DateTime Hasta,string Co_lin = null,string Co_subl = null, string Co_color = null, string Co_cat = null, string Cod_proc = null)
        {
            ListaAc = Ac;
            Gr = Grupo;
            Al = Almacen;
            De = Desde;
            Ha = Hasta;
            Cl = Co_lin;
            Sl = Co_subl;
            Cl = Co_color;
            Ct = Co_cat;
            Pr = Cod_proc;

            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea enviar el reporte por correo?", "Profit Expansion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {

                    //timer1_Tick(sender, e);
                    //timer1.Start();
                    //timer1.Enabled = true;
                    progressBarX1.Visible = true;
                    lblComentario.Visible = true;
                    lblComentario.Text = "Generando archivo...";

                    GenerarArchivo(true);

                    List<pSeleccionarParametros_Result> param = new List<pSeleccionarParametros_Result>();
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        param = context.pSeleccionarParametros().ToList();
                    }

                    lblComentario.Text = "Enviando correo...";

                    EnviarCorreo("Purchase Order",
                                    txtPara.Text.Trim(),
                                    "",
                                    "",
                                    param[0].email.Trim(),
                                    param[0].password.Trim(),
                                    param[0].puerto,
                                    param[0].servidor.Trim(),
                                    param[0].ssl,
                                    "", Archivo, "PDF");

                    lblComentario.Visible = false;
                    //timer1.Stop();
                    //timer1.Enabled = false;
                    progressBarX1.Visible = false;
                    MessageBox.Show("Correo enviado...", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                } 
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
                pSeleccionarParametros_Result p = new pSeleccionarParametros_Result();
                //Programa e = new Programa();
                pSeleccionarReportes_Result r = new pSeleccionarReportes_Result();
                //List<pSeleccionarValores_prog_Result> v = new List<pSeleccionarValores_prog_Result>();
                //string returnValue = null;

                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    p = context.pSeleccionarParametros().FirstOrDefault();
                    //e = context.Programas.Where(ev => ev.id_evento == Id_evento).FirstOrDefault();
                    r = context.pSeleccionarReportes("006").FirstOrDefault();
                    //v = context.pSeleccionarValores_prog(e.id_evento).ToList();
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

        void EnviarCorreo(string Asunto, string To, string CC, string CCO, string Remitente, string Clave, Int32 Puerto, string Servidor, bool Ssl, string Grupo, string Archivo, string Tipo)
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
                    default:
                    case "PDF":
                        Data = new Attachment(PathFile, MediaTypeNames.Application.Pdf);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarX1.Value += 25;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}