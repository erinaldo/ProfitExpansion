using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitContenedor
{
    public partial class FrmActivos : DevComponents.DotNetBar.Metro.MetroForm
    {
       
        public FrmActivos()
        {
            InitializeComponent();
        }
        public string co_usuario1;
        public string name1;
       
        public FrmActivos(string usuario)
        {
            InitializeComponent();
            co_usuario1 = usuario;
            name1 = nombre;
        }
        

        Boolean Nuevo = false;
        int a;
        pSeleccionarGIT_Activo_Result acti1 = new pSeleccionarGIT_Activo_Result();
       // pSeleccionarID_Asignacion_Result asig21 = new pSeleccionarID_Asignacion_Result();
        pBuscarActivoByName_Result buscar3 = new pBuscarActivoByName_Result();
        pBuscarActivobyName2_Result buscar4 = new pBuscarActivobyName2_Result();
        private string nombre;

        private void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                txtCo_activo.Enabled = false;
                 
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    var pubi = context.pObtenerTablaStr(txtCo_activo.Text.Trim(), "id_activo", p, "GIT_Activo").ToList();
                    

                    if (pubi.Count > 0)
                    {

                        acti1 = context.pSeleccionarGIT_Activo(pubi[0].Trim()).FirstOrDefault();
                        var asig21 = context.pSeleccionarID_Asignacion(pubi[0].Trim()).FirstOrDefault();
                        if (asig21 != null)
                        {
                            txtCo_activo.Text = acti1.id_activo;
                            txt_descrip.Text = acti1.descrip;
                            txt_modelo.Text = acti1.modelo;
                            txt_serial.Text = acti1.serial;
                            txt_valor.Text = acti1.valor.ToString();
                            var a = context.pBuscarAsignacionActivo(acti1.id_activo).FirstOrDefault().Value;

                            if (a == 0)
                            {
                                txt_asigna54.Text = "No tiene Asignación";
                                //if (MessageBox.Show("Desea asignarle este activo a un empleado","Profit Expansion", 
                                //    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                //{
                                //    FrmAsignacion Asi = new FrmAsignacion(acti1.id_activo.Trim());
                                //    Asi.Show();
                                //}
                                //else
                                //{
                                //    DialogResult = DialogResult.None;
                                //}
                            }

                            else if (asig21.status.Trim() == "L")
                            {
                                MessageBox.Show("Este activo esta asignado actualmente a un empleado liquidado.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            else
                            {
                                txt_asigna54.Text = asig21.nombre_completo.Trim().ToString();
                            }
                            cbo_Cat.SelectedValue = acti1.id_cat_activo;
                            cbo_ubic.SelectedValue = acti1.co_ubic;
                            date_fec_adqui.Value = Convert.ToDateTime(acti1.fecha_adq);
                            date_fec_regis.Value = Convert.ToDateTime(acti1.fecha_reg);
                            date_fec_reti.Value = acti1.fecha_reti.Value;
                            var u = from ptt in context.GIT_Activo
                                    where ptt.id_activo == txtCo_activo.Text
                                    select ptt.status;

                            if (u.FirstOrDefault().ToString() == "DISPONIBLE")
                            {
                                chk_disponible.CheckState = CheckState.Checked;
                            }
                            else
                            {
                                chk_disponible.CheckState = CheckState.Unchecked;

                            }
                            var uu = context.pValidarAsignacion(asig21.nombre_completo.Trim()).Count();
                            if (uu < 1)
                            {
                                lbl_supervi.Visible = true;
                                lbl_supervi.ForeColor = Color.Red;
                                // MessageBox.Show("El Usuario no tiene supervisor Asignado.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                lbl_supervi.Visible = false;
                            }

                            //var Imagen = ImagenBD.BytesToImage(Usuario.ilustracion)
                        }
                        else if (asig21 == null)
                        {
                            MessageBox.Show("Este activo no tiene asignacion actualmente.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                           // MessageBox.Show("Este activo esta asignado actualmente a un empleado liquidado.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void LimpiarControles()
        {

      //    txtCo_activo.Text = "";
            txt_descrip.Text = "";
            txt_modelo.Text = "";
            txt_serial.Text = "";
            txt_valor.Text = "";
            txt_asigna54.Text = "0";
            cbo_Cat.SelectedItem = "";
            cbo_ubic.SelectedItem = "";
            date_fec_adqui.ResetValue();
            date_fec_regis.ResetValue();
            date_fec_regis.Value = DateTime.Now;
            date_fec_reti.ResetValue();
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

        internal void txtBuscar_LostFocus()
        {
            throw new NotImplementedException();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            Navegar(3);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var context = new Profit_RGEntities())
            {
                txtCo_activo.Enabled = false;
                txtCo_activo.Text = context.pContadorActivo().FirstOrDefault ();

                LimpiarControles();
                Nuevo = true;
              //  txtCo_activo.Enabled = true;
                txt_descrip.Focus();
                //txtCo_activo.Enabled = false;
            }
        }
        /// <summary>
        /// Metodo que se encargar de guardar los activos en la tabla GIT_Activos en la base de datos Profit_RG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Guardar(Boolean Tipo1)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    if (Tipo1 == true)
                    {
                        var h = context.GIT_Activo.Select(x => x.serial).ToList();
                        if (date_fec_adqui.Value > date_fec_regis.Value)
                            MessageBox.Show(this, "La fecha de adquisicion no puede ser mayor a la de registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (txt_serial.Text == h.ToString ())
                        {
                            MessageBox.Show(this, "Este Activo ya esta registrado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                                            
                        else
                        {
                           context.pGIT_ActivoInsertar(txtCo_activo.Text.Trim(), txt_descrip.Text.Trim(), txt_serial.Text.Trim(),
                           txt_modelo.Text.Trim(), Convert.ToDecimal(txt_valor.Text.Trim()), date_fec_regis.Value, date_fec_adqui.Value, date_fec_reti.Value,
                           cbo_ubic.SelectedValue.ToString(), cbo_Cat.SelectedValue.ToString());
                           MessageBox.Show(this, "Los datos fueron registrados exitosamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if(date_fec_adqui.Value > date_fec_regis.Value)
                            MessageBox.Show(this, "La fecha de adquisicion no puede ser mayor a la de registro.", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            context.pGIT_ActivoActualizar(txtCo_activo.Text.Trim(), txt_descrip.Text.Trim(), txt_serial.Text.Trim(),
                                txt_modelo.Text.Trim(), Convert.ToDecimal(txt_valor.Text.Trim()), date_fec_regis.Value, date_fec_adqui.Value, date_fec_reti.Value,
                                cbo_ubic.SelectedValue.ToString().Trim (), cbo_Cat.SelectedValue.ToString(), acti1.Rowguid);
                            if (chk_disponible.CheckState == CheckState.Checked)
                            {
                                context.pCambiarStatusActivo(txtCo_activo.Text.Trim());
                            }
                            else
                            {
                                context.pCambiarStatusActivo2(txtCo_activo.Text.Trim());
                            }
                            
                            
                            MessageBox.Show(this, "Los datos fueron registrados exitosamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (EntityException ex1)
            {
                MessageBox.Show(this, "Revise si el Serial no esta duplicado o esta insertando algun dato de manera incorrecta.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(this, ex1.InnerException.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar(Nuevo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea eliminar este registro?", "Profit Contenedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        context.pGIT_ActivoEliminar(acti1.Rowguid);
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

        public void FrmActivos_Load(object sender, EventArgs e)
        {
            try
            {
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    
                    cbo_Cat.DataSource = context.GIT_Catalogo_Activo.ToList();
                    cbo_Cat.DisplayMember = "descripcion";
                    cbo_Cat.ValueMember = "id_cat_activo";

                    cbo_ubic.DataSource = context.GIT_Ubicaciones.ToList();
                    cbo_ubic.DisplayMember = "descrip";
                    cbo_ubic.ValueMember = "co_ubic";

                    lbl_supervi.Visible = false;

                    if (co_usuario1 == "JAC" || co_usuario1 == "JP")
                    {
                        btnEliminar.Enabled = true;
                    }
                    else
                    {
                        btnEliminar.Enabled = false;
                    }
                    
                        AutoCompleteStringCollection buscar1 = new AutoCompleteStringCollection();
                        List<GIT_Activo> Li = context.GIT_Activo.ToList();
                        foreach (var item in Li)
                        {
                            buscar1.Add(item.id_activo.Trim());
                        }
                        txtBuscar.AutoCompleteCustomSource = buscar1;
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
          //  Navegar(0);
        }
        
        public void btn_asign12_Click(object sender, EventArgs e)
        {
            FrmAsignacion ASG = new FrmAsignacion(acti1.id_activo.Trim());
            ASG.Show();
           //   txtCo_activo.Text = ASG.grddatos1.CurrentRow.Cells["Activo"].ToString();
           // using (Profit_RGEntities context = new Profit_RGEntities())
           // {
           //     ASG.grddatos1.DataSource = context.pSeleccionarGIT_Asignaciones().ToList ();
           // }
                
        }

        private void btn_movES_Click(object sender, EventArgs e)
        {
            FrmMovES mov12 = new FrmMovES(txtCo_activo.Text);
            mov12.Show();
        }

        private void btn_mtto_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMantActivo lli = new FrmMantActivo(acti1.id_activo.Trim());
                lli.Show();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(this, ex1.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
          //  txtCo_activo.Text = lli.grddatos2.CurrentRow.Cells["Activo"].Value.ToString();
        }

        private void txt_asigna54_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_asigna54.Text != "")
                {

                }
                else
                {
                    if (txt_asigna54.Text != "0")
                    {
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            // context.pActualizarGIT_id_asign(acti1.id_activo, asig21.id_asign);
                            txt_asigna54.Text = context.pSeleccionarID_Asignacion(acti1.id_activo.Trim()).FirstOrDefault().nombre_completo;
                        }
                    }
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(this, ex1.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            FrmPrintActivos prin1 = new FrmPrintActivos();
            prin1.Show();
        }
        /// <summary>
        /// Mostrar el Formulario: FrmSearch que se encarga de refinar la busqueda de un activo por Catalogo y por Empresa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem2_Click(object sender, EventArgs e)
        {
            FrmSearch sear = new FrmSearch();
            sear.ShowDialog();
            Buscar(sear.activo23);

           // this.Hide();
        }
        public void Buscar(string U)
        {
            try
            {
                
                using (var context = new Profit_RGEntities())
                {
                    // FrmSearch SE = new FrmSearch();

                    //nombre = SE.list_empleados.SelectedItem.Value.ToString();
                    // pBuscarActivobyName2_Result JAC1 = new pBuscarActivobyName2_Result();
                   // var P = context.pBuscarActivo(SE.cbo_empresa.SelectedValue.ToString(), SE.cbo_catalogo.SelectedValue.ToString()).ToList();
                    var pubi = context.GIT_Activo.Where(c => c.id_activo.Trim() == U.Trim()).ToList();
                    if (pubi.Count > 0)
                    {

                        acti1 = context.pSeleccionarGIT_Activo(pubi[0].id_activo.Trim().ToUpper ()).FirstOrDefault();
                        //asig21 = context.pSeleccionarID_Asignacion(pubi[0].Trim()).FirstOrDefault();
                        txtCo_activo.Text =acti1.id_activo;
                        txt_descrip.Text = acti1.descrip;
                        txt_modelo.Text = acti1.modelo;
                        txt_serial.Text = acti1.serial;
                        txt_valor.Text = acti1.valor.ToString();
                        var a = context.pBuscarAsignacionActivo(acti1.id_activo).FirstOrDefault().Value;
                        if (a == 0)
                        {
                            txt_asigna54.Text = "No tiene Asignación";
                            if (MessageBox.Show("Desea asignarle este activo a un empleado", "Profit Expansion",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                FrmAsignacion Asi = new FrmAsignacion(acti1.id_activo.Trim());
                                Asi.Show();
                            }
                            else
                            {
                                DialogResult = DialogResult.None;
                            }
                        }
                        else
                        {
                            var o = context.pSeleccionarID_Asignacion(pubi[0].id_activo).FirstOrDefault().nombre_completo;
                            txt_asigna54.Text = o.Trim ().ToString();
                        }
                        
                        cbo_Cat.SelectedValue = acti1.id_cat_activo;
                        cbo_ubic.SelectedValue = acti1.co_ubic;
                        date_fec_adqui.Value = Convert.ToDateTime (acti1.fecha_adq);
                        date_fec_regis.Value = Convert.ToDateTime (acti1.fecha_reg);
                        date_fec_reti.Value = acti1.fecha_reti.Value;

                        
                        var u = from ptt in context.GIT_Activo
                        where ptt.id_activo == txtCo_activo.Text
                        select ptt.status;

                        if (u.FirstOrDefault().ToString() == "DISPONIBLE")
                        {
                            chk_disponible.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            chk_disponible.CheckState = CheckState.Unchecked;

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
        /// <summary>
        /// Programacion del Reporte: RepAutorizacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem3_Click(object sender, EventArgs e)
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
                comd.CommandText = "pSeleccionarEmpleadobyActivo";

                comd.Parameters.Add("@id_activo", SqlDbType.NChar);
                comd.Parameters[0].Value = txtCo_activo.Text.Trim();



                SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                sqlAdapter.SelectCommand = comd;
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "pSeleccionarEmpleadobyActivo");

                FrmRep Fr = new FrmRep(ds, "RepAutorizacion.rpt", false);
                Fr.Show();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Programacion del Reporte: RepEtiqueta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem4_Click(object sender, EventArgs e)
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
            comd.CommandText = "pRepEtiqueta";

            comd.Parameters.Add("@id_activo", SqlDbType.NChar);
            comd.Parameters[0].Value = txtCo_activo.Text.Trim();



            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            sqlAdapter.SelectCommand = comd;
            DataSet ds = new DataSet();
            sqlAdapter.Fill(ds, "pRepEtiqueta");

            CrystalDecisions.CrystalReports.Engine.ReportDocument oRpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
           
            string Filename = @"\\172.16.1.4\Profit\Publicaciones\Profit Expansion\Reportes\RepEtiqueta.rpt";
                
            oRpt.Load(Filename);

            string NombreImpresora = "";//Donde guardare el nombre de la impresora por defecto

            //Busco la impresora por defecto
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                PrinterSettings a = new PrinterSettings();
                a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
                if (a.IsDefaultPrinter)
                {
                    NombreImpresora = PrinterSettings.InstalledPrinters[i].ToString();
                }
            }

            oRpt.SetDataSource(ds);//Asigno la fuente de datos a mi reporte.
            oRpt.PrintOptions.PrinterName = NombreImpresora;//Asigno la impresora
            oRpt.PrintToPrinter(1, false, 0, 0);//Imprimo 1 copias

            //FrmRep Fr = new FrmRep(ds, "RepEtiqueta.rpt", false);
            //Fr.Show();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            FrmConfi_Logica COL = new FrmConfi_Logica(acti1.id_activo);
            COL.Show();
        }

        private void bnt_conf_logic_Click(object sender, EventArgs e)
        {
            FrmConfi_Logica LOGI = new FrmConfi_Logica(acti1.id_activo);
            LOGI.Show();
        }

        public void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar(txtBuscar.Text);
        }
        public void txtBuscar_LostFocus(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }
    }
 }

