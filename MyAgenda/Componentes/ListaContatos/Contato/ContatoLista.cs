using MyAgenda.Controladores.ListaContatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Componentes.ListaContatos.Contato
{
    class ContatoLista : Panel
    {

        ListaContatosController _lista;

        List<ContatoItem> _items = new List<ContatoItem>();

        private int _ultimoY = 5;

        /// <summary>
        /// Carrega os controles dos contatos em memória
        /// </summary>
        public void CarregaLista()
        {
            _lista = ListaContatosController.GetInstance();
            _items = _lista.GetViews();

            _desenhaContatos();
        }

        /// <summary>
        /// Desenha os controles dos usuários na tela
        /// </summary>
        private void _desenhaContatos()
        {
            if (_items != null)
            {
                this.Controls.Clear();
            }

            _ultimoY = 5;

            foreach (ContatoItem c in _items)
            {
                c.Location = new Point(5, _ultimoY);
                c.Width = this.ClientSize.Width - 10;
                c.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                c.MensagemClick += _onItemMensagemClick;
                c.RemoverClick += _onItemRemoverClick;

                c.CreateControl();
                this.Controls.Add(c);

                c.Invalidate();
                _ultimoY += c.Height + 5;
            }
        }

        /// <summary>
        /// Atualiza os estados dos contatos (online ou offline)
        /// </summary>
        public void AtualizaStatus()
        {
            _lista = ListaContatosController.GetInstance();
            _items = _lista.GetViews();

            if (_items.Count != this.Controls.Count)
            {
                _desenhaContatos();
            }
            else
            {
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    ((ContatoItem)this.Controls[i]).Modelo.Estado = _items[i].Modelo.Estado;
                    this.Controls[i].Invalidate();
                }
            }

            this.Invalidate();
            
        }

        /// <summary>
        /// Busca um contato no banco de dados
        /// </summary>
        /// <param name="busca">email ou nome do contato</param>
        /// <returns></returns>
        public List<ContatoController> BuscaContato(string busca)
        {
            return _lista.BuscaContato(busca);
        }

        /// <summary>
        /// Desenha um novo item sem redesenhar todos os outros contatos
        /// </summary>
        /// <param name="contato"></param>
        private void _acrescentaContato(ContatoItem contato)
        {
            contato.Location = new Point(5, _ultimoY);
            contato.Width = this.ClientSize.Width - 10;
            contato.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            contato.MensagemClick += _onItemMensagemClick;
            contato.RemoverClick += _onItemRemoverClick;

            contato.CreateControl();
            this.Controls.Add(contato);

            contato.Invalidate();
            _ultimoY += contato.Height + 5;
        }

        /// <summary>
        /// Adiciona um contato aos contatos do usuário
        /// </summary>
        /// <param name="contato"></param>
        /// <returns></returns>
        public bool AdicionarContato(ContatoController contato)
        {
            ContatoItem novoItem = _lista.AdicionaContato(contato);

            if(novoItem != null)
            {
                _items.Add(novoItem);
                _acrescentaContato(novoItem);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Verifica se um contato já existe para um usuário
        /// </summary>
        /// <param name="contato"></param>
        /// <returns></returns>
        public bool Contem(ContatoController contato)
        {
            return _lista.ContatoExiste(contato);
        }

        private void _atualizarLista(Point location)
        {
            Point ultimaPosicao = new Point();

            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].Location.Y > location.Y)
                {
                    if (ultimaPosicao.Y == 0)
                    {
                        ultimaPosicao = this.Controls[i].Location;
                        this.Controls[i].Location = location;
                    }
                    else
                    {
                        location = ultimaPosicao;
                        ultimaPosicao = this.Controls[i].Location;
                        this.Controls[i].Location = location;
                    }
                }
            }
        }

        private void _onItemMensagemClick(object sender, EventArgs e)
        {
            ContatoItem contato = (ContatoItem)sender;

            if(contato.Modelo.Estado != Database.UsuarioAPI.EEstadoUsuario.ONLINE)
            {
                MessageBox.Show("Contato não está conectado.", "Erro ao abrir conversa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Iniciar o chat
                FormChat chat = new FormChat(contato.Modelo);
                chat.Show();
            }

        }

        private void _onItemRemoverClick(object sender, EventArgs e)
        {
            //Remover o contato
            ContatoItem contato = (ContatoItem)sender;

            if (_lista.RemoverContato(contato))
            {
                this.Controls.Remove(contato);
                _ultimoY = (this.Controls.Count * (contato.Height + 5)) + 5;
                _items.Remove(contato);
                _atualizarLista(contato.Location);
                this.Invalidate();
            }
        }
    }
}
