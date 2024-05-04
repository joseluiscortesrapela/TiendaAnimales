using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda.Helper
{
    public static class GestorInterfaz
    {


        public static DataGridView CambiarColorFilas(DataGridView dgvPolizas)
        {
            foreach (DataGridViewRow row in dgvPolizas.Rows)
            {
                if (row.Cells["estado"].Value != null)
                {
                    string estado = row.Cells["estado"].Value.ToString();

                    switch (estado)
                    {
                        case "Cobrada":
                            row.DefaultCellStyle.BackColor = Color.LightBlue;
                            break;
                        case "A cuenta":
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        case "Liquidada":
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                            break;
                        case "Anulada":
                            row.DefaultCellStyle.BackColor = Color.LightSalmon;
                            break;

                    }
                }
            }

            return dgvPolizas;

        }



    }
}
