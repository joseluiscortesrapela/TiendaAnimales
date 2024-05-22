namespace Tienda.Entidades
{
    public class Producto
    {
        private int id;
        private string nombre;
        private string categoria;
        private decimal precio;
        private int stock;
        private string descripcion;
        private int iva;
        private int cantidad;
        private int descuento;


        // 1º Constructor sin id
        public Producto(string nombre, string categoria, decimal precio, int stock, string descripcion)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
            this.stock = stock;
            this.descripcion = descripcion;
        }

        // 2º Constructor con id
        public Producto(int id, string nombre, string categoria, decimal precio, int stock, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
            this.stock = stock;
            this.descripcion = descripcion;
        }

        // 3 Constructor con cantidad, iva y descuento
        public Producto(int id, string nombre, string categoria, decimal precio, int stock, string descripcion, int iva, int cantidad, int descuento)
        {
            this.id = id;
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
            this.stock = stock;
            this.descripcion = descripcion;
            this.iva = iva;
            this.cantidad = cantidad;
            this.descuento = descuento;
        }

        // 3º Constructor con iva y descuento


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Iva { get => iva; set => iva = value; }
        public int Descuento { get => descuento; set => descuento = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        // Método ToString para representar los datos del producto
        public override string ToString()
        {
            return $"ID: {id}, Nombre: {nombre}, Categoría: {categoria}, Precio: {precio}, Stock: {stock}, Descripción: {descripcion}, IVA: {iva}, Cantidad: {cantidad}, Descuento: {descuento}";
        }
    }
}
