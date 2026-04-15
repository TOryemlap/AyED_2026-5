using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca su sueldo: ");
            int sueldo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca los años de antiguedad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 10)
            {
                int porcent = sueldo * 20 / 100;
                int aum = sueldo + porcent;
                Console.WriteLine("SU SUELDO MAS AUMENTO ES: $" + aum);
            }
            if (edad < 5)
            {
                int porcent2 = sueldo * 5 / 100;
                int aum2 = sueldo + porcent2;
                Console.WriteLine("SU SUELDO MAS AUMENTO ES: $" + aum2);
            }
        }
    }
}
