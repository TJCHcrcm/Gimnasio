using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gimnasio.Dominio.Entidades
{
    public class Usuario
    {
        public int cod_usuario { get; set; }
        public int id_tipo_usuario { get; set; }
        public string nom_usuario { get; set; }
        public string telf_usuario { get; set; }
        public string mail_usuario { get; set; }
        public string contrasena_usuario { get; set; }
        public string dni_usuario { get; set; }

        public static Usuario crear(int id_tipo, string nom, string telf, string mail, string contrasena, string dni)
        {
            return new Usuario()
            {

                id_tipo_usuario = id_tipo,
                nom_usuario = nom,
                telf_usuario = telf,
                mail_usuario = mail,
                contrasena_usuario = contrasena,
                dni_usuario = dni
            };
        }
    }
}
