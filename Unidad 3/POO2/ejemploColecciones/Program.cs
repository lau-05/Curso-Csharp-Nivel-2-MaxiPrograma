﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploColecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo >>> Auto > AutoDeportivo > AutoUrbano
            //>Camioneta
            //>Moto
            //Vehiculo v1 = new Vehiculo();
            //Camioneta c1 = new Camioneta();
            //Camioneta c2 = new Camioneta();
            //Camioneta c3 = new Camioneta();
            //c1.Color = "Gris";
            //c2.Color = "Blanco";
            //c3.Color = "Negro";


            //Coleccion
            //List<Camioneta> listaCamionetas = new List<Camioneta>();
            //listaCamionetas.Add(c1);
            //listaCamionetas.Add(c2);
            //listaCamionetas.Add(c3);

            //Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);
            //listaCamionetas[1].Color = "Rojo";
            //c2.Color = "Azul";
            //Console.WriteLine("El color de la segunda camioneta es: "+listaCamionetas[1].Color);
            //listaCamionetas.Remove(c3);
            //Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);

            //foreach (Camioneta camioneta in listaCamionetas)
            //{
            //    Console.WriteLine("Color: " + camioneta.Color);

            Auto a1 = new Auto();
            a1.Motor = new Motor();

            Console.ReadKey();
            }

        }
    }

