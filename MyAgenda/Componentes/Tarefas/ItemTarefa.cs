using MyAgenda.Controladores.Geral;
using MyAgenda.Dados;
using MyAgenda.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda.Componentes.Tarefas
{
    public partial class ItemTarefa : UserControl
    {
        private Tarefa _tarefa;

        public string DescricaoTarefa
        {
            get { return lblDescricaoTarefa.Text; }
            set { lblDescricaoTarefa.Text = value; }
        }

        public ItemTarefa()
        {
            this.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            InitializeComponent();
        }

        public ItemTarefa(Tarefa tarefa)
        {
            InitializeComponent();

            this._tarefa = tarefa;
        }

        public void btnChecar_Click(object sender, EventArgs e)
        {
            TarefaAPI tarefaAPI = new TarefaAPI();
            
            if (tarefaAPI.IsTarefaConcluida(_tarefa.Titulo, _tarefa.Lista.Titulo))
            {
                tarefaAPI.DesconcluirTarefa(_tarefa);
                lblDescricaoTarefa.Font = new Font(lblDescricaoTarefa.Font, FontStyle.Regular);
            } 
            else
            {
                tarefaAPI.ConcluirTarefa(_tarefa);
                lblDescricaoTarefa.Font = new Font(lblDescricaoTarefa.Font, FontStyle.Strikeout);
            }
        }

        private void ItemTarefa_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            btnChecar.BackColor = Color.LightGray;
            btnEditar.BackColor = Color.LightGray;
            btnExcluir.BackColor = Color.LightGray;
        }

        private void ItemTarefa_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnChecar.BackColor = Color.White;
            btnEditar.BackColor = Color.White;
            btnExcluir.BackColor = Color.White;
        }

        private void btnExcluir_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            btnChecar.BackColor = Color.LightGray;
            btnEditar.BackColor = Color.LightGray;
            btnExcluir.BackColor = Color.LightGray;
        }

        private void btnExcluir_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnChecar.BackColor = Color.White;
            btnEditar.BackColor = Color.White;
            btnExcluir.BackColor = Color.White;
        }

        private void btnEditar_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            btnChecar.BackColor = Color.LightGray;
            btnEditar.BackColor = Color.LightGray;
            btnExcluir.BackColor = Color.LightGray;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnChecar.BackColor = Color.White;
            btnEditar.BackColor = Color.White;
            btnExcluir.BackColor = Color.White;
        }

        private void btnChecar_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            btnChecar.BackColor = Color.LightGray;
            btnEditar.BackColor = Color.LightGray;
            btnExcluir.BackColor = Color.LightGray;
        }

        private void btnChecar_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnChecar.BackColor = Color.White;
            btnEditar.BackColor = Color.White;
            btnExcluir.BackColor = Color.White;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditarTarefa formEditarTarefa = new FormEditarTarefa(_tarefa, UsuarioController.GetInstance());
            formEditarTarefa.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            TarefaAPI tarefaAPI = new TarefaAPI();
            tarefaAPI.ExcluirTarefa(_tarefa);

            if (System.Windows.Forms.Application.OpenForms["FormListaAfazeres"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["FormListaAfazeres"] as FormListaAfazeres).AtualizaTarefasEmTela();
            }
        }

        private void ItemTarefa_Load(object sender, EventArgs e)
        {
            TarefaAPI tarefaAPI = new TarefaAPI();

            Tarefa tarefa = new Tarefa();
            tarefa.Titulo = lblDescricaoTarefa.Text;

            if (tarefaAPI.IsTarefaConcluida(lblDescricaoTarefa.Text, _tarefa.Lista.Titulo))
            {
                lblDescricaoTarefa.Font = new Font(lblDescricaoTarefa.Font, FontStyle.Strikeout);
            }
            else
            {
                lblDescricaoTarefa.Font = new Font(lblDescricaoTarefa.Font, FontStyle.Regular);
            }
        }

        private void lblDescricaoTarefa_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            btnChecar.BackColor = Color.LightGray;
            btnEditar.BackColor = Color.LightGray;
            btnExcluir.BackColor = Color.LightGray;
        }

        private void lblDescricaoTarefa_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnChecar.BackColor = Color.White;
            btnEditar.BackColor = Color.White;
            btnExcluir.BackColor = Color.White;
        }
    }
}
