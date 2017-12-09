using MyAgenda.Controladores.MatrizTempo;
using System;

namespace MyAgenda.Modelos.Geral
{
    public class UsuarioModel
    {

        public int Id { get; set; }

        public string Nome { get; set; }
        
        public MatrizController MatrizTempo { get; set; }
            
        public UsuarioModel(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public UsuarioModel(int id, string nome, MatrizController matriz)
        {
            Id = id;
            Nome = nome;
            MatrizTempo = matriz;
        }
    }
}
