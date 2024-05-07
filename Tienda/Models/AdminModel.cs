﻿using MySql.Data.MySqlClient;
using Tienda.Conexion;
using Tienda.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda.Models
{
    public class AdminModel
    {
        private static bool estado;


        public static DataTable getComprasByClientID(int idCliente)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            // Consulta sql
            string sql = "SELECT * FROM ventas WHERE idCliente = " + idCliente + " ORDER BY fecha DESC";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return table;
        }

        // Obtengo todos los clientes
        public static DataTable getClientes()
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            // Consulta sql
            string sql = "SELECT * FROM clientes";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return table;
        }

        // Obtengo todos los clientes
        public static List<Cliente> getObjetosClientes()
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // Declaro el array 
            List<Cliente> clientes = new List<Cliente>();
            // Consulta sql
            string sql = "SELECT * FROM clientes";

            MySqlCommand comando = new MySqlCommand(sql, conexion);

            try
            {
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    // Obtengo los datos del cliente
                    int id = int.Parse(reader["idCliente"].ToString());
                    string nombre = reader["nombre"].ToString();
                    string apellidos = reader["apellidos"].ToString();
                    string dni = reader["dni"].ToString();
                    string telefono = reader["telefono"].ToString();
                    string correo = reader["correo"].ToString();
                    string contraseña = reader["contraseña"].ToString();
                    int idProvincia = int.Parse(reader["idProvincia"].ToString());
                    int idMunicipio = int.Parse(reader["idMunicipio"].ToString());
                    string tipo = reader["tipo"].ToString();

                    // Creo e inicializo el objeto cliente con los datos del cliente
                    Cliente cliente = new Cliente(id, nombre, apellidos, dni, telefono, correo, contraseña, idProvincia, idMunicipio, tipo);

                    // Añado el cliente al array
                    clientes.Add(cliente);
                }

                // Cierro el lector
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException);
            }
            finally
            {
                conexion.Close();
            }
            
            return clientes;
        }



        // Registra un nuevo usuario
        public static int registrarCliente(Cliente cliente)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            // Consulta sql
            string sql = "INSERT INTO clientes ( nombre, apellidos, dni, telefono, correo, contraseña, idProvincia, idMunicipio, tipo ) " +
                                      "VALUES ( @nombre, @apellidos, @dni, @telefono, @correo, @contraseña, @idProvincia, @idMunicipio, @tipo )";
            // Preparo la consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Le paso el pago
            comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
            comando.Parameters.AddWithValue("@dni", cliente.Dni);
            comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("@correo", cliente.Correo);
            comando.Parameters.AddWithValue("@contraseña", cliente.Contraseña);
            comando.Parameters.AddWithValue("@idProvincia", cliente.IdProvincia);
            comando.Parameters.AddWithValue("@idMunicipio", cliente.IdMuncipio);
            comando.Parameters.AddWithValue("@tipo", cliente.Tipo);

            int creado;

            try
            {
                // Return value is the number of rows affected by the SQL statement.
                creado = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                creado = 0;
                MessageBox.Show(ex.Message  +  " " + ex.InnerException );
            }

            return creado;

        }

        // Actualiza datos del cliente
        public static int editarCliente(Cliente cliente)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            // Consulta SQL para realizar un UPDATE en lugar de un INSERT
            string sql = "UPDATE clientes SET nombre = @nombre, apellidos = @apellidos, dni = @dni, telefono = @telefono, " +
                         "correo = @correo, contraseña = @contraseña, idProvincia = @idProvincia, idMunicipio = @IdMunicipio, tipo = @tipo " +
                         "WHERE idCliente = @idCliente"; // Ajusta la condición WHERE según la estructura de tu tabla y el nombre de la columna que identifica al cliente (id en este caso)

            // Preparo la consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Le paso el pago
            comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
            comando.Parameters.AddWithValue("@dni", cliente.Dni);
            comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("@correo", cliente.Correo);
            comando.Parameters.AddWithValue("@contraseña", cliente.Contraseña);
            comando.Parameters.AddWithValue("@idProvincia", cliente.IdProvincia);
            comando.Parameters.AddWithValue("@idMunicipio", cliente.IdMuncipio);
            comando.Parameters.AddWithValue("@tipo", cliente.Tipo);
            comando.Parameters.AddWithValue("@idCliente", cliente.IdCliente);

            int creado;

            try
            {
                // Return value is the number of rows affected by the SQL statement.
                creado = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                creado = 0;
                MessageBox.Show(ex.Message);
            }

            return creado;

        }

        // Elimina un jugador y todas sus partidas
        public static bool eliminarCliente(int idCliente)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            bool eliminado;

            // Inicio una transacción
            MySqlTransaction transaccion = null;

            try
            {
                // Mi transaccion
                transaccion = conexion.BeginTransaction();

                // Consulta sql para eliminar todas las polizas del cliente
                string sql = "DELETE FROM polizas WHERE idCliente = @idCliente";
                // Mi sql y conexon
                MySqlCommand comandoEliminarPolizas = new MySqlCommand(sql, conexion);
                // Le paso como parametro el id del cliente a eliminar
                comandoEliminarPolizas.Parameters.AddWithValue("@idCliente", idCliente);
                // Preparo la transaccion.
                comandoEliminarPolizas.Transaction = transaccion;

                // Ejecutar la transaccion.
                comandoEliminarPolizas.ExecuteNonQuery();

                // Consulta sql para eliminar al cliente
                sql = "DELETE FROM clientes WHERE idCliente = @idCliente";
                // Mi sql y conexon
                MySqlCommand comandoEliminarCliente = new MySqlCommand(sql, conexion);
                // Le paso como parametros el id del cliente
                comandoEliminarCliente.Parameters.AddWithValue("@idCliente", idCliente);
                // Preparo la transaccion.
                comandoEliminarCliente.Transaction = transaccion;

                // Ejecutar la consulta para eliminar al jugador y obtengo un 1 si se ha realizado con exito y 0 en caso contrario
                int estado = comandoEliminarCliente.ExecuteNonQuery();

                // Convierto el int a bool
                eliminado = (estado != 0);

                // Confirmar la transacción
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, se realiza un rollback de la transacción
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
                eliminado = false;
            }
            finally
            {
                // Cierro la conexión
                conexion.Close();
            }

            return eliminado;

        }

        // Busca clientes
        public static DataTable buscarClientes(string texto)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            // Mi consulta 
            string sql = $"SELECT * FROM clientes WHERE nombre LIKE @texto OR apellidos LIKE @texto OR correo LIKE @texto";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@texto", "%" + texto + "%");

            // creo el adaptador
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

            // Instancio una tabla vacia. 
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table); // Relleno la tabla con el resulatado de la consulta.

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }


            return table;
        }

        // Busca clientes
        public static DataTable buscarProductos(string texto)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            // Mi consulta 
            string sql = $"SELECT * FROM productos WHERE nombre LIKE @texto OR categoria LIKE @texto";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@texto", "%" + texto + "%");

            // creo el adaptador
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

            // Instancio una tabla vacia. 
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table); // Relleno la tabla con el resulatado de la consulta.

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return table;
        }


        public static DataTable getProductos()
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            // Consulta sql
            string sql = "SELECT * FROM productos";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }


            return table;
        }

        public static DataTable getVentas()
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            // Consulta sql
            string sql = "SELECT * FROM ventas";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }


            return table;
        }

        // Obtengo las polias del cliente
        public static DataTable getCarteraClientes(int idAgente)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta sql
            string sql = "SELECT * FROM clientes WHERE idAgente = " + idAgente;

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return table;
        }


        // Registra un nuevo producto
        public static bool registrarProducto(Producto producto)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            // Consulta sql
            string sql = "INSERT INTO productos (nombre, categoria, precio, stock, descripcion ) VALUES ( @nombre, @categoria, @precio, @stock, @descripcion)";

            // Preparo la consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Le paso el pago

            // Agregar los parámetros para importe, estado, fecha y ID del cliente
            comando.Parameters.AddWithValue("@nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@categoria", producto.Categoria);
            comando.Parameters.AddWithValue("@precio", producto.Precio);
            comando.Parameters.AddWithValue("@stock", producto.Stock);
            comando.Parameters.AddWithValue("@descripcion", producto.Descripcion);


            bool creado;

            try
            {
                // Return value is the number of rows affected by the SQL statement.
                int estado = comando.ExecuteNonQuery();
                // Convierto el int a bool
                creado = (estado != 0);
            }
            catch (Exception ex)
            {
                creado = false;
                Console.WriteLine(ex.Message);
            }

            return creado;

        }

        // Actualiza un producto
        public static bool actualizarProducto(Producto producto)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            // Consulta sql
            string sql = "UPDATE productos SET nombre = @nombre, categoria = @categoria, precio = @precio, stock = @stock, descripcion = @descripcion WHERE idProducto = @idProducto";

            // Preparo la consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Le paso el pago

            // Agregar los parámetros para importe, estado, fecha y ID del cliente
            comando.Parameters.AddWithValue("@nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@categoria", producto.Categoria);
            comando.Parameters.AddWithValue("@precio", producto.Precio);
            comando.Parameters.AddWithValue("@stock", producto.Stock);
            comando.Parameters.AddWithValue("@descripcion", producto.Descripcion);
            comando.Parameters.AddWithValue("@idProducto", producto.Id);


            bool creado;

            try
            {
                // Return value is the number of rows affected by the SQL statement.
                int estado = comando.ExecuteNonQuery();
                // Convierto el int a bool
                creado = (estado != 0);
            }
            catch (Exception ex)
            {
                creado = false;
                Console.WriteLine(ex.Message);
            }

            return creado;

        }

        // Elimina un jugador y todas sus partidas
        public static bool eliminarProducto(int id)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            bool eliminado;

            try
            {
                // Consulta sql para eliminar todas las polizas del cliente
                string sql = "DELETE FROM productos WHERE idProducto = @id";
                // Mi sql y conexon
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                // Le paso como parametro el id del cliente a eliminar
                comando.Parameters.AddWithValue("@id", id);
                // Ejecutar la consulta para eliminar, si obtengo un 1 si se ha realizado con exito y 0 en caso contrario
                int estado = comando.ExecuteNonQuery();
                // Convierto el int a bool
                eliminado = (estado != 0);
                // Cierro la conexion
                conexion.Close();


            }
            catch (Exception ex)
            {

                eliminado = false; // Cierro la conexión
            }
            finally
            {
                conexion.Close();
            }

            return eliminado;

        }

        // Obtengo todos las provincias
        public static DataTable getProvincias()
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            // Consulta sql
            string sql = "SELECT * FROM provincias";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return table;
        }

        // Obtengo los muncipios de una provia.
        public static DataTable getMunicipiosPorProvincia(int idProvincia)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            // Consulta sql
            string sql = "SELECT * FROM municipios WHERE provincia = " + idProvincia;

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return table;

        }

        // Obtengo el nombre de la provincia
        public static string getNombresProvincia(int idProvincia)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            ;
            // Consulta SQL para obtener el nombre de la provincia
            string sql = "SELECT provincia FROM provincias WHERE id = @idProvincia";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idProvincia", idProvincia);

            // Ejecuta la consulta y obtiene el nombre de la provincia
            object resultado = comando.ExecuteScalar();
            // Obtengo nombre   
            string nombreProvincia = resultado.ToString();

            // Devuelvo dato
            return nombreProvincia;

        }

        // Obtengo el nombre del municipio
        public static string getNombresMunicipio(int idMunicipio)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            // Consulta SQL 
            string sql = "SELECT municipio FROM municipios WHERE id = @idMunicipio";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idMunicipio", idMunicipio);

            // Ejecuta la consulta y obtiene el nombre de la provincia
            object resultado = comando.ExecuteScalar();
            // Obtengo nombre   
            string nombreMunicipio = resultado.ToString();

            // Devuelvo dato
            return nombreMunicipio;

        }

        public static DataTable generarInformes(int idClienteMin, int idClienteMax, DateTime fechaDesde, DateTime fechaHasta)
        {

            MySqlConnection conexion = ConexionBaseDatos.getConexion();

            DataTable dataTable = new DataTable();

            // Construir la consulta SQL
            string sql = @"
                            SELECT 
                                c.idCliente,
                                c.nombre AS nombreCliente,
                                p.idPoliza,
                                p.importe,
                                p.tipo,
                                p.observaciones,
                                p.fecha,
                                p.estado
                            FROM 
                                clientes c
                            INNER JOIN 
                                polizas p ON c.idCliente = p.idCliente
                            WHERE 
                                c.idCliente BETWEEN @idClienteMin AND @idClienteMax
                                AND p.fecha BETWEEN @fechaDesde AND @fechaHasta";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idClienteMin", idClienteMin);
            comando.Parameters.AddWithValue("@idClienteMax", idClienteMax);
            comando.Parameters.AddWithValue("@fechaDesde", fechaDesde);
            comando.Parameters.AddWithValue("@fechaHasta", fechaHasta);

            // Creo el adapatador
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(dataTable);

            // Cerrar la conexión manualmente
            conexion.Close();

            return dataTable;

        }

        // Genera informa por id clientes, fecha y ademas el esatdo de la poliza.
        public static DataTable generarInformePorEstado(int idClienteMin, int idClienteMax, DateTime fechaDesde, DateTime fechaHasta, string estado)
        {

            MySqlConnection conexion = ConexionBaseDatos.getConexion();


            DataTable dataTable = new DataTable();

            // Construir la consulta SQL
            string sql = @"
                            SELECT 
                                c.idCliente,
                                c.nombre AS nombreCliente,
                                p.idPoliza,
                                p.importe,
                                p.tipo,
                                p.observaciones,
                                p.fecha,
                                p.estado
                            FROM 
                                clientes c
                            INNER JOIN 
                                polizas p ON c.idCliente = p.idCliente
                            WHERE 
                                c.idCliente BETWEEN @idClienteMin AND @idClienteMax
                                AND p.fecha BETWEEN @fechaDesde AND @fechaHasta
                                AND p.estado = @estadoPoliza";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idClienteMin", idClienteMin);
            comando.Parameters.AddWithValue("@idClienteMax", idClienteMax);
            comando.Parameters.AddWithValue("@fechaDesde", fechaDesde);
            comando.Parameters.AddWithValue("@fechaHasta", fechaHasta);
            comando.Parameters.AddWithValue("@estadoPoliza", estado);

            // Creo el adapatador
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(dataTable);

            // Cerrar la conexión manualmente
            conexion.Close();

            return dataTable;

        }


    }
}
