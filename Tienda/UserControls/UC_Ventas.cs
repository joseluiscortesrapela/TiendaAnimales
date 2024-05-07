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



        private void ConfigurarComboBox()
        {
            cbClientes.DisplayMember = "nombre"; // Propiedad para mostrar en el ComboBox
            cbClientes.ValueMember = "IdCliente"; // Asigna el nombre del campo que contiene el ID del cliente
           // cbClientes.DataSource = clientes;
            // Configuración del autocompletado personalizado
            AutoCompleteStringCollection colecciónAutocompletado = new AutoCompleteStringCollection();

            foreach (var cliente in clientes)
            {
                colecciónAutocompletado.Add(cliente.Nombre);
            }
            cbClientes.AutoCompleteCustomSource = colecciónAutocompletado;
        }


        // Autoload
        private void UC_Ventas_Load(object sender, EventArgs e)
        {
            clientes = AdminModel.getObjetosClientes();
            ConfigurarComboBox();
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

            foreach (var cliente in clientes)
            {
                if (cliente.Nombre.ToLower().Contains(textoBusqueda))
                {
                    clientesCoincidentes.Add(cliente);
                }
            }

            // Actualizar el ComboBox con los resultados de la búsqueda
            cbClientes.DataSource = null;
            cbClientes.DataSource = clientesCoincidentes;

        }


    }
}
