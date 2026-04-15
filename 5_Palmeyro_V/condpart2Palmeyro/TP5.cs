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
            Console.Write("Introduzca la cantidad de segundos: ");
            int seg = Convert.ToInt32(Console.ReadLine());
            if (seg > 60)
            {
                int min = seg / 60;
                int segrest = seg % 60;
                Console.WriteLine(min + " minutos y " + segrest + " segundos.");
            }
            else
                Console.WriteLine(seg + " segundos.");
        }
    }
}
