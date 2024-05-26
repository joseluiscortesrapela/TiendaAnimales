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

namespace Tienda.UserControls
{
    public partial class UC_Informes : UserControl
    {
        public UC_Informes()
        {
            InitializeComponent();
        }

        // Realizo el informe
        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {

            // Cargo resultados
            DataTable dataTableResultadosClientes = AdminModel.getClientes();
            // Borra cualquier origen de datos existente del ReportViewer para limpiarlo
            reportViewerInforme.LocalReport.DataSources.Clear();
            // Crea un nuevo ReportDataSource utilizando el DataTable que contiene los resultados de la consulta
            ReportDataSource reportDataSource = new ReportDataSource("DataSetClientes", dataTableResultadosClientes);
            // Agrega el nuevo ReportDataSource al ReportViewer para que los datos se muestren en el informe
            reportViewerInforme.LocalReport.DataSources.Add(reportDataSource);
            // Refresca el informe para que se actualicen los cambios y se muestren los nuevos datos
            reportViewerInforme.RefreshReport();

        }

    

        private void btnGenerarInformeProductos_Click(object sender, EventArgs e)
        {         
            // Cargo resultados
             DataTable dataTableResultadosProductos = AdminModel.getProductos();
            // Borra cualquier origen de datos existente del ReportViewer para limpiarlo
            reportViewerInforme.LocalReport.DataSources.Clear();
            // Crea un nuevo ReportDataSource utilizando el DataTable que contiene los resultados de la consulta
            ReportDataSource reportDataSource = new ReportDataSource("DataSetInforme", dataTableResultadosProductos);
            // Agrega el nuevo ReportDataSource al ReportViewer para que los datos se muestren en el informe
            reportViewerInforme.LocalReport.DataSources.Add(reportDataSource);
            // Refresca el informe para que se actualicen los cambios y se muestren los nuevos datos
            reportViewerInforme.RefreshReport();
        }

        private void pbExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
