using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            //int float bool char
            //double decimal long short string datetime
            Console.WriteLine("Hola Mundo");
            int a,b,c;
            Console.WriteLine("Ingrese un número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            b = int.Parse(Console.ReadLine());
            c=a+b;
            Console.WriteLine("El resultado es: "+c);
            Console.ReadKey();
        }
    }
}
