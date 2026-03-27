using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Palmeyro
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola usuario");
            Console.Write("Introduzca su año de nacimiento: ");
            int año = Convert.ToInt32(Console.ReadLine());
            int edad = 2026 - año;
            Console.WriteLine("Tu edad si naciste en el año " + año + " es de " + edad + " años.");
        }
    }
}
