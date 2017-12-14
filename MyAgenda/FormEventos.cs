﻿using MyAgenda.Componentes.Geral;
using MyAgenda.Componentes.Tarefas;
using MyAgenda.Controladores.Geral;
using MyAgenda.Dados;
using MyAgenda.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda
{
    public partial class FormEventos : BaseForm
    {
        private UsuarioController _usuario = null;

        public FormEventos(UsuarioController u)
        {
            InitializeComponent();

            BarraNavegacao.AddItem("Matriz do Tempo", (int)EBarraNavegacaoBotoes.MATRIZ_TEMPO);
            BarraNavegacao.AddItem("Pomodoro", (int)EBarraNavegacaoBotoes.POMODORO);
            BarraNavegacao.AddItem("Tarefas", (int)EBarraNavegacaoBotoes.TAREFAS);

            _usuario = u;
        }

        protected override void OnBarraNavegacaoItemClick(Button btn, int itemId)
        {
            base.OnBarraNavegacaoItemClick(btn, itemId);

            switch (itemId)
            {
                case (int)EBarraNavegacaoBotoes.MATRIZ_TEMPO:
                    FormMatrizTempo matriz = new FormMatrizTempo(_usuario);
                    matriz.Show();
                    this.Close();
                    break;
                case (int)EBarraNavegacaoBotoes.POMODORO:
                    FormPomodoro pomodoro = new FormPomodoro(_usuario);
                    pomodoro.Show();
                    this.Close();
                    break;
                case (int)EBarraNavegacaoBotoes.TAREFAS:
                    FormListaAfazeres tarefas = new FormListaAfazeres(_usuario);
                    tarefas.Show();
                    this.Close();
                    break;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            evento.Titutlo = txtTitulo.Text;
            evento.Descricao = txtDescricao.Text;

            DateTime dataHoraInicio = dtpInicio.Value;

            evento.DataHoraInicio = dataHoraInicio;

            DateTime dataHoraFinal = dtpTermino.Value;

            evento.DataHoraTermino = dataHoraFinal;

            EventoAPI eventoAPI = new EventoAPI();
            eventoAPI.AdicionaEvento(evento);
            AtualizaEventosEmTela();
        }

        public void AtualizaEventosEmTela()
        {
            txtTitulo.Text = "";
            txtDescricao.Text = "";
            dtpInicio.Value = DateTime.Now;
            dtpTermino.Value = DateTime.Now;        

            pnlEventos.Controls.Clear();        

            _carregaEventosDaBaseDeDados();
        }

        private void _carregaEventosDaBaseDeDados()
        {
            EventoAPI eventoAPI = new EventoAPI();
            List<Evento> eventos = eventoAPI.CarregaEventos();
            foreach (Evento evento in eventos)
            {
                ItemEvento itemEvento = new ItemEvento(evento);
                itemEvento.Titulo = evento.Titutlo;
                itemEvento.Descricao = evento.Descricao;
                itemEvento.DataInicio = evento.DataHoraInicio.ToLongDateString();
                itemEvento.HoraInicioHoraFim = evento.DataHoraInicio.TimeOfDay.ToString(@"hh\:mm") + " - " + evento.DataHoraTermino.TimeOfDay.ToString(@"hh\:mm");
                itemEvento.Dock = DockStyle.Top;

                double dateDiff = (evento.DataHoraInicio - DateTime.Now).TotalDays;

                if (dateDiff < 0)
                {
                    itemEvento.Prioridade = Color.LightGray;
                }
                else if (dateDiff <= 2)
                {
                    itemEvento.Prioridade = Color.LightSalmon;
                }
                else if (dateDiff <= 7)
                {
                    itemEvento.Prioridade = Color.LightYellow;
                } else
                {
                    itemEvento.Prioridade = Color.LightGreen;
                }

                pnlEventos.Controls.Add(itemEvento);
            }
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {
            _carregaEventosDaBaseDeDados();

            dtpInicio.Value = DateTime.Now;
            dtpTermino.Value = DateTime.Now;
        }

        private void btnAdicionar_MouseLeave(object sender, EventArgs e)
        {
            btnAdicionar.Image = Properties.Resources.ic_add_circle_black;
            btnAdicionar.ForeColor = System.Drawing.Color.Black;
        }

        private void btnAdicionar_MouseEnter(object sender, EventArgs e)
        {
            btnAdicionar.Image = Properties.Resources.ic_add_circle_white;
            btnAdicionar.ForeColor = System.Drawing.Color.White;
        }
    }
}
