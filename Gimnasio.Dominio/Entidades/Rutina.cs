using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gimnasio.Dominio.Entidades
{
    public class Rutina
    {
        #region
        //propiedades
        public int id_rutina { get; set; }
        public string descripcion_rutina { get; set; }

        #endregion
        #region constructor
        private Rutina() {
        }
        #endregion
        #region metodos
        public static Rutina crear( int ai_id_rutina, string ai_descripcion_rutina)
        {
            return new Rutina()
            {
                id_rutina = ai_id_rutina,
                descripcion_rutina = ai_descripcion_rutina
            };
        }
        public void ModificarRutina(string as_nueva_descripcion)
        {
            descripcion_rutina = as_nueva_descripcion;
        }
    }
        #endregion
    
}
