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
            Console.Write("Introduzca la edad del primer hermano: ");
            int edad1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca la edad del segundo hermano: ");
            int edad2 = Convert.ToInt32(Console.ReadLine());
            if (edad1 > edad2)
            {
                int dif = edad1 - edad2;
                Console.WriteLine("El hermano 1 es mayor que el hermano 2");
                Console.WriteLine("La diferencia de edad es de: " + dif);
            }
            else
            {
                int dif = edad2 - edad1;
                Console.WriteLine("El hermano 2 es mayor que el hermano 1");
                Console.WriteLine("La diferencia de edad es de: " + dif);
            }   
        }
    }
}
