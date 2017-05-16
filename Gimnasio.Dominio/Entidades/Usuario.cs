using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gimnasio.Dominio.Entidades
{
    public class Usuario
    {
        #region Propiedades
        public int cod_usuario { get; set; }
        public int id_tipo_usuario { get; set; }
        public string nom_usuario { get; set; }
        public string telf_usuario { get; set; }
        public string mail_usuario { get; set; }
        public string contrasena_usuario { get; set; }
        public string dni_usuario { get; set; }
        #endregion
        #region Constructor
        private Usuario() {
        }
        #endregion
        #region Metodos

        public static Usuario Crear(int cod,int id_tipo, string nom, string telf, string mail, string contrasena, string dni)
        {
            return new Usuario()
            {
                cod_usuario=cod,
                id_tipo_usuario = id_tipo,
                nom_usuario = nom,
                telf_usuario = telf,
                mail_usuario = mail,
                contrasena_usuario = contrasena,
                dni_usuario = dni
            };
        }
        public void Modificarusuario(int cod, int id_tipo, string nom, string telf, string mail, string contrasena, string dni)
        {
            id_tipo_usuario = id_tipo;
            nom_usuario = nom;
            telf_usuario = telf;
            mail_usuario = mail;
            contrasena_usuario = contrasena;
            dni_usuario = dni;
        }

        #endregion
    }
}
