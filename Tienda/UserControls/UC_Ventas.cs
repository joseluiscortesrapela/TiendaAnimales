using Mysqlx.Cursor;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Entidades;
using Tienda.Forms;
using Tienda.Models;
using Tienda.Sesion;
using Tienda.Utilizades;

namespace Tienda.UserControls
{
    public partial class UC_Ventas : UserControl
    {
        // Lista para los clientes
        private List<Cliente> clientes;
        // Identificador cliente
        private int idCliente;
        // el cliente 
        private Cliente cliente;
        // Identificador de la venta
        private int idVenta;
        // La fila selecionada
        private DataGridViewRow fila;
        // Dasdboard
        private MenuPrincipal menuPrincipal;
        // Declaro array 
        private List<Devolucion> devoluciones;


        // 1º Constructor: Crea una venta a cualquier cliente, vienes desde el menu principal
        public UC_Ventas()
        {
            InitializeComponent();
            // Inicializo datos base formulario
            inicializarFormularioCrearUnaNuevaVentaAQuialiarCliente();
            // Muestro tipo constructor
            Console.WriteLine("Ventas: 1º consctructor");
        }

        // 2º Constructor: crea la venta a un cliente especifico, vienes desde la ventana ce clientes
        public UC_Ventas(Cliente cliente)
        {
            InitializeComponent();
            // Guardo la referencia del cliente
            this.cliente = cliente;
            // Guardo el id del cliente
            idCliente = cliente.IdCliente;
            // Inicializo datos base formulario
            inicializarFormularioCrearVentaAUnClienteEspecifico();

            Console.WriteLine("Ventas: 2º consctructor");

        }

        // 3º Constructor:  Muestro el detalle de la compra de un cliente, vienes desde la ventana de clientes
        public UC_Ventas(Cliente cliente, int idVenta, string fecha)
        {
            InitializeComponent();
            // Guardo la referencia del cliente
            this.cliente = cliente;
            // Guardo el id del cliente
            this.idCliente = cliente.IdCliente;
            // Guardo el id de la venta que quiere hacer la devolucion.
            this.idVenta = idVenta;
            // Lista de productos que se quieren devolver.
            devoluciones = new List<Devolucion>();
            // Inicializo datos base formulario
            inicializarFormularioDetalleVenta(idVenta, fecha);

            Console.WriteLine("Ventas: 3º consctructor");

        }

        // Autoload
        private void UC_Ventas_Load(object sender, EventArgs e)
        {
            // Guardo referencia del menu principal.
            this.menuPrincipal = SesionPrograma.ObtenerMenuPrincipal();
        }

        // Obtengo la fila que ha sido selecionada en el dgv ventas
        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si es una fila correcta
            if (e.RowIndex >= 0)
            {
                // Obtengo la fila selecionada
                fila = dgvVenta.Rows[e.RowIndex];
                // Muestro los botones de accion
                mostrarBotonesAccion();
                // Muestro por consola la fila seleccionada
                Console.WriteLine("Fila seleccionada " + fila.Cells["producto"].Value);
            }

        }



        // Carga todos los productos qel detalle de venta en el dgv
        private void cargarDGVDetallesVenta(int idVenta)
        {
            dgvVenta.DataSource = AdminModel.getDetalleVenta(idVenta);
        }


        // Carga inicial formulario
        private void inicializarFormularioCrearUnaNuevaVentaAQuialiarCliente()
        {
            // Obtengo los clientes 
            clientes = AdminModel.getObjetosClientes();
            // Configuro compbobox para autocompletado
            autoCompleteNow();
            // Obtengo los clientes 
            clientes = AdminModel.getObjetosClientes();
        }

        // Carga inicial formulario
        private void inicializarFormularioCrearVentaAUnClienteEspecifico()
        {
            // Oculto el combobx de clientes
            cbClientes.Visible = false;
            // Muestro el nombre del cliente
            lbNombreCliente.Text = "Cliente: " + cliente.Nombre;

        }

