using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void ContarHasta(int numero)
        {
            for (int i = 1; i <= numero; i++)
            {
                numero = numero + i;
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero para la cuenta regresiva: ");
            int numero = int.Parse(Console.ReadLine());
            ContarHasta(numero);
        }
    }
}
