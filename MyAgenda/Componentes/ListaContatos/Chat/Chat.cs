using MyAgenda.Controladores.Chat;
using MyAgenda.Controladores.Geral;
using MyAgenda.Database;
using MyAgenda.Modelos.Chat;
using MyAgenda.Modelos.ListaContatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda.Componentes.ListaContatos.Chat
{
    class Chat : Panel
    {
        
        private ChatController _chatController;

        private UsuarioController _usuario;

        private int _ultimoY = 10;
        
        public void IniciaChat(ContatoModelo contato)
        {
            _usuario = UsuarioController.GetInstance();

            _chatController = new ChatController(contato);
            _chatController.MensagensCarregadas += _mensagensCarregadas;
            _chatController.MensagemRecebida += _mensagemRecebida;

            _chatController.Carrega();
            
        }

        public void DesligaChat()
        {
            _chatController.Escuta = false;
            _chatController.AceitaNovaMensagem = false;
        }

        private void _mensagemRecebida(object sender, MensagemModelo msg)
        {
            _chatController.AceitaNovaMensagem = false;

            _chatController.AtualizaMensagem(msg);
            
            _adicionaMesagem(new ChatMensagem(msg), ChatAPI.EDirecao.RECEBIDA);            

            _chatController.AceitaNovaMensagem = true;
        }

        private void _mensagensCarregadas(object sender, List<MensagemModelo> msgs)
        {
            if(msgs.Count <= 0)
            {
                return;
            }

            this.SuspendLayout();

            foreach(MensagemModelo msg in msgs)
            {
                ChatAPI.EDirecao direcao = ChatAPI.EDirecao.NENHUM;

                if (msg.Destinatario == _usuario.GetModelo().Id)
                {
                    direcao = ChatAPI.EDirecao.RECEBIDA;
                }
                else
                {
                    direcao = ChatAPI.EDirecao.ENVIADA;
                }
                
                if(msg.Estado == ChatAPI.EEstadoMensagem.NAO_ENTREGUE)
                {
                    _chatController.AtualizaMensagem(msg);
                }

                ChatMensagem cmsg = new ChatMensagem(msg);
                _adicionaMesagem(cmsg, direcao);
            }

            this.ResumeLayout();
            this.PerformLayout();

            this.ScrollControlIntoView(this.Controls[this.Controls.Count - 1]);
            _ultimoY = this.Controls[this.Controls.Count - 1].Bottom + 6;
        }
        
        public bool EnviaMensagem(string autor, string mensagem, DateTime data)
        {
            ChatMensagem msg = new ChatMensagem(new MensagemModelo(autor, mensagem, ChatAPI.EEstadoMensagem.NAO_ENTREGUE, data, _chatController.GetContato().Id));

            if (_chatController.EnviaMensagem(msg.GetModelo()))
            {
                _adicionaMesagem(msg, ChatAPI.EDirecao.ENVIADA);
                return true;
            }

            return false;
        }

        private void _adicionaMesagem(ChatMensagem msg, ChatAPI.EDirecao direcao)
        {
            if (direcao == ChatAPI.EDirecao.ENVIADA)
            {
                msg.Location = new Point(this.Width - 327, _ultimoY);
                msg.BackColor = Color.SlateGray;
                msg.MudaCorTexto(Color.White);
            }
            else
            {
                msg.Location = new Point(10, _ultimoY);
            }

            string autor = "";

            if (msg.GetModelo().Destinatario == _usuario.GetModelo().Id)
            {
                autor = _chatController.GetContato().Nome;
            }
            else
            {
                autor = _usuario.GetModelo().Nome;
            }

            msg.GetModelo().Autor = autor;

            msg.CreateControl();

            this.Controls.Add(msg);

            msg.Invalidate();

            this.ScrollControlIntoView(msg);
            
            _ultimoY = this.Controls[this.Controls.Count - 1].Bottom + 6;
        }

    }
}
