using MyAgenda.Dados;
using System;

namespace MyAgenda.Modelos.Chat
{
    public class MensagemModelo
    {

        public string Autor { get; set; }
        public string Texto { get; set; }
        public ChatAPI.EEstadoMensagem Estado { get; set; }
        public DateTime Data { get; set; }
        public int Destinatario { get; set; }

        public MensagemModelo(string texto, ChatAPI.EEstadoMensagem estado, DateTime data, int destino)
        {
            Texto = texto;
            Estado = estado;
            Data = data;
            Destinatario = destino;
        }

        public MensagemModelo(string autor, string texto, ChatAPI.EEstadoMensagem estado, DateTime data, int destino)
        {
            Texto = texto;
            Estado = estado;
            Data = data;
            Destinatario = destino;
            Autor = autor;
        }

        public MensagemModelo(string texto, DateTime data, string autor)
        {
            Texto = texto;
            Data = data;
            Autor = autor;
        }
    }
}
