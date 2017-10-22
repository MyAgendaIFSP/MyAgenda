using MyAgenda.Modelos.MatrizTempo;
using System;
using System.Collections.Generic;

namespace MyAgenda.Controladores.MatrizTempo
{
    public class MatrizController
    {

        private MatrizModel _modelo;

        private static MatrizController _instancia = null;

        public static MatrizController GetInstance()
        {
            if(_instancia == null)
            {
                _instancia = new MatrizController();
            }

            return _instancia;
        }

        private MatrizController()
        {
            //Buscar no banco a matriz do usuário
            _modelo = new MatrizModel(1, DateTime.Now, DateTime.Now, _carregaItens());
        }

        private List<ItemMatrizController> _carregaItens()
        {
            return new List<ItemMatrizController>();
        }

        public List<ItemMatrizController> GetItens()
        {
            return _modelo.Itens;
        }

        public MatrizModel GetModel()
        {
            return _modelo;
        }

        public bool AddItem(ItemMatrizController item)
        {
            try {
                _modelo.Itens.Add(item);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool DeletarItem(ItemMatrizController item)
        {
            //Apagar o item do banco
            _modelo.Itens.Remove(item);

            return true;
        }
        
    }
}
