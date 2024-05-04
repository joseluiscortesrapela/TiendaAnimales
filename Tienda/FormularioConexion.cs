using Tienda.Conexion;
using System;
using System.Windows.Forms;

namespace Tienda
{

    public partial class FormularioConexion : Form
    {
        public FormularioConexion()
        {
            InitializeComponent();
        }

        // Recoge los valores del formulario y establece la conexion con la base de datos mysql
        private void btnConectar_Click(object sender, EventArgs e)
        {
            // Obtengo datos formularioi      
            string server = tbServer.Text;
            string database = tbDatabase.Text;
            string user = tbUser.Text;
            string password = tbPassword.Text;

            // Creo la conexion a la base de datos
            ConexionBaseDatos conexion = new ConexionBaseDatos(server, database, user, password);

            // Si ha conectado 
            if (conexion.testConexion())
            {
                this.Hide();
                // Muestro el formulario principal, se inicia el programa tras realizar la conexion
                var login = new Login();
                // Muesstro la ventana
                login.Show();
            }
            else
            {
                lbMensaje.Text = "No se ha podido conectar a la base de datos, revise el valor de los campos";
            }

        }

        // Cierra la ventana
        private void cerrar(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
