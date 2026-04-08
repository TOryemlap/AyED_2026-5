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
            Console.Write("Cuantos minutos estuvo el auto estacionado: ");
            int minutos = Convert.ToInt32(Console.ReadLine());
            int hora = minutos / 60;
            int resto = minutos % 60;
            Console.WriteLine("estuviste estacionado: " + hora + "horas y " + resto + "minutos.");
            int preciohora = hora * 6000;
            int preciominuto = resto * 150;
            int preciototal = preciohora + preciominuto;
            Console.WriteLine("Precio total: $" + preciototal);
            float iva = preciototal * 21 / 100;
            float montofinal = preciototal + iva;
            Console.WriteLine("Precio IVA: $" + iva);
            Console.WriteLine("Monto a pagar: $" + montofinal);
        }
    }
}
