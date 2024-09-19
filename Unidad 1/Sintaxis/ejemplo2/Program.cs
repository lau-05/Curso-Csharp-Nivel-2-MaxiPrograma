using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONDICIONALES
            //IF
            int a, b;
            Console.WriteLine("Ingrese a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b: ");
            b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("a es menor que b");
            }
            else
            {
                Console.WriteLine("b es menor que a");
            }

            /*
             * SWITCH
            switch (a)
            {
                case 1: 
                    Console.WriteLine("Caso 1");
                    break;
                case 2: 
                    Console.WriteLine("Caso 2");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            */
Console.ReadKey();
        }
    }
}