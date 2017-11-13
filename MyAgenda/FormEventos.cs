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
using MyAgenda.Componentes;

namespace MyAgenda
{
    public partial class FormEventos : Form
    {
        public FormEventos()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            evento.Titutlo = txtTitulo.Text;
            evento.Descricao = txtDescricao.Text;

            DateTime dataHoraInicio = cldDataInicio.SelectionRange.Start;
            dataHoraInicio.Add(dtpHorarioInicio.Value.TimeOfDay);

            evento.DataHoraInicio = dataHoraInicio;

            DateTime dataHoraFinal = cldDataTermino.SelectionRange.Start;
            dataHoraFinal.Add(dtpHorarioTermino.Value.TimeOfDay);

            evento.DataHoraTermino = dataHoraFinal;

            EventoAPI eventoAPI = new EventoAPI();
            eventoAPI.AdicionaEvento(evento);
            CarregaEventosDaBaseDeDados();
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {
            CarregaEventosDaBaseDeDados();
        }

        private void CarregaEventosDaBaseDeDados()
        {
            EventoAPI eventoAPI = new EventoAPI();
            List<Evento> eventos = eventoAPI.CarregaEventos();

            int y = 1;
            foreach (Evento evento in eventos)
            {
                ItemEvento itemEvento = new ItemEvento();
                itemEvento.Titulo = evento.Titutlo;
                itemEvento.Descricao = evento.Descricao;
                itemEvento.DataHoraTermino = evento.DataHoraTermino.ToLongDateString();
                if (y == 1)
                {
                    itemEvento.Location = new Point(0, 0);
                }
                else
                {
                    itemEvento.Location = new Point(0, y * 60 + 1);
                }
                pnlEventos.Controls.Add(itemEvento);
                y++;
            }
        }
    }
}
