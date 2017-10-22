using MyAgenda.Componentes.MatrizTempo;
using MyAgenda.Database;
using MyAgenda.Modelos.MatrizTempo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda.Controladores.MatrizTempo
{
    public class MatrizController
    {

        private MatrizModel _modelo;

        private MyAgendaAPI _api;

        private static MatrizController _instancia = null;

        public static MatrizController GetInstance(int id, DateTime dtInicializacao, DateTime ultimoAcesso)
        {
            if(_instancia == null)
            {
                _instancia = new MatrizController(id, dtInicializacao, ultimoAcesso);
            }

            return _instancia;
        }

        public static MatrizController GetInstance()
        {
            if (_instancia == null)
            {
                _instancia = new MatrizController();
            }

            return _instancia;
        }
        
        private MatrizController()
        {
            _api = new MyAgendaAPI();
        }

        private MatrizController(int id, DateTime dtInicializacao, DateTime ultimoAcesso)
        {
            //Buscar no banco a matriz do usuário
            _api = new MyAgendaAPI();
            _modelo = new MatrizModel(id, dtInicializacao, ultimoAcesso, _carregaItens(id));
        }

        private List<ItemMatrizController> _carregaItens(int id)
        {
            return _api.CarregaItensMatriz(id);
        }

        public List<ItemMatrizController> GetItens()
        {
            return _modelo.Itens;
        }

        public bool AlteraUltimoAcesso()
        {
            return _api.AtualizaUltimoAcessoMatriz(_modelo.Id);
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
