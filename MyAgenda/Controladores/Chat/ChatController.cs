﻿using MyAgenda.Controladores.Geral;
using MyAgenda.Database;
using MyAgenda.Modelos.Chat;
using MyAgenda.Modelos.ListaContatos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MyAgenda.Controladores.Chat
{
    class ChatController
    {
        public delegate void MensagensCarregadasEventHandler(object sender, List<MensagemModelo> msgs);
        public delegate void MensagemRecebidaEventHandler(object sender, MensagemModelo msg);

        public event MensagensCarregadasEventHandler MensagensCarregadas;
        public event MensagemRecebidaEventHandler MensagemRecebida;

        /// <summary>
        /// Id da conversa atual
        /// </summary>
        public int Id { get; set; }

        public List<MensagemModelo> Mensagens { get; set; }

        private ContatoModelo _contato;

        private UsuarioController _usuario;

        private ChatAPI _api;

        //private BackgroundWorker _escutadorMensagens;
        Progress<MensagemModelo> _mensagemRepoter;

        public bool Escuta { get; set; }

        public bool AceitaNovaMensagem { get; set; }

        public bool TodasConversas { get; set; }

        public ChatController()
        {
            Mensagens = new List<MensagemModelo>();
            Escuta = true;
            AceitaNovaMensagem = true;
            _api = new ChatAPI();
            _usuario = UsuarioController.GetInstance();
            TodasConversas = true;

            _comecaEscutarMensagens();
        }

        public ChatController(ContatoModelo contato)
        {
            Mensagens = new List<MensagemModelo>();
            _contato = contato;
            Escuta = true;
            AceitaNovaMensagem = true;
            _api = new ChatAPI();
            _usuario = UsuarioController.GetInstance();
            TodasConversas = false;

            _comecaEscutarMensagens();
        }
        
        private void _comecaEscutarMensagens()
        {
            _mensagemRepoter = new Progress<MensagemModelo>(_disparaMensagem);
            Task.Run((Action) _escutaMensagem);
        }

        private void _escutaMensagem()
        {
            var progress = _mensagemRepoter as IProgress<MensagemModelo>;
            ChatAPI chat = new ChatAPI();

            while (Escuta)
            {
                MensagemModelo msg;

                if (TodasConversas)
                {
                    msg = null;
                }
                else
                {
                    msg = chat.MensagemNova(Id, _usuario.GetModelo().Id);
                }

                if (msg != null && AceitaNovaMensagem)
                {
                    progress.Report(msg);
                }

                Thread.Sleep(1000);
            }
        }

        public void AtualizaMensagem(MensagemModelo msg)
        {
            if(_api.AtualizaEstadoMensagem(msg, Id))
            {
                msg.Estado = ChatAPI.EEstadoMensagem.ENTREGUE;
            }
        }

        private void _disparaMensagem(MensagemModelo msg)
        {
            //Recebeu mensagem nova

            if (TodasConversas)
            {
                //Mostrar notificação de mensagem
            }
            else
            {
                if (MensagemRecebida != null)
                {
                    MensagemRecebida(this, msg);
                }
            }
        }

        public void Carrega()
        {
            bool conversaNova = false;
            Id = _api.AbreConversa(_usuario.GetModelo().Id, _contato.Id, ref conversaNova);

            if (!conversaNova && Id > 0)
            {
                //buscar as mensagens existentes na conversa
                _carregarMensagens();
            }
        }

        public ContatoModelo GetContato()
        {
            return _contato;
        }

        public bool EnviaMensagem(MensagemModelo msg)
        {
            //Enviar a mensagem
            bool enviada = true;

            if (enviada)
            {
                msg.Estado = ChatAPI.EEstadoMensagem.ENTREGUE;
                _api.RegistraMensagem(msg, Id);
            }

            return enviada;
        }

        private void _carregarMensagens()
        {
            Mensagens = _api.CarregaMensagens(Id);

            if (MensagensCarregadas != null)
            {
                MensagensCarregadas(this, Mensagens);
            }
        }

    }
}
