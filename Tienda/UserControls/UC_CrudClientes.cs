using Tienda.Entidades;
using Tienda.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace Tienda.UserControls
{
    public partial class UC_CrudClientes : UserControl
    {
        private DataGridViewRow filaCliente;
        private Cliente cliente;
        private bool estado;


        // Contruc por por defecto,
        public UC_CrudClientes()
        {
            InitializeComponent();
            // Obtengo todos los clientes  y los guardo en el dgv
            actualizarDgvClientes();
        }

        // Constructor que recibe el id del agente
        public UC_CrudClientes(int idAgente)
        {
            InitializeComponent();
            // Obtengo solo los clientes del agente de seguros
            dgvClientes.DataSource = AdminModel.getCarteraClientes(idAgente);
        }

        // Obtengo el cliente seleccionado.
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtengo la fila que ha sido seleccionada en el dataGridView
            if (e.RowIndex >= 0)
            {
                // Obtengo la que ha sido seleccionada en el dgv
                filaCliente = dgvClientes.Rows[e.RowIndex];
                // Obtengo el id del usuario.
                int idCliente = int.Parse(filaCliente.Cells["idCliente"].Value.ToString());
                // Obtengo nombre cliente
                string nombre = filaCliente.Cells["nombre"].Value.ToString();
                // Obtengo los apellidos
                string apellidos = filaCliente.Cells["apellidos"].Value.ToString();
                // Obtengo el dni
                string dni = filaCliente.Cells["dni"].Value.ToString();
                // Obtengo el telefono
                string telefono = filaCliente.Cells["telefono"].Value.ToString();
                // Obtengo el correo 
                string correo = filaCliente.Cells["correo"].Value.ToString();
                // Obtengo la contraseña 
                string contraseña = filaCliente.Cells["contraseña"].Value.ToString();
                // Obtengo el id de la provincia
                int idProvincia = int.Parse(filaCliente.Cells["provincia"].Value.ToString());
                // Obtengo el id del municipio
                int idMunicipio = int.Parse(filaCliente.Cells["municipio"].Value.ToString());
                // Obtengo el tipo 
                string tipo = filaCliente.Cells["tipo"].Value.ToString();

                // Instancio e inicializo un nuevo objeto de tipo Cliente
                cliente = new Cliente(idCliente, nombre, apellidos, dni, telefono, correo, contraseña, idProvincia, idMunicipio, tipo);

                // Muestro botones de accion del crud clientes.
                mostrarBotonesAccion();
                // Elimina mensajes general
                ocultarMensaje();


                // si se ha habilitado
                if (estado)
                {
                    // Obtengo las compras del cliente
                    DataTable tabla = AdminModel.getComprasByClientID(idCliente);

                    // Compruebo que no este vacio
                    if (tabla.Rows.Count >= 1)
                    {
                        // Muestro las compras del clietne en el dgv
                        dgvVentas.DataSource = tabla;
              
                        // Muestro nombre del cliente
                        lbClienteSelecionado.Text = "El cliente/a " +  nombre + ", " + apellidos + " tiene registradas " + dgvVentas.RowCount + " compras.";
                    }
                    else
                    {
                        limpiarDgvPolizas();
                    }
                }


            }

        }

        private void ocultarMensaje()
        {
            timerOcultarMensaje.Start();
        }

        // Obtengo todos los clietnes de la base de datos y los guardo en el dgv
        private void actualizarDgvClientes()
        {
            // Obtengo todos los clientes  y los guardo en el dgv
            dgvClientes.DataSource = AdminModel.getClientes();
        }

        // Muestra formulario para crear un nuevo cliente.
        private void pbMostrarPanelCrear_Click(object sender, EventArgs e)
        {
            // Muestro formulario para crear un nuevo cliente.
            mostrarFormulario("Crear");
            // Añado las provincias al select
            cargarProvincias(cbProvinciasCrear);

            Console.WriteLine("Muestro panel Crear cliente");
        }

        // Muestra formulario con los datos del cliente
        private void pbMostrarPanelDetalle_Click(object sender, EventArgs e)
        {
            // Muestra formulario para ver detalles del cliente
            mostrarFormulario("Detalle");
            // Cargo el formulario con los datos del cliente
            lbIdDetalleCliente.Text = cliente.IdCliente.ToString();
            tbNombreDetalle.Text = cliente.Nombre;
            tbApellidosDetalle.Text = cliente.Apellidos;
            tbDniDetalle.Text = cliente.Dni;
            tbTelefonoDetalle.Text = cliente.Telefono;
            tbCorreoDetalle.Text = cliente.Correo;
            tbContraseñaDetalle.Text = cliente.Contraseña;
            cbTipoDetalle.Text = cliente.Tipo;
            // Obtengo de la base de datos el nombre de la provincia y lo guardo en el campo de texto
            tbProvincia.Text = AdminModel.getNombresProvincia(cliente.IdProvincia);
            // Obtengo de la base de datos el nombre del municipio y lo guardo en el campo de texto
            tbMunicipio.Text = AdminModel.getNombresMunicipio(cliente.IdMuncipio);

            Console.WriteLine("Muestro panel detalle cliente");
        }

        // Muestro la ventana que contiene el formulario crear, editar o detalle de un cliente.
        private void mostrarFormulario(string nombreFormulario)
        {

            switch (nombreFormulario)
            {
                case "Crear": // Muestra ventana crrear cliente
                    panelCrudClientes.Visible = false;
                    panelEditarCliente.Visible = false;
                    panelDetalleCliente.Visible = false;
                    panelCrearCliente.Visible = true;
                    break;
                case "Editar": // Muestra ventana para editar cliente
                    panelCrudClientes.Visible = false;
                    panelCrearCliente.Visible = false;
                    panelDetalleCliente.Visible = false;
                    panelEditarCliente.Visible = true;
                    break;
                case "Detalle": // Muestra ventana para ver detalles cliente.
                    panelCrudClientes.Visible = false;
                    panelCrearCliente.Visible = false;
                    panelEditarCliente.Visible = false;
                    panelDetalleCliente.Visible = true;
                    break;

            }

        }

        // Muestra formulario para editar cliente
        private void pbMostrarPanelEditar_Click(object sender, EventArgs e)
        {
            // Muestro formulario para editar datos de un cliente
            mostrarFormulario("Editar");

            // Relleno formulario con los datos del cliente
            lbIdClienteEditar.Text = cliente.IdCliente.ToString();
            tbNombreEditar.Text = cliente.Nombre;
            tbApellidosEditar.Text = cliente.Apellidos;
            tbDniEditar.Text = cliente.Dni;
            tbTelefonoEditar.Text = cliente.Telefono;
            tbCorreoEditar.Text = cliente.Correo;
            tbContraseñaEditar.Text = cliente.Contraseña;
            cbTipoEditar.Text = cliente.Tipo;

 
            // Añado las provincias al compbo que esta en el panel editar cliente.
            cargarProvincias(cbProvinciasEditar);

            // Obtengo de la base de datos el nombre de la provincia y lo guardo en el campo de texto
            cbProvinciasEditar.Text = AdminModel.getNombresProvincia(cliente.IdProvincia);
            // Obtengo de la base de datos el nombre del municipio y lo guardo en el campo de texto
            cbMunicipiosEditar.Text = AdminModel.getNombresMunicipio(cliente.IdMuncipio);
            
            // Quito mensaje
            lbMensajeEditar.Text = "";

        }

        // Muestra ventan emergente para eliminar cliente
        private void pbEliminar_Click(object sender, EventArgs e)
        {

            int idCliente = cliente.IdCliente;
            // Mensaje que vera el usuario
            String message = "Quieres eliminar a " + cliente.Nombre + " con id " + cliente.IdCliente + " ?";
            // Titulo de la ventana emergente.
            String caption = "Eliminar cliente";
            // Muestro mensaje y obtengo el boton que ha seleccionado
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Quiere eliminar cliente
            if (result == DialogResult.Yes)
            {
                // Eliminar cliente en cascada con sus polizas.
                if (AdminModel.eliminarCliente(idCliente))
                {
                    // Actualizo el dgv
                    actualizarDgvClientes();
                    // Elimino las polizas del dgv
                    resetearDgvPolizas();
                    // Muestro mensaje 
                    lbMensajeGeneral.Text = "Se acaba de eliminar al cliente junto con sus polizas";
                }
                else
                {
                    // Sino se ha podido elimianr muestro mensaje
                    lbMensajeGeneral.Text = "Error al eliminar al cliente";
                }

            }

        }

        // Resetea los valores del dgv
        private void resetearDgvPolizas()
        {   // Elimina todo el contenido 
            dgvVentas.DataSource = null;
        }

        private void limpiarDgvPolizas()
        {
            dgvVentas.DataSource = null;
            lbClienteSelecionado.Text = "";
        }

        // Muestra botones de accion ver, editar y elimianr
        private void mostrarBotonesAccion()
        {
            pbDetalle.Visible = true;
            pbEditar.Visible = true;
            pbEliminar.Visible = true;
        }

        // Habilito la posibilidad de mostrar los pagos por poliza.
        private void pbMostrarComprasCliente_Click(object sender, EventArgs e)
        {
            estado = true;
            pbOn.Visible = false;
            pbOff.Visible = true;
            panelComprasDelCliente.Visible = true;
            lbMensajeInterruptor.Text = "Habilitado! seleccione un cliente";
            Console.WriteLine("On");
        }

        // Desactivo la posibilidad de mostrar los pagos de cada poliza
        private void pbOcultarComprasCliente_Click(object sender, EventArgs e)
        {
            estado = false;
            pbOn.Visible = true;
            pbOff.Visible = false;
            panelComprasDelCliente.Visible = false;
            lbMensajeInterruptor.Text = "Deshabilitado";
            lbClienteSelecionado.Text = "";
            Console.WriteLine("off");
        }

        private void pbMostrarBuscadorClientes_Click(object sender, EventArgs e)
        {

        }


        // Limpia contendio del campo de texto del buscador, mensaje placeholder
        private void limpiaPlaceholderBuscador(object sender, EventArgs e)
        {
            tbBuscar.Text = "";
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        // Lipia el place holder de los campos del formualario
        private void limpiarPlaceholder(object sender, EventArgs e)
        {
            // Limpia el texto del TextBox que desencadenó el evento
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.Text = string.Empty;
            }
        }

        // Vuelve al crud de clientes
        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelEditarCliente.Visible = false;
            panelCrearCliente.Visible = false;
            panelDetalleCliente.Visible = false;
            panelCrudClientes.Visible = true;
        }

        // Creo un nuevo cliente
        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Recoje los datos del formulario
            string nombre = tbNombreCrear.Text;
            string apellidos = tbApellidosCrear.Text;
            string dni = tbDniCrear.Text;
            string telefono = tbTelefonoCrear.Text;
            string correo = tbCorreoCrear.Text;
            string contraseña = tbContraseñaCrear.Text;
            int idProvincia = int.Parse(cbProvinciasCrear.SelectedValue.ToString());
            int idMunicipio = int.Parse(cbMunicipiosCrear.SelectedValue.ToString());
            string tipo = cbTipoCrear.Text;

            // Instancio e inicializo un nuevo objeto de tipo Cliente
            Cliente cliente = new Cliente(nombre, apellidos, dni, telefono, correo, contraseña, idProvincia, idMunicipio, tipo);

            // Si consigie guardar al cliente en la base de datos
            if (AdminModel.registrarCliente(cliente) == 1)
            {   // Muestro mensaje
                lbMensajeCrear.Text = "Acabas de crear un nuevo cliente";
            }
            else
            {   // En caso de error, muestro este mensaje
                lbMensajeCrear.Text = "Error al crear un nuevo cliente";
            }

        }

        // El usuario ha seleccionado una provinca desde el formulario crar nuevo cliente.
        private void cbProvinciasCrear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idProvincia = Convert.ToInt32(cbProvinciasCrear.SelectedValue);
            cargarMunicipios(idProvincia, cbMunicipiosCrear);
        }

        // Carga las provincias en el combbox que le indiquemos
        private void cargarMunicipios(int idProvincia, ComboBox cbMunicipios)
        {
            DataTable tablaMunicipios = AdminModel.getMunicipiosPorProvincia(idProvincia);

            // Recorre cada fila en el DataTable
            foreach (DataRow row in tablaMunicipios.Rows)
            {
                // Accede a cada columna de la fila actual por su nombre o índice
                // Por ejemplo, para acceder al nombre del municipio (columna "nombre"):
                string nombreMunicipio = row["municipio"].ToString(); // Ajusta el nombre de la columna según la estructura de tu tabla
                                                                      // Para acceder al ID del municipio (columna "id"):
                int idMunicipio = Convert.ToInt32(row["id"]); // Ajusta el nombre de la columna según la estructura de tu tabla

                // Aquí puedes hacer lo que necesites con los datos de cada municipio
                // Por ejemplo, imprimirlos en la consola o mostrarlos en un MessageBox
                Console.WriteLine("Nombre: " + nombreMunicipio + ", ID: " + idMunicipio);
            }


            // Asignar los municipios al ComboBox cbMunicipios   
            cbMunicipios.DisplayMember = "municipio"; // Suponiendo que el nombre de los municipios está en una columna llamada "nombre"
            cbMunicipios.ValueMember = "id"; // Suponiendo que el ID de los municipios está en una columna llamada "id"
            cbMunicipios.DataSource = tablaMunicipios;
        }

        // Carga las provincias en el combbox que le indiquemos
        private void cargarProvincias(ComboBox cbProvincias)
        {
            // Obtengo las provincias y las cargo en el combobox
            cbProvincias.DisplayMember = "provincia";
            cbProvincias.ValueMember = "id";
            cbProvincias.DataSource = AdminModel.getProvincias();
        }

        // Editar datos del cliente
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obtengo datos formulario
            int idCliente = cliente.IdCliente;
            string nombre = tbNombreEditar.Text;
            string apellidos = tbApellidosEditar.Text;
            string dni = tbDniEditar.Text;
            string telefono = tbTelefonoEditar.Text;
            string correo = tbCorreoEditar.Text;
            string contraseña = tbContraseñaEditar.Text;
            int idProvincia = int.Parse(cbProvinciasEditar.SelectedValue.ToString());
            int idMunicipio = int.Parse(cbMunicipiosEditar.SelectedValue.ToString());
            string tipo = cbTipoEditar.Text;

            // Instancio e inicializo un nuevo objeto de tipo Cliente
            Cliente nuevoCliente = new Cliente(idCliente, nombre, apellidos, dni, telefono, correo, contraseña, idProvincia, idMunicipio, tipo);

            // Actualizo datos base datos del cliente
            if (AdminModel.editarCliente(nuevoCliente) == 1)
            {
                // Actualizo el dgv de clientes con los nuevos cambios
                actualizarDgvClientes();
                // Muestro mensaje 
                lbMensajeEditar.Text = "Acabas de actualizar datos cliente";
            }

            Console.WriteLine("Editar cliente id : " + idCliente + " idProvincia: " + idProvincia + " idMunicipio " + idMunicipio);
        }


        private void cbProvinciasEditar_SelectedIndexChanged(object sender, EventArgs e)
        {   // Obtengo el indice de la provincia
            int idProvincia = Convert.ToInt32(cbProvinciasEditar.SelectedValue);
            cargarMunicipios(idProvincia, cbMunicipiosEditar);
        }

        private void timerOcultarMensaje_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("timer fin");
            lbMensajeGeneral.Text = "";
            timerOcultarMensaje.Stop();
        }

        // Muestra el buscador
        private void mostrarBuscador(object sender, EventArgs e)
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

        // Realiza la busqueda un cliente  por nombre, apellidos o correo.
        private void buscarClientes(object sender, EventArgs e)
        {
            // Obtengo lo que ha escrito en el buscador
            string texto = tbBuscar.Text;
            // Obtengo los clientes que coincidan por los criterios de busqueda.
            dgvClientes.DataSource = AdminModel.buscarClientes(texto);
        }


    }




}
