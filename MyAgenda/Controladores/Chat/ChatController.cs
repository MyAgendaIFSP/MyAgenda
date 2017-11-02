using MyAgenda.Componentes.ListaContatos.Chat;
using MyAgenda.Controladores.Geral;
using MyAgenda.Database;
using MyAgenda.Modelos.Chat;
using MyAgenda.Modelos.ListaContatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgenda.Controladores.Chat
{
    class ChatController
    {
        public delegate void MensagensCarregadasEventHandler(object sender, List<MensagemModelo> msgs);
        public delegate void MensagemRecebidaEventHandler(object sender, MensagemModelo msg);

        public event MensagensCarregadasEventHandler MensagensCarregadas;
        public event MensagemRecebidaEventHandler MensagemRecebdida;

        public int Id { get; set; }

        public List<MensagemModelo> Mensagens { get; set; }

        private ContatoModelo _contato;

        private UsuarioController _usuario;

        private ChatAPI _api;

        public ChatController(ContatoModelo contato)
        {
            Mensagens = new List<MensagemModelo>();
            _contato = contato;
            _api = ChatAPI.GetInstance();
            _usuario = UsuarioController.GetInstance();
        }

        public void Carrega()
        {
            bool conversaNova = false;
            Id = _api.AbreConversa(_usuario.GetModelo().Id, _contato.Id, ref conversaNova);

            if (!conversaNova && Id > 0)
            {
                //buscar as mensagens existentes na conversa
                _carregarMensagens();
            }
        }

        public ContatoModelo GetContato()
        {
            return _contato;
        }

        public bool EnviaMensagem(MensagemModelo msg)
        {
            //Enviar a mensagem
            bool enviada = true;

            if (enviada)
            {
                msg.Estado = ChatAPI.EEstadoMensagem.ENTREGUE;
                _api.RegistraMensagem(msg, Id);
            }

            return enviada;
        }

        private void _carregarMensagens()
        {
            Mensagens = _api.CarregaMensagens(Id);

            if (MensagensCarregadas != null)
            {
                MensagensCarregadas(this, Mensagens);
            }
        }

    }
}
