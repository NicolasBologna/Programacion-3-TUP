using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio1.Presentacion.Modelos
{
    public class CervezaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Ibu { get; set; }
        public string Color { get; set; }
        public double GraduacionAlcoholica { get; set; }

        public CervezaDto(int id, string nombre, double ibu, string color, double graduacionAlcoholica)
        {
            Id = id;
            Nombre = nombre;
            Ibu = ibu;
            Color = color;
            GraduacionAlcoholica = graduacionAlcoholica;
        }
    }
}
