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

        private void _populaComboBoxDeListasdeAfazeres()
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
            _populaComboBoxDeListasdeAfazeres();

            _carregaTarefasDaBaseDeDados();
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
            tarefa.Descricao = txtTarefa.Text;
            tarefa.Data = cldData.SelectionRange.Start;

            Usuario usuario = new Usuario();
            usuario.IdUsuario = 2;

            tarefa.Usuario = usuario;

            ListaAfazeres lista = new ListaAfazeres();
            lista.Titulo = "Lista da Faculdade";

            tarefa.Lista = lista;

            TarefaAPI tarefaAPI = new TarefaAPI();
            tarefaAPI.AdicionaTarefa(tarefa);
            _carregaTarefasDaBaseDeDados();
        }

        private void _carregaTarefasDaBaseDeDados()
        {
            TarefaAPI tarefaAPI = new TarefaAPI();
            List<Tarefa> tarefas = tarefaAPI.CarregaTarefas("Lista da Faculdade");

            int y = 0;
            foreach (Tarefa tarefa in tarefas)
            {
                ItemTarefa itemTarefa = new ItemTarefa(tarefa);
                itemTarefa.DescricaoTarefa = tarefa.Descricao;
                itemTarefa.Width = pnlListaAfazeres.Width - 20;
                itemTarefa.Location = new Point(0, y);
                pnlListaAfazeres.Controls.Add(itemTarefa);
                y = pnlListaAfazeres.Controls[pnlListaAfazeres.Controls.Count - 1].Bottom + 10;

            }
        }
    }
}
