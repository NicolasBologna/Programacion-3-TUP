using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio1.Presentacion.Modelos
{
    public class CervezaParaCrearDto
    {
        public string Nombre { get; set; }
        public double Ibu { get; set; }
        public string Color { get; set; }
        public double GraduacionAlcoholica { get; set; }

        public CervezaParaCrearDto(string nombre, double ibu, string color, double graduacionAlcoholica)
        {
            Nombre = nombre;
            Ibu = ibu;
            Color = color;
            GraduacionAlcoholica = graduacionAlcoholica;
        }

    }
}
