using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Persona
    {
        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"Hola! mi nombre es {Nombre}.";
        }
    }
}
