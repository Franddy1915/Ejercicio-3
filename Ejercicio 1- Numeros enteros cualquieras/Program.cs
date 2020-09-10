using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_1__Numeros_enteros_cualquieras
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = 0;
            int final= 0;
            
            
            Console.WriteLine("inicio");
            inicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("final");
            final = Convert.ToInt32(Console.ReadLine());
            while (inicio<=final)
            {
                
                Console.WriteLine(inicio);
                inicio++;

            }
            while(inicio>=final)
            {

                Console.WriteLine(inicio);
                inicio--;
            }
            Console.ReadKey();
        }
    }
}
