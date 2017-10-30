using MyAgenda.Componentes.ListaContatos.Contato;
using MyAgenda.Controladores.Geral;
using MyAgenda.Database;
using System.Collections.Generic;

namespace MyAgenda.Controladores.ListaContatos
{

    public class ListaContatosController
    {
        private List<ContatoController> _contatos = new List<ContatoController>();
        
        private ContatosAPI _api = ContatosAPI.GetInstance();

        private static ListaContatosController _instancia = null;
        
        public static ListaContatosController GetInstance()
        {
            if (_instancia == null)
            {
                _instancia = new ListaContatosController();
            }

            return _instancia;
        }

        /// <summary>
        /// Busca os contatos do usuário no banco de dados
        /// </summary>
        private void _carregaContatos()
        {
            UsuarioController usuario = UsuarioController.GetInstance();
            _contatos = _api.CarregaContatos(usuario.GetModelo().Id);
        }

        /// <summary>
        /// Obtém os contatos do usuário
        /// </summary>
        /// <returns></returns>
        public List<ContatoController> GetContatos()
        {
            return _contatos;
        }

        /// <summary>
        /// Obtém os controles que serão mostrados na tela
        /// </summary>
        /// <returns></returns>
        public List<ContatoItem> GetViews()
        {  

            List<ContatoItem> contatosViews = new List<ContatoItem>();

            _carregaContatos();

            foreach (ContatoController c in _contatos)
            {
                contatosViews.Add(new ContatoItem(c.GetModelo()));
            }

            return contatosViews;
        }

        /// <summary>
        /// Busca um contato no banco de dados
        /// </summary>
        /// <param name="busca">nome ou email do contato</param>
        /// <returns></returns>
        public List<ContatoController> BuscaContato(string busca)
        {
            return _api.BuscaContato(busca);
        }

        /// <summary>
        /// Adiciona um contato novo para o usuário
        /// </summary>
        /// <param name="contato"></param>
        /// <returns></returns>
        public ContatoItem AdicionaContato(ContatoController contato)
        {
            if (_api.AdicionaContato(contato))
            {
                return new ContatoItem(contato.GetModelo());
            }

            return null;
        }

        /// <summary>
        /// Remove um contato do usuário
        /// </summary>
        /// <param name="contato"></param>
        /// <returns></returns>
        public bool RemoverContato(ContatoItem contato)
        {
            return _api.RemoveContato(contato.Modelo.Id);
        }

        /// <summary>
        /// Verifica se um contato já existe
        /// </summary>
        /// <param name="contato"></param>
        /// <returns></returns>
        public bool ContatoExiste(ContatoController contato)
        {
            return _contatos.Contains(contato);
        }
    }
}
