using MyAgenda.Componentes.MatrizTempo;
using MyAgenda.Dados;
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

        private MatrizTempoAPI _api;

        private static MatrizController _instancia = null;

        /// <summary>
        /// Método chamado pela API para iniciar o controlador da matriz
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dtInicializacao"></param>
        /// <param name="ultimoAcesso"></param>
        /// <returns></returns>
        public static MatrizController GetInstance(int id, DateTime dtInicializacao, DateTime ultimoAcesso)
        {
            if(_instancia == null)
            {
                _instancia = new MatrizController(id, dtInicializacao, ultimoAcesso);
            }

            return _instancia;
        }

        /// <summary>
        /// Método chamado pelas classes. Sempre será chamado depois do GetInstance com parametros, que foi inicializado pela API
        /// </summary>
        /// <returns></returns>
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
            _api = MatrizTempoAPI.GetInstance();
        }

        private MatrizController(int id, DateTime dtInicializacao, DateTime ultimoAcesso)
        {
            //Buscar no banco a matriz do usuário
            _api = MatrizTempoAPI.GetInstance();
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

        public MatrizModel GetModelo()
        {
            return _modelo;
        }

        public bool AddItem(ItemMatrizController item)
        {
            try {
                if (_api.AdicionaItemMatriz(item.GetModel()))
                {
                    _modelo.Itens.Add(item);
                    return true;
                }
            }
            catch { }

            return false;
        }

        public bool DeletarItem(ItemMatrizController item)
        {
            //Apagar o item do banco
            if (_api.RemoveItemMatriz(item.GetModel().Id))
            {
                _modelo.Itens.Remove(item);
                return true;
            }

            return false;
        }
                
    }
}
