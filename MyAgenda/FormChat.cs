using MyAgenda.Componentes.Geral;
using MyAgenda.Componentes.ListaContatos.Chat;
using MyAgenda.Controladores.Geral;
using MyAgenda.Modelos.ListaContatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda
{
    public partial class FormChat : BaseForm
    {

        private ContatoModelo _contato;

        private UsuarioController _usuario;

        public FormChat()
        {
            InitializeComponent();
            this.TemBarraNavegacao = false;
            Loader.Visible = false;
        }

        public FormChat(ContatoModelo contato)
        {
            InitializeComponent();

            this.TemBarraNavegacao = false;
            Loader.Visible = false;

            _contato = contato;
            _usuario = UsuarioController.GetInstance();
            this.Text = "Conversa - " + contato.Nome;
        }

        private void btnEnviarMensagem_MouseEnter(object sender, EventArgs e)
        {
            btnEnviarMensagem.BackgroundImage = Properties.Resources.ic_send_white;
        }

        private void btnEnviarMensagem_MouseLeave(object sender, EventArgs e)
        {
            btnEnviarMensagem.BackgroundImage = Properties.Resources.ic_send_black;
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {
            //enviar mensagem
            /*chat.AdicionaMensagem("Opa", "Lorem Ipsum dorem sit amet. Lorem Ipsum dorem sit amet. Lorem Ipsum dorem sit amet. Lorem Ipsum dorem sit amet. Lorem Ipsum dorem sit amet.", DateTime.Now, ChatMensagem.EEstadoMensagem.ENTREGUE);
            chat.AdicionaMensagem("Opa", "Lorem Ipsum dorem sit amet. Lorem Ipsum dorem sit amet. Lorem Ipsum dorem sit amet.", DateTime.Now, ChatMensagem.EEstadoMensagem.NAO_ENTREGUE);
            chat.AdicionaMensagem("Opa1", "Lorem Ipsum dorem sit amet.", DateTime.Now, ChatMensagem.EEstadoMensagem.ENTREGUE);
            chat.AdicionaMensagem("Opa1", "Lorem Ipsum dorem sit amet. Lorem Ipsum dorem sit amet. Lorem Ipsum dorem sit amet. Lorem Ipsum dorem sit amet. Lorem Ipsum dorem sit amet. vLorem Ipsum dorem sit amet.", DateTime.Now, ChatMensagem.EEstadoMensagem.ENTREGUE);
            chat.AdicionaMensagem("Opa", "Lorem Ipsum dorem sit amet.", DateTime.Now, ChatMensagem.EEstadoMensagem.NAO_ENTREGUE);*/

            if (!String.IsNullOrEmpty(txtMensagem.Text))
            {
                chat.AdicionaMensagem(_usuario.GetModelo().Nome, txtMensagem.Text, DateTime.Now);
            }
        }
    }
}
