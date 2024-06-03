using Tienda.Entidades;
using Tienda.Models;
using System;
using System.Data;
using System.Windows.Forms;
using Tienda.Forms;
using Tienda.Sesion;
using Tienda.Utilizades;
using System.Drawing;
using Mysqlx;

namespace Tienda.UserControls
{
    public partial class UC_CrudClientes : UserControl
    {
        private DataGridViewRow filaCliente;
        private DataGridViewRow filaVenta;
        private Cliente cliente;
        private MenuPrincipal menuPrincipal;


        // Contruc por por defecto, carga los datos de la base de datos.
        public UC_CrudClientes()
        {
            InitializeComponent();
            // Obtengo todos los clientes  y los guardo en el dgv
            cargarrDgvClientes();
        }

        public UC_CrudClientes(Cliente cliente)
        {
            InitializeComponent();
            // Guardo cliente
            this.cliente = cliente;
            // Obtengo todos los clientes  y los guardo en el dgv
            cargarrDgvClientes();
            // Mostrar el dgv de ventas del cliente
            seleccionarFilaDGVClientes();
        }

        // Auto load ventana
        private void UC_CrudClientes_Load(object sender, EventArgs e)
        {
            // personalizo dgv
            ocultarColumnasDelDGVClientes();
            // Guardo referencia del menu principal.
            this.menuPrincipal = SesionPrograma.ObtenerMenuPrincipal();
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
                int idProvincia = int.Parse(filaCliente.Cells["idProvincia"].Value.ToString());
                // Nombre de la provincia
                string nombreProvincia = filaCliente.Cells["provincia"].Value.ToString();
                // Obtengo el id del municipio
                int idMunicipio = int.Parse(filaCliente.Cells["idMunicipio"].Value.ToString());
                // Nombre de la provincia
                string nombreMunicipio = filaCliente.Cells["municipio"].Value.ToString();

                // Instancio e inicializo un nuevo objeto de tipo Cliente
                cliente = new Cliente(idCliente, nombre, apellidos, dni, telefono, correo, contraseña, idProvincia, nombreProvincia, idMunicipio, nombreMunicipio);

                // Muestro botones de accion del crud clientes.
                mostrarBotonesAccion();
                // Muestro el panel que conteiene el crud de ventas del cliente
                panelVentasDelCliente.Visible = true;
                // Oculto botones de accion del dgv ventas
                ocultarrBotonesAccionDGVVenta();
                // Elimina mensajes general
                mostrarMensajeYOcultarloAutomaticamente();
                // Obtengo las compras del cliente
                cargarDGVConLasVentasDelClientePorSuid(idCliente);

                // Compruebo que no este vacio
                if (dgvVentas.Rows.Count >= 0)
                {
                    // Muestro datos del clietne que acaba de ser selecionado.
                    lbClienteSelecionado.Text = "El cliente/a " + nombre + ", " + apellidos + " tiene registradas " + dgvVentas.RowCount + " compras.";
                    // Muestro panel
                    mostrarPanelVentas();
                }
                else
                {
                    limpiarDgvVentas();
                    ocultarPanelVentas();
                }

            }

        }


        private void seleccionarFilaDGVClientes()
        {

            foreach (DataGridViewRow fila in dgvClientes.Rows)
            {
                // Verificar que el valor de la celda no sea nulo y convertir a entero
                if (fila.Cells["idCliente"].Value != null && Convert.ToInt32(fila.Cells["idCliente"].Value) == cliente.IdCliente)
                {

                    // Simular el clic en la fila encontrada
                    if (fila.Selected == false)
                    {
                        // Limpiar cualquier selección previa
                        dgvClientes.ClearSelection();

                        // Seleccionar la fila
                        fila.Selected = true;

                        fila.DefaultCellStyle.BackColor = Color.LightSalmon;

                        // Cambiar el color de fondo de la fila seleccionada
                        fila.DefaultCellStyle.BackColor = dgvClientes.DefaultCellStyle.SelectionBackColor;

                        // Desplazar el DataGridView para que la fila seleccionada sea visible
                        dgvClientes.FirstDisplayedScrollingRowIndex = fila.Index;

                        // Crear argumentos para el evento CellClick
                        DataGridViewCellEventArgs eventArgs = new DataGridViewCellEventArgs(0, fila.Index);

                        // Llamar manualmente al evento CellClick
                        dgvClientes_CellClick(dgvClientes, eventArgs);
                    }

                    // Salir del bucle una vez que se encuentra y selecciona la fila
                    break;
                }
            }

        }

