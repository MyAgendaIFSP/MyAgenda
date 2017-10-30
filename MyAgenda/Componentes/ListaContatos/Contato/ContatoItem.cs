using MyAgenda.Database;
using MyAgenda.Modelos.ListaContatos;
using System;
using System.Windows.Forms;

namespace MyAgenda.Componentes.ListaContatos.Contato
{
    public partial class ContatoItem : UserControl
    {
        public event EventHandler MensagemClick;
        public event EventHandler RemoverClick;

        public ContatoModelo Modelo { get; set; }

        public ContatoItem()
        {
            InitializeComponent();
        }

        public ContatoItem(ContatoModelo modelo)
        {
            InitializeComponent();
            Modelo = modelo;
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);

            lblNome.Text = Modelo.Nome;
            lblEmail.Text = Modelo.Email;

            if (Modelo.Estado == UsuarioAPI.EEstadoUsuario.ONLINE)
            {
                pcbEstado.BackgroundImage = Properties.Resources.ic_status_online;
            }
            else if(Modelo.Estado == UsuarioAPI.EEstadoUsuario.OFFLINE)
            {
                pcbEstado.BackgroundImage = Properties.Resources.ic_status_offline;
            }
        }

        private void pcbMensagem_Click(object sender, EventArgs e)
        {
            if(MensagemClick != null)
            {
                MensagemClick(this, new EventArgs());
            }
        }

        private void ContatoItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void ContatoItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
        }

        private void pcbRemoverContato_Click(object sender, EventArgs e)
        {
            if (RemoverClick != null)
            {
                RemoverClick(this, new EventArgs());
            }
        }
    }
}
