﻿using MyAgenda.Controladores.Geral;
using MyAgenda.Dados;
using MyAgenda.Entidades;
using System;
using System.Windows.Forms;

namespace MyAgenda
{
    public partial class FormEditarEvento : Form
    {
        private Evento _evento;
        private UsuarioController _usuario = null;

        public FormEditarEvento()
        {
            InitializeComponent();
        }

        public FormEditarEvento(Evento evento, UsuarioController usuario)
        {
            InitializeComponent();

            _usuario = usuario;
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
            
            eventoAtualizado.Usuario = _usuario.GetModelo();

            eventoAPI.EditarEvento(_evento, eventoAtualizado);

            if (Application.OpenForms["FormEventos"] != null)
            {
                (Application.OpenForms["FormEventos"] as FormEventos).AtualizaEventosEmTela();
            }

            this.Close();
        }

        private void btnSalvarEdicao_MouseEnter(object sender, EventArgs e)
        {
            btnSalvarEdicao.Image = Properties.Resources.ic_add_circle_white;
            btnSalvarEdicao.ForeColor = System.Drawing.Color.White;
        }

        private void btnSalvarEdicao_MouseLeave(object sender, EventArgs e)
        {
            btnSalvarEdicao.Image = Properties.Resources.ic_add_circle_black;
            btnSalvarEdicao.ForeColor = System.Drawing.Color.Black;
        }
    }
}