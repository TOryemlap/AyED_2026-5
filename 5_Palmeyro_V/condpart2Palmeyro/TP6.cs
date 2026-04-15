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
            Console.Write("Introduzca su promedio (1-10): ");
            int prom = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca la distancia de su casa a la facultad: ");
            int dist = Convert.ToInt32(Console.ReadLine());
            if (prom > 8 || dist > 50)
            {
                Console.WriteLine("Beca concedida");
            }
        }
    }
}
