using MyAgenda.Controladores.Geral;
using MyAgenda.Dados;
using MyAgenda.Entidades;
using System;
using System.Windows.Forms;

namespace MyAgenda
{
    public partial class FormNovaListaAfazeres : Form
    {

        private UsuarioController _usuario;

        public FormNovaListaAfazeres()
        {
            InitializeComponent();
        }

        public FormNovaListaAfazeres(UsuarioController usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void btnNovaLista_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTitulo.Text)) {
                ListaAfazeres listaAfazeres = new ListaAfazeres();
                listaAfazeres.Titulo = txtTitulo.Text;
                listaAfazeres.DataCriacao = DateTime.Now;

                listaAfazeres.Usuario = _usuario.GetModelo();

                ListaAfazeresAPI listaAfazeresAPI = new ListaAfazeresAPI();
                listaAfazeresAPI.AdicionaLista(listaAfazeres);

                if (System.Windows.Forms.Application.OpenForms["FormListaAfazeres"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["FormListaAfazeres"] as FormListaAfazeres).AtualizaTarefasEmTela();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Digite um título para a lista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNovaLista_MouseEnter(object sender, EventArgs e)
        {
            btnNovaLista.Image = Properties.Resources.ic_add_circle_white;
            btnNovaLista.ForeColor = System.Drawing.Color.White;
        }

        private void btnNovaLista_MouseLeave(object sender, EventArgs e)
        {
            btnNovaLista.Image = Properties.Resources.ic_add_circle_black;
            btnNovaLista.ForeColor = System.Drawing.Color.Black;
        }
    }
}
