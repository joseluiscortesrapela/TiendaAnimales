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
    public partial class UC_CrudAdministradores : UserControl
    {
        // Constructor
        public UC_CrudAdministradores()
        {
            InitializeComponent();
        }

        // Autoload
        private void UC_CrudAdministradores_Load(object sender, EventArgs e)
        {
            dgvAdministradores.DataSource = AdminModel.getAdministradores();
        }

        private void pbCrear_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Crear administrador");
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Editar administrador");
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Eliminar administrador");
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

        private void buscarAdministradores(object sender, EventArgs e)
        {
            // Obtengo lo que ha escrito en el buscador
            string texto = tbBuscar.Text;
            // Obtengo los clientes que coincidan por los criterios de busqueda.
            dgvAdministradores.DataSource = AdminModel.buscar("administradores", texto);
        }

        // Quita el placeholder del buscador
        private void limpiaPlaceholderBuscador(object sender, EventArgs e)
        {
            tbBuscar.Text = "";
        }
    }
}
