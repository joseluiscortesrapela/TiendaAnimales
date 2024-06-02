﻿using System;
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

        public static bool esUnaCadenaVacia(string cadena)
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
            // con una parte entera mayor que 0 o un número decimal con una parte decimal de hasta dos dígitos.
            Regex regex = new Regex(@"^(0|[1-9]\d*)\,\d{1,2}$");

            // Verificamos si el texto coincide con el patrón de la expresión regular.
            return regex.IsMatch(cadena);

        }



    }


}
