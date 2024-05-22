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
using Tienda.Models;

namespace Tienda.Forms
{
    public partial class BuscarProductosModal : Form
    {

        private Producto producto;

        public BuscarProductosModal()
        {
            InitializeComponent();
            // Obtengo todos los productos de la base de datos y los muestro en el dgv
            cargarProductosDGV();
        }

        // Carga todos los productos en el dgv
        private void cargarProductosDGV()
        {
            dgvProductos.DataSource = AdminModel.getProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtengo la fila que ha sido seleccionada en el dataGridView
            if (e.RowIndex >= 0)
            {
                // Obtengo la que ha sido seleccionada en el dgv
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                // Cargo datos en el formulario de la fila selecionada.
                tbIdentificador.Text = fila.Cells["idProducto"].Value.ToString();
                tbNombre.Text = fila.Cells["nombre"].Value.ToString();
                string categoria = fila.Cells["categoria"].Value.ToString();
                tbCategoria.Text = categoria;
                nudIva.Value = calcularTipoIva(categoria);
                tbPrecio.Text = fila.Cells["precio"].Value.ToString();
                tbStock.Text = fila.Cells["stock"].Value.ToString();
                tbDescripcion.Text = fila.Cells["descripcion"].Value.ToString();

            }
        }

        // Comprueba que iva le corresponde al producto dependiendo de la categoria
        private int calcularTipoIva(string categoria)
        {
            int iva = 0; // Lo que tendre que pagar de iva

            // Las categorias
            switch (categoria)
            {
                case "Animales":
                    iva = 8;
                    break;
                case "Alimentacion":
                    iva = 10;
                    break;
                case "Accesorios":
                    iva = 21;
                    break;
            }

            return iva;
        }


        // Busca productos por nombre
        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            // Obtengo lo que ha escrito en el buscador
            string texto = tbBuscar.Text;
            // Obtengo los clientes que coincidan por los criterios de busqueda.
            dgvProductos.DataSource = AdminModel.buscarProductos(texto);
        }

        // Devuelve el objeto 
        public Producto dameProducto()
        {
            return producto;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Obtengo datos formulario
            int id = int.Parse(tbIdentificador.Text.ToString());
            string nombre = tbNombre.Text;
            string categoria = tbCategoria.Text;
            int iva = int.Parse(nudIva.Value.ToString());
            int descuento = int.Parse(tbDescuento.Text.ToString());
            decimal precio = decimal.Parse(tbPrecio.Text);
            int stock = int.Parse(tbStock.Text);
            int cantidad = int.Parse(nudCantidad.Value.ToString());
            string descripcion = tbDescripcion.Text;

            // Instancio e inicializo el objeto
            producto = new Producto(id, nombre, categoria, precio, stock, descripcion, iva, cantidad, descuento);

            // Cerrar la ventana modal con DialogResult.OK
            DialogResult = DialogResult.OK;

        }

        // Comprueba que la cantidad elegida no sea mayor que el stock del producto
        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            // Obtergn la cantidad introducida en el campo de texto.
            int cantidad = int.Parse(nudCantidad.Value.ToString());
            // Obtengo el stock del producto
            int stock = int.Parse(tbStock.Text.ToString());

            Console.WriteLine("Cantidad: " + cantidad + " stock: " + stock);


            // Si la cantidad no supera el stock del producto
            if (cantidad > stock)
            {   // Muestro icono y mensaje al usaurio
                error.SetError(nudCantidad, "La cantidad no puede superar el stock");
                // Desactivo el boton aceptar
                btnAceptar.Enabled = false;
            }
            else
            {   // Todo es correcto, quito el mensaje de error
                error.SetError(nudCantidad, "");
                // Habilito el boton aceptar
                btnAceptar.Enabled = true;
            }

        }
    }
}
