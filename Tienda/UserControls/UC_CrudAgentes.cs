using Tienda.Helper;
using Tienda.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace Tienda.UserControls
{
    public partial class UC_CrudAgentes : UserControl
    {

        private DataGridViewRow filaAgente, filaCliente;
        private bool estado;

        public UC_CrudAgentes()
        {
            InitializeComponent();
            // Obtengo todos los agentes y los gaurdo en el dgv
            dgvAgentes.DataSource = AdminModel.getAgentes();
        }


        // Obtengo el agente que ha sido seleccionado.
        private void dgvAgentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtengo la fila que ha sido seleccionada en el dataGridView
            if (e.RowIndex >= 0)
            {   // Obtengo la que ha sido seleccionada en el dgv
                filaAgente = dgvAgentes.Rows[e.RowIndex];
                // Obtengo el id del usuario.
                int idAgente = int.Parse(filaAgente.Cells["idAgente"].Value.ToString());


                // Si quiere ver clientes y polizas
                if (estado)
                {
                    // Obtengo los clientes del agente y los guardo temporalmente en un objeto datatable.
                    DataTable tablaClientes = AdminModel.getCarteraClientes(idAgente);

                    // Compruebo que no este vacio
                    if (tablaClientes.Rows.Count >= 1)
                    {
                        // Obtengo la cartera de clientes del agente y los gaurdo en un dgv.
                        dgvClientes.DataSource = tablaClientes;
                        // Obtengo el nombre del agente
                        string nombre = filaAgente.Cells["nombre"].Value.ToString();
                        // Obtengo los apellidos del agente
                        string apellido = filaAgente.Cells["apellidos"].Value.ToString();
                        // Concateno nombre y apellidos y los muestro
                        lbNombreAgente.Text = apellido + ", " + nombre;
                        // Muestro panel
                        panelCarteraClientes.Visible = true;
                    }

                }


                limpiarDgvPolizas();
                // Muestro botones de accion
                mostrarBotonesAccion();
            }
        }

        // Obtengo el cliente que ha sido seleccionado en el dgv
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si no esta vacia
            if (e.RowIndex >= 0)
            {   // Obtengo la fila y la guardo
                filaCliente = dgvClientes.Rows[e.RowIndex];
                // Obtengo el id del usuario.
                int idCliente = int.Parse(filaCliente.Cells["idCliente"].Value.ToString());
                // Muestro el nombre 
                lbNombreCliente.Text = filaCliente.Cells["nombre"].Value.ToString();

                // Obtengo las polizas del cliente y las guardo temporalmente en un obtejo DataTable
                DataTable tablaPolizas = AdminModel.getPolizasByClientID(idCliente);

                // Si no esta vacio
                if (tablaPolizas.Rows.Count >= 1)
                {
                    // Guardo el contenido de la tabla en el dgv
                    dgvPolizas.DataSource = tablaPolizas;
                    // Cambio color a las filas segun su estado
                    GestorInterfaz.CambiarColorFilas(dgvPolizas);
                }
                else
                {
                    limpiarDgvPolizas();
                }

                Console.WriteLine("mostrar polizas del cliente id " + idCliente);
            }
        }

        private void limpiarDgvPolizas()
        {
            dgvPolizas.DataSource = null;
            lbNombreCliente.Text = "";
        }

        // Muestra botones de accion
        private void mostrarBotonesAccion()
        {
            pbEditar.Visible = true;
            pbEliminar.Visible = true;
        }

        // Muestra formulario para crear un nuevo agente
        private void pbCrear_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Crear agente");

        }

        // Muestra formulario para editar los datos del agente
        private void pbEditar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Editar agente");
        }

        // Muestra formulario para eliminar un agente
        private void pbEliminar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Eliminar agente");
        }

        // Habilito la posibilidad de mostrar los clientes y sus polias.
        private void pbMostrarCarterClientes_Click(object sender, EventArgs e)
        {
            estado = true;
            pbOn.Visible = false;
            pbOff.Visible = true;
            panelCarteraClientes.Visible = true;
            lbMensajeInterruptor.Text = "Habilitado! seleccione un agente";
            lbNombreCliente.Text = "";
            lbNombreAgente.Text = "";
            Console.WriteLine("On");
        }

        // Desactivo la posibilidad de mostrar los clientes y sus polias.
        private void pbOcultarCarteraClientes_Click(object sender, EventArgs e)
        {
            estado = false;
            pbOn.Visible = true;
            pbOff.Visible = false;
            panelCarteraClientes.Visible = false;
            lbMensajeInterruptor.Text = "Desactivado";
            dgvClientes.DataSource = null;
            dgvPolizas.DataSource = null;
            Console.WriteLine("off");
        }

   
        // Salimos del programa
        private void pbMostrarBuscador_Click(object sender, EventArgs e)
        {

            if (panelBuscador.Visible)
            {
                panelBuscador.Visible = false;
            }
            else
            {
                panelBuscador.Visible = true;
            }

        }
     
        // Busca un agente por diferentes criterios de busqueda
        private void buscarAgentes(object sender, EventArgs e)
        {
            // Obtengo lo que ha escrito en el buscador
            string texto = tbBuscar.Text;
            // Obtengo los clientes que coincidan por los criterios de busqueda.
            dgvAgentes.DataSource = AdminModel.buscar("agentes", texto);
        }

        // Limpia el placeholder del buscador.
        private void limpiaPlaceholderBuscador(object sender, EventArgs e)
        {
            tbBuscar.Text = "";
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
