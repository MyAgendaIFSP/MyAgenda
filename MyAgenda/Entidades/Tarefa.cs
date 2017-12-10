using MyAgenda.Modelos.Geral;
using System;

namespace MyAgenda.Entidades
{
    public class Tarefa
    {
        public ListaAfazeres Lista;

        public string Titulo;

        public DateTime Data;

        public string Descricao;

        public UsuarioModel Usuario;

        public bool IsConcluida;
    }
}
