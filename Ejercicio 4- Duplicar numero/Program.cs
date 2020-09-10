using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4__Duplicar_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double resultado = 0;
            Console.WriteLine("Ingrese su numero");
             x = double.Parse(Console.ReadLine());

            //instanciacion de la funcion
            operacion y = new operacion();
            resultado = y.operador(x);

            //resultado = operacion.operador(x);
            Console.WriteLine("Su resultado es: {0}",resultado );
            Console.ReadKey();

        }
    }
}