        // Oculto algunas columnas del dgv
        private void ocultarColumnasDelDGVClientes()
        {
            // Oculto las siguientes columnas
            dgvClientes.Columns["contraseña"].Visible = false;
            dgvClientes.Columns["idProvincia"].Visible = false;
            dgvClientes.Columns["idMunicipio"].Visible = false;
        }


        // Carga las vetnas de un cliente en el dgv ventas/compras
        private void cargarDGVConLasVentasDelClientePorSuid(int idCliente)
        {   // Obtegno las ventas de un cliente
            dgvVentas.DataSource = AdminModel.getVentasByIDCliente(idCliente);
        }

        // Muestra panel con las compras que ha realizado el cliente
        private void mostrarPanelVentas()
        {
            panelVentasDelCliente.Visible = true;
        }

        // Oculta panel con las compras que ha realizado el cliente
        private void ocultarPanelVentas()
        {
            panelVentasDelCliente.Visible = false;
        }


        private void mostrarMensajeYOcultarloAutomaticamente()
        {
            timerMensaje.Start();
        }

        // Obtengo todos los clietnes de la base de datos y los guardo en el dgv
        private void cargarrDgvClientes()
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

            // Obtengo de la base de datos el nombre de la provincia y lo guardo en el campo de texto
            tbProvincia.Text = AdminModel.getNombresProvincia(cliente.IdProvincia);
            // Obtengo de la base de datos el nombre del municipio y lo guardo en el campo de texto
            tbMunicipio.Text = AdminModel.getNombresMunicipio(cliente.IdMuncipio);

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
                    panelVentasDelCliente.Visible = false;
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

            // Ocuto buscador
            panelFlSuperior.Visible = false;
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

