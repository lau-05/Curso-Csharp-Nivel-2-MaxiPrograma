using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FUNCIONES
            int n1, n2;
            Console.WriteLine(saludar("Lautaro"));
            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma es: " + sumar(n1, n2));
            Console.ReadKey();
        }
        static int sumar(int a, int b)
        {
            return a + b;
        }
        static string saludar(string nombre)
        {
            return "Buenos dias " + nombre;
        }
    }
}
