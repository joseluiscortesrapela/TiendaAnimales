using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Entidades;
using Tienda.Models;

namespace Tienda.Forms
{
    public partial class BuscarProductosModal : Form
    {

        public string idProducto;
        public string nombre;
        public int cantidad;
        public decimal precio;
       
        public BuscarProductosModal()
        {
            InitializeComponent();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtengo la fila que ha sido seleccionada en el dataGridView
            if (e.RowIndex >= 0)
            {
                // Obtengo la que ha sido seleccionada en el dgv
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];          
                // Obteno el id del producto y lo guardo en la variable global
                idProducto = fila.Cells["idProducto"].Value.ToString();

                // Inicializo campos formulario con la informacion del producto selecionado.
               
                // Nombre
                tbNombre.Text = fila.Cells["nombre"].Value.ToString();           
                // Precio  
                tbPrecio.Text = fila.Cells["precio"].Value.ToString();
                
            }
        }

        // Busca productos por nombre
        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            // Obtengo lo que ha escrito en el buscador
            string texto = tbBuscar.Text;
            // Obtengo los clientes que coincidan por los criterios de busqueda.
            dgvProductos.DataSource = AdminModel.buscarProductos(texto);
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            // Obtengo campos del formulario
            precio = decimal.Parse(tbPrecio.Text);
            cantidad = int.Parse( tbCantidad.Text );
            
            // Cerrar la ventana modal con DialogResult.OK
            DialogResult = DialogResult.OK;
            // Close();
        }
    }
}
