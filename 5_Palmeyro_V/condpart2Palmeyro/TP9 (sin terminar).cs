using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantas horas estuvo estacionado el vehiculo?: ");
            int hs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Con cuanto dinero va a abonar?: ");
            int abono = Convert.ToInt32(Console.ReadLine());
            if (hs == 1)
            {
                int vuelto = abono - 4000;
                if (vuelto <= 0)
                {
                    int falta = 4000 - abono;
                    Console.WriteLine("Dinero insuficiente, faltan $" + falta + " para abonar");
                }
                else
                {
                    
                }
            }
        }
    }
}
