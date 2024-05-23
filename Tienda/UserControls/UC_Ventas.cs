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
        private List<Cliente> clientes;

        // Constructor
        public UC_Ventas()
        {
            InitializeComponent();
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


        // Autoload
        private void UC_Ventas_Load(object sender, EventArgs e)
        {
            clientes = AdminModel.getObjetosClientes();

            autoCompleteNow();
        }

        private void limpiarPlaceholderCbCliente(object sender, EventArgs e)
        {
            cbClientes.Text = "";
        }

        private void cbClientes_TextChanged(object sender, EventArgs e)
        {
            // Realizar la búsqueda cada vez que el texto en el ComboBox cambie
            string textoBusqueda = cbClientes.Text.ToLower();

            List<Cliente> clientesCoincidentes = new List<Cliente>();

            clientesCoincidentes = clientes.Where(cliente => cliente.Nombre.Contains(textoBusqueda)).ToList();

            // Asignar la lista filtrada al origen de datos del ComboBox
            // cbClientes.DataSource = clientesCoincidentes;


        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            Console.WriteLine("Cliente selecionado");

            int idCliente = int.Parse(cbClientes.SelectedValue.ToString());
            string nombre = cbClientes.Text;

            Console.WriteLine("Id: " + idCliente + " nombre: " + nombre);


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

            }
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


        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
