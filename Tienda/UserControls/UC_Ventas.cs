﻿using System;
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
    public partial class UC_Ventas : UserControl
    {
        public UC_Ventas()
        {
            InitializeComponent();
        }

 

        private void limpiarPlaceholderCbCliente(object sender, EventArgs e)
        {
            cbCliente.Text = "";
        }
 
    }
}
