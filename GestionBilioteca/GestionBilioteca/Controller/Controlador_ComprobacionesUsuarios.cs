using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestionBilioteca.Controller
{
    public static class Controlador_ComprobacionesUsuarios
    {
        public static bool comprobarDni(string dni)
        {
            if (string.IsNullOrEmpty(dni) || dni.Length != 9)
            {
                return false;
            }

            string dniLetters = "TRWAGMYFPDXBNJZSQVHLCKE";
            char letraCalculada = dniLetters[Convert.ToInt32(dni.Substring(0, 8)) % 23];

            Console.WriteLine($"Número DNI: {dni.Substring(0, 8)}");
            Console.WriteLine($"Letra Calculada: {letraCalculada}");

            return letraCalculada == dni[8];
        }

        public static bool comprobarNie(string nie)
        {
            if (string.IsNullOrEmpty(nie) || nie.Length != 9)
            {
                return false;
            }

            char niePrefix = nie[0];

            // Considerar el valor correspondiente a cada letra del NIE
            int valorPrefijo;
            switch (niePrefix)
            {
                case 'X': valorPrefijo = 0; break;
                case 'Y': valorPrefijo = 1; break;
                case 'Z': valorPrefijo = 2; break;
                default: return false; // Retornar falso si el prefijo no es 'X', 'Y', o 'Z'
            }

            // Asegurarse de que el número del DNI tenga 7 dígitos
            string dniParaValidar = valorPrefijo + nie.Substring(1).PadLeft(7, '0');

            Console.WriteLine($"DNI a validar: {dniParaValidar}");

            return comprobarDni(dniParaValidar);
        }

        public static bool comprobarTelefono(String telefono)
        {
            return ((telefono.Length == 9) && (int.TryParse(telefono, out _))) ? true : false;
        }

        public static bool comprobarCorreo(String correo)
        {
            string patronCorreo = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return (string.IsNullOrEmpty(correo)) ? false : Regex.IsMatch(correo, patronCorreo);
        }

        public static bool ComprobarClaves(String clave, String claveConfirmacion)
        {
            return !string.IsNullOrEmpty(clave) && (clave == claveConfirmacion);
        }
    }
}
