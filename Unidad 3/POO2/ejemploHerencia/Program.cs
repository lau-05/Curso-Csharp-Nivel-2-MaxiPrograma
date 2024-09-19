using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona >>> Lider > Developer > Tester
            Persona p1 = new Persona();
            Developer d1 = new Developer();
            Developer d2 = new Java_Developer();

            Persona p2 = new Lider();
            Persona d3 = new Java_Developer();
            Lider lider = new Lider();
            Lider.algo();

            Console.WriteLine("hola");
        }
    }
}
