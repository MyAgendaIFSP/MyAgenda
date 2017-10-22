using MyAgenda.Controladores.MatrizTempo;
using System;
using System.Collections.Generic;

namespace MyAgenda.Modelos.MatrizTempo
{
    public class MatrizModel
    {

        public int Id { get; set; }

        public DateTime DataInicializacao { get; set; }

        public DateTime UltimoAcesso { get; set; }

        public List<ItemMatrizController> Itens { get; set; }

        public MatrizModel(int id, DateTime dataInicializacao, DateTime ultimoAcesso, List<ItemMatrizController> itens)
        {
            Id = id;
            DataInicializacao = dataInicializacao;
            UltimoAcesso = ultimoAcesso;
            Itens = itens;
        }

        public ItemMatrizController GetItemAt(int index)
        {
            return Itens[index];
        }

    }
}
