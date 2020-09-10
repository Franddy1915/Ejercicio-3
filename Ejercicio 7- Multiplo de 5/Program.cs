using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio_7__Multiplo_de_5
{
    class Program
    {
        static void Main(string[] args)

        {
            for (int i = 1; i <=1000; i++)
            {
                if (i%5==0)
                {
                    //Console.WriteLine("Los numero multiplo de 5 son: {0}",i);
                    tabla_5(i);
                }
                
            }
            Console.ReadKey();
        }
        public static void tabla_5(int x) 
        {
            Console.WriteLine("\n \n");
            Console.WriteLine("******* Tabla del {0} *********", x);
            Console.WriteLine("\t{0} X 1: {1}", x, x * 1);
            Console.WriteLine("\t{0} X 2: {1}", x, x * 2);
            Console.WriteLine("\t{0} X 3: {1}", x, x * 3);
            Console.WriteLine("\t{0} X 4: {1}", x, x * 4);
            Console.WriteLine("\t{0} X 5: {1}", x, x * 5);
            Console.WriteLine("\t{0} X 6: {1}", x, x * 6);
            Console.WriteLine("\t{0} X 7: {1}", x, x * 7);
            Console.WriteLine("\t{0} X 8: {1}", x, x * 8);
            Console.WriteLine("\t{0} X 9: {1}", x, x * 9);
            Console.WriteLine("\t{0} X 10: {1}", x, x * 10);
            Console.WriteLine("\t{0} X 11: {1}", x, x * 11);
            Console.WriteLine("\t{0} X 12: {1}", x, x * 12);

        }
    }
}
