using MyAgenda.Dados;
using MyAgenda.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda.Componentes.Tarefas
{
    public partial class ItemEvento : UserControl
    {
        private Evento _evento;

        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        public string Descricao
        {
            get { return lblDescricao.Text; }
            set { lblDescricao.Text = value; }
        }

        public string DataHoraTermino
        {
            get { return lblDataHoraTermino.Text; }
            set { lblDataHoraTermino.Text = value; }
        }

        public ItemEvento()
        {
            InitializeComponent();
        }

        public ItemEvento(Evento evento)
        {
            InitializeComponent();

            this._evento = evento;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditarEvento formEditarEvento = new FormEditarEvento(_evento);
            formEditarEvento.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            EventoAPI eventoAPI = new EventoAPI();
            eventoAPI.ExcluirEvento(_evento);

            if (System.Windows.Forms.Application.OpenForms["FormEventos"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["FormEventos"] as FormEventos).AtualizaEventosEmTela();
            }
        }
        private void ItemEvento_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            btnEditar.BackColor = Color.LightGray;
            btnExcluir.BackColor = Color.LightGray;
        }

        private void ItemTarefa_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnEditar.BackColor = Color.White;
            btnExcluir.BackColor = Color.White;
        }

        private void btnExcluir_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            btnEditar.BackColor = Color.LightGray;
            btnExcluir.BackColor = Color.LightGray;
        }

        private void btnExcluir_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnEditar.BackColor = Color.White;
            btnExcluir.BackColor = Color.White;
        }

        private void btnEditar_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            btnEditar.BackColor = Color.LightGray;
            btnExcluir.BackColor = Color.LightGray;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnEditar.BackColor = Color.White;
            btnExcluir.BackColor = Color.White;
        }
    }
}
