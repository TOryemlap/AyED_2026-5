using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la cantidad de droides a comprar ($2000 c/u): ");
            int droides = Convert.ToInt32(Console.ReadLine());
            int precio = droides * 2000;
            if (droides >= 3)
            {
                int descuento = precio * 20 / 100;
                int preciodesc = precio - descuento;
                Console.WriteLine("El precio final es de $" + preciodesc);
            }
            else
            {
                Console.WriteLine("El precio final es de $" + precio);
            }
        }
    }
}
