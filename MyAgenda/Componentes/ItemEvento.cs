using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAgenda.Entidades;
using MyAgenda.Dados;

namespace MyAgenda.Componentes
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
            /*FormEditarEvento formEditarEvento = new FormEditarEvento(_evento);
            formEditarEvento.Show();*/
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            EventoAPI eventoAPI = new EventoAPI();
            eventoAPI.ExcluirEvento(_evento);
            //TODO Atualizar a lista após a exclusão do evento
        }
    }
}
