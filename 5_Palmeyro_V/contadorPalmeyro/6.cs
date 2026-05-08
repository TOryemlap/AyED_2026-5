using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca los gastos realizados en el dia:");
            int contador = 0;
            int num = 0;
            int gastostotales = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Cuanto gastó?: ");
                num = int.Parse(Console.ReadLine());
                gastostotales = gastostotales + num;
                if (num > 500)
                {
                    contador++;
                }
            }
            Console.WriteLine("dinero gastado: $" + gastostotales);
            Console.WriteLine("gastos mayores a $500: " + contador);
        }
    }
}
