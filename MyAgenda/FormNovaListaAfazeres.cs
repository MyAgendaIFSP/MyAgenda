using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAgenda.Dados;
using MyAgenda.Entidades;

namespace MyAgenda
{
    public partial class FormNovaListaAfazeres : Form
    {
        public FormNovaListaAfazeres()
        {
            InitializeComponent();
        }

        private void btnNovaLista_Click(object sender, EventArgs e)
        {
            ListaAfazeres listaAfazeres = new ListaAfazeres();
            listaAfazeres.Titulo = txtTitulo.Text;
            listaAfazeres.DataCriacao = DateTime.Now;

            Usuario usuario = new Usuario();
            usuario.IdUsuario = 2;

            listaAfazeres.Usuario = usuario;

            ListaAfazeresAPI listaAfazeresAPI = new ListaAfazeresAPI();
            listaAfazeresAPI.AdicionaLista(listaAfazeres);
            this.Close();
        }
    }
}
