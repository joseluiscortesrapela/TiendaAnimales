using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tienda.Conexion
{
    class ConexionBaseDatos
    {
        private static string parameters;

        public ConexionBaseDatos(string server, string dataBase, string user, string password)
        {
            // Parametros
            parameters = "server=" + server + ";database=" + dataBase + "; user=" + user + "; password=" + password;
        }

        // Establece la conezion a la bsae de datos
        public static MySqlConnection getConexion()
        {
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
                return false;
            }

        }

    }
}
