using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Entidades
{
    public class Devolucion
    {
        private int idVenta;
        private int idProducto;
        private int cantidad;

        public Devolucion(int idVenta, int idProducto, int cantidad)
        {
            this.idVenta = idVenta;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
