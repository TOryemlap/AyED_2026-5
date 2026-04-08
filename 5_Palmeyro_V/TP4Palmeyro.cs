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

            Console.Write("Decime un numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("decime el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resultadosum = num1 + num2;
            int resultadore = num1 - num2;
            int resultadomult = num1 * num2;
            int resultadodiv = num1 / num2;
            Console.WriteLine("el resultado de la suma es: " + resultadosum);
            Console.WriteLine("el resultado de la resta es: " + resultadore);
            Console.WriteLine("el resultado de la multiplicación es: " + resultadomult);
            Console.WriteLine("el resultado de la división es: " + resultadodiv);
        }
    }
}
