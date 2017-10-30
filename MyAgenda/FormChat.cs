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
    public partial class FormChat : Form
    {

        private ContatoModelo _contato;

        public FormChat()
        {
            InitializeComponent();
        }

        public FormChat(ContatoModelo contato)
        {
            InitializeComponent();
            _contato = contato;
            this.Text = "Conversa - " + contato.Nome;
        }

        private void btnEnviarMensagem_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.ic_send_white;
        }

        private void btnEnviarMensagem_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.ic_send_black;
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {
            //enviar mensagem
        }
    }
}
