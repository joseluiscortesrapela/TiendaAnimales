using MySqlX.XDevAPI;
using Tienda.Entidades;
using Tienda.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Tienda.Utilizades;

namespace Tienda.UserControls
{
    public partial class UC_CrudProductos : UserControl
    {
        private int idProducto;
        private Producto producto;
        private DataGridViewRow fila;

        // Constructor
        public UC_CrudProductos()
        {
            InitializeComponent();
            // Obtengo todas los productos y las muestro en el dgv
            cargarProductosDGV();
            // Oculto columnas
            dgvProductos.Columns["idProducto"].Visible = false;
            dgvProductos.Columns["descripcion"].Visible = false;
        }

        // Auto load ventana 
        private void UC_CrudProductos_Load(object sender, EventArgs e)
        {
            Util.CambiarColorFilasDependiendoDeSuStock(dgvProductos);
        }

        // Obtengo el producto que ha sido seleccionada en el dgv
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtengo la fila que ha sido seleccionada en el dataGridView
            if (e.RowIndex >= 0)
            {
                // Obtengo la que ha sido seleccionada en el dgv
                fila = dgvProductos.Rows[e.RowIndex];
                // Obtengo el id del usuario.
                idProducto = int.Parse(fila.Cells["idProducto"].Value.ToString());
                // Nombre 
                string nombre = fila.Cells["nombre"].Value.ToString();
                // Categoria
                string categoria = fila.Cells["categoria"].Value.ToString();
                // Descripcion
                string descripcion = fila.Cells["descripcion"].Value.ToString();
                // Precio 
                decimal precio = decimal.Parse(fila.Cells["precio"].Value.ToString());
                // Stock producto
                int stock = int.Parse(fila.Cells["stock"].Value.ToString());

                // Inicializo el objeto producto con los datos de la fila que ha sido selecionada en el datagridview.
                producto = new Producto(idProducto, nombre, categoria, precio, stock, descripcion);

                Console.WriteLine("Fila selecionada producto Id: " + idProducto + " nombre: " + nombre + " categoria: " + categoria + " descripcion: " + descripcion + " precio: " + precio + " stock: " + stock);

                // Muestro botones de accion.
                mostrarBotonesAccion();
            }

        }

        // Muestra el panel que contiene el formulario para crear un nuevo producto
        private void pbMostrarFormularioCrearProducto_Click(object sender, EventArgs e)
        {
            // Muestro formulario para crear una poliza.
            mostrarFormulario("CrearProducto");
        }

        // Muestra ventana con el formulario con los datos del cliente
        private void pbMostraFormularioDetalleProducto_Click(object sender, EventArgs e)
        {
            // Muestro formulario para editar una poliza
            mostrarFormulario("DetalleProducto");

            // Cargo la lista de clientes en el select
            lbIdDetalle.Text = producto.Id.ToString();
            tbNombreDetalle.Text = producto.Nombre;
            cbCategoriaDetalle.Text = producto.Categoria;
            tbPrecioDetalle.Text = producto.Precio.ToString();
            tbStockDetalle.Text = producto.Stock.ToString();
            tbDescripcionDetalle.Text = producto.Descripcion;

        }

        // Muestra el panel que contiene el formulario para editar una nueva poliza.
        private void pbMostrarFormularioEditarProducto_Click(object sender, EventArgs e)
        {
            // Muestro formulario para editar una poliza
            mostrarFormulario("EditarProducto");

            // Cargo la lista de clientes en el select
            lbIdEditar.Text = producto.Id.ToString();
            tbNombreEditar.Text = producto.Nombre;
            cbCategoriaEditar.Text = producto.Categoria;
            tbPrecioEditar.Text = producto.Precio.ToString();
            nupStockEditar.Value = producto.Stock;
            tbDescripcionsEdiitar.Text = producto.Descripcion.Trim();

        }

        // Muestra el panel y formulario que necesite
        private void mostrarFormulario(string formulario)
        {

            switch (formulario)
            {
                case "CrearProducto":
                    // Muestra panel con el formulario para crear poliza
                    panelCrudProductos.Visible = false;
                    panelDetalleProducto.Visible = false;
                    panelEditarProducto.Visible = false;
                    panelCrearProducto.Visible = true;
                    break;
                case "EditarProducto":
                    // Muestra el panel con el formulario para editar poliza
                    panelCrudProductos.Visible = false;
                    panelCrearProducto.Visible = false;
                    panelDetalleProducto.Visible = false;
                    panelEditarProducto.Visible = true;
                    break;
                case "DetalleProducto":
                    // Muestra panel con el formulario para ver detalle de la poliza
                    panelCrudProductos.Visible = false;
                    panelCrearProducto.Visible = false;
                    panelEditarProducto.Visible = false;
                    panelDetalleProducto.Visible = true;
                    break;

            }

            // Oculto el panel superior donde esta el buscador
            panelNavegacionSuperior.Visible = false;

            Console.WriteLine("Muestro formulario: " + formulario);
        }

