using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int pares(int par, int i, int impar, int mayor, int menor)
        {
            if (i % 2 == 0)
            {
                par++;
            }
            return par;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dos numeros. Introduzca el menor: ");
            int menor = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el mayor: ");
            int mayor = int.Parse(Console.ReadLine());

            int par = 0;
            int impar = 0;
            int contador = 0;

            for (int i = menor; i <= mayor; i++)
            {
                contador = contador + i;
                Console.WriteLine(i);
                par = pares(i, par, impar, mayor, menor);
            }

            int total = mayor - menor;
            impar = total - par;

            Console.WriteLine("Pares: " + par + " impares: " + impar + " Suma: " + contador);
        }
    }
}
