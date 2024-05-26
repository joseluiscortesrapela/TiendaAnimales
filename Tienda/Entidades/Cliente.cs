using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Entidades
{
    public class Cliente
    {
        private int idCliente;
        private string nombre;
        private string apellidos;
        private string dni;
        private string telefono;
        private string correo;
        private string contraseña;
        private int idProvincia;
        private string nombreProvincia;
        private int idMuncipio;
        private string nombreMunicipio;



        public Cliente(int idCliente, string nombre, string apellidos, string dni, string telefono, string correo, string contraseña, int idProvincia, string nombreProvincia, int idMuncipio, string nombreMunicipio)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.telefono = telefono;
            this.correo = correo;
            this.contraseña = contraseña;
            this.idProvincia = idProvincia;
            this.nombreProvincia = nombreProvincia;
            this.idMuncipio = idMuncipio;
            this.nombreMunicipio = nombreMunicipio;
        }

    


        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int IdProvincia { get => idProvincia; set => idProvincia = value; }
        public string NombreProvincia { get => nombreProvincia; set => nombreProvincia = value; }
        public int IdMuncipio { get => idMuncipio; set => idMuncipio = value; }
        public string NombreMunicipio { get => nombreMunicipio; set => nombreMunicipio = value; }
    }
}
