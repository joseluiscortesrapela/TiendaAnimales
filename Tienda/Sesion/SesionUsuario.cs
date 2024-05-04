using System;

namespace Tienda
{
    internal class SesionUsuario
    {

        private static int id;
        private static string correo;
        private static string contraseña;
        private static string nombre;
        private static string apellidos;
        private static string tipo;

        public static int Id { get => id; set => id = value; }
        public static string Correo { get => correo; set => correo = value; }
        public static string Contraseña { get => contraseña; set => contraseña = value; }
        public static string Nombre { get => nombre; set => nombre = value; }
        public static string Apellidos { get => apellidos; set => apellidos = value; }
        public static string Tipo { get => tipo; set => tipo = value; }
    }
}
