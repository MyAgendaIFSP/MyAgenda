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
            eventoAtualizado.DataHoraInicio = cldDataInicio.SelectionRange.Start + dtpHorarioInicial.Value.TimeOfDay;
            eventoAtualizado.DataHoraTermino = cldDataTermino.SelectionRange.Start + dtpHorarioTermino.Value.TimeOfDay;

            Usuario usuario = new Usuario();
            usuario.IdUsuario = 1;

            eventoAtualizado.Usuario = usuario;

            eventoAPI.EditarEvento(_evento, eventoAtualizado);

            if (System.Windows.Forms.Application.OpenForms["FormEventos"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["FormEventos"] as FormEventos).AtualizaEventosEmTela();
            }

            this.Close();
        }
    }
}
