using System;
using System.Windows.Forms;
using Tienda.Entidades;
using Tienda.Models;
using Tienda.Utilizades;

namespace Tienda.Forms
{
    public partial class BuscarProductosModal : Form
    {
        // Variable clase objeto producto
        private Producto producto;

        // Constructor
        public BuscarProductosModal()
        {
            InitializeComponent();
            // Obtengo todos los productos de la base de datos y los muestro en el dgv
            cargarProductosDGV();
            // Ocutlo columnas del dgv
            ocultarColumnasDelDGV();
        }

        private void ocultarColumnasDelDGV()
        {
            dgvProductos.Columns["idProducto"].Visible = false;
            dgvProductos.Columns["descripcion"].Visible = false;
            dgvProductos.Columns["categoria"].Visible = false;
       }

        // Auto load
        private void BuscarProductosModal_Load(object sender, EventArgs e)
        {
            Util.CambiarColorFilasDependiendoDeSuStock(dgvProductos);
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
                int stock = int.Parse(fila.Cells["stock"].Value.ToString());
                tbStock.Text = stock.ToString();
                tbDescripcion.Text = fila.Cells["descripcion"].Value.ToString();


                // Si no tiene stock oculto el boton 
                if (stock == 0)
                {
                    // Oculto el boton
                    btnAceptar.Visible = false;
                }
                else
                {
                    // Muestro  el boton
                    btnAceptar.Visible = true;
                }

                // Quito alerta
                error.SetError(nudCantidad, "");

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
        public Producto dameElProductoSeleccionado()
        {
            return producto;
        }

        // Acepta el producto 
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

            // Si la cantidad no supera el stock del producto
            if (cantidad > stock)
            {   // Muestro icono y mensaje al usaurio
                error.SetError(nudCantidad, "La cantidad no puede superar el stock");
                // Desactivo el boton aceptar
                btnAceptar.Enabled = false;
            } // Si la cantidad es cero
            else if (cantidad == 0)
            {
                // Muestro icono y mensaje al usaurio
                error.SetError(nudCantidad, "La cantidad no puede ser 0");
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
