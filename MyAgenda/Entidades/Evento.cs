using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgenda.Entidades
{
    public class Evento
    {
        public long IdEvento;

        public string Titutlo;

        public string Descricao;

        public DateTime DataHoraInicio;

        public DateTime DataHoraTermino;

        public Usuario Usuario;
    }
}
