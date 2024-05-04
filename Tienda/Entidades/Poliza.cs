using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Entidades
{
    public class Poliza
    {

        private int id;
        private int importe;
        private string tipo;
        private string estado;
        private DateTime fecha;
        private string observaciones;
        private int idCliente;


        public Poliza(int id, int importe, string tipo, string estado, DateTime fecha, string observaciones, int idCliente)
        {
            this.id = id;
            this.importe = importe;
            this.tipo = tipo;
            this.estado = estado;
            this.fecha = fecha;
            this.observaciones = observaciones;
            this.idCliente = idCliente;
        }
        public Poliza(int importe, string tipo, string estado, DateTime fecha, string observaciones, int idCliente)
        {
            this.importe = importe;
            this.tipo = tipo;
            this.estado = estado;
            this.fecha = fecha;
            this.observaciones = observaciones;
            this.idCliente = idCliente;
        }



        public int Id { get => id; set => id = value; }
        public int Importe { get => importe; set => importe = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Estado { get => estado; set => estado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
