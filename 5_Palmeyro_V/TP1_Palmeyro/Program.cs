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
            String nombre;
            String pelicula;

            Console.WriteLine("Hola crack, maquina, bestia, etc...");
            Console.Write("¿Cual es tu nombre?: ");
            nombre = Console.ReadLine();
            Console.Write("¿Cual es tu pelicula favorita?: ");
            pelicula = Console.ReadLine();
            Console.Write("Hola " + nombre + ". Tu pelicula preferida " + pelicula + " es una porqueria.");
        }
    }
}
