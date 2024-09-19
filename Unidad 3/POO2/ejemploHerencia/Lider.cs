using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia
{
    class Lider : Persona
    {
        public int Legajo { get; set; }
        public static string algo()
        {
            return "hola";
        }
    }
}