            // Añado las provincias al compbo que esta en el panel editar cliente.
            cargarProvincias(cbProvinciasEditar);
            // Obtengo de la base de datos el nombre de la provincia y lo guardo en el campo de texto
            cbProvinciasEditar.Text = AdminModel.getNombresProvincia(cliente.IdProvincia);
            // Obtengo de la base de datos el nombre del municipio y lo guardo en el campo de texto
            cbMunicipiosEditar.Text = AdminModel.getNombresMunicipio(cliente.IdMuncipio);

        }

        // Muestra ventan emergente para eliminar cliente
        private void pbEliminar_Click(object sender, EventArgs e)
        {

            int idCliente = cliente.IdCliente;
            // Mensaje que vera el usuario
            String message = "Quieres eliminar a " + cliente.Nombre + " con id " + cliente.IdCliente + " y todas sus ventas ?";
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
                    cargarrDgvClientes();
                    // Elimino las polizas del dgv
                    resetearDgvVentas();
                    // Muestro mensaje 
                    mostrarMensajeGeneral("Cliente ha sido elimnado!");
                }

            }

        }

        // Resetea los valores del dgv
        private void resetearDgvVentas()
        {   // Elimina todo el contenido 
            dgvVentas.DataSource = null;
        }

        private void limpiarDgvVentas()
        {
            dgvVentas.DataSource = null;
            lbClienteSelecionado.Text = "";
        }

        // Muestra botones de accion ver, editar, elimianr y informes
        private void mostrarBotonesAccion()
        {
            pbDetalle.Visible = true;
            pbEditar.Visible = true;
            pbEliminar.Visible = true;
            btnMostrarInformeVentasCliente.Visible = true;
        }

        // Limpia contendio del campo de texto del buscador, mensaje placeholder
        private void limpiaPlaceholderBuscador(object sender, EventArgs e)
        {
            tbBuscar.Text = "";
            // Oculto panel con el crud ventas cliente
            panelVentasDelCliente.Visible = false;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        // Lipia el place holder de los campos del formualario
        private void limpiarPlaceholder(object sender, EventArgs e)
        {

            // Obtengo el componente que ha lanzado evento
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                textBox.Text = string.Empty;
            }

        }

        // Vuelve al crud de clientes
        private void btnVolver_Click(object sender, EventArgs e)
        {
            regresarVentanaCrudClientes();
        }

        private void regresarVentanaCrudClientes()
        {
            cargarrDgvClientes();
            panelEditarCliente.Visible = false;
            panelCrearCliente.Visible = false;
            panelDetalleCliente.Visible = false;
            // Muestro la ventana 
            panelCrudClientes.Visible = true;
            // Muestro panel superior del buscador
            panelFlSuperior.Visible = true;
        }

        // Creo un nuevo cliente
        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Si formulario es correcto
            if (validarFormularioCrearCliente())
            {
                // Recoje los datos del formulario
                string nombre = tbNombreCrear.Text;
                string apellidos = tbApellidosCrear.Text;
                string dni = tbDniCrear.Text;
                string telefono = tbTelefonoCrear.Text;
                string correo = tbCorreoCrear.Text;
                string contraseña = tbContraseñaCrear.Text;
                int idProvincia = int.Parse(cbProvinciasCrear.SelectedValue.ToString());
                string nombreProvincia = cbProvinciasCrear.Text;
                int idMunicipio = int.Parse(cbMunicipiosCrear.SelectedValue.ToString());
                string nombreMunicipio = cbMunicipiosCrear.Text;

                // Instancio e inicializo un nuevo objeto de tipo Cliente
                Cliente cliente = new Cliente(0, nombre, apellidos, dni, telefono, correo, contraseña, idProvincia, nombreProvincia, idMunicipio, nombreMunicipio);

                // Si consigie guardar al cliente en la base de datos
                if (AdminModel.registrarCliente(cliente) == 1)
                {
                    // Regreso al la ventana principal
                    regresarVentanaCrudClientes();
                    // Muestro mensaje
                    mostrarMensajeGeneral("Acabas de crear un nuevo cliente");

                }
                else
                {   // En caso de error, muestro este mensaje
                    lbMensajeCrearCliente.Text = "Error al crear un nuevo cliente";
                }


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

            // Si todos los campos del formulario son correctos
            if (validarFormularioEditarCliente())
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
                string nombreProvincia = cbProvinciasEditar.Text;
                int idMunicipio = int.Parse(cbMunicipiosEditar.SelectedValue.ToString());
                string nombreMunicipio = cbMunicipiosEditar.Text;

                // Instancio e inicializo un nuevo objeto de tipo Cliente
                Cliente nuevoCliente = new Cliente(idCliente, nombre, apellidos, dni, telefono, correo, contraseña, idProvincia, nombreProvincia, idMunicipio, nombreMunicipio);

                // Actualizo datos base datos del cliente
                if (AdminModel.editarCliente(nuevoCliente))
                {
                    // Regreso a la ventana crud clientes
                    regresarVentanaCrudClientes();
                    // Muestro mensaje
                    mostrarMensajeGeneral("El cliente ha sido actualizado!");
                }

            }


        }


        private void cbProvinciasEditar_SelectedIndexChanged(object sender, EventArgs e)
        {   // Obtengo el indice de la provincia
            int idProvincia = Convert.ToInt32(cbProvinciasEditar.SelectedValue);
            cargarMunicipios(idProvincia, cbMunicipiosEditar);
        }

        private void timerOcultarMensaje_Tick(object sender, EventArgs e)
        {
            lbMensajeGeneral.Text = "";
            timerMensaje.Stop();
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

        // Muestra la ventana ventas
        private void btnMostrarCrearVenta_Click(object sender, EventArgs e)
        {
            // Crear una instancia del UserControl de ventas
            UC_Ventas ventas = new UC_Ventas(cliente);
            // Llamar al método del formulario principal para cambiar el contenido del panel contenedor
            menuPrincipal.mostrarUserControl(ventas);
        }

        // Muestro el detalle de la venta
        private void btnMostrarDetallesVenta_Click(object sender, EventArgs e)
        {
            // Obtengo el id de la venta
            int idVenta = int.Parse(filaVenta.Cells["idVenta"].Value.ToString());
            // Obtengo la fecha
            string fecha = filaVenta.Cells["fecha"].Value.ToString();
            // Instancio objeto y le paso los parametros al constructor
            UC_Ventas ventas = new UC_Ventas(cliente, idVenta, fecha);
            // Llamar al método del formulario principal para cambiar el contenido del panel contenedor
            menuPrincipal.mostrarUserControl(ventas);
        }


        // Pregunta si quiere eliminar la venta
        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {

            // Obtengo el identificador
            int idVenta = int.Parse(filaVenta.Cells["idVenta"].Value.ToString());
            // Mensaje que vera el usuario
            String message = "Quieres eliminar la venta con nº: " + idVenta + " del cliente " + cliente.Nombre + ", " + cliente.Apellidos;
            // Titulo de la ventana emergente.
            String caption = "Eliminar cliente";
            // Muestro mensaje y obtengo el boton que ha seleccionado
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Quiere eliminar cliente
            if (result == DialogResult.Yes)
            {
                // Eliminar cliente en cascada con sus polizas.
                if (AdminModel.eliminarVenta(idVenta))
                {
                    // Actualizo el dgv  
                    cargarDGVConLasVentasDelClientePorSuid(cliente.IdCliente);
                    // Muestro mensaje 
                    mostrarMensajeGeneral("La venta fue elimnada!");
                }

            }

        }

        // Muetro mensaje general 
        private void mostrarMensajeGeneral(string mensaje)
        {
            // Asigno el valor 
            lbMensajeGeneral.Text = mensaje;
            // Inicio el temporizador
            timerMensaje.Start();
        }

        // Obtengo fila selecionada en el dgv de ventas
        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si es una fila correcta
            if (e.RowIndex >= 0)
            {
                // Obtengo la fila selecionada
                filaVenta = dgvVentas.Rows[e.RowIndex];
                // Muestro los botones de accion
                mostrarBotonesAccionDGVVenta();
            }

        }

        // Muestro los botones de accion del crud ventas
        private void mostrarBotonesAccionDGVVenta()
        {
            btnDetallesVenta.Visible = true;
            btnEliminarVenta.Visible = true;
        }

        // Oculto los botones de accion del crud ventas
        private void ocultarrBotonesAccionDGVVenta()
        {
            btnDetallesVenta.Visible = false;
            btnEliminarVenta.Visible = false;
        }

        // Comprueba que los datos introducidos en el formulario para crear un cliente sean correctos
        private bool validarFormularioCrearCliente()
        {
            bool resultado = true;

            // Si el dni es incorrecto
            if (!Validacion.esUnDNIValido(tbDniCrear.Text))
            {
                resultado = false;
                error.SetError(tbDniCrear, "El DNI no es valido");
                iconoDni.Visible = false;
            }
            else
            {
                error.SetError(tbDniCrear, "");
                iconoDni.Visible = true; ;
            }


            // Sino ha introducido el nombre
            if (Validacion.esUnaCadenaVacia(tbNombreCrear.Text))
            {
                resultado = false;
                error.SetError(tbNombreCrear, "Introduce el nombre");
                iconoNombre.Visible = false;
            }
            else
            {
                error.SetError(tbNombreCrear, "");
                iconoNombre.Visible = true;
            }


            // Sino ha introducido los apellidos
            if (Validacion.esUnaCadenaVacia(tbApellidosCrear.Text))
            {
                resultado = false;
                error.SetError(tbApellidosCrear, "Introduce los apellidos");
                iconoApellidos.Visible = false;
            }
            else
            {
                error.SetError(tbApellidosCrear, "");
                iconoApellidos.Visible = true;
            }

            // Si telefono no es valido
            if (!Validacion.esNumeroTelefonoValido(tbTelefonoCrear.Text))
            {
                resultado = false;
                error.SetError(tbTelefonoCrear, "Introduce un telefono de 9 digitos");
                iconoTelefono.Visible = false;
            }
            else
            {
                error.SetError(tbTelefonoCrear, "");
                iconoTelefono.Visible = true;
            }


            // Si correo no es valido
            if (!Validacion.esCorreoElectronicoValido(tbCorreoCrear.Text))
            {
                resultado = false;
                error.SetError(tbCorreoCrear, "Introduce el correo electronico");
                iconoCorreo.Visible = false;
            }
            else
            {
                error.SetError(tbCorreoCrear, "");
                iconoCorreo.Visible = true;

                // Instancio objeto            
                LoginModel loginModel = new LoginModel();

                // Si el correo existe
                if (loginModel.isUserExist(tbCorreoCrear.Text))
                {
                    Console.WriteLine("Correo existe");
                    error.SetError(tbCorreoCrear, "El correo existe");
                    iconoCorreo.Visible = false;
                }
                else
                {
                    Console.WriteLine("correo libre");
                    error.SetError(tbCorreoCrear, "");
                    iconoCorreo.Visible = true;
                }
            }


            // Si la contraseña esta vacia 
            if (Validacion.esUnaCadenaVacia(tbContraseñaCrear.Text))
            {
                resultado = false;
                error.SetError(tbContraseñaCrear, "Introduce la contraseña");
                iconoContraseña.Visible = false;
            }
            else
            {
                error.SetError(tbContraseñaCrear, "");
                iconoContraseña.Visible = true;
            }

            // Sino ha seleccionado una provincia
            if (Validacion.esUnaCadenaVacia(cbProvinciasCrear.Text))
            {
                resultado = false;
                error.SetError(cbProvinciasCrear, "Selecciona una provincia");
                iconoProvincia.Visible = false;
            }
            else
            {
                error.SetError(cbProvinciasCrear, "");
                iconoProvincia.Visible = true;
            }



            // Sino ha seleccionado un municipio
            if (Validacion.esUnaCadenaVacia(cbMunicipiosCrear.Text))
            {
                resultado = false;
                error.SetError(cbMunicipiosCrear, "Selecciona un municipio");
                iconoMunicipio.Visible = false;
            }
            else
            {
                error.SetError(cbMunicipiosCrear, "");
                iconoMunicipio.Visible = true;
            }



            return resultado;
        }

        // Comprueba que los datos introducidos en el formulario para editar un cliente sean correctos
        private bool validarFormularioEditarCliente()
        {
            bool resultado = true;


            // Si el dni es incorrecto
            if (!Validacion.esUnDNIValido(tbDniEditar.Text))
            {
                resultado = false;
                error.SetError(tbDniEditar, "El DNI no es valido");
                iconoDniEditar.Visible = false;
            }
            else
            {
                error.SetError(tbDniEditar, "");
                iconoDniEditar.Visible = true; ;
            }


            // Sino ha introducido el nombre
            if (Validacion.esUnaCadenaVacia(tbNombreEditar.Text))
            {
                resultado = false;
                error.SetError(tbNombreEditar, "Introduce el nombre");
                iconoNombreEditar.Visible = false;
            }
            else
            {
                error.SetError(tbNombreEditar, "");
                iconoNombreEditar.Visible = true;
            }


            // Sino ha introducido los apellidos
            if (Validacion.esUnaCadenaVacia(tbApellidosEditar.Text))
            {
                resultado = false;
                error.SetError(tbApellidosEditar, "Introduce los apellidos");
                iconoApellidosEditar.Visible = false;
            }
            else
            {
                error.SetError(tbApellidosEditar, "");
                iconoApellidosEditar.Visible = true;
            }

            // Si telefono no es valido
            if (!Validacion.esNumeroTelefonoValido(tbTelefonoEditar.Text))
            {
                resultado = false;
                error.SetError(tbTelefonoEditar, "Introduce un telefono de 9 digitos");
                iconoTelefonoEditar.Visible = false;
            }
            else
            {
                error.SetError(tbTelefonoEditar, "");
                iconoTelefonoEditar.Visible = true;
            }


            // Si correo no es valido
            if (!Validacion.esCorreoElectronicoValido(tbCorreoEditar.Text))
            {
                resultado = false;
                error.SetError(tbCorreoEditar, "Introduce el correo electronico");
                iconoCorreoEditar.Visible = false;
            }
            else
            {
                error.SetError(tbCorreoEditar, "");
                iconoCorreoEditar.Visible = true;

                // Instancio objeto            
                LoginModel loginModel = new LoginModel();

                Console.WriteLine("correo " + cliente.Correo);

                // Si quire cambiar de correo
                if (cliente.Correo != tbCorreoEditar.Text)
                {
                    // Compruebo si existe el nuevo correo
                    if (loginModel.isUserExist(tbCorreoEditar.Text))
                    {
                        resultado = false;
                        error.SetError(tbCorreoEditar, "El correo existe");
                        iconoCorreoEditar.Visible = false;
                    }
                    else
                    {
                        error.SetError(tbCorreoEditar, "");
                        iconoCorreoEditar.Visible = true;
                    }

                }


            }


            // Si la contraseña esta vacia 
            if (Validacion.esUnaCadenaVacia(tbContraseñaEditar.Text))
            {
                resultado = false;
                error.SetError(tbContraseñaEditar, "Introduce la contraseña");
                iconoContraseñaEditar.Visible = false;
            }
            else
            {
                error.SetError(tbContraseñaEditar, "");
                iconoContraseñaEditar.Visible = true;
            }

            // Sino ha seleccionado una provincia
            if (Validacion.esUnaCadenaVacia(cbProvinciasEditar.Text))
            {
                resultado = false;
                error.SetError(cbProvinciasEditar, "Selecciona una provincia");
                iconoProvinciaEditar.Visible = false;
            }
            else
            {
                error.SetError(cbProvinciasEditar, "");
                iconoProvinciaEditar.Visible = true;
            }



            // Sino ha seleccionado un municipio
            if (Validacion.esUnaCadenaVacia(cbMunicipiosEditar.Text))
            {
                resultado = false;
                error.SetError(cbMunicipiosEditar, "Selecciona un municipio");
                iconoMunicipioEditar.Visible = false;
            }
            else
            {
                error.SetError(cbMunicipiosEditar, "");
                iconoMunicipioEditar.Visible = true;
            }


            return resultado;
        }

        private void btnMostrarInformeVentasCliente_Click(object sender, EventArgs e)
        {
            // Crear una instancia del UserControl de informes
            var informes = new UC_Informes( cliente.IdCliente );
            // Llamar al método del formulario principal para cambiar el contenido del panel contenedor
            menuPrincipal.mostrarUserControl(informes);

        }



    }


}
