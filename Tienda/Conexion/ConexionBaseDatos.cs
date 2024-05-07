using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using MySql.Data.MySqlClient;

namespace Tienda.Conexion
{
    class ConexionBaseDatos
    {

        private static string server = "localhost";
        private static string database = "Tienda";
        private static string user = "examen";
        private static string password = "examen";
        private static string parameters;


        // Establece la conezion a la bsae de datos
        public static MySqlConnection getConexion()
        {   // La cadena de conexion
            parameters = "server=" + server + ";database=" + database + "; user=" + user + "; password=" + password;
            // Abro la conexion con la base de datos
            MySqlConnection conexion = new MySqlConnection(parameters);
            // Abro la conexion
            conexion.Open();

            return conexion;
        }

        // Comprueba si se ha realizado la conexion
        public bool testConexion()
        {
            try
            {
                var conexion = new MySqlConnection(parameters);
                conexion.Open();
                Console.WriteLine("CONECTADO A LA BASE DE DATOS!");

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine( e.InnerException );
                return false;
            }

        }

    }
}
