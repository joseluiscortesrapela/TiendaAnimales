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
        // La fila selecionada
        private DataGridViewRow fila;
        // Dasdboard
        private MenuPrincipal menuPrincipal;


        // 1º Constructor: Crea una venta a cualquier cliente, vienes desde el menu principal
        public UC_Ventas()
        {
            InitializeComponent();
            // Inicializo datos base formulario
            inicializarFormularioCrearUnaNuevaVentaAQuialiarCliente();
            // Muestro tipo constructor
            Console.WriteLine("Ventas: 1º consctructo");
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
         
            Console.WriteLine("Ventas: 2º consctructo");

        }

        // 3º Constructor:  Muestro el detalle de la compra de un cliente, vienes desde la ventana de clientes
        public UC_Ventas(Cliente cliente, int idVenta, string fecha)
        {
            InitializeComponent();
            // Guardo la referencia del cliente
            this.cliente = cliente;
            // Guardo el id del cliente
            idCliente = cliente.IdCliente;
           
            // Inicializo datos base formulario
            inicializarFormularioDetalleVenta(idVenta, fecha);
       
            Console.WriteLine("Ventas: 3º consctructo");

        }

        // Autoload
        private void UC_Ventas_Load(object sender, EventArgs e)
        {
            // Guardo referencia del menu principal.
            this.menuPrincipal = SesionPrograma.ObtenerMenuPrincipal();
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
        }

        // Carga inicial formulario
        private void inicializarFormularioCrearVentaAUnClienteEspecifico()
        {
            // Oculto el combobx de clientes
            cbClientes.Visible = false;
            // Muestro el nombre del cliente
            lbNombreCliente.Text =  "Cliente: " + cliente.Nombre;
            // Obtengo los clientes 
            // clientes = AdminModel.getObjetosClientes();
            // Configuro compbobox para autocompletado
            //autoCompleteNow();
            // Seleciono el cliente en el combobx
            MessageBox.Show("VENTA A UN CLIENTE ESPECIFICO: nombre: " + cliente.Nombre + " id: " + cliente.IdCliente);

        }

        // Detalle venta
        private void inicializarFormularioDetalleVenta(int idVenta, string fecha)
        {
            // Obtengo los clientes 
           // clientes = AdminModel.getObjetosClientes();
            // Muestro nombre cliente
            //cbClientes.Text = cliente.Nombre;
            // Desabilito combobox
            //cbClientes.Enabled = false;
           
            MessageBox.Show("DETALLE VENTA: nombre: " + cliente.Nombre + " id: " + cliente.IdCliente);
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
            // Muestro titulo
            lbTitulo.Text = "Detalles de la venta";
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
        }

        // Muestra ventana modal para elegir el producto que quiere añadir al la compra.
        private void btnMostrarBuscadorProductosModal_Click(object sender, EventArgs e)
        {
            // Instancio objeto
            var modal = new BuscarProductosModal();

            // Si le ha dado al boton aceptar
            if (modal.ShowDialog() == DialogResult.OK)
            {
                // Acceder a los datos seleccionados por el usuario en la ventana modal
                Producto producto = modal.dameProducto();

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

                // Muestro el subtotal 
                fila.Cells["subtotal"].Value = subtotal;
                // Muestro el total
                fila.Cells["total"].Value = total;

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

            // Muestro la suma de los subtotales
            lbSubtotal.Text = subtotales.ToString();
            // Muestro el descuetno 
            lbDescuentos.Text = totalDescuentos.ToString();
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

        // Actualiza un producto en el carrito de compra
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

        // Elimina un venta
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            // Mensaje que vera el usuario
            String message = "Quieres eliminar " + fila.Cells["producto"].Value + " ?";
            // Titulo de la ventana  
            String caption = "Eliminar producto";
            // Muestro mensaje y obtengo el boton que ha seleccionado
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Si quiere eliminar  
            if (result == DialogResult.Yes)
            {
                // Eliminar la fila seleccionada
                dgvVenta.Rows.Remove(fila);
                // Actualizo 
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

        // Registrar venta
        private void btnAceptarVenta_Click(object sender, EventArgs e)
        {
            Console.WriteLine("aceptar venta idCliente: " + idCliente);
            
            // Si el carrito no esta vacio
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
                    // Obtengo el id de la venta
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

                    // Registro el detalle venta
                    if (AdminModel.registrarDetalleVenta(carritoCompra))
                    {
                        Console.WriteLine("Registrada venta");
                        mostrarVentanaClientes();
                    }

                }

            } // Si el carrito esta vacio, sin productos
            else
            {   // Muestro mensaje 
                lbMensajeGeneral.Text = "No hay productos en el carrito de compra.";
                // Cambia el color del texto a rojo
                lbMensajeGeneral.ForeColor = Color.Red;
                // Oculto mensaje transcurrido unos segundos
                mostrarMensajeYOcultarloAutomaticamente();
            }
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

                Console.WriteLine("Fila venta id: " + fila.Cells[0].Value);
            }

        }

        private void mostrarMensajeYOcultarloAutomaticamente()
        {
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
            Console.WriteLine("Volver ventana clientes id: " + idCliente);
            // Crear una instancia del UserControl de clientes
            UC_CrudClientes ventanaClientes = new UC_CrudClientes(idCliente);
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
    }
}
