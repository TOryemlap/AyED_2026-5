using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int mayor(int num, int may)
        {
            if (num > may)
            {
                return num;
            }
            else { return may;  }
        }
        static int menor(int num)
        {
            int men = num;
            if (num < men)
            {
                men = num;
            }
            //Console.WriteLine(men);
            return men;
        }
        static int promedio(int num)
        {
            int x = 0;
            for (int i = 1; i <= num; i++)
            {
                x = x + num;
            }
            int prom = x / 5;
            //Console.WriteLine(prom);
            return prom;
        }
        static int pares(int num, int par = 0)
        {
            if (num % 2 == 0)
            {
                par++;
            }
            //Console.WriteLine(par);
            return par;
        }
        static int impares(int num, int impar = 0)
        {
            if (num % 2 == 0)
            {
                impar++;
            }
            //Console.WriteLine(impar);
            return impar;
        }
            static void Main(string[] args)
        {
            int num, may = 0, men = 0, prom = 0, par = 0, impar = 0;
            for (int i = 1; i <= 5; i++)
            {
                
                Console.WriteLine("Dame 5 numeros random: ");
                num = int.Parse(Console.ReadLine());
                may = mayor(num, may);
                men = menor(num);
                prom = promedio(num);
                par = pares(num);
                impar = impares(num);
            }
            Console.WriteLine("mayor: " + may);
            //Console.WriteLine("menor: " + men);
            //Console.WriteLine("promedio: " + prom);
            //Console.WriteLine("mayor: " + may);
        }
    }
}
