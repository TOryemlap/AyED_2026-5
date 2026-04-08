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
            Console.Write("Años luz a viajar: ");
            int años = Convert.ToInt32(Console.ReadLine());
            Console.Write("Combustible disponible: ");
            int nafta = Convert.ToInt32(Console.ReadLine());
            int distancia = años * 12;
            if (nafta < distancia)
            {
                Console.WriteLine("Cálculos precisos. Saltando al hiperespacio.");
            }
            else
            {
                int combustiblenecesario = distancia - nafta;
                Console.WriteLine("Peligro: Combustible insuficiente. Faltan " + combustiblenecesario + " litros.");
            }
        }
    }
}
