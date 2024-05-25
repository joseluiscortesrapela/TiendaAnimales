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
            // Nombre del usuario
            lbUsuario.Text = SesionUsuario.Nombre;
            // Obtengo el tipo o rol
            tipo = SesionUsuario.Tipo;

            // Muestro el menu principal segun tipo usuario.
           // prepararInterfazUsuario(tipo);

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
            lbTipoUsuario.Text = SesionUsuario.Tipo;

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

            Console.WriteLine("Muestro user control");
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

        

        private void btnClientes_Click(object sender, EventArgs e)
        {
            mostrarUserControl(new UC_CrudClientes(this));
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            mostrarUserControl(new UC_Informes());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            mostrarUserControl(new UC_Ventas());
        }

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