        // Eliminar una poliza junto con sus pagos
        private void pbEliminar_Click(object sender, EventArgs e)
        {
            // Mensaje que vera el usuario
            String message = "Quieres eliminar el producto con id " + idProducto + " " + fila.Cells["nombre"].Value + " ?";
            // Titulo de la ventana emergente.
            String caption = "Eliminar";
            // Muestro mensaje y obtengo el boton que ha seleccionado
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Si quiere eliminar
            if (result == DialogResult.Yes)
            {
                // Si ha eliminado el producto
                if (AdminModel.eliminarProducto(idProducto))
                {
                    // Muetro mensaje al usuario
                    mostrarMensajeGeneral("Acabas de eliminar el producto");
                    // Actualizo la lista de productos
                    cargarProductosDGV();
                }

            }

        }

        // Muestra botones de accion
        private void mostrarBotonesAccion()
        {   // Muestro los botones detalle, editar y eliminar
            pbMostraFormularioDetalleProducto.Visible = true;
            pbMostrarFormularioEditarProducto.Visible = true;
            pbEliminarProducto.Visible = true;
        }

        // Crea un nuevo producto
        private void btnCrearProducto_Click(object sender, EventArgs e)
        {

            // Si los datos introducidos en el formulario son validos
            if (validarFormularioCrearProducto())
            {

                // Obtengo datos del formulario crear producto, primero los texto para evitar excepciones.
                string nombre = tbNombre.Text;
                string categoria = cbCategoria.Text.ToString();
                string descripcion = tbDescripcion.Text.Trim();
                int stock = int.Parse(nudStock.Value.ToString());
                decimal precio = decimal.Parse(tbPrecio.Text);

                // Creo un objeto de tipo producto
                Producto producto = new Producto(nombre, categoria, precio, stock, descripcion);

                // Si ha guardado el producto 
                if (AdminModel.registrarProducto(producto))
                {
                    // Muestro la ventana crud productos
                    regresarVentanaCrudProductos();
                    // Muestro mensaje
                    mostrarMensajeGeneral("Acabas de crear un nuevo producto!");
                }

            }


        }



        // Editar producto
        private void btnEditarProducto_Click(object sender, EventArgs e)
        {

            // Si los datos introducidos en el formulario son validos
            if (validarFormularioEditarProducto())
            {
                // Obtengo el valor de los campos del formulario
                int id = int.Parse(lbIdEditar.Text.ToString());
                string nombre = tbNombreEditar.Text;
                string categoria = cbCategoriaEditar.Text;
                decimal precio = decimal.Parse(tbPrecioEditar.Text.ToString());
                int stock = int.Parse(nupStockEditar.Value.ToString());
                string descripcion = tbDescripcionsEdiitar.Text.Trim();

                // Creo un objeto de tipo producto
                Producto producto = new Producto(id, nombre, categoria, precio, stock, descripcion);

                // Si ha guardado el producto 
                if (AdminModel.actualizarProducto(producto))
                {
                    // Muestro la ventana crud productos
                    regresarVentanaCrudProductos();
                    // Muestro mensaje
                    mostrarMensajeGeneral("Acabas de actualizar el producto!");
                }
            }

        }


        // Limpia mensaje placeholder de los campos del formulario una vez que haces click sobre uno
        private void limpiarPlaceholder(object sender, EventArgs e)
        {
            // Limpia el texto del TextBox que desencadenó el evento
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (textBox != null)
            {
                textBox.Text = string.Empty;
            }

        }

        // Carga el dgv con las polizas y las muestra de colores
        private void cargarProductosDGV()
        {
            // Obtengo todas las polizas y las muestro en el dgv
            dgvProductos.DataSource = AdminModel.getProductos();
        }

        // Vuelve al crud principal de polizas, contenedor principal
        private void btnVolver_Click(object sender, EventArgs e)
        {
            regresarVentanaCrudProductos();
        }

        private void regresarVentanaCrudProductos()
        {
            // Oculto los paneles  para editar y crear polizas.
            panelCrearProducto.Visible = false;
            panelEditarProducto.Visible = false;
            panelDetalleProducto.Visible = false;
            // Actualizo, me traigo todas las polizas de la base de datos.
            cargarProductosDGV();
            // Muestro menu superior co nel buscador
            panelNavegacionSuperior.Visible = true;
            // Muestro el contenedor 
            panelCrudProductos.Visible = true;
        }

        // Cierro la aplicacion
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Muetro mensaje general 
        private void mostrarMensajeGeneral(string mensaje)
        {
            // Asigno el valor 
            lbMensajeGeneral.Text = mensaje;
            // Inicio el temporizador
            timerMensaje.Start();
        }

        // Oculto mensajes 
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

