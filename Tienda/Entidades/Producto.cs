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


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
