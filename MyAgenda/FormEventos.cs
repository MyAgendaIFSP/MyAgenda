using MyAgenda.Componentes.Geral;
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
                    MessageBox.Show("botão Pomodoro");
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

            DateTime dataHoraInicio = cldDataInicio.SelectionRange.Start;
            dataHoraInicio.Add(dtpHorarioInicial.Value.TimeOfDay);

            evento.DataHoraInicio = dataHoraInicio;

            DateTime dataHoraFinal = cldDataTermino.SelectionRange.Start;
            dataHoraFinal.Add(dtpHorarioTermino.Value.TimeOfDay);

            evento.DataHoraTermino = dataHoraFinal;

            EventoAPI eventoAPI = new EventoAPI();
            eventoAPI.AdicionaEvento(evento);
            _carregaEventosDaBaseDeDados();
        }

        public void AtualizaEventosEmTela()
        {
            pnlEventos.Controls.Clear();

            _carregaEventosDaBaseDeDados();
        }

        private void _carregaEventosDaBaseDeDados()
        {
            EventoAPI eventoAPI = new EventoAPI();
            List<Evento> eventos = eventoAPI.CarregaEventos();

            int y = 0;
            foreach (Evento evento in eventos)
            {
                ItemEvento itemEvento = new ItemEvento(evento);
                itemEvento.Titulo = evento.Titutlo;
                itemEvento.Descricao = evento.Descricao;
                itemEvento.DataHoraTermino = evento.DataHoraTermino.ToLongDateString();
                itemEvento.Width = pnlEventos.Width - 20;
                itemEvento.Location = new Point(0, y);
                pnlEventos.Controls.Add(itemEvento);
                y = pnlEventos.Controls[pnlEventos.Controls.Count - 1].Bottom + 10;
            }
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {
            _carregaEventosDaBaseDeDados();
        }
    }
}
