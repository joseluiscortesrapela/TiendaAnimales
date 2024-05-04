using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Sesion
{
    public static class SesionPrograma
    {
        private static String dondeEstoy;

        public static string DondeEstoy { get => dondeEstoy; set => dondeEstoy = value; }
    }
}
