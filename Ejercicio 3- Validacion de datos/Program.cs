using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Ejercicio_3__Validacion_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            

            do
            {
                string usuario = "";
                string clave = "";
                Console.WriteLine($"Intento #{x+1} ");
                Console.WriteLine("Ingrese su usuario");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese su clave");
                clave = (Console.ReadLine());
                Console.WriteLine(" \n \n");

                x++;
                //Medoto validacion de datos
                Herramientas.validacion_datos(usuario,clave);

            } while (x <= 2);

            Console.ReadKey();
        }//-----------------
        
    }
}