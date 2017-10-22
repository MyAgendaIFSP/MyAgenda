﻿using MyAgenda.Controladores.MatrizTempo;
using System;

namespace MyAgenda.Modelos.Geral
{
    class UsuarioModel
    {

        public int Id { get; set; }

        public string Nome { get; set; }
        
        public DateTime DataNascimento { get; set; }

        public MatrizController MatrizTempo { get; set; }

        public bool Autenticado { get; set; } = false;
    
        public UsuarioModel(int id, string nome, DateTime dataNascimento, MatrizController matrizTempo)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            MatrizTempo = matrizTempo;
        }
        
    }
}
