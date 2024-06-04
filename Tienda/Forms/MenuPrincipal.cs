using Tienda.UserControls;
using System;
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
            // Obtengo el tipo o rol
            tipo = SesionUsuario.Tipo;
            // Muestro el nombre  
            lbUsuario.Text = SesionUsuario.Nombre;
        }

      
        // Auto load ventana
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

            // Asigna el texto del tooltip al botón btnClientes
            toolTip.SetToolTip(btnClientes, "Clientes");
            toolTip.SetToolTip(btnInventario, "Inventario");
            toolTip.SetToolTip(btnVentas, "Ventas");
            toolTip.SetToolTip(btnInformes, "Informes");
            toolTip.SetToolTip(btnCerrarSesion, "Cerrar sesión");

        }



        // Método para mostrar un UserControl en el panel contenedor
        public void mostrarUserControl(UserControl userControl)
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


        // Cierro programa
        private void pbExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            panelContenedor.Visible = false;
        }


        // Se ha pulsado el boton clientes desde el menu principal
        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Muestro la ventana clientes
            mostrarUserControl(new UC_CrudClientes());
        }

        // Muestro la ventana de informes
        private void btnInformes_Click(object sender, EventArgs e)
        {
            mostrarUserControl(new UC_Informes());
        }

        // Muestro la ventana de ventas
        private void btnVentas_Click(object sender, EventArgs e)
        {
            mostrarUserControl(new UC_Ventas());
        }

        // Muestro la ventana de inventario con los productos
        private void btnInventario_Click(object sender, EventArgs e)
        {
            mostrarUserControl(new UC_CrudProductos());
        }

        // Se cierra el programa
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
