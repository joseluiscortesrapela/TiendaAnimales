using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Forms;

namespace Tienda.Sesion
{
    public static class SesionPrograma
    {

        private static MenuPrincipal menuPrincipal;

        public static void guardarReferenciaMenuPrincipal(MenuPrincipal menu)
        {
            menuPrincipal = menu;
        }

        public static MenuPrincipal ObtenerMenuPrincipal()
        {
            return menuPrincipal;
        }
      
    }
}
