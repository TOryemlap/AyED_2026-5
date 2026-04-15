using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca el sueldo actual: ");
            int sueldo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca cuando dinero se quiere retirar: ");
            int ret = Convert.ToInt32(Console.ReadLine());
            if (sueldo < ret)
            {
                Console.WriteLine("SALDO INSUFICIENTE");
            }
            else
            {
                if (ret % 1000 == 0)
                {
                    Console.WriteLine("OPERACIÓN PERMITIDA");
                }
                else
                {
                    Console.WriteLine("SOLO BILLETES DE 1000");
                }
            }     
        }
    }
}
