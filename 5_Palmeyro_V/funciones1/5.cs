using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int Potencia(int numero, int pot)
        {
            int suma = 1;
            for (int i = 1; i <= pot; i++)
            {
                suma = suma * numero;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba una potencia: ");
            int pot = int.Parse(Console.ReadLine());
            int res = Potencia(numero, pot);
            Console.WriteLine(res);
        }
    }
}
