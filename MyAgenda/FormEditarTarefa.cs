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

namespace MyAgenda
{
    public partial class FormEditarTarefa : Form
    {
        private Tarefa _tarefa;

        public FormEditarTarefa()
        {
            InitializeComponent();
        }

        public FormEditarTarefa(Tarefa tarefa)
        {
            InitializeComponent();

            this._tarefa = tarefa;
        }

        private void FormEditarTarefa_Load(object sender, EventArgs e)
        {
            ListaAfazeresAPI listaAfazeresAPI = new ListaAfazeresAPI();

            List<ListaAfazeres> listasAfazeres = new List<ListaAfazeres>();
            listasAfazeres = listaAfazeresAPI.CarregaListasAfazeres();

            foreach (ListaAfazeres lista in listasAfazeres)
            {
                cbbListasAfazeres.Items.Add(lista.Titulo);
            }

            txtTarefa.Text = _tarefa.Descricao;
            cbbListasAfazeres.Text = _tarefa.Lista.Titulo;
            cldData.SetDate(_tarefa.Data);
        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            TarefaAPI tarefaAPI = new TarefaAPI();
            Tarefa tarefaAtualizada = new Tarefa();
            tarefaAtualizada.Titulo = "Teste";
            tarefaAtualizada.Descricao = txtTarefa.Text;
            tarefaAtualizada.Data = cldData.SelectionRange.Start;

            Usuario usuario = new Usuario();
            usuario.IdUsuario = 1;

            tarefaAtualizada.Usuario = usuario;

            tarefaAPI.EditarTarefa(_tarefa, tarefaAtualizada);

            if (System.Windows.Forms.Application.OpenForms["FormListaAfazeres"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["FormListaAfazeres"] as FormListaAfazeres).AtualizaTarefasEmTela();
            }

            this.Close();
        }
    }
}