        // Detalle venta
        private void inicializarFormularioDetalleVenta(int idVenta, string fecha)
        {

            // Oculto el combobx de clientes
            cbClientes.Visible = false;
            // Muestro el nombre del cliente
            lbNombreCliente.Text = "Cliente: " + cliente.Nombre;
            // Muestro la fecha de la venta
            dtpFecha.Text = fecha;
            // Desactivo la fecha
            dtpFecha.Enabled = false;
            // Elimino todas ls columnas que cree manualmente ya que ahora las genera solas de la bse de datos.
            dgvVenta.Columns.Clear();
            // Muestro la lista de productos del detalle de la venta
            cargarDGVDetallesVenta(idVenta);
            // Oculto columna
            dgvVenta.Columns["idProducto"].Visible = false;
            // Amplio el ancho de la columna nombre producto
            dgvVenta.Columns["producto"].Width = 573;
            // Amplio el ancho de la columna categoria
            dgvVenta.Columns["categoria"].Width = 120;
            // Centrar el contenido de la columna "cantidad"
            dgvVenta.Columns["cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Centrar el contenido de la columna "descuento"
            dgvVenta.Columns["descuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Muestro titulo
            lbTitulo.Text = $"Detalles de la venta nº {idVenta}";
            // Oculto boton para crear una venta
            btnRealizarVenta.Visible = false;
            // Muestro boton para realizar una devolucion
            btnAceptarDevolucion.Visible = true;
            // Muestrar el subtotal, total a pagar
            calcularFilasCarrito();
            // Recalcula 
            recalcular();

        }


        private void autoCompleteNow()
        {
            cbClientes.DisplayMember = "nombre"; // Propiedad para mostrar en el ComboBox
            cbClientes.ValueMember = "IdCliente"; // Asigna el nombre del campo que contiene el ID del cliente
            cbClientes.DataSource = clientes;

            AutoCompleteStringCollection colecciónAutocompletado = new AutoCompleteStringCollection();

            foreach (var cliente in clientes)
            {
                colecciónAutocompletado.Add(cliente.Nombre);
            }

            cbClientes.AutoCompleteCustomSource = colecciónAutocompletado;
            cbClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbClientes.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        // Obtengo lo que ha escirto en el select de clientes.
        private void cbClientes_TextChanged(object sender, EventArgs e)
        {
            // Realizar la búsqueda cada vez que el texto en el ComboBox cambie
            string textoBusqueda = cbClientes.Text.ToLower();

            List<Cliente> clientesCoincidentes = new List<Cliente>();

            clientesCoincidentes = clientes.Where(cliente => cliente.Nombre.Contains(textoBusqueda)).ToList();

        }

        // Obtengo el cliente que ha sido seleciodado en el combobo
        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Obtengo el id del cliente que acaba de ser selecionado 
            idCliente = int.Parse(cbClientes.SelectedValue.ToString());
            // Muestro por consola el id del cliente selecionado
            Console.WriteLine("Combobox de cliente selecciionado id: " + idCliente);

        }

        // Añade un producto al carrito o actualiza uno existente
        private void btnMostrarBuscadorProductosModal_Click(object sender, EventArgs e)
        {
            // Instancio objeto
            var modal = new BuscarProductosModal();

            // Si le ha dado al boton aceptar
            if (modal.ShowDialog() == DialogResult.OK)
            {
                // Obtengo el producto que queire añadir al carrito
                Producto producto = modal.dameElProductoSeleccionado();

                // Si el producto ya estaba en la cesta de la compra
                if (siProductoExiste(producto.Id))
                {
                    Console.WriteLine("El producto existe");
                    // Actualizo la cantidad
                    actualizarProductoCarrito(producto);
                }
                else
                {
                    Console.WriteLine("El producto es nuevo, lo añado a la cesta de la compra");
                    // Agregar el producto seleccionado al DataGridView venta
                    añadirProductoAlCarrito(producto);
                }

                // Actualizo el subtotal, total, impuestos y despucuentos de la venta
                calcularFilasCarrito();
                // Recalcula 
                recalcular();
            }

        }

        // Calcular venta
        private void calcularFilasCarrito()
        {
            // Recorro todos los profuctos del carrito de compra
            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                // Obtengo la cantidad
                int cantidad = int.Parse(fila.Cells["cantidad"].Value.ToString());
                // Obtengo el precio del pruducto
                decimal precio = decimal.Parse(fila.Cells["precio"].Value.ToString());
                // Obtengo el tipo de descuento que se aplicara
                int tipoDescuento = int.Parse(fila.Cells["descuento"].Value.ToString());
                // Obtengo el tipo de iva que se aplicara
                int tipoIVA = int.Parse(fila.Cells["iva"].Value.ToString());

                // Calculo el subtotal
                decimal subtotal = cantidad * precio;
                // Calculo el descuento
                decimal descuento = (subtotal * tipoDescuento) / 100;
                // Calculo los impuestos 
                decimal impuestos = (subtotal * tipoIVA) / 100;
                // Calculo total
                decimal total = (subtotal - descuento) + impuestos;

                // Muestro el subtotal, con su valor redondeado 
                fila.Cells["subtotal"].Value = Util.redondearADosDecimales(subtotal);
                // Muestro el total, con su valor redondeado
                fila.Cells["total"].Value = Util.redondearADosDecimales(total);

            }
        }

        private void recalcular()
        {
            //  Obtengo todos los subtotales
            decimal subtotales = obtenerSubtotal();
            // Obtengo el total descuetos
            int totalDescuentos = obtenerTotalDescuentos();
            // Obtengo el total a pagar
            decimal totalAPagar = ObtenerTotales();
            // Redondeo el total a pagar a un maximo de dos decimales
            totalAPagar = Util.redondearADosDecimales(totalAPagar);
            // Redondeo el subtotal
            subtotales = Util.redondearADosDecimales(subtotales);
            // Muestro la suma de los subtotales
            lbSubtotal.Text = subtotales.ToString();
            // Muestro la suma de todos los totales
            lbTotalAPagar.Text = totalAPagar.ToString();

        }

        // Calcula el subtotal del carrito de compra
        private int obtenerTotalDescuentos()
        {
            int totalDescuento = 0;

            // Recorro todos los profuctos del carrito de compra
            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {   // Si es la columana que busco
                if (fila.Cells["descuento"].Value != null)
                {
                    // Obtengo el valode la columna
                    int descuento = int.Parse(fila.Cells["descuento"].Value.ToString());
                    // Voy guardando los totales de cada producto
                    totalDescuento += descuento;
                }

            }

            return totalDescuento;
        }

        // Calcula el subtotal del carrito de compra
        private decimal obtenerSubtotal()
        {
            decimal totalSubtotal = 0;

            // Recorro todos los profuctos del carrito de compra
            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                if (fila.Cells["subtotal"].Value != null)
                {
                    // Obtengo el subtotal
                    decimal subtotal = decimal.Parse(fila.Cells["subtotal"].Value.ToString());
                    // Voy guardando los totales de cada producto
                    totalSubtotal += subtotal;
                }

            }

            return totalSubtotal;
        }

