using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gimnasio.Dominio.Entidades
{
    class Tipo_Ejercicio
    {
        #region Propiedades
        public int id_ejercicio { get; set; }
        public string nombre_ejercicio { get; set; }
        public string musculo_a_trabajar { get; set; }
        public string tipo_ejercicio { get; set; }
        public string num_repeticiones { get; set; }

        #endregion
        #region Constructor
        public Tipo_Ejercicio() {
        }
        #endregion
        #region Metodos
        
        #endregion
    }
}
