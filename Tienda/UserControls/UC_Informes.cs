using Microsoft.Reporting.WinForms;
using Tienda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tienda.UserControls
{
    public partial class UC_Informes : UserControl
    {
        public UC_Informes()
        {
            InitializeComponent();
        }

        // Realizo el informe
        private void btnGenerarInformeClientes_Click(object sender, EventArgs e)
        {

            // Cargo resultados
            DataTable dataTableResultadosClientes = AdminModel.getClientes();
            // Configura el ReportViewer con los datos de clientes y la ruta del informe de clientes
            ConfigurarReportViewer(@"../../ReportClientes.rdlc", "DataSetClientes", dataTableResultadosClientes);

        }

       

        private void btnGenerarInformeProductos_Click(object sender, EventArgs e)
        {         
            // Cargo resultados
             DataTable dataTableResultadosProductos = AdminModel.getProductos();
            // Configura el ReportViewer con los datos de productos y la ruta del informe de productos
            ConfigurarReportViewer(@"../../ReportIProductos.rdlc", "DataSetProductos", dataTableResultadosProductos);
        }


        private void ConfigurarReportViewer(string reportPath, string nombreDataSet, DataTable dataTable)
        {
            // Obtiene el directorio base de la aplicación
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Construye la ruta completa del informe combinando el directorio base y la ruta relativa del informe
            string reportFullPath = Path.Combine(basePath, reportPath);

            // Establece la ruta del informe
            reportViewerGeneral.LocalReport.ReportPath = reportFullPath;

            // Borra cualquier origen de datos existente del ReportViewer para limpiarlo
            reportViewerGeneral.LocalReport.DataSources.Clear();

            // Crea un nuevo ReportDataSource utilizando el DataTable proporcionado
            ReportDataSource reportDataSource = new ReportDataSource(nombreDataSet, dataTable);

            // Agrega el nuevo ReportDataSource al ReportViewer para que los datos se muestren en el informe
            reportViewerGeneral.LocalReport.DataSources.Add(reportDataSource);

            // Refresca el informe para que se actualicen los cambios y se muestren los nuevos datos
            reportViewerGeneral.RefreshReport();
        }



        private void pbExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
