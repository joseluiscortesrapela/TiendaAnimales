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

        private void btnMostrarBuscadorProductosModal_Click(object sender, EventArgs e)
        {
            var modal = new BuscarProductosModal();

            if (modal.ShowDialog() == DialogResult.OK)
            {
                // Acceder a los datos seleccionados por el usuario en la ventana modal
                string idProducto = modal.idProducto;
                string nombre = modal.nombre;
                int cantidad = modal.cantidad;
                decimal precio = modal.precio;
                int impuesto = 0;
                int descuento = 0;
                decimal subtotal = cantidad * precio;

                // Agregar el producto seleccionado al DataGridView venta
                dgvVenta.Rows.Add(idProducto, nombre, cantidad, precio, impuesto, descuento, subtotal);
            }

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
