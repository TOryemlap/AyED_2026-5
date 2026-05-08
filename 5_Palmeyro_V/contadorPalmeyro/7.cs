using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Intruduzca un numero para analizar si es primo o no: ");
            int num = int.Parse(Console.ReadLine());
            int divisor = 0;
            if (num <=1)
            {
                Console.WriteLine("El numero no es primo.");
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        divisor = i;
                        break;
                    }
                }
                if (divisor == 0)
                {
                    Console.WriteLine("El numero es primo.");
                }
                else
                {
                    Console.WriteLine("El numero no es primo.");
                    Console.WriteLine("El primer divisor encontrado fue: " + divisor);
            }
        }
    }
}
}
