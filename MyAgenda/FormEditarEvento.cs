using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAgenda.Entidades;
using MyAgenda.Dados;

namespace MyAgenda
{
    public partial class FormEditarEvento : Form
    {
        private Evento _evento;

        public FormEditarEvento()
        {
            InitializeComponent();
        }

        public FormEditarEvento(Evento evento)
        {
            InitializeComponent();

            _evento = evento;
        }

        private void FormEditarEvento_Load(object sender, EventArgs e)
        {
            txtTitulo.Text = _evento.Titutlo;
            txtDescricao.Text = _evento.Descricao;
            cldDataInicio.SetDate(_evento.DataHoraInicio);
            cldDataTermino.SetDate(_evento.DataHoraTermino);
        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            EventoAPI eventoAPI = new EventoAPI();
            Evento eventoAtualizado = new Evento();
            eventoAtualizado.Titutlo = txtTitulo.Text;
            eventoAtualizado.Descricao = txtDescricao.Text;
            eventoAtualizado.DataHoraInicio = cldDataInicio.SelectionRange.Start;
            eventoAtualizado.DataHoraTermino = cldDataTermino.SelectionRange.Start;
            //TODO Ajustar horário inicial e final dos eventos no update

            Usuario usuario = new Usuario();
            usuario.IdUsuario = 1;
            //TODO Ajustar o usuário do evento

            eventoAtualizado.Usuario = usuario;

            eventoAPI.EditarEvento(_evento, eventoAtualizado);

            this.Close();
            //TODO Atualizar o form de eventos após a atualização
        }
    }
}
