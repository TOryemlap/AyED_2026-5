using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el idioma: ");
            Console.WriteLine("1. Inglés.");
            Console.WriteLine("1. Francés.");
            Console.WriteLine("3. Alemán.");
            Console.Write("Introduzca el número correspondiente al idioma: ");
            String letra = Console.ReadLine();
            switch (letra)
            {
                case "1":
                    Console.WriteLine("Hello.");
                    break;
                case "2":
                    Console.WriteLine("Salut.");
                    break;
                case "3":
                    Console.WriteLine("Hallo.");
                    break;
            }
        }
    }
}
