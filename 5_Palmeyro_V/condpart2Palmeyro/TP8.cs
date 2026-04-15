using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el tercer  numero: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " es el numero mayor.");
            }
            if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + " es el numero mayor.");
            }
            if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine(num3 + " es el numero mayor.");
            }
        }
    }
}
