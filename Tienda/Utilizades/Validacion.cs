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
        
        // Comprueba si la cadena esta vacia
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

        // Comprueba si el dni es valido
        public static bool esUnDNIValido(string dni)
        {
            // Verificar si el DNI tiene la longitud correcta
            if (dni.Length != 9)
            {
                return false;
            }

            // Verificar si los primeros 8 caracteres son dígitos
            if (!int.TryParse(dni.Substring(0, 8), out _))
            {
                return false;
            }

            // Verificar si el último carácter es una letra válida
            char letra = char.ToUpper(dni[8]);
            string letrasValidas = "TRWAGMYFPDXBNJZSQVHLCKE";
            int resto = int.Parse(dni.Substring(0, 8)) % 23;
            char letraCalculada = letrasValidas[resto];

            return letra == letraCalculada;
        }

        // Comprueba si un correo es valido
        public static bool esCorreoElectronicoValido(string correo)
        {
            // Expresión regular para validar un correo electrónico
            string patronCorreo = @"^[a-zA-Z0-9._%+ñÑ-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            // Verificar si el correo coincide con el patrón de la expresión regular
            return Regex.IsMatch(correo, patronCorreo);
        }


        // Comprueba si el telefono es valido
        public static bool esNumeroTelefonoValido(string cadena)
        {
            return cadena.Length == 9 && int.TryParse(cadena, out _);
        }

    }


}