        private decimal ObtenerTotales()
        {
            decimal totalAPagar = 0;

            // Recorro todos los profuctos del carrito de compra
            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                if (fila.Cells["total"].Value != null)
                {
                    // Obtengo el total
                    decimal total = decimal.Parse(fila.Cells["total"].Value.ToString());
                    // Voy guardando los totales de cada producto
                    totalAPagar += total;
                }

            }

            return totalAPagar;
        }

        // Añade un nuevo producto al dgv
        private void añadirProductoAlCarrito(Producto p)
        {   // Añade una nueva fila al dgv
            dgvVenta.Rows.Add(p.Id, p.Nombre, p.Categoria, p.Cantidad, p.Precio, p.Iva, p.Descuento);
        }

        // Comprueba si el producto existe en el dgv
        private bool siProductoExiste(int idNuevoProducto)
        {
            bool productoExiste = false;

            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                if (int.Parse(fila.Cells["idProducto"].Value.ToString()) == idNuevoProducto)
                {
                    // El producto con el ID especificado ya existe en el DataGridView
                    productoExiste = true;
                }
            }

            return productoExiste;
        }

        // Actualiza el producto dentro del carrito de compra, el producto ya existe, actuliza cantidad y total
        private void actualizarProductoCarrito(Producto producto)
        {
            // Recorro los productos
            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                // Si encuentras el producto por su id
                if (int.Parse(fila.Cells["idProducto"].Value.ToString()) == producto.Id)
                {
                    // Obtengo la cantidad que tenia el producto en lista de la compra.
                    int cantidadQueTenia = int.Parse(fila.Cells["cantidad"].Value.ToString());
                    // Obtengo la cantidad total del producto
                    int cantidadTotal = cantidadQueTenia + producto.Cantidad;

                    // Actualizo la fila con los nuevos datos.
                    fila.Cells["producto"].Value = producto.Nombre;
                    fila.Cells["cantidad"].Value = cantidadTotal;
                    fila.Cells["iva"].Value = producto.Iva;
                    fila.Cells["descuento"].Value = producto.Descuento;
                    fila.Cells["precio"].Value = producto.Precio;
                }
            }

        }

        // Elimina un producto del carrtio de compra 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtengo el identificador del producto 
            int idProducto = int.Parse(fila.Cells["idProducto"].Value.ToString());
            // Nombre del producto
            string nombre = fila.Cells["producto"].Value.ToString();
            // Obtengo la cantidad
            int cantidad = int.Parse(fila.Cells["cantidad"].Value.ToString());
            // Mensaje que vera el usuario
            String message = "¿Quieres eliminar " + nombre + " ?";
            // Titulo de la ventana  
            String caption = "Eliminar producto";
            // Muestro mensaje y obtengo el boton que ha seleccionado
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Si quiere eliminar  
            if (result == DialogResult.Yes)
            {
                // Guardo en el array el produto a eliminar
                devoluciones.Add(new Devolucion(idVenta, idProducto, cantidad));
                // Eliminar la fila  del dgv
                dgvVenta.Rows.Remove(fila);
                // Actualizo sutotal y total
                recalcular();
                // Oculto botones 
                ocultarBotonesAccion();
            }

        }

        // Oculta los botones de accion.
        private void ocultarBotonesAccion()
        {
            btnEliminar.Visible = false;
        }

        // Muestra los botones de accion
        private void mostrarBotonesAccion()
        {
            btnEliminar.Visible = true;
        }

        // Registrar una nueva venga
        private void btnAceptarVenta_Click(object sender, EventArgs e)
        {

            // Si hay productos en el carrito de compra.
            if (dgvVenta.RowCount > 0)
            {
                // Obtener la fecha seleccionada por el usuario
                DateTime fechaSeleccionada = dtpFecha.Value;
                // Formatear la fecha en el formato YYYY-MM-DD
                string fecha = fechaSeleccionada.ToString("yyyy-MM-dd");
                // Obtengo el total
                decimal totalAPagar = ObtenerTotales();

                // Si ha registrado la venta en la base de datos
                if (AdminModel.registrarVenta(idCliente, fecha, totalAPagar))
                {
                    // Obtengo el id del ultimo registro que se creo de la tabla ventas
                    int idVenta = AdminModel.getUltimoIdVenta();
                    // Creo una lista vacia
                    List<DetalleVenta> carritoCompra = new List<DetalleVenta>();

                    // Recorro los productos añadidos al carrito de compra
                    foreach (DataGridViewRow fila in dgvVenta.Rows)
                    {
                        // Obtengo las celdas de la fila
                        int idProducto = int.Parse(fila.Cells["idProducto"].Value.ToString());
                        string producto = fila.Cells["producto"].Value.ToString();
                        string categoria = fila.Cells["categoria"].Value.ToString();
                        int cantidad = int.Parse(fila.Cells["cantidad"].Value.ToString());
                        decimal precio = decimal.Parse(fila.Cells["precio"].Value.ToString());
                        int iva = int.Parse(fila.Cells["iva"].Value.ToString());
                        int descuento = int.Parse(fila.Cells["descuento"].Value.ToString());
                        decimal subtotal = decimal.Parse(fila.Cells["subtotal"].Value.ToString());
                        decimal total = decimal.Parse(fila.Cells["total"].Value.ToString());

                        // Instancio e inicializo el objeto
                        DetalleVenta venta = new DetalleVenta(0, idVenta, idCliente, idProducto, producto, categoria, precio, iva, cantidad, descuento, subtotal, total);

                        // Añado un producto al carrito
                        carritoCompra.Add(venta);

                    }
                    // Si la venta y el detalle venta se han creado con exito, hemos terminado.
                    if (AdminModel.registrarDetalleVenta(carritoCompra))
                    {
                        // Si el valor del objeto es null, queiere decir que he entrado desde me menu principal y no requiere regresar
                        if (cliente == null)
                        {
                            // Reseteo el formulario para una nueva venta.
                            resetear();
                            // Muestro mensaje
                            mostrarMensajeGeneral("Venta finalizada con exito! puede serguir vendiendo");
                        }
                        else
                        {
                            // Regreso de nuevo a la ventana de la que venia, el crud de clientes.
                            mostrarVentanaClientes();
                        }

                    }

                }

            } // Si el carrito esta vacio, sin productos
            else
            {
                mostrarMensajeGeneral("No hay productos en el carrito de compra.");
            }

        }

        // Vacio el carrito de compra
        private void resetear()
        {
            // Eliminar todas las filas 
            dgvVenta.Rows.Clear();
            // Quito el cliente seleccionado
            cbClientes.Text = "Introduce el nombre";
            // Pongo la fecha actual
            dtpFecha.Value = DateTime.Now;
            // Inicializo a cero
            lbSubtotal.Text = "0";
            // Inicializo a cero
            lbTotalAPagar.Text = "0";
        }

        // Muestra mensaje general en la ventan de ventas
        private void mostrarMensajeGeneral(string mensaje)
        {
            // Muestro mensaje 
            lbMensajeGeneral.Text = mensaje;
            timerMensaje.Start();

        }



        private void timerMensaje_Tick(object sender, EventArgs e)
        {
            lbMensajeGeneral.Text = "";
            timerMensaje.Stop();
            Console.WriteLine("termino temporaizdo");
        }

        private void mostrarVentanaClientes()
        {
            // Crear una instancia del UserControl de clientes
            UC_CrudClientes ventanaClientes = new UC_CrudClientes(cliente);
            // Llamar al método del formulario principal para cambiar el contenido del panel contenedor
            menuPrincipal.mostrarUserControl(ventanaClientes);
        }

        // Se cierra el programa
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Volver
        private void btnVolver_Click(object sender, EventArgs e)
        {
            mostrarVentanaClientes();
        }

        // Realizar devolucion, actualizar una venta
        private void btnAceptarDevolucion_Click(object sender, EventArgs e)
        {
            // Si hay productos a devolver
            if (devoluciones.Count > 0)
            {
                // Si se realiza correctamente la devolucion
                if (AdminModel.realizarDevolucion(devoluciones))
                {   // Muestro mensaje
                    mostrarMensajeGeneral("Acabas de realizar una devolución!");
                  
                    // Si el carrito esta vacio, ha eliminado todos los productos elimino la venta
                    if (dgvVenta.RowCount == 0)
                    {   // Si la venta fue eliminada
                        if (AdminModel.eliminarVenta(idVenta))
                        {
                            // Muestro mensaje
                            mostrarMensajeGeneral("Devolucion realizada y venta cancelada");
                            // Oculto boton para aceptar una devolucion, hemos descambiado todos los productos del carrito de compra.
                            btnAceptarDevolucion.Visible = false;
                                              
                        }

                    }


                }

            }


        }


    }
}
