using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




 namespace Ejercicio_2_Numero_interminados
{
    class Program
    {
        static void Main(string[] args)
       {
            
            //Instancia para numeros random
       
            Random random = new Random();
            int r= random.Next(5, 8);

            int snumeros = 0;
            int[] numeros = new int[r] ;

            //--------------presentacion de acciones----------------------
             for (int i = 0; i < numeros.Length; i++)
             {
                 Console.Write($"Ingrese valor {i + 1} : " );
                 numeros[i] = int.Parse(Console.ReadLine());

                snumeros = snumeros + numeros[i];

                if(numeros[i] ==0)
                {

                    for (
                        i = 0; i < numeros.Length; i++)
                    {
                        Console.WriteLine("El numero es: {0}", numeros[i]);
                    }


                    Console.WriteLine("\n ---------------");
                    Console.WriteLine("La suma de todos los numeros es: {0}", snumeros);
                    System.Threading.Thread.Sleep(5000);
                    Environment.Exit(-1);

                }

             }
                
            
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("El numero es: {0}", numeros[i]);
            }
           
           
            Console.WriteLine("\n ---------------");
            Console.WriteLine("La suma de todos los numeros es: {0}", snumeros);
            Console.ReadLine();


            Console.ReadKey();
            

        }
    }
}
