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
            Console.Write("¿Cuantas facturas fueron producidas?: ");
            int facturas = Convert.ToInt32(Console.ReadLine());
            Console.Write("¿Cuantas docenas fueron vendidas?: ");
            int docenasvendidas = Convert.ToInt32(Console.ReadLine());
            Console.Write("¿Cual es el precio por docena?: ");
            int precio12 = Convert.ToInt32(Console.ReadLine());
            int dinerorec = docenasvendidas * precio12;
            int sobrante = facturas - (docenasvendidas * 12);
            if (facturas >= 12)
            {
                if (sobrante <= 6)
                {
                    Console.WriteLine("Producción eficiente.");
                }
                else
                {
                    Console.WriteLine("ALERTA: EXCESO DE PRODUCCIÓN.");
                }
            }
            Console.WriteLine("dinero recaudado: $" + dinerorec);

        }
    }
}
