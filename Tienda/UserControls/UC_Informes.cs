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

            /*
            // Obtegno datos formulario informe
            int desdeIdeCliente = int.Parse(idCliente1.Value.ToString());
            int hastaIdCliente = int.Parse(idCliente2.Value.ToString());
            DateTime fechaDesde = dtpFechaDetalle.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;
            string estado = cbEstadosInforme.Text;

            // Decalro una bariable del tipo DataTable donde guardare los resultado de mi consulta a la base de datos.
            DataTable dataTableResultados = new DataTable();

            
            // Si quiere ver todas las polizas
            if (estado == "Todas")
            {   // Obtengo todas las polizas
                dataTableResultados = AdminModel.generarInformes(desdeIdeCliente, hastaIdCliente, fechaDesde, fechaHasta);
                Console.WriteLine("Muestro polizas por estado");
            }
            else
            {
                // Obtengo las polizas por estado
                dataTableResultados = AdminModel.generarInformePorEstado(desdeIdeCliente, hastaIdCliente, fechaDesde, fechaHasta, estado);
                // Sino solo muestro las polizas por estado
                Console.WriteLine("Muestro polizas por estado");
            }
            */

            Console.WriteLine("Generar informa de clientes");


            DataTable dataTableResultados = new DataTable();
            // Cargo resultados
            dataTableResultados = AdminModel.getClientes();
            // Borra cualquier origen de datos existente del ReportViewer para limpiarlo
            reportViewerInforme.LocalReport.DataSources.Clear();
            // Crea un nuevo ReportDataSource utilizando el DataTable que contiene los resultados de la consulta
            ReportDataSource reportDataSource = new ReportDataSource("DataSetClientes", dataTableResultados);
            // Agrega el nuevo ReportDataSource al ReportViewer para que los datos se muestren en el informe
            reportViewerInforme.LocalReport.DataSources.Add(reportDataSource);
            // Refresca el informe para que se actualicen los cambios y se muestren los nuevos datos
            reportViewerInforme.RefreshReport();

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        // Cierro la aplicacion
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnGenerarInformeProductos_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Generar informa de productos");

            DataTable dataTableResultados = new DataTable();
            // Cargo resultados
            dataTableResultados = AdminModel.getProductos();
            // Borra cualquier origen de datos existente del ReportViewer para limpiarlo
            reportViewerInforme.LocalReport.DataSources.Clear();
            // Crea un nuevo ReportDataSource utilizando el DataTable que contiene los resultados de la consulta
            ReportDataSource reportDataSource = new ReportDataSource("DataSetInforme", dataTableResultados);
            // Agrega el nuevo ReportDataSource al ReportViewer para que los datos se muestren en el informe
            reportViewerInforme.LocalReport.DataSources.Add(reportDataSource);
            // Refresca el informe para que se actualicen los cambios y se muestren los nuevos datos
            reportViewerInforme.RefreshReport();
        }
    }
}
