using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quartz;
using Quartz.Impl;
using MyAgenda.Entidades;
using MyAgenda.Dados;

namespace MyAgenda.Agendamentos
{
    public class JobEmiteAlertaParaEventos : IJob
    {
        List<Evento> eventos;

        public void Execute(IJobExecutionContext context)
        {
            EventoAPI eventoAPI = new EventoAPI();

            eventos = eventoAPI.BuscaInformacoesDeEventosParaEmissaoDeAlerta();

            foreach (Evento evento in eventos)
            {
                DateTime dataHoraServidor = DateTime.Now;
                DateTime dataHoraInicioEvento = evento.DataHoraInicio;
                double tempoRestante;

                if (DateTime.Compare(dataHoraServidor, dataHoraInicioEvento) < 0)
                {
                    tempoRestante = Math.Round(dataHoraInicioEvento.Subtract(dataHoraServidor).TotalMinutes);

                    if (tempoRestante == 5 || tempoRestante == 10)
                    {
                        FormAlertaEvento formAlertaEvento = new FormAlertaEvento(evento, tempoRestante);
                        formAlertaEvento.ShowDialog();
                    }
                }
            }
        }
    }
}
