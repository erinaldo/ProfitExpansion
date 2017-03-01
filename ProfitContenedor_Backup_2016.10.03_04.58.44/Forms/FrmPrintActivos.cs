using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitContenedor
{
    public partial class FrmPrintActivos : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmPrintActivos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Configuracion del boton que abre el reporte: RepEmpleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton1_Click(object sender, EventArgs e)
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
                comd.CommandText = "pRepEmpleados";


                SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                sqlAdapter.SelectCommand = comd;
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "pRepEmpleados");

                FrmRep Fr = new FrmRep(ds, "RepEmpleados.rpt", false);
                Fr.Show();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Configuracion del boton que abre el reporte: RepUbicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButton2_Click(object sender, EventArgs e)
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
                comd.CommandText = "pRepUbicacion";


                SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                sqlAdapter.SelectCommand = comd;
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "pRepUbicacion");

                FrmRep Fr = new FrmRep(ds, "RepUbicacion.rpt", false);
                Fr.Show();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
