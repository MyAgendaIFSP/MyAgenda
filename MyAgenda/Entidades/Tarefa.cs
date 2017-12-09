using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgenda.Entidades
{
    public class Tarefa
    {
        public ListaAfazeres Lista;

        public string Titulo;

        public DateTime Data;

        public string Descricao;

        public Usuario Usuario;

        public bool IsConcluida;
    }
}