        // Buscador de productos
        private void buscarProductos(object sender, EventArgs e)
        {
            // Obtengo lo que ha escrito en el buscador
            string texto = tbBuscar.Text;
            // Obtengo los clientes que coincidan por los criterios de busqueda.
            dgvProductos.DataSource = AdminModel.buscarProductos(texto);

        }


        // Valida el formulario para crear un producto nuevo
        private bool validarFormularioCrearProducto()
        {
            // Supngo que el formulario es correcto
            bool resulatdo = true;


            // Si el nombre del producto esta vacio
            if (Validacion.esUnaCadenaVacia(tbNombre.Text))
            {
                resulatdo = false;
                error.SetError(tbNombre, "Introduce el nombre del producto");
                iconoNombre.Visible = false;
            }
            else
            {
                error.SetError(tbNombre, "");
                iconoNombre.Visible = true;
            }


            // Sino es un numero decimal con un maximo de dos decimales
            if (!Validacion.siEsNumeroDecimal(tbPrecio.Text))
            {
                resulatdo = false;
                error.SetError(tbPrecio, "Introduce un numero con un maximo 2 decimales Ej: 5,75");
                iconoPrecio.Visible = false;
            }
            else
            {
                error.SetError(tbPrecio, "");
                iconoPrecio.Visible = true;
            }


            // Si no se ha seleccionado una cateogira
            if (Validacion.esUnaCadenaVacia(cbCategoria.Text))
            {
                resulatdo = false;
                error.SetError(cbCategoria, "Selecciona una categoria");
                iconoCategoria.Visible = false;
            }
            else
            {
                error.SetError(cbCategoria, "");
                iconoCategoria.Visible = true;
            }



            // Obtengo el valor del stock
            string stock = nudStock.Value.ToString().Trim();

            // La cadena está vacía, es igual a "0" o no es un número entero válido
            if (string.IsNullOrWhiteSpace(stock) || stock == "0" || !int.TryParse(stock, out _))
            {
                resulatdo = false;
                error.SetError(nudStock, "Introduce el stock");
                iconoStock.Visible = false;
            }
            else
            {
                error.SetError(nudStock, "");
                iconoStock.Visible = true;
            }


            // Si la descripcion no tiene un minimo de caracteres
            if (tbDescripcion.Text.Length < 20)
            {
                resulatdo = false;
                error.SetError(tbDescripcion, "Descripcion minima 20 caracteres");
                iconoDescripcion.Visible = false;
            }
            else
            {
                error.SetError(tbDescripcion, "");
                iconoDescripcion.Visible = true;
            }



            return resulatdo;
        }


        // Valida el formulario editar producto
        private bool validarFormularioEditarProducto()
        {
            // Supngo que el formulario es correcto
            bool resulatdo = true;

            // Si el nombre del producto esta vacio
            if (Validacion.esUnaCadenaVacia(tbNombreEditar.Text))
            {
                resulatdo = false;
                error.SetError(tbNombreEditar, "Introduce el nombre del producto");
                iconoNombreEditar.Visible = false;
            }
            else
            {
                error.SetError(tbNombreEditar, "");
                iconoNombreEditar.Visible = true;
            }


            // Sino es un numero decimal con un maximo de dos decimales
            if (!Validacion.siEsNumeroDecimal(tbPrecioEditar.Text))
            {
                resulatdo = false;
                error.SetError(tbPrecioEditar, "Introduce un numero con un maximo 2 decimales Ej: 5,75");
                iconoPrecioEditar.Visible = false;
            }
            else
            {
                error.SetError(tbPrecioEditar, "");
                iconoPrecioEditar.Visible = true;
            }


            // Si no se ha seleccionado una cateogira
            if (Validacion.esUnaCadenaVacia(cbCategoriaEditar.Text))
            {
                resulatdo = false;
                error.SetError(cbCategoriaEditar, "Selecciona una categoria");
                iconoCategoriaEditar.Visible = false;
            }
            else
            {
                error.SetError(cbCategoriaEditar, "");
                iconoCategoriaEditar.Visible = true;
            }



            // Obtengo el valor del stock
            string stock = nupStockEditar.Value.ToString().Trim();

            // La cadena está vacía, es igual a "0" o no es un número entero válido
            if (string.IsNullOrWhiteSpace(stock) || stock == "0" || !int.TryParse(stock, out _))
            {
                resulatdo = false;
                error.SetError(nupStockEditar, "Introduce el stock");
                iconoStockEditar.Visible = false;
            }
            else
            {
                error.SetError(nupStockEditar, "");
                iconoStockEditar.Visible = true;
            }


            // Si la descripcion no tiene un minimo de caracteres
            if (tbDescripcionsEdiitar.Text.Length < 20)
            {
                resulatdo = false;
                error.SetError(tbDescripcionsEdiitar, "Descripcion minima 20 caracteres");
                iconoDescripcionEditar.Visible = false;
            }
            else
            {
                error.SetError(tbDescripcionsEdiitar, "");
                iconoDescripcionEditar.Visible = true;
            }



            return resulatdo;
        }

    }


}
