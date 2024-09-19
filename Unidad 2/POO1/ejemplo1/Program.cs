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
            //PERSONA
            Persona p1 = new Persona();
            p1.setEdad(20);
            Console.WriteLine("La edad de la persona es: " + p1.getEdad());

            //BOTELLA
            Botella b1 = new Botella();
            b1.Capacidad = 1500;
            int algo = b1.Capacidad;

            //PERRO
            Perro perro1 = new Perro();
            Console.WriteLine("Ingrese el nombre del perro: ");
            perro1.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la raza del perro: ");
            perro1.Raza = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del perro: ");
            perro1.Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("El perro se llama: " + perro1.Nombre);
            Console.WriteLine("La raza del perro es: " + perro1.Raza);
            Console.WriteLine("La edad del perro es: " + perro1.Edad);



            Console.ReadKey();
        }
    }
}
