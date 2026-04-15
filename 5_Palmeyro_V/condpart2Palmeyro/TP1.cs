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
            Console.Write("Introduzca su peso: ");
            float peso = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca su altura: ");
            double alt = Convert.ToDouble(Console.ReadLine());
            double altm2 = alt * alt;
            double imc = peso / altm2;
            if (imc > 25)
            {
                Console.WriteLine("SOBREPESO");
            }
            else
            {
                Console.WriteLine("PESO NORMAL");
            }
        }
    }
}
