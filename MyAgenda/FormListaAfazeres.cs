using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MyAgenda.Componentes;
using MyAgenda.Entidades;
using MyAgenda.Dados;

namespace MyAgenda
{
    public partial class FormListaAfazeres : Form
    {

        private CultureInfo cultureInfo = new CultureInfo("pt-BR");

        public FormListaAfazeres()
        {
            InitializeComponent();
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
            FormNovaListaAfazeres form = new FormNovaListaAfazeres();
            form.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = new Tarefa();
            tarefa.Titulo = txtTarefa.Text;
            tarefa.Data = cldData.SelectionRange.Start;

            Usuario usuario = new Usuario();
            usuario.IdUsuario = 2;

            tarefa.Usuario = usuario;

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
    }
}
