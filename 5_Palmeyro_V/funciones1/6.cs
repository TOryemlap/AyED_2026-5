using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Primos(int num)
        {
            int div = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    div++;
                }
            }
            if (div == 2)
            {
                Console.WriteLine("El numero es primo!!!!!!!!!!!!!");
            }
            else
            {
                Console.WriteLine("El numero no es primo...........");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Ingresé un numero para ver si es primo o no.");
            int num = int.Parse(Console.ReadLine());
            Primos(num);
        }
    }
}
