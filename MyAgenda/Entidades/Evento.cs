using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgenda.Entidades
{
    class Evento
    {
        long IdEvento;

        string Titutlo;

        string Descricao;

        DateTime DataHoraInicio;

        DateTime DataHoraTermino;

        Usuario Usuario;
    }
}
