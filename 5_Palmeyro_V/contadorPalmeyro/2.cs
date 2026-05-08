using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca 5 números random:");
            int contador = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Introduzca un numero: ");
                int num = int.Parse(Console.ReadLine());
                if (num > 100)
                {
                    contador++;
                }
            }
            Console.WriteLine("los numeros mayores a 100 fueron " + contador);
        }
    }
}
