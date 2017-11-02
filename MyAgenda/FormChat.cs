using MyAgenda.Componentes.Geral;
using MyAgenda.Controladores.Geral;
using MyAgenda.Modelos.ListaContatos;
using System;
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
            if (!String.IsNullOrEmpty(txtMensagem.Text))
            {
                if(!chat.EnviaMensagem(_usuario.GetModelo().Nome, txtMensagem.Text, DateTime.Now))
                {
                    MessageBox.Show("Sua mensagem não pôde ser enviada. Tente novamente.", "Erro ao enviar mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormChat_Shown(object sender, EventArgs e)
        {
            chat.IniciaChat(_contato);
        }

        private void FormChat_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            chat.DesligaChat();
        }
    }
}
