using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tienda.Utilizades
{
    public class Validacion
    {

        public static bool isEstaUnaVacia(string cadena)
        {
            // Verificar si la cadena está vacía
            return string.IsNullOrWhiteSpace(cadena);
        }

        // Comprueba si es un numero entero
        public static bool siEsUnNumeroEntero(string cadena)
        {
            return int.TryParse(cadena, out _);
        }


        // Comprueba si es un numero decimal
        public static bool siEsNumeroDecimal(string cadena)
        {
            // Utilizamos una expresión regular para validar que el texto sea un número decimal
            // con un máximo de dos decimales.
            Regex regex = new Regex(@"^\d+(\.\d{1,2})?$");

            // Verificamos si el texto coincide con el patrón de la expresión regular.
            return regex.IsMatch(cadena);

        }



    }


}
