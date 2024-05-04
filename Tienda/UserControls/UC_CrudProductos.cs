using Tienda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda.UserControls
{
    public partial class UC_CrudInventario : UserControl
    {
        // Constructor
        public UC_CrudInventario()
        {
            InitializeComponent();
        }

        // Autoload
        private void UC_CrudAdministradores_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = AdminModel.getProductos();
        }

        private void pbCrear_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Crear producto");
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Editar producto");
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Eliminar producto");
        }

        // Salimos del programa
        private void pbMostrarBuscador_Click(object sender, EventArgs e)
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

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buscarProductos(object sender, EventArgs e)
        {
            // Obtengo lo que ha escrito en el buscador
            string texto = tbBuscar.Text;
            // Obtengo los clientes que coincidan por los criterios de busqueda.
            dgvProductos.DataSource = AdminModel.buscarProductos(texto);
        }

        // Quita el placeholder del buscador
        private void limpiaPlaceholderBuscador(object sender, EventArgs e)
        {
            tbBuscar.Text = "";
        }
    }
}
