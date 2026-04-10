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
            Console.Write("Introduzca el presupuesto disponible: ");
            int presupuesto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca el costo de los materiales: ");
            int costo = Convert.ToInt32(Console.ReadLine());
            if (presupuesto < costo)
            {
                int dif = costo - presupuesto;
                Console.WriteLine("el presupuesto es menor que el costo");
                Console.WriteLine("Dinero faltante: " + dif);
            }
            else
            {
                Console.WriteLine("Los precios coinciden.");
            }   
        }
    }
}
