﻿using MyAgenda.Componentes.Geral;
using MyAgenda.Componentes.Tarefas;
using MyAgenda.Controladores.Geral;
using MyAgenda.Dados;
using MyAgenda.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MyAgenda
{
    public partial class FormListaAfazeres : BaseForm
    {
        private UsuarioController _usuario = null;
        private CultureInfo cultureInfo = new CultureInfo("pt-BR");

        public FormListaAfazeres(UsuarioController u)
        {
            InitializeComponent();

            BarraNavegacao.AddItem("Início", (int)EBarraNavegacaoBotoes.INICIO);
            BarraNavegacao.AddItem("Matriz do Tempo", (int)EBarraNavegacaoBotoes.MATRIZ_TEMPO);
            BarraNavegacao.AddItem("Pomodoro", (int)EBarraNavegacaoBotoes.POMODORO);

            _usuario = u;
        }

        protected override void OnBarraNavegacaoItemClick(Button btn, int itemId)
        {
            base.OnBarraNavegacaoItemClick(btn, itemId);

            switch (itemId)
            {
                case (int)EBarraNavegacaoBotoes.INICIO:
                    FormEventos eventos = new FormEventos(_usuario);
                    eventos.Show();
                    this.Close();
                    break;
                case (int)EBarraNavegacaoBotoes.POMODORO:
                    MessageBox.Show("botão Pomodoro");
                    break;
                case (int)EBarraNavegacaoBotoes.MATRIZ_TEMPO:
                    FormMatrizTempo matriz = new FormMatrizTempo(_usuario);
                    matriz.Show();
                    this.Close();
                    break;
            }
        }

        private void _populaComboBoxDeListasdeAfazeresDoFormAdicionarTarefa()
        {
            ListaAfazeresAPI listaAfazeresAPI = new ListaAfazeresAPI();

            List<ListaAfazeres> listasAfazeres = new List<ListaAfazeres>();
            listasAfazeres = listaAfazeresAPI.CarregaListasAfazeres();

            foreach (ListaAfazeres lista in listasAfazeres)
            {
                cbbOpcoesListasAfazeres.Items.Add(lista.Titulo);
            }
        }

        private void _populaComboBoxDeListasDeAfazeresDoTopoDoForm()
        {
            ListaAfazeresAPI listaAfazeresAPI = new ListaAfazeresAPI();

            List<ListaAfazeres> listasAfazeres = new List<ListaAfazeres>();
            listasAfazeres = listaAfazeresAPI.CarregaListasAfazeres();

            foreach (ListaAfazeres lista in listasAfazeres)
            {
                cbbListasAfazeres.Items.Add(lista.Titulo);
            }
        }

        private void FormListaAfazeres_Load(object sender, EventArgs e)
        {
            _populaComboBoxDeListasdeAfazeresDoFormAdicionarTarefa();

            _populaComboBoxDeListasDeAfazeresDoTopoDoForm();

            ListaAfazeresAPI listaAfazeresAPI = new ListaAfazeresAPI();
            _carregaTarefasDaBaseDeDados(listaAfazeresAPI.GetNomePrimeiraListaDeAfazeres());
        }

        public void AtualizaTarefasEmTela()
        {
            pnlListaAfazeres.Controls.Clear();
            cbbOpcoesListasAfazeres.Items.Clear();
            cbbListasAfazeres.Items.Clear();

            ListaAfazeresAPI listaAfazeresAPI = new ListaAfazeresAPI();
            _carregaTarefasDaBaseDeDados(listaAfazeresAPI.GetNomePrimeiraListaDeAfazeres());

            _populaComboBoxDeListasdeAfazeresDoFormAdicionarTarefa();

            _populaComboBoxDeListasDeAfazeresDoTopoDoForm();
        }

        private void btnNovaLista_Click(object sender, EventArgs e)
        {
            FormNovaListaAfazeres form = new FormNovaListaAfazeres(_usuario);
            form.ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = new Tarefa();
            tarefa.Titulo = txtTarefa.Text;
            tarefa.Data = cldData.SelectionRange.Start;

            tarefa.Usuario = _usuario.GetModelo();

            ListaAfazeres lista = new ListaAfazeres();
            lista.Titulo = cbbOpcoesListasAfazeres.GetItemText(cbbOpcoesListasAfazeres.SelectedItem);

            tarefa.Lista = lista;

            TarefaAPI tarefaAPI = new TarefaAPI();
            tarefaAPI.AdicionaTarefa(tarefa);
            _carregaTarefasDaBaseDeDados(lista.Titulo);
        }

        private void _carregaTarefasDaBaseDeDados(string listaAfazeres)
        {
            TarefaAPI tarefaAPI = new TarefaAPI();
            List<Tarefa> tarefas = tarefaAPI.CarregaTarefas(listaAfazeres);

            int y = 0;
            foreach (Tarefa tarefa in tarefas)
            {
                ItemTarefa itemTarefa = new ItemTarefa(tarefa);
                itemTarefa.DescricaoTarefa = tarefa.Titulo;
                itemTarefa.Width = pnlListaAfazeres.Width - 20;
                itemTarefa.Location = new Point(0, y);

                pnlListaAfazeres.Controls.Add(itemTarefa);
                y = pnlListaAfazeres.Controls[pnlListaAfazeres.Controls.Count - 1].Bottom + 10;

            }
        }

        private void btnExibirTarefas_Click(object sender, EventArgs e)
        {
            string listaAfazeres = cbbListasAfazeres.GetItemText(cbbListasAfazeres.SelectedItem);

            pnlListaAfazeres.Controls.Clear();
            cbbOpcoesListasAfazeres.Items.Clear();
            cbbListasAfazeres.Items.Clear();

            _carregaTarefasDaBaseDeDados(listaAfazeres);

            _populaComboBoxDeListasdeAfazeresDoFormAdicionarTarefa();

            _populaComboBoxDeListasDeAfazeresDoTopoDoForm();
        }

        private void btnNovaLista_MouseEnter(object sender, EventArgs e)
        {
            btnNovaLista.Image = Properties.Resources.ic_add_circle_white;
            btnNovaLista.ForeColor = System.Drawing.Color.White;
        }

        private void btnNovaLista_MouseLeave(object sender, EventArgs e)
        {
            btnNovaLista.Image = Properties.Resources.ic_add_circle_black;
            btnNovaLista.ForeColor = System.Drawing.Color.Black;
        }

        private void btnAdicionar_MouseEnter(object sender, EventArgs e)
        {
            btnAdicionar.Image = Properties.Resources.ic_add_circle_white;
            btnAdicionar.ForeColor = System.Drawing.Color.White;
        }

        private void btnAdicionar_MouseLeave(object sender, EventArgs e)
        {
            btnAdicionar.Image = Properties.Resources.ic_add_circle_black;
            btnAdicionar.ForeColor = System.Drawing.Color.Black;
        }

        private void btnExibirTarefas_MouseEnter(object sender, EventArgs e)
        {
            btnExibirTarefas.ForeColor = System.Drawing.Color.White;
        }

        private void btnExibirTarefas_MouseLeave(object sender, EventArgs e)
        {
            btnExibirTarefas.ForeColor = System.Drawing.Color.Black;
        }
    }
}
