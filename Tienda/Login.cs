
using Tienda.Forms;
using Tienda.Models;
using System;
using System.Windows.Forms;
using Tienda.Sesion;

namespace Tienda
{
    public partial class Login : Form
    {
        private LoginModel loginModel;


        public Login()
        {
            InitializeComponent();
            // Intencio el modelo de datos que controlara las peticiones  con la base de datos.
            loginModel = new LoginModel();
        }


        // Login usuario
        private void login_Click(object sender, EventArgs e)
        {
            // Obtengo correo
            string correo = tbCorreo.Text;
            // Obtengo la contraseña
            string contraseña = tbContraseña.Text;

            // Si el formulario es valido    
            if (siValidarFormularioLogin(correo, contraseña))
            {
                // Compruebo si existe el usaurio
                bool existe = loginModel.login(correo, contraseña);

                // Si usuario existe.
                if (existe)
                {
                    // Oculto la ventana de login
                    this.Hide();
                    // Instancio objeto
                    var menu = new MenuPrincipal();
                    // Gaurdo la referencia del objeto globalmente
                    SesionPrograma.guardarReferenciaMenuPrincipal( menu );
                    // Muestro la ventana
                    menu.Show();
                }
                else
                {
                    labelMensajeLogin.Text = "El login es incorrecto";
                }
                Console.WriteLine("LOGIN: el usuario: " + correo + " con contraseña: " + contraseña + " ¿Existe? " + existe);
            }
        }


        // Valida los campos del formulario de login
        private bool siValidarFormularioLogin(string correo, string contraseña)
        {

            bool valido = true;

            // Si el nombre de usuario no esta vacio
            if (correo.Length == 0)
            {
                valido = false;
                error.SetError(tbCorreo, "El correo no puede estar vacio.");
            }
            else
            {
                error.SetError(tbCorreo, "");
            }

            // Si el campo contraseña no esta vacio
            if (contraseña.Length == 0)
            {
                valido = false;
                error.SetError(tbContraseña, "La contraseña no puede estar vacia.");
            }
            else
            {
                error.SetError(tbContraseña, "");
            }


            return valido;


        }



        // Se cierra el programa
        private void pbExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    } // Final clase Login



} // Final nameespace
