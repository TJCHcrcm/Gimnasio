using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gimnasio.Dominio.Entidades
{
    class Administrador
    {
        #region Propiedades

        public int id_tipo_usuario { get; set; }
        public string horario { get; set; }

        #endregion

        #region Constructor

        private Administrador()
        {
        }

        #endregion

        #region Metodos

        public static Administrador Crear(int id_tipo_usuario_mod, string horario_mod)
        {
            return new Administrador()
            {
                id_tipo_usuario = id_tipo_usuario_mod,
                horario = horario_mod
            };
        }
        public void Modificaradministrador(int id_tipo_usuario_mod, string horario_mod)
        {
            id_tipo_usuario = id_tipo_usuario_mod;
            horario = horario_mod;
        }
        #endregion
    }
}
