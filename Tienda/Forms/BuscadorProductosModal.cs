using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Models;

namespace Tienda.Forms
{
    public partial class BuscadorProductosModal : Form
    {

        public string nombre;
        public int cantidad;
        public decimal precio;


        public BuscadorProductosModal()
        {
            InitializeComponent();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            // Obtengo lo que ha escrito en el buscador
            string texto = tbBuscar.Text;
            // Obtengo los clientes que coincidan por los criterios de busqueda.
            dgvProductos.DataSource = AdminModel.buscarProductos(texto);
        }
    }
}
