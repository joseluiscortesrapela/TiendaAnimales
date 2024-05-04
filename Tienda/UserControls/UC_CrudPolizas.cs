using MySqlX.XDevAPI;
using Tienda.Entidades;
using Tienda.Helper;
using Tienda.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tienda.UserControls
{
    public partial class UC_CrudPolizas : UserControl
    {
        private Poliza polizaSeleccinada;
        private int idPoliza;
        private DataGridViewRow filaPoliza;
        private int importe, totalPagado, deboPagar;

        // Constructor
        public UC_CrudPolizas()
        {
            InitializeComponent();
            // Obtengo todas las polizas y las muestro en el dgv
            cargarPolizasDGV();
        }

        // Sobrecarga del constructor, recibe el id del cliente
        public UC_CrudPolizas(int idCliente)
        {
            InitializeComponent();
            // Obtengo solo las polizas del cliente y las muestro en el dgv
            dgvPolizas.DataSource = AdminModel.getPolizasByClientID(idCliente);
        }

        // Autoload ventana polizas
        private void UC_CrudPolizas_Load(object sender, EventArgs e)
        {   // Cambia color filas del dgv de polizas segun su estado
            CambiarColorFilas();
        }

        // Obtengo la poliza que ha sido seleccionada en el dgv de polizas.
        private void dgvPolizas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtengo la fila que ha sido seleccionada en el dataGridView
            if (e.RowIndex >= 0)
            {
                // Obtengo la que ha sido seleccionada en el dgv
                filaPoliza = dgvPolizas.Rows[e.RowIndex];
                // Obtengo el id del usuario.
                idPoliza = int.Parse(filaPoliza.Cells["idPoliza"].Value.ToString());
                // Obtengo estado 
                string estado = filaPoliza.Cells["estado"].Value.ToString();
                // Obtengo el importe 
                importe = int.Parse(filaPoliza.Cells["importe"].Value.ToString());
                // Fecha de la poliza
                DateTime fechaPôliza = DateTime.Parse(filaPoliza.Cells["fecha"].Value.ToString());
                // Tipo de poliza
                string tipo = filaPoliza.Cells["tipo"].Value.ToString();
                // Obtengo el comentario
                string observaciones = filaPoliza.Cells["observaciones"].Value.ToString();
                // Obtengo el id del cliente de esta poliza.
                int idCliente = int.Parse(filaPoliza.Cells["idCliente"].Value.ToString());

                // Encapsulo los datos de la poliza en un objeto tipo Poliza
                polizaSeleccinada = new Poliza(idPoliza, importe, tipo, estado, fechaPôliza, observaciones, idCliente);

                // Obtengo el cliente de la poliza.
                DataTable clienteData = AdminModel.getClienteById(idCliente);
                // Obtengo el nobmre
                string nombre = clienteData.Rows[0]["nombre"].ToString();
                // Obtengo los apellidos
                string apellidos = clienteData.Rows[0]["apellidos"].ToString();

                // Obtengo los posibles pagos que pudiera tener la poliza
                DataTable pagosRealizados = AdminModel.getPagosByPoliza(idPoliza);

                // Si se ha realizado algun pago
                if (pagosRealizados.Rows.Count > 0)
                {
                    // Obtengo los pagos de la poliza seleccionada
                    dgvPagos.DataSource = pagosRealizados;
                }
                else
                {
                    dgvPagos.DataSource = null;
                }

                // Si aun queda por pagar
                if (estado == "A cuenta")
                {
                    // Calculo lo que se ha pagado
                    totalPagado = calcularTotalPagado();
                    // Calculo el importe total que debo
                    deboPagar = importe - totalPagado;
                    // Muestro icono 
                    pbIconoPolizaSelecionada.Visible = true;
                    // Muestro mensaje al usuario del total que ha pagado hasta el momento
                    lbPolizaSelecionada.Text = "Póliza nº " + idPoliza + " del cliente " + nombre + ",  " + apellidos + " lleva pagado " + totalPagado + " € y aun debe un importe de ";
                    // Le doy el valor al campo de pago lo que aun debe de la poliza.
                    tbPago.Text = deboPagar.ToString();
                    // Muestro formulario
                    panelPago.Visible = true;

                }
                else
                {
                    // Muestro mensaje al usuario de que no es necesario pago alguno.
                    lbPolizaSelecionada.Text = "La poliza nº " + idPoliza + " al encontrarse " + estado + " no require ningun pago adicional.";
                    // Oculto panel de pago
                    panelPago.Visible = false;

                }

                // Muestro botones editar y eliminar.
                mostrarBotonesAccion();
            }

        }

        // Muestra el panel que contiene el formulario para crear una nueva poliza.
        private void pbMostrarFormularioCrearPoliza_Click(object sender, EventArgs e)
        {
            // Muestro formulario para crear una poliza.
            mostrarFormulario("CrearPoliza");
            // Cargo la lista de clientes en el select
            cargarSelectConLosClientes(cbClientes);
        }

        // Muestra ventana con el formulario con los datos del cliente
        private void pbMostraFormularioDetallePoliza_Click(object sender, EventArgs e)
        {
            // Muestro formulario para editar una poliza
            mostrarFormulario("DetallePoliza");

            // Cargo la lista de clientes en el select
            cargarSelectConLosClientes(cbClientesDetalle);
            lbIdPolizaDetalle.Text = polizaSeleccinada.Id.ToString();
            tbImporteDetalle.Text = polizaSeleccinada.Importe.ToString();
            cbTipoDetalle.Text = polizaSeleccinada.Tipo;
            cbEstadoDetalle.Text = polizaSeleccinada.Estado;

            cbClientesDetalle.Text = polizaSeleccinada.IdCliente.ToString();

            tbObservacionesDetalle.Text = polizaSeleccinada.Observaciones;
            dtpFechaDetalle.Value = polizaSeleccinada.Fecha;

            Console.WriteLine("Muestro formulario detalle poliza: ");
        }

        // Muestra el panel que contiene el formulario para editar una nueva poliza.
        private void pbMostrarFormularioEditarPoliza_Click(object sender, EventArgs e)
        {
            // Muestro formulario para editar una poliza
            mostrarFormulario("EditarPoliza");
            // Cargo la lista de clientes en el select
            cargarSelectConLosClientes(cbClientesEditar);

            // Relleno el formulario con los datos de la poliza.
            lbIdPolizaEditar.Text = polizaSeleccinada.Id.ToString();
            tbImporteEditar.Text = polizaSeleccinada.Importe.ToString();
            cbTipoEditar.Text = polizaSeleccinada.Tipo;
            cbEstadosEditar.Text = polizaSeleccinada.Estado;
            dtpFechaEditar.Value = polizaSeleccinada.Fecha;
            tbObservacionesEdiitar.Text = polizaSeleccinada.Observaciones;
            tbIdCliente.Text = polizaSeleccinada.IdCliente.ToString();
            
            string nombreCliente = AdminModel.getNombresCliente(polizaSeleccinada.IdCliente);
            cbClientesEditar.Text = nombreCliente;


            Console.WriteLine("Muestro formulario editar poliza" );
        }

        // Añade los clietnes al select
        private void cargarSelectConLosClientes(System.Windows.Forms.ComboBox select)
        {
            // Obtengo los clientes y los guardo en select
            select.DisplayMember = "nombre";
            select.ValueMember = "idCliente";
            select.DataSource = AdminModel.getClientes();
        }

        // Muestra el panel y formulario que necesite
        private void mostrarFormulario(string formulario)
        {

            switch (formulario)
            {
                case "CrearPoliza":
                    // Muestra panel con el formulario para crear poliza
                    panelCrudPolizas.Visible = false;
                    panelDetallePoliza.Visible = false;
                    panelEditarPoliza.Visible = false;
                    panelCrearPoliza.Visible = true;
                    break;
                case "EditarPoliza":
                    // Muestra el panel con el formulario para editar poliza
                    panelCrudPolizas.Visible = false;
                    panelCrearPoliza.Visible = false;
                    panelDetallePoliza.Visible = false;
                    panelEditarPoliza.Visible = true;
                    break;
                case "DetallePoliza":
                    // Muestra panel con el formulario para ver detalle de la poliza
                    panelCrudPolizas.Visible = false;
                    panelCrearPoliza.Visible = false;
                    panelEditarPoliza.Visible = false;
                    panelDetallePoliza.Visible = true;
                    break;

            }
            Console.WriteLine("Muestro formulario: " + formulario);
        }

        // Eliminar una poliza junto con sus pagos
        private void pbEliminar_Click(object sender, EventArgs e)
        {
            // Mensaje que vera el usuario
            String message = "Quieres eliminar la poliza nº " + idPoliza + " de " + polizaSeleccinada.Tipo + " por un importe de " + polizaSeleccinada.Importe + " del cliente " + polizaSeleccinada.IdCliente + " ?";
            // Titulo de la ventana emergente.
            String caption = "Eliminar poliza";
            // Muestro mensaje y obtengo el boton que ha seleccionado
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Si quiere eliminar
            if (result == DialogResult.Yes)
            {
                // Si se ha conseguido eliminar de la baae de datos
                if (AdminModel.eliminarPoliza(idPoliza))
                {
                    // Actualizo el dgv con las nuevas polizas desde el base de datos
                    cargarPolizasDGV();
                    // Muestro mensaje
                    lbPolizaSelecionada.Text = "Acabas de eliminar la poliza junto con sus pagos";
                    // Vacio el dgv co los pagos
                    dgvPagos.DataSource = null;
                }

            }

        }

        // Calcula lo que se ha pagado
        private int calcularTotalPagado()
        {
            int total = 0;

            // Recorro el dgv
            foreach (DataGridViewRow row in dgvPagos.Rows)
            {   // Si es la fila vacia por defecto para añadir la salto
                if (row.IsNewRow) continue; // Ignorar la fila de nueva entrada, si está presente
                // Obtengo el valor de la columna pagado, lo convierto a numero y lo voy concatenando.
                total += int.Parse(row.Cells["pagado"].Value.ToString());
            }

            // Devuelvo el total 
            return total;
        }

        // Estado de las polizas por colores, cambia el color de fondo de la fila segun su estado.
        private void cambiarColorPolizas()
        {
            GestorInterfaz.CambiarColorFilas(dgvPolizas);
        }

        // Muestra botones de accion
        private void mostrarBotonesAccion()
        {   // Muestro los botones detalle, editar y eliminar
            pbMostraFormularioDetallePoliza.Visible = true;
            pbMostrarFormularioEditarPoliza.Visible = true;
            pbEliminarPoliza.Visible = true;
        }

        // Realiza el pago 
        private void pbPagar_Click(object sender, EventArgs e)
        {
            // Obtengo la cantidad a pagar
            int pago = int.Parse(tbPago.Text.ToString());

            // Si paga lo que debe
            if (pago == deboPagar)
            {
                // Si se ha realizado el pago 
                if (AdminModel.pagarPoliza(pago, idPoliza) == 1)
                {
                    // Si ha conseguido actualizar el estado de la poliza a cobrada
                    if (AdminModel.actualizarEstadoPoliza(idPoliza, "Cobrada") == 1)
                    {   // Actualizo las polizas del dgv
                        dgvPolizas.DataSource = AdminModel.getPolizas();
                        // Muestro las filas de las polizas por color segun su estado
                        cambiarColorPolizas();
                        // Muestro mensaje
                        lbMensajeCrearPoliza.Text = "Acabas de pagar el importe total de tu poliza";
                    }
                    // Quito mensje del errorProvider
                    error.SetError(tbPago, "");
                }

            }
            // Si paga una cantidad pero aun sigue debiendo
            else if (pago < deboPagar)
            {
                // Realizo pago
                if (AdminModel.pagarPoliza(pago, idPoliza) == 1)
                {
                    // Actualizo los pagos de la poliza y los muestro en el dgv
                    dgvPagos.DataSource = AdminModel.getPagosByPoliza(idPoliza);
                    // Muestro mensaje
                    lbMensajeCrearPoliza.Text = "El pago se ha realizado con exito";
                    // Quito mensje del errorProvider
                    error.SetError(tbPago, "");
                }
            }
            else
            {   // Cantidad ingresada no puede ser mayor de lo que debe.
                error.SetError(tbPago, "La cantidad introducida es mayor que lo que debe");
            }

        }

        private void btnCrearPoliza_Click(object sender, EventArgs e)
        {

            // Obtengo datos del formulario
            int importe = int.Parse(tbImporte.Text.ToString());
            string tipo = cbTipo.Text.ToString();
            string estado = cbEstados.Text.ToString();
            int idCliente = int.Parse(cbClientes.SelectedValue.ToString());
            DateTime fecha = dtpFecha.Value;
            string observaciones = tbObservaciones.Text.ToString();

            // Encapsulo los datos en un objeto del tipo Poliza.
            Poliza poliza = new Poliza(importe, tipo, estado, fecha, observaciones, idCliente);



            // Si la poliza se ha registrado correctamente en la base de datos.
            if (AdminModel.registrarPoliza(poliza))
            {
                // Limpio el formulario
                limpiarFormularioCrearPoliza();
                // Muestro mensaje
                lbMensajeCrearPoliza.Text = "Acabas de crear una nueva poliza";
            }


            Console.WriteLine("Crear poliza: importe: " + importe + " tipo: " + tipo + " estado: " + estado + "idCliente: " + idCliente + " fecha " + fecha + " obsevaciones: " + observaciones);

        }

        // Limpia contendio del fomulario para crear una poliza
        private void limpiarFormularioCrearPoliza()
        {
            tbImporte.Text = "0";
            cbTipo.Text = "tipo";
            cbEstados.Text = "Selecciona estado";
            cbClientes.Text = "Selecciona cliente";
            dtpFecha.Text = "";
            lbMensajeCrearPoliza.Text = "";
        }

        // Editar los datos de una poliza
        private void btnEditarPoliza_Click(object sender, EventArgs e)
        {
            // El id de la poliza que quiero actualizar
            int idPoliza = polizaSeleccinada.Id;

            // Obtengo valor campos formulario editar
            int importe = int.Parse(tbImporteEditar.Text);
            string tipo = cbTipoEditar.Text;
            string estado = cbEstadosEditar.Text;
            DateTime fecha = dtpFechaEditar.Value;
            string observaciones = tbObservacionesEdiitar.Text;
            int idCliente = int.Parse(cbClientesEditar.SelectedValue.ToString());

            // Encapsulo los datos en un objeto del tipo Poliza.
            Poliza poliza = new Poliza(idPoliza, importe, tipo, estado, fecha, observaciones, idCliente);

            // Si ha actualizado la poliza en la basde de datos
            if (AdminModel.editarPoliza(poliza))
            {
                // Muestro mensaje
                lbMensajeEdtiarPoliza.Text = "Acaba de actualizar la poliza";
            }


            Console.WriteLine("Editar poliza: idPoliza: " + poliza.Id + " importe: " + importe + " tipo: " + tipo + " estado: " + estado +
                "idCliente: " + idCliente + " fecha " + fecha + " observaciones: " + observaciones);

        }

        // Cambia el color de las polizas segun su estado.
        private void CambiarColorFilas()
        {
            GestorInterfaz.CambiarColorFilas(dgvPolizas);
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtengo el indice de la provincia
            int idCliente = Convert.ToInt32(cbClientes.SelectedValue);
            Console.WriteLine("Cliente " + idCliente + "  seleccionado añadir a la poliza");
        }

        // Limpia mensaje placeholder de los campos del formulario una vez que haces click sobre uno
        private void limpiarPlaceholder(object sender, EventArgs e)
        {
            // Limpia el texto del TextBox que desencadenó el evento
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (textBox != null)
            {
                textBox.Text = string.Empty;
            }

        }

        // Carga el dgv con las polizas y las muestra de colores
        private void cargarPolizasDGV()
        {
            // Obtengo todas las polizas y las muestro en el dgv
            dgvPolizas.DataSource = AdminModel.getPolizas();
            // Cambio color polizas segun su estado
            cambiarColorPolizas();
        }

        // Vuelve al crud principal de polizas, contenedor principal
        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Oculto los paneles  para editar y crear polizas.
            panelCrearPoliza.Visible = false;
            panelEditarPoliza.Visible = false;
            panelDetallePoliza.Visible = false;
            // Actualizo, me traigo todas las polizas de la base de datos.
            cargarPolizasDGV();
            // Muestro el contenedor 
            panelCrudPolizas.Visible = true;
        }

        // Cierro la aplicacion
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
