using MyAgenda.Componentes.Geral;
using MyAgenda.Controladores.Geral;
using MyAgenda.Modelos.ListaContatos;
using System;

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

            //TODO: Verificar no banco de dados se essa conversa existe no banco

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
            if (!String.IsNullOrEmpty(txtMensagem.Text))
            {
                chat.EnviaMensagem(_usuario.GetModelo().Nome, txtMensagem.Text, DateTime.Now);
            }
        }

        private void FormChat_Shown(object sender, EventArgs e)
        {
            chat.IniciaChat(_contato);
        }
    }
}
