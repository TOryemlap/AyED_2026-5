using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantas horas estuvo estacionado el vehiculo?: ");
            int hs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Con cuanto dinero va a abonar?: ");
            int abono = Convert.ToInt32(Console.ReadLine());
            int prmhs = 4000;
            if (hs > 1)
            {
                int hspagar = prmhs + 1600 * hs;
                int vuelto1 = abono - hspagar;

                if (vuelto1 <= 0)
                {
                    int falta1 = hspagar - abono;
                    Console.WriteLine("Dinero insuficiente, faltan $" + falta1 + " para abonar");
                }
                else
                {
                    Console.WriteLine("Su vuelto es: $" + vuelto1);
                }
            }
            if (hs == 1)
            {
                int vuelto2 = abono - 4000;
                if (vuelto2 <= 0)
                {
                    int falta2 = 4000 - abono;
                    Console.WriteLine("Dinero insuficiente, faltan $" + falta2 + " para abonar");
                }
                else
                {
                    Console.WriteLine("Su vuelto es: $" + vuelto2);
                }
            }
        }
    }
}



