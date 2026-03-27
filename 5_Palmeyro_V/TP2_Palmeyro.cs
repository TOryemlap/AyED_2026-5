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
            String juego;
            String consola;

            Console.WriteLine("Hola crack, maquina, bestia, etc...");
            Console.Write("¿Cual es tu nombre?: ");
            nombre = Console.ReadLine();
            Console.Write("¿Cual es tu juego favorito?: ");
            juego = Console.ReadLine();
            Console.Write("¿En que consola se juega?: ");
            consola = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ". Tu juego favorito es " + juego + " y se juega en " + consola);
        }
    }
}
