using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using CrystalDecisions;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace ProfitContenedor
{
    public partial class FrmRep : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmRep()
        {
            InitializeComponent();
            
        }

        DataSet Dsrep = new DataSet();
        String Nr;
        bool Print;

        public FrmRep(DataSet DataSet,String Nombre_reporte,bool Imprimir)
        {
            Dsrep = DataSet;
            Nr = Nombre_reporte;
            Print = Imprimir;
            InitializeComponent();
        }

        private void FrmRep_Load(object sender, EventArgs e)
        {
            try
            {
                string Filename = "\\\\172.16.1.4\\Profit\\Publicaciones\\Profit Expansion\\Reportes\\" + Nr.Trim();
                oRpt.Load(Filename);
                oRpt.SetDataSource(Dsrep);
                crystalReportViewer1.ReportSource = oRpt;
                if (Print == true)
                {
                    Imprimir(Dsrep);
                    this.Close();
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Profit Expansion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Imprimir(DataSet Dt)
        {
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

            oRpt.SetDataSource(Dt);//Asigno la fuente de datos a mi reporte.
            oRpt.PrintOptions.PrinterName = NombreImpresora;//Asigno la impresora
            oRpt.PrintToPrinter(2, false, 0, 0);//Imprimo 2 copias
        }
    }
}