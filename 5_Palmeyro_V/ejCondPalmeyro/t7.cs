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
            Console.Write("Introduzca un numero para saber si es multiplo de 5: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("su numero es multiplo de 5");
            }
            else
            {
                Console.WriteLine("su numero NO es multiplo de 5");
            }   
        }
    }
}
