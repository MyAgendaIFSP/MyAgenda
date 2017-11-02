using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Componentes.ListaContatos.Chat
{
    public partial class ChatMensagem : UserControl
    {

        public enum EEstadoMensagem { ENTREGUE, NAO_ENTREGUE }

        public string Autor { get; set; }
        public string Mensagem { get; set; }
        public DateTime Data { get; set; }
        public EEstadoMensagem Estado { get; set; }

        public ChatMensagem()
        {
            InitializeComponent();
        }

        public ChatMensagem(string autor, string mensagem, DateTime data, EEstadoMensagem estado)
        {
            InitializeComponent();

            Autor = autor;
            Mensagem = mensagem;
            Data = data;
            Estado = estado;

        }

        public ChatMensagem(string autor, string mensagem, DateTime data)
        {
            InitializeComponent();

            Autor = autor;
            Mensagem = mensagem;
            Data = data;

        }

        public void MudaCorTexto(Color cor)
        {
            this.ForeColor = cor;
            lblData.ForeColor = cor;

            if (cor == Color.White)
            {
                pbxEstado.BackgroundImage = Properties.Resources.ic_check_white;
            }
            else
            {
                pbxEstado.BackgroundImage = Properties.Resources.ic_check_black;
            }
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);

            lblAutor.Text = Autor + ":";
            lblMensagem.Text = Mensagem;
            lblData.Text = Data.ToString();

            if (Estado == EEstadoMensagem.ENTREGUE)
            {
                pbxEstado.Visible = true;
                lblData.Visible = true;
            }
            else
            {
                pbxEstado.Visible = false;
                lblData.Visible = false;
            }

            this.Height = lblAutor.Height + lblMensagem.Height + lblData.Height + 15;
            lblData.Location = new Point(25, lblMensagem.Location.Y + lblMensagem.Height + 1);
            pbxEstado.Location = new Point(10, lblData.Location.Y);
        }
    }
}
