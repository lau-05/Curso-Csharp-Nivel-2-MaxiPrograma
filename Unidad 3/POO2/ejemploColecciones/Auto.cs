using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejemploColecciones
{
    internal class Auto : Vehiculo
    {
        public Auto() 
        {
            Chasis = new Chasis();
        }
        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }


        //Composicion
        public Chasis Chasis { get; }

        //Agregacion
        public Motor Motor { get; set; }
    }
}
