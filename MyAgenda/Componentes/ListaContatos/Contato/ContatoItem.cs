using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAgenda.Modelos.ListaContatos;

namespace MyAgenda.Componentes.ListaContatos.Contato
{
    public partial class ContatoItem : UserControl
    {
        public event EventHandler ContatoClick;

        private ContatoModelo _modelo;
        public ContatoModelo Modelo
        {
            get
            {
                return _modelo;
            }

            set
            {
                _modelo = value;
                lblNome.Text = _modelo.Nome;
                lblEmail.Text = _modelo.Email;
                
                if(_modelo.Estado == Database.UsuarioAPI.EEstadoUsuario.ONLINE)
                {
                    pcbEstado.BackgroundImage = Properties.Resources.ic_status_online;
                }
                else
                {
                    pcbEstado.BackgroundImage = Properties.Resources.ic_status_offline;
                }
            }
        }

        public ContatoItem()
        {
            InitializeComponent();
        }

        private void pcbMensagem_Click(object sender, EventArgs e)
        {
            if(ContatoClick != null)
            {
                ContatoClick(this, new EventArgs());
            }
        }
    }
}
