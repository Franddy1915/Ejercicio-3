using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6__Convertor
{
    class convertor
    {
        public static void menu()
        {
            int x = 1;
            do
            {
            Console.WriteLine("Elige una opcion a convertir\n" +
                   "\n1.- Grados Celcius a Farenheit" +
                   "\n2.- Dolar a Peso" +
                   "\n3.- Metros a Pies" +
                   "\n4.- Salir\n");

            int s = 0;
            s = int.Parse(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        float f;
                        float resultado;
                        string hola = " Grados Celcius";
                        Console.WriteLine("Ingrese el valor Grado Farenhait ");
                        f = Convert.ToInt32(Console.ReadLine());
                        //Console.WriteLine("Presicione una tecla para continuar");
                        //Console.ReadKey();

                        resultado = cal_celcius(f);

                        Console.WriteLine("Esto equivale a: " + resultado + hola);
                        
                        // Aqui utilizo el paradigma de la recursividad
                        Volver_menu();

                        break;

                    case 2:

                        double peso;
                        double resul;
                        Console.WriteLine("Ingrese el monto en Dolar: ");
                        peso = Convert.ToInt32(Console.ReadLine());
                        resul = Dolar(peso);
                        Console.WriteLine("Este es su valor en Pesos: " + resul);
                         Volver_menu();
                        


                        break;
                    case 3:
                        double metro = 0;
                        Console.WriteLine("Ingrese la cantidad de metros a convetir");
                        metro = double.Parse(Console.ReadLine());
                        double total = Metro(metro);
                        Console.WriteLine("El resultado es: " + total);
                        Volver_menu();


                        break;
                    case 4:

                        Console.WriteLine("Gracias por usar nuestra aplicacion :D!");
                        System.Threading.Thread.Sleep(5000);
                        x = 0;
                        Environment.Exit(-1);


                        break;
                    default:
                        Console.WriteLine("Opcion invalidad");
                        break;
                
                
                }

            } while (x==1);

        }

        public static float cal_celcius(float f)
        {
           float resultado;
            resultado = (f - 32) * 5 / 9;
            return resultado;

        }

        public static double Dolar(double peso)
        {
            double dolar = 58.80;
            double resultado;
            
            resultado =dolar*peso;

            return resultado;

        }
        public static double Metro(double metro)
        {
            double total;
            double pie = 3.28084; 
            total = metro * pie;

            return total;

        }
        public static void Volver_menu()
        {
            
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            menu();

        }
    }

}
