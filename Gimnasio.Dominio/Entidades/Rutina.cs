using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gimnasio.Dominio.Entidades
{
    class Rutina
    {
        public int ID_Rutina { get; private set; }

        public String Descripion_Rutina{ get; set; }

        private Rutina() { }


        public static Rutina Crear(String descripion_rutin) {

            return new Rutina() {
                Descripion_Rutina = descripion_rutin

            };

        }

        public void Modificar_Rutina(String n_descripcion_rutina)

        {
            Descripion_Rutina = n_descripcion_rutina;
        }


    }
}
