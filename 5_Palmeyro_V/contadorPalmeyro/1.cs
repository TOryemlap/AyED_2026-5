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
            Console.WriteLine("Introduzca la letra que quiere saber la calificación:");
            Console.WriteLine("A.");
            Console.WriteLine("B.");
            Console.WriteLine("C.");
            Console.WriteLine("D.");
            Console.WriteLine("F.");
            String letra = Console.ReadLine();
            switch (letra)
            {
                case "A":
                    Console.WriteLine("la letra A es EXCELENTE.");
                    break;
                case "B":
                    Console.WriteLine("la letra B es BUENO.");
                    break;
                case "C":
                    Console.WriteLine("la letra C es REGULAR.");
                    break;
                case "D":
                    Console.WriteLine("la letra D es SUFICIENTE.");
                    break;
                case "F":
                    Console.WriteLine("la letra F es REPROBADO.");
                    break;
            }
        }
    }
}
