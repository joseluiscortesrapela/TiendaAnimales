using MySqlX.XDevAPI;
using Tienda.Models;
using Tienda.Sesion;
using Tienda.UserControls;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tienda.Forms
{
    public partial class MenuPrincipal : Form
    {
        private int idUsuario;
        private string tipo;

        public MenuPrincipal()
        {
            InitializeComponent();
            // Obtengo el id
            idUsuario = SesionUsuario.Id;
            // Nombre del usuario
            lbUsuario.Text = SesionUsuario.Nombre;
            // Obtengo el tipo o rol
            tipo = SesionUsuario.Tipo;

            // Muestro el menu principal segun tipo usuario.
            prepararInterfazUsuario(tipo);

        }

        // Prepara interfaz del usuaqrio dependiendo del tipo o rol 
        private void prepararInterfazUsuario(string tipo)
        {
            // Tipo usuario
            switch (tipo)
            {
                case "Administrador":
                    btnAdministradores.Visible = true;
                    btnEmpleados.Visible = true;
                    btnClientes.Visible = true;    
                    btnInventario.Visible = true;
                    btnVentas.Visible = true;   
                    btnInformes.Visible = true;
                    break;
                case "Empleado":
                    btnInventario.Visible = true;
                    btnVentas.Visible = true;
                    btnMisVentas.Visible = true;
                    btnInformes.Visible = true;
                    break;
                case "Cliente":
                    break;
            }

        }




        // Auto load ventana
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            // Muestro nombre usuario
            lbUsuario.Text = SesionUsuario.Nombre;
            // Muestro tipo o rol del usuario.
            lbTipoUsuario.Text = SesionUsuario.Tipo;
        }

        // Muestra la ventana de ventas
        private void btnVentas_Click(object sender, EventArgs e)
        {
            mostrarUserControl(new UC_Ventas() );
        }

        // Muestro la ventana de los clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Muestro la vengana 
            mostrarUserControl(new UC_CrudClientes());
        }


        // Muestro la venana del inventario de productos.
        private void btnProductos_Click(object sender, EventArgs e)
        {
            // Muestro la ventana 
            mostrarUserControl(new UC_CrudProductos());
        }



        // Regreso al inico o home
        private void pbInicio_Click(object sender, EventArgs e)
        {
            panelContenedor.Visible = false;
        }



        // Método para mostrar un UserControl en el panel contenedor
        private void mostrarUserControl(UserControl userControl)
        {
            // Limpiar el panel contenedor antes de agregar un nuevo control
            panelContenedor.Controls.Clear();
            // Muestro el panel
            panelContenedor.Visible = true;
            // Ajustar el tamaño del UserControl al tamaño del panel contenedor
            userControl.Dock = DockStyle.Fill;
            // Agregar el UserControl al panel contenedor
            panelContenedor.Controls.Add(userControl);
        }

        // Cierra la sesion actual
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Oculto ventana menu jugador
            this.Hide();
            // Instancio la clase
            Login login = new Login();
            // Muestro la vengana de login/registro
            login.Show();
        }

        // Muestra las polizas de un cliente
        private void btnMisPolizas_Click(object sender, EventArgs e)
        {
            mostrarUserControl(new UC_CrudProductos());
        }



        // Cierro programa
        private void pbExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Muestro ventana informes
        private void btnInformes_Click(object sender, EventArgs e)
        {
            mostrarUserControl(new UC_Informes());
        }
    }
}
