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
            Console.Write("Introduzca la temperatura actual: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine("Peligro de congelamiento");
            }
            else if (temp < 15)
            {
                Console.WriteLine("Mucho frio.");
            }
            else
            {
                Console.WriteLine("Clima agradable");
            }
        }
    }
}
