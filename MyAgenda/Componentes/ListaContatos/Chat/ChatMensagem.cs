using MyAgenda.Database;
using MyAgenda.Modelos.Chat;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda.Componentes.ListaContatos.Chat
{
    public partial class ChatMensagem : UserControl
    {

        private MensagemModelo _modelo;
        
        public ChatMensagem()
        {
            InitializeComponent();
        }

        public ChatMensagem(MensagemModelo msg)
        {
            InitializeComponent();

            _modelo = msg;

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


        public MensagemModelo GetModelo()
        {
            return _modelo;
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);

            lblAutor.Text = _modelo.Autor + ":";
            lblMensagem.Text = _modelo.Texto;
            lblData.Text = _modelo.Data.ToString();

            if (_modelo.Estado == ChatAPI.EEstadoMensagem.ENTREGUE)
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
