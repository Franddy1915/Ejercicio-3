using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3__Validacion_de_datos
{
    class Herramientas
    {
        public static void validacion_datos(string usuario, string clave)
        {
            //Metedo validacion de datos
            if (usuario == "admin" && clave == "123456")
            {
                Console.WriteLine("Bienvenido {0}", usuario);
                //codigo para cerrar
                cerrar();
            }
            else
            {
                Console.WriteLine("Ingrese un usuario y contraseña valido \n ");
            }

        }
        public static void cerrar()
        {
            System.Threading.Thread.Sleep(5000);
            Environment.Exit(-1);
        }
    }
}
