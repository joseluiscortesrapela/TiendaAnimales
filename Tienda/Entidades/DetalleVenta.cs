using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Entidades
{
    public class DetalleVenta
    {
        private int idDetalleVenta;
        private int idVenta;
        private int idCliente;
        private int idProducto;
        private string producto;
        private string categoria;
        private decimal precio;
        private int iva;
        private int cantidad;
        private int descuento;
        private decimal subtotal;
        private decimal total;

        public DetalleVenta(int idDetalleVenta, int idVenta, int idCliente, int idProducto, string producto, string categoria, decimal precio, int iva, int cantidad, int descuento, decimal subtotal, decimal total)
        {
            this.idDetalleVenta = idDetalleVenta;
            this.idVenta = idVenta;
            this.idCliente = idCliente;
            this.idProducto = idProducto;
            this.producto = producto;
            this.categoria = categoria;
            this.precio = precio;
            this.iva = iva;
            this.cantidad = cantidad;
            this.descuento = descuento;
            this.subtotal = subtotal;
            this.total = total;
        }

        public int IdDetalleVenta { get => idDetalleVenta; set => idDetalleVenta = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Iva { get => iva; set => iva = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Descuento { get => descuento; set => descuento = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public decimal Total { get => total; set => total = value; }
    }
}
