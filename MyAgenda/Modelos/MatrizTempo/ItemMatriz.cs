using System;
using static MyAgenda.Componentes.MatrizTempo.Matriz;

namespace MyAgenda.Modelos.MatrizTempo
{
    public class ItemMatriz
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

        public ItemMatriz(string titulo, string descricao, EQuadrante quadrante)
        {
            Titulo = titulo;
            Descricao = descricao;
            Quadrante = quadrante;

            //Define um títul padrão caso não existe um 
            if (String.IsNullOrEmpty(Titulo))
            {
                Titulo = _getTitulo();
            }
        }

        public ItemMatriz(string titulo, string descricao, EQuadrante quadrante, bool ativo)
        {
            Titulo = titulo;
            Descricao = descricao;
            Quadrante = quadrante;
            Ativo = ativo;

            //Define um títul padrão caso não existe um 
            if (String.IsNullOrEmpty(Titulo))
            {
                Titulo = _getTitulo();
            }
        }

        public ItemMatriz(string titulo, string descricao, EQuadrante quadrante, bool ativo, DateTime dataAdicao)
        {
            Titulo = titulo;
            Descricao = descricao;
            Quadrante = quadrante;
            Ativo = ativo;
            DataAdicao = dataAdicao;

            //Define um títul padrão caso não existe um 
            if (String.IsNullOrEmpty(Titulo))
            {
                Titulo = _getTitulo();
            }
        }

        private string _getTitulo()
        {
            switch (Quadrante)
            {
                case EQuadrante.QUADRANTE_1:
                    return "Estresse";

                case EQuadrante.QUADRANTE_2:
                    return "Qualidade";

                case EQuadrante.QUADRANTE_3:
                    return "Ilusão";

                case EQuadrante.QUADRANTE_4:
                    return "Desperdício";
            }

            return null;
        }
    }
}
