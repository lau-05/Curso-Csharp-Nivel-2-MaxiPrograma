using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Perro
    {
        //Perro: Nombre, Raza, Edad
        private string nombre;
        private string raza;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }

}

