using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar datos para el primer teléfono
            Console.WriteLine("Ingrese el modelo del primer teléfono:");
            string modelo1 = Console.ReadLine();
            Console.WriteLine("Ingrese la marca del primer teléfono:");
            string marca1 = Console.ReadLine();

            // Crear el primer objeto Telefono
            Telefono telefono1 = new Telefono(modelo1, marca1);

            Console.WriteLine("Ingrese el número telefónico del primer teléfono:");
            telefono1.NumeroTelefonico = Console.ReadLine();

            Console.WriteLine("Ingrese el código de operador (1, 2, 3) del primer teléfono:");
            int codigoOperador1;
            while (!int.TryParse(Console.ReadLine(), out codigoOperador1) || (codigoOperador1 != 1 && codigoOperador1 != 2 && codigoOperador1 != 3))
            {
                Console.WriteLine("Código de operador inválido. Por favor, ingrese 1, 2 o 3:");
            }
            telefono1.CodigoOperador = codigoOperador1;

            // Solicitar datos para el segundo teléfono
            Console.WriteLine("Ingrese el modelo del segundo teléfono:");
            string modelo2 = Console.ReadLine();
            Console.WriteLine("Ingrese la marca del segundo teléfono:");
            string marca2 = Console.ReadLine();

            // Crear el segundo objeto Telefono
            Telefono telefono2 = new Telefono(modelo2, marca2);

            Console.WriteLine("Ingrese el número telefónico del segundo teléfono:");
            telefono2.NumeroTelefonico = Console.ReadLine();

            Console.WriteLine("Ingrese el código de operador (1, 2, 3) del segundo teléfono:");
            int codigoOperador2;
            while (!int.TryParse(Console.ReadLine(), out codigoOperador2) || (codigoOperador2 != 1 && codigoOperador2 != 2 && codigoOperador2 != 3))
            {
                Console.WriteLine("Código de operador inválido. Por favor, ingrese 1, 2 o 3:");
            }
            telefono2.CodigoOperador = codigoOperador2;

            // Mostrar estado de los teléfonos
            Console.WriteLine($"Telefono 1: Modelo={telefono1.Modelo}, Marca={telefono1.Marca}, Numero={telefono1.NumeroTelefonico}, CodigoOperador={telefono1.CodigoOperador}");
            Console.WriteLine($"Telefono 2: Modelo={telefono2.Modelo}, Marca={telefono2.Marca}, Numero={telefono2.NumeroTelefonico}, CodigoOperador={telefono2.CodigoOperador}");

            // Probar métodos Llamar
            Console.WriteLine("Probando llamada sin contacto para Telefono 1:");
            Console.WriteLine(telefono1.Llamar());

            Console.WriteLine("Ingrese un contacto para llamar desde el primer teléfono:");
            string contacto1 = Console.ReadLine();
            Console.WriteLine(telefono1.Llamar(contacto1));

            Console.WriteLine("Probando llamada sin contacto para Telefono 2:");
            Console.WriteLine(telefono2.Llamar());

            Console.WriteLine("Ingrese un contacto para llamar desde el segundo teléfono:");
            string contacto2 = Console.ReadLine();
            Console.WriteLine(telefono2.Llamar(contacto2));

            // Mantener la consola abierta
            Console.ReadLine();
        }
    }
}