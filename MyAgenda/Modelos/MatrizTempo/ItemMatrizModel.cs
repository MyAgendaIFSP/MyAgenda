﻿using MyAgenda.Componentes.MatrizTempo;
using System;
using System.Drawing;
using static MyAgenda.Componentes.MatrizTempo.Matriz;

namespace MyAgenda.Modelos.MatrizTempo
{
    public class ItemMatrizModel
    {
        /// <summary>
        /// Título do item
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Descrição breve do item
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Quadrante ao qual o item pertence. Varia de 1 a 4
        /// </summary>
        public EQuadrante Quadrante { get; set; }

        /// <summary>
        /// Indica se o item está ativo ou foi finalizado
        /// </summary>
        public bool Ativo { get; set; }

        /// <summary>
        /// Data que o item foi adicionado à matriz
        /// </summary>
        public DateTime DataAdicao { get; set; }

        public int Id { get; set; }

        public ItemMatrizModel(string titulo, string descricao, EQuadrante quadrante)
        {
            Titulo = titulo;
            Descricao = descricao;
            Quadrante = quadrante;
            Ativo = true;
            DataAdicao = DateTime.Now;
        }

        public ItemMatrizModel(string titulo, string descricao, EQuadrante quadrante, bool ativo)
        {
            Titulo = titulo;
            Descricao = descricao;
            Quadrante = quadrante;
            Ativo = ativo;
            DataAdicao = DateTime.Now;
        }

        public ItemMatrizModel(string titulo, string descricao, EQuadrante quadrante, bool ativo, DateTime dataAdicao)
        {
            Titulo = titulo;
            Descricao = descricao;
            Quadrante = quadrante;
            Ativo = ativo;
            DataAdicao = dataAdicao;
        }
        
    }
}