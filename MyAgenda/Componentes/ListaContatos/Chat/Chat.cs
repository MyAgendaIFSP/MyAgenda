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
        
        private ChatController _chat;

        private UsuarioController _usuario;

        private int _ultimoY = 10;
        
        public void IniciaChat(ContatoModelo contato)
        {
            _usuario = UsuarioController.GetInstance();

            _chat = new ChatController(contato);
            _chat.MensagensCarregadas += _mensagensCarregadas;
            _chat.MensagemRecebdida += _mensagemRecebida;

            _chat.Carrega();
            
        }

        private void _mensagemRecebida(object sender, MensagemModelo msg)
        {
            ChatMensagem cmsg = new ChatMensagem(msg);
            _adicionaMesagem(cmsg, ChatAPI.EDirecao.RECEBIDA);
        }

        private void _mensagensCarregadas(object sender, List<MensagemModelo> msgs)
        {
            foreach(MensagemModelo msg in msgs)
            {
                string autor = "";
                ChatAPI.EDirecao direcao = ChatAPI.EDirecao.NENHUM;

                if (msg.Destinatario == _usuario.GetModelo().Id)
                {
                    autor = _chat.GetContato().Nome;
                    direcao = ChatAPI.EDirecao.RECEBIDA;
                }
                else
                {
                    autor = _usuario.GetModelo().Nome;
                    direcao = ChatAPI.EDirecao.ENVIADA;
                }

                msg.Autor = autor;

                ChatMensagem cmsg = new ChatMensagem(msg);
                _adicionaMesagem(cmsg, direcao);
            }
        }
        
        public bool EnviaMensagem(string autor, string mensagem, DateTime data)
        {
            ChatMensagem msg = new ChatMensagem(new MensagemModelo(autor, mensagem, ChatAPI.EEstadoMensagem.NAO_ENTREGUE, data, _chat.GetContato().Id));

            if (_chat.EnviaMensagem(msg.GetModelo()))
            {
                _adicionaMesagem(msg, ChatAPI.EDirecao.ENVIADA);
            }

            return true;
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

            msg.CreateControl();

            this.Controls.Add(msg);

            msg.Invalidate();

            this.ScrollControlIntoView(msg);

            _ultimoY = this.Controls[this.Controls.Count - 1].Bottom + 6;

            this.Invalidate();
        }

    }
}
