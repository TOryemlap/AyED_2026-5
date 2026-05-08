using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca su producto del menú: ");
            Console.WriteLine("(S)ándwich.");
            Console.WriteLine("(P)izza.");
            Console.WriteLine("(H)amburguesa.");
            Console.Write("Introduzca la letra correspondiente al producto: ");
            String letra = Console.ReadLine();
            switch (letra)
                {
                case "S":
                    Console.WriteLine("Su producto es: Sandwich.");
                    Console.WriteLine("Su precio es: $5500.");
                    break;
                case "P":
                    Console.WriteLine("Su producto es: Pizza.");
                    Console.WriteLine("Su precio es: $13200.");
                    break;
                case "H":
                    Console.WriteLine("Su producto es: Hamburguesa.");
                    Console.WriteLine("Su precio es: $10300.");
                    break;
            }
        }
    }
}
