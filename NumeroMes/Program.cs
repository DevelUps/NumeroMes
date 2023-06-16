using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float NumeroMes;
           
            //Este programa le pide al usuario un número del 1 al 12 y escriba el nombre del mes que corresponde ese número en el calendario. Agregar un case default.


            Console.Write("Por favor, ingresa el numero para validar el mes:  ");
            NumeroMes = Convert.ToSingle(Console.ReadLine());

            switch (NumeroMes)
            {
                case 1:
                    Console.WriteLine("El mes {0} es Enero", NumeroMes);
                    break;
                case 2:
                    Console.WriteLine("El mes {0} es Febrero", NumeroMes);
                    break;
                case 3:
                    Console.WriteLine("El mes {0} es Marzo", NumeroMes);
                    break;
                case 4:
                    Console.WriteLine("El mes {0} es Abril", NumeroMes);
                    break;
                case 5:
                    Console.WriteLine("El mes  {0} es Mayo", NumeroMes);
                    break;
                case 6:
                    Console.WriteLine("El mes {0} es Junio", NumeroMes);
                    break;
                case 7:
                    Console.WriteLine("El mes {0} es Julio", NumeroMes);
                    break;
                case 8:
                    Console.WriteLine("El mes  {0} es Agosto", NumeroMes);
                    break;
                case 9:
                    Console.WriteLine("El mes {0} es Septiembre", NumeroMes);
                    break;
                case 10:
                    Console.WriteLine("El mes {0} es Octubre", NumeroMes);
                    break;
                case 11:
                    Console.WriteLine("El mes  {0} es Noviembre", NumeroMes);
                    break;
                case 12:
                    Console.WriteLine("El mes {0} es Diciembre", NumeroMes);
                    break;
                default : Console.WriteLine("El numero {0} ingrasado no coincide con el numero de mes, ingresa un valor del 1 al 12.  ");
                    break;


            }

        }
    }
}
