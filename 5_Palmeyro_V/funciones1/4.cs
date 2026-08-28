using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int Factorial(int numero)
        {
            int suma = 1;
            for (int i = 1; i <= numero; i++)
            {
                suma = suma + i;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero: ");
            int numero = int.Parse(Console.ReadLine());
            int res = Factorial(numero);
            Console.WriteLine(res);
        }
    }
}