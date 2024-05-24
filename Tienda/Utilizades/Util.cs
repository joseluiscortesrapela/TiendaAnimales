using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda.Utilizades
{
    public static class Util
    {

        public static DataGridView CambiarColorFilasDependiendoDeSuStock(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["stock"].Value != null)
                {
                    int stock = int.Parse(row.Cells["stock"].Value.ToString());

                    if (stock == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }

            return dgv;

        }


    }
}
