using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gimnasio.Dominio.Entidades
{
    public class Rutina
    {
        public int id_rutina { get; set; }
        public int nro_repeticiones { get; set; }
        public string descripcion_rutina { get; set; }

        public static Rutina crear(string descripcion)
        {
            return new Rutina()
            {

                descripcion_rutina = descripcion
            };
        }
    }
}
