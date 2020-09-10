using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5__Meses
{
    class meses
    {
        public string devolver_meses(int x)
        {
            
            string linea="";


            switch (x)
            {
                case 1:
                    linea = "Enero";
                    break;
                case 2:
                    linea = "Febrero";
                    break;
                case 3:
                    linea = "Marzo";
                    break;
                case 4:
                    linea = "Abril";
                    break;
                case 5:
                    linea = "Mayo";
                    break;
                case 6:
                    linea = "Junio";
                    break;
                case 7:
                    linea = "Julio";
                    break;
                case 8:
                    linea = "Agosto";
                    break;
                case 9:
                    linea = "Septimbre";
                    break;
                case 10:
                    linea = "Octubre";
                    break;
                case 11:
                    linea = "Noviembre";
                    break;
                case 12:
                    linea = "Diciembre";
                    break;

                default:
                    Console.WriteLine("Ingrese un numero de mes valido");
                        
               break;
            
            }
            
            
            return linea;
        }
        public static void cerrar()
        {
            System.Threading.Thread.Sleep(5000);
            Environment.Exit(-1);
        }
    }
}
