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
            Console.Write("Introduzca su genero (M o F): ");
            String sexo = Console.ReadLine();
            Console.Write("Introduzca su genero: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (sexo == "F" && edad >= 60)
            {
                Console.WriteLine("Puede iniciar el tramite jubilatorio.");
            }
            else
            {
                Console.WriteLine("no puede iniciar el tramite");
            }
            if (sexo == "M" && edad >= 65)
            {
                Console.WriteLine("Puede iniciar el tramite jubilatorio.");
            }
            else
            {
                Console.WriteLine("no puede iniciar el tramite");
            }
        }
    }
}
