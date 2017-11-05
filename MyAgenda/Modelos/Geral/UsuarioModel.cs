using MyAgenda.Controladores.MatrizTempo;
using System;

namespace MyAgenda.Modelos.Geral
{
    public class UsuarioModel
    {

        public int Id { get; set; }

        public string Nome { get; set; }
        
        public DateTime DataNascimento { get; set; }

        public MatrizController MatrizTempo { get; set; }
            
        public UsuarioModel(int id, string nome, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
        }
        
    }
}
