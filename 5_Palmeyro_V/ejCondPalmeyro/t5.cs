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
            Console.Write("Introduzca su nombre de usuario: ");
            String nombre = Console.ReadLine();
            Console.Write("Introduzca su contraseña: ");
            String contraseña = Console.ReadLine();
            if (nombre == "admin")
            {
                if (contraseña == "1234")
                {
                    Console.WriteLine("Acceso concedido.");
                }
                else
                    Console.WriteLine("Error de credenciales.");
            }
            else
            {
                Console.WriteLine("Error de credenciales.");
            }
        }
    }
}
