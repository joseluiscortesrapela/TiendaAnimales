using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Entidades;
using Tienda.Forms;
using Tienda.Models;

namespace Tienda.UserControls
{
    public partial class UC_Ventas : UserControl
    {
        // Lista para los clientes
        private List<Cliente> clientes;
        // La fila selecionada
        private DataGridViewRow fila;
        // Identificador cliente
        private int idCliente;

        // 1º Constructor
        public UC_Ventas()
        {
            InitializeComponent();
            // Inicializo datos base formulario
            inicializarFormulario();
        }

        // 2º Constructor para crear venta
        public UC_Ventas(Cliente cliente)
        {
            InitializeComponent();
            // Inicializo datos base formulario
            inicializarFormulario();
            // Seleciono el cliente en el combobx
            cbClientes.SelectedValue = cliente.IdCliente;
        }

        // 3º Constructor para crear venta
        public UC_Ventas(Cliente cliente, int idVenta)
        {
            InitializeComponent();
            // Inicializo datos base formulario
            inicializarFormulario();
            // Seleciono el cliente en el combobx
            cbClientes.SelectedValue = cliente.IdCliente;
            // Elimino todas ls columnas que cree manualmente ya que ahora las genera solas de la bse de datos.
            dgvVenta.Columns.Clear();
            // Muestro la lista de productos del detalle de la venta
            cargarDGVDetallesVenta(idVenta);
        }

        private void cargarDGVDetallesVenta(int idVenta)
        {
            dgvVenta.DataSource = AdminModel.getDetalleVenta(idVenta);
        }

        // Carga inicial formulario
        private void inicializarFormulario()
        {
            clientes = AdminModel.getObjetosClientes();
            autoCompleteNow();
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
            var modal = new BuscarProductosModal();

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
                calcularFilaProducto();
            }

        }

        // Calcular venta
        private void calcularFilaProducto()
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

                // Recalcula 
                recalcular();
            }
        }

        private void recalcular()
        {
            //  Obtengo todos los subtotales
            decimal subtotal = calcularSubtotales();
            // Muestro el subtotal 
            lbSubtotal.Text = subtotal.ToString();

            // Obtengo el total a pagar
            decimal total = calcularTotalAPagar();
            // Muestro el total a pagar
            lbTotalAPagar.Text = total.ToString();

        }

        // Calcula el subtotal del carrito de compra
        private decimal calcularSubtotales()
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

        private decimal calcularTotalAPagar()
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
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            // Obtener la fecha seleccionada por el usuario
            DateTime fechaSeleccionada = dtpFecha.Value;
            // Formatear la fecha en el formato YYYY-MM-DD
            string fecha = fechaSeleccionada.ToString("yyyy-MM-dd");
            // Obtengo el total
            decimal totalAPagar = calcularTotalAPagar();

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
                    Console.WriteLine("Detalle venta creado");
                }

            }

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
