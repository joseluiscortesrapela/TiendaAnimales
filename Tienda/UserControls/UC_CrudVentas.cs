using Tienda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda.UserControls
{
    public partial class UC_CrudVentas : UserControl
    {
        // Constructor
        public UC_CrudVentas()
        {
            InitializeComponent();
        }

        // Autoload
        private void UC_CrudAdministradores_Load(object sender, EventArgs e)
        {
           // dgvVentas.DataSource = AdminModel.getProductos();
        }

        private void pbCrear_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Crear venta");
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Editar una venta");
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Eliminar una venta");
        }

    

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
