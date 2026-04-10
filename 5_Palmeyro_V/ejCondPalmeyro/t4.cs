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
            Console.Write("Cual es el monto de la compra?: ");
            float compra = Convert.ToInt32(Console.ReadLine());
            if (compra > 5000)
            {
                float descuento = compra * 15 / 100;
                float preciofinal = compra - descuento;
                Console.WriteLine("total a pagar (15% de descuento): " + preciofinal);
            }
            else
            {
                Console.WriteLine("Total a pagar: " + compra);
            }
        }
    }
}
