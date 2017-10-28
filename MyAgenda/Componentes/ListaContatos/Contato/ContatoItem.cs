using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Componentes.ListaContatos.Contato
{
    public partial class ContatoItem : UserControl
    {

        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
                lblNome.Text = _nome;
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
                lblEmail.Text = _email;
            }
        }

        public ContatoItem()
        {
            InitializeComponent();
        }
    }
}
