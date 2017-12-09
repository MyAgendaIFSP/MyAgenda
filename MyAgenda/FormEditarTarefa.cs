using MyAgenda.Controladores.Geral;
using MyAgenda.Dados;
using MyAgenda.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyAgenda
{
    public partial class FormEditarTarefa : Form
    {
        private Tarefa _tarefa;

        private UsuarioController _usuario;

        public FormEditarTarefa()
        {
            InitializeComponent();
        }

        public FormEditarTarefa(Tarefa tarefa, UsuarioController usuario)
        {
            InitializeComponent();

            _usuario = usuario;
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

            txtTarefa.Text = _tarefa.Titulo;
            cbbListasAfazeres.Text = _tarefa.Lista.Titulo;
            cldData.SetDate(_tarefa.Data);
        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            TarefaAPI tarefaAPI = new TarefaAPI();
            Tarefa tarefaAtualizada = new Tarefa();
            tarefaAtualizada.Titulo = txtTarefa.Text;
            tarefaAtualizada.Descricao = txtTarefa.Text;
            tarefaAtualizada.Data = cldData.SelectionRange.Start;
            
            tarefaAtualizada.Usuario = _usuario.GetModelo();

            tarefaAPI.EditarTarefa(_tarefa, tarefaAtualizada);

            if (System.Windows.Forms.Application.OpenForms["FormListaAfazeres"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["FormListaAfazeres"] as FormListaAfazeres).AtualizaTarefasEmTela();
            }

            this.Close();
        }
    }
}
