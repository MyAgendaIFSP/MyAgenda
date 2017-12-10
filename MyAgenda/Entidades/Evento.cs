using MyAgenda.Modelos.Geral;
using System;

namespace MyAgenda.Entidades
{
    public class Evento
    {
        public long IdEvento;

        public string Titutlo;

        public string Descricao;

        public DateTime DataHoraInicio;

        public DateTime DataHoraTermino;

        public UsuarioModel Usuario;
    }
}
