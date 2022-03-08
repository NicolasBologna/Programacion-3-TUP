using Ejercicio1.Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio1.Presentacion
{
    public class CervezasData
    {
        public static CervezasData DbContext = new();

        public List<CervezaDto> Cervezas { get; set; } = new();

        public CervezasData()
        {
            Cervezas.Add(new CervezaDto(1,"Choco Stout", 10, "Negro", 4.6));
            Cervezas.Add(new CervezaDto(2,"Golden", 6, "Rubia", 6.3));
            Cervezas.Add(new CervezaDto(3,"Barba Roja", 35, "Roja", 19));
        }

        public static CervezaDto Add(CervezaParaCrearDto nuevaCerveza)
        {
            var maxId = DbContext.Cervezas.Select(c => c.Id).Max();

            var cerveza = new CervezaDto(++maxId, nuevaCerveza.Nombre, nuevaCerveza.Ibu, nuevaCerveza.Color, nuevaCerveza.GraduacionAlcoholica);

            DbContext.Cervezas.Add(cerveza);

            return cerveza;
        }
    }
}
