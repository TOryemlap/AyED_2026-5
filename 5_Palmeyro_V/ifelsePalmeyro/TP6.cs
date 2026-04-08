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
            Console.Write("cual es el peso de la nave?: ");
            int peso = Convert.ToInt32(Console.ReadLine());
            if (peso <= 5000)
            {
                Console.WriteLine("Despegue autorizado.Buen viaje, Mando.");
            }
            else
            {
                int pesodif = peso - 5000;
                Console.WriteLine("Alerta: Exceso de peso. Debes descargar " + pesodif + "kg para despegar");
            }
        }
    }
}
