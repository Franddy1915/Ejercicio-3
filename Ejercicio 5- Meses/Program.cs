using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5__Meses
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;
            
            Console.WriteLine("MESES DEL AÑO");
            Console.Write("Ingrese un numero del 1 al 12 :");
            linea = Console.ReadLine();
            num = int.Parse(linea);

            meses y = new meses();
            linea=y.devolver_meses(num);

            Console.WriteLine($"MESES DEL AÑO ES: {linea}");

            //Cerrar programa despues de 5 segundos
            meses.cerrar();
            

        }
           

        
       
    }
}
