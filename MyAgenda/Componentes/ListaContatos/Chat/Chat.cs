using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Componentes.ListaContatos.Chat
{
    class Chat : Panel
    {

        public enum EDirecao { ENVIADA, RECEBIDA, NENHUM }

        private List<ChatMensagem> _mensagens = new List<ChatMensagem>();

        private int _ultimoY = 10;

        private EDirecao _ultimoLado = EDirecao.NENHUM;

        public bool AdicionaMensagem(string autor, string mensagem, DateTime data, ChatMensagem.EEstadoMensagem estado)
        {
            ChatMensagem msg = new ChatMensagem(autor, mensagem, data, estado);

            _adicionaMesagem(msg, EDirecao.ENVIADA);

            return true;
        }

        public bool AdicionaMensagem(string autor, string mensagem, DateTime data)
        {
            ChatMensagem msg = new ChatMensagem(autor, mensagem, data);

            _adicionaMesagem(msg, EDirecao.ENVIADA);

            return true;
        }

        private void _adicionaMesagem(ChatMensagem msg, EDirecao direcao)
        {
            if (direcao == EDirecao.ENVIADA)
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

            _mensagens.Add(msg);

            this.ScrollControlIntoView(msg);

            _ultimoY = _mensagens[_mensagens.Count - 1].Bottom + 6;

            this.Invalidate();
        }

    }
}
