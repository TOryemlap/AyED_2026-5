using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int Divisores(int Numero)
        {
            int suma = 0;

            for (int i = 1; i < Numero; i++)
            {
                if (Numero % i == 0)
                {
                    suma = suma + i;
                }
            }
            return suma;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un numero random: ");
            int numero = int.Parse(Console.ReadLine());
            int suma = Divisores(numero);
            if (suma == numero)
            {
                Console.WriteLine("pefeto pefeto caballero");
            }
            else
            {
                Console.WriteLine("no es pefeto");
            }
        }
    }
}
