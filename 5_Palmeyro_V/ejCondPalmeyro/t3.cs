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
            Console.Write("Cual es la nota del examen?: ");
            double nota = Convert.ToInt32(Console.ReadLine());
            if (nota >= 7)
            {
                Console.WriteLine("Promocionado.");
            }
            else if (nota > 4)
            {
                Console.WriteLine("A finales.");
            }
            if (nota < 4)
            {
                Console.WriteLine("Recuperatorio.");
            }
        }
    }
}
