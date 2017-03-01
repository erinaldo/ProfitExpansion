using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ProfitContenedor;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity.Core;
using System.Diagnostics;

namespace ProfitContenedor
{
    public partial class FrmCont : DevComponents.DotNetBar.Metro.MetroForm
    {
        List<pSeleccionarReng_emb_Result> detalle = new List<pSeleccionarReng_emb_Result>();

        public FrmCont()
        {
            InitializeComponent();
        }
        
        Boolean Nuevo = false;
        byte[] Validador;
        
        private void FrmCont_Load(object sender, EventArgs e)
        {
            txtViaje.Value = 0;
            Navegar(3);
            grdDatos.AutoGenerateColumns = false;

            
            
        }

        private void Navegar(int p)
        {
            try
            {
                Nuevo = false;
                //txtBL.Enabled = false;

                grdDatos.AutoGenerateColumns = false;
                
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    pSeleccionarEmbarque_Result embarque = new pSeleccionarEmbarque_Result();
                    var pemb = context.pObtenerTablaInt(txtViaje.Value, "nro_viaje", p, "Embarques").ToList();
                    if (pemb.Count>0)
                    {
                        embarque = context.pSeleccionarEmbarque(pemb[0].Value).FirstOrDefault();
                        txtViaje.Value = embarque.nro_viaje;
                        txtC20p.Value = embarque.c20p;
                        txtC40p.Value = embarque.c40p;
                        txtBL.Text = embarque.bl.Trim();
                        txtCo_consig.Text = embarque.co_consig.Trim();
                        txtDes_consig.Text = embarque.des_consig.Trim();
                        txtCo_naviera.Text = embarque.co_naviera.Trim();
                        txtNavi_des.Text = embarque.navi_des.Trim();

                        lnkTrack.Links.Clear();
                        lnkTrack.Links.Add(0, 120, new Uri("https://www.cma-cgm.com/ebusiness/tracking/search?SearchBy=BL&Reference=" + txtBL.Text.Trim() + "&search=Search"));

                        txtCo_shipper.Text = embarque.co_shipper.Trim();
                        txtShipper_des.Text = embarque.shipper_des.Trim();
                        txtPto_Origen.Text = embarque.pto_sal.Trim();
                        txtFec_sal.Value = embarque.fecha_sal;
                        txtPto_destino.Text = embarque.pto_lleg.Trim();
                        txtFec_lleg.Value = embarque.fecha_lleg;
                        Validador = embarque.validador;
                        if (txtFec_lleg.Value.Date < System.DateTime.Now.Date)
                            labelX9.Text = "[0] dias restantes...";
                        else
                            labelX9.Text = "["+(txtFec_lleg.Value.Date - System.DateTime.Now.Date).Days.ToString()+"] dias restantes...";
                        CargarDetalle(context, pemb[0].Value);
                    }
                    else
                    {
                        if (embarque.validador != null)
                            LimpiarControles();
                        else
                            Validador = null;
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

        private void CargarDetalle(Profit_RGEntities context, Int32 Nro_viaje)
        {
            detalle = context.pSeleccionarReng_emb(Nro_viaje).ToList();
            grdDatos.DataSource = detalle;
        }

        private void LimpiarControles()
        {
            txtViaje.Value = 0;
            txtC20p.Value = 0;
            txtC40p.Value = 0;
            txtBL.Text = "";
            txtCo_consig.Text = "";
            txtDes_consig.Text = "";
            txtPto_Origen.Text = "";
            txtFec_sal.Value = DateTime.Today;
            txtPto_destino.Text = "";
            txtFec_lleg.Value = DateTime.Today;
            txtCo_naviera.Text = "";
            txtNavi_des.Text = "";
            txtCo_shipper.Text = "";
            txtShipper_des.Text = "";
            Validador = null;
            grdDatos.DataSource = "";
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
            LimpiarControles();
            Nuevo = true;
            //txtBL.Enabled = true;
            txtBL.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Nuevo == true)
                {
                    if (superValidator1.Validate() == true)
                    {
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            context.pInsertarEmbarque(txtBL.Text.Trim(), txtFec_sal.Value, 
                                                        txtFec_lleg.Value, txtCo_consig.Text.Trim(),txtDes_consig.Text.Trim(),
                                                        txtPto_Origen.Text.Trim(), txtPto_destino.Text.Trim(),
                                                        txtCo_naviera.Text.Trim(), txtCo_shipper.Text.Trim(),txtShipper_des.Text.Trim(),txtC20p.Value,txtC40p.Value);
                        }
                        Navegar(5);

                    }
                }
                else
                {
                    if (superValidator1.Validate() == true)
                    {
                        using (Profit_RGEntities context = new Profit_RGEntities())
                        {
                            context.pActualizarEmbarque(txtBL.Text.Trim(), txtFec_sal.Value,
                                                        txtFec_lleg.Value, txtCo_consig.Text.Trim(), txtDes_consig.Text.Trim(),
                                                        txtPto_Origen.Text.Trim(), txtPto_destino.Text.Trim(),
                                                        txtCo_naviera.Text.Trim(), txtCo_shipper.Text.Trim(),txtShipper_des.Text.Trim(),
                                                        txtC20p.Value,txtC40p.Value,Validador);
                        }
                        Navegar(5);
                    }
                }
                MessageBox.Show(this, "Se ha guardado la informacion satisfactoriamente.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if(MessageBoxEx.Show("Desea eliminar el registro?","Profit Expansion",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)== System.Windows.Forms.DialogResult.Yes)
                using (Profit_RGEntities context = new Profit_RGEntities())
                {
                    context.pEliminarEmbarque(Validador);
                    Navegar(2);
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

        private void txtCo_consig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FrmBuscar Fe = new FrmBuscar(txtCo_consig,txtDes_consig,"Empresa");
                Fe.Show();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (txtViaje.Value == 0)
            {
                MessageBoxEx.Show("Debe guardar el registro del contenedor.", "Profit Expansion",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                FrmODC Fo = new FrmODC(txtViaje.Value, grdDatos, txtCo_consig.Text.Trim());
                Fo.Show();

            }
        }

        private void txtCo_consig_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCo_consig.Text.Trim().Length > 0)
                {
                    //ProfitDsTableAdapters.empresasTableAdapter emp = new ProfitDsTableAdapters.empresasTableAdapter();
                    //ProfitDs.empresasDataTable Dt = new ProfitDs.empresasDataTable();
                    //emp.Fill(Dt);
                    List<Empresa> Dt = new List<Empresa>();
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        Dt = context.Empresas.ToList();
                    }
                    var Emp = Dt.FirstOrDefault(c => c.co_empresa.Trim() == txtCo_consig.Text.Trim());
                    if (Emp == null)
                    {
                        txtDes_consig.Text = "NO ENCONTRADO";
                    }
                    else
                    {
                        txtDes_consig.Text = Emp.des_emp.Trim();
                    }
                }
            }
            catch (DataException ex0)
            {
                MessageBox.Show(ex0.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (MessageBox.Show("Desea eliminar este articulo del embarque?", "Profit Administrativo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        if (grdDatos.RowCount > -1 && grdDatos.CurrentCell.RowIndex > -1)
                        {
                            System.Guid? R = new Guid(grdDatos[6, grdDatos.CurrentCell.RowIndex].Value.ToString());
                            context.pEliminarReng_emb(R);
                        }
                        CargarDetalle(context, txtViaje.Value);
                    }
                }

            }
            catch (DataException ex0)
            {
                MessageBox.Show(ex0.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFec_sal_Leave(object sender, EventArgs e)
        {
            txtFec_lleg.Value = txtFec_sal.Value.AddDays(45);
        }

        private void btnEdoCta_Click(object sender, EventArgs e)
        {
            FrmEdoCta Fedc = new FrmEdoCta(detalle);
            Fedc.Show();
        }

        private void txtCo_shipper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (txtCo_consig.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe elegir una empresa.", "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCo_consig.Focus();
                }
                else
                {
                    FrmBuscar Fe = new FrmBuscar(txtCo_shipper, txtShipper_des, "Shipper", txtCo_consig.Text.Trim());
                    Fe.Show();
                }
            }
        }

        private void txtCo_shipper_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCo_shipper.Text.Trim().Length > 0)
                {
                    pSeleccionarProv_Result shipper = new pSeleccionarProv_Result();
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        shipper = context.pSeleccionarProv(txtCo_consig.Text.Trim(), txtCo_shipper.Text.Trim()).FirstOrDefault();
                    }
                    if (shipper == null)
                    {
                        txtShipper_des.Text = "NO ENCONTRADO";
                    }
                    else
                    {
                        txtShipper_des.Text = shipper.prov_des.Trim();
                    }
                }
            }
            catch (DataException ex0)
            {
                MessageBox.Show(ex0.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCo_naviera_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FrmBuscar Fe = new FrmBuscar(txtCo_naviera, txtNavi_des, "Naviera");
                Fe.Show();
            }
        }

        private void txtCo_naviera_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCo_naviera.Text.Trim().Length > 0)
                {
                    pSeleccionarNaviera_Result naviera = new pSeleccionarNaviera_Result();
                    using (Profit_RGEntities context = new Profit_RGEntities())
                    {
                        naviera = context.pSeleccionarNaviera(txtCo_naviera.Text.Trim()).FirstOrDefault();
                    }
                    if (naviera == null)
                    {
                        txtNavi_des.Text = "NO ENCONTRADO";
                    }
                    else
                    {
                        txtNavi_des.Text = naviera.navi_des.Trim();
                    }
                }
            }
            catch (DataException ex0)
            {
                MessageBox.Show(ex0.InnerException.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            Navegar(5);
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
                comd.CommandText = "pRepEmbarque";

                comd.Parameters.Add("@Nro_viaje", SqlDbType.Int);
                comd.Parameters[0].Value = Convert.ToInt32(txtViaje.Text);
                
                SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                sqlAdapter.SelectCommand = comd;
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "pRepEmbarque");

                FrmRep Fr = new FrmRep(ds, "RepEmbarques.rpt",false);
                Fr.Show();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void lnkTrack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(e.Link.LinkData.ToString());
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }    
    }
}
