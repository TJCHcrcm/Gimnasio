using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gimnasio.Dominio.Entidades
{
    class Cliente
    {

        public Usuario usuario { get; set; }
        public Double pesoCliente { get; set; }
        public Double alturaCliente { get; set; }
        public DateTime horarioCliente { get; set; }
        public Plan plan { get; set; }

        public static Cliente Crear(Usuario idusuario, Double peso, Double altura, DateTime horario, int idplan)
        {
            return new Cliente()
            {
                usuario = idusuario,
                pesoCliente = peso,
                alturaCliente = altura,
                horarioCliente = horario,
            };


        }
    }
