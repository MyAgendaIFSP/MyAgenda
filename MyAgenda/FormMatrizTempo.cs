using MyAgenda.Controladores.Geral;
using MyAgenda.Controladores.MatrizTempo;
using MyAgenda.Modelos.MatrizTempo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MyAgenda.Componentes.Geral;
using MyAgenda.Componentes.MatrizTempo;

namespace MyAgenda
{
    public partial class FormMatrizTempo : Form
    {
        private Matriz.EQuadrante _quadranteSelecionado = Matriz.EQuadrante.NENHUM;

        private UsuarioController _usuario = null;

        public FormMatrizTempo(UsuarioController u)
        {
            InitializeComponent();
            barraNavegacao1.MenuItemClick += _click;

            barraNavegacao1.AddItem("Início", Properties.Resources.ic_home_white, 1);
            barraNavegacao1.AddItem("Pomodoro", 2);
            barraNavegacao1.AddItem("Tarefas", 3);
            barraNavegacao1.AddItem("Sair", Properties.Resources.ic_exit_to_app_white, BarraNavegacao.EPosicao.DIREITA, 4);
            barraNavegacao1.AddItem("Offline", Properties.Resources.ic_cloud_queue_white, BarraNavegacao.EPosicao.DIREITA, _cloudClick, 5);

            _usuario = u;
        }

        private void FormMatrizTempo_Load(object sender, EventArgs e)
        {
            _comecaCarregar();

            //Buscar no banco de dados os itens do usuário
            matrizTempo.CarregaMatriz();

            _paraCarregar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string descricao = txtDescricao.Text;

            if (String.IsNullOrEmpty(titulo))
            {
                _mostraErro("Digite um título para o item");
                return;
            }
            else if (_quadranteSelecionado == Matriz.EQuadrante.NENHUM)
            {
                _mostraErro("Selecione um quadrante");
                return;
            }

            ItemMatrizModel item = new ItemMatrizModel(titulo, descricao, _quadranteSelecionado);

            matrizTempo.AdicionaItem(new ItemMatrizController(item));

            _mostraSucesso("Item adicionado.");
        }

        private void btnQuad1_Click(object sender, EventArgs e)
        {
            _quadranteSelecionado = Matriz.EQuadrante.QUADRANTE_1;
        }

        private void btnQuad2_Click(object sender, EventArgs e)
        {
            _quadranteSelecionado = Matriz.EQuadrante.QUADRANTE_2;
        }

        private void btnQuad3_Click(object sender, EventArgs e)
        {
            _quadranteSelecionado = Matriz.EQuadrante.QUADRANTE_3;
        }

        private void btnQuad4_Click(object sender, EventArgs e)
        {
            _quadranteSelecionado = Matriz.EQuadrante.QUADRANTE_4;
        }

        #region Click handlers da barra de navegação

        private void _cloudClick(ref Button btn, int itemId)
        {
            MessageBox.Show("botão Nuvem");

            //Realizar aqui a sincronização dos dados do usuário

            btn.Image = Properties.Resources.ic_cloud_white;
        }

        private void _click(ref Button btn, int itemId)
        {
            switch (itemId)
            {
                case 1:
                    MessageBox.Show("botão início");
                    break;
                case 2:
                    MessageBox.Show("botão Pomodoro");
                    break;
                case 3:
                    MessageBox.Show("botão Tarefas");
                    break;
                case 4:
                    MessageBox.Show("botão Sair");
                    break;
            }
        }

        #endregion

        #region Tramits de interface do usuário

        private void btnQuad1_MouseEnter(object sender, EventArgs e)
        {
            //Destacar quadrante 1 na matriz
            matrizTempo.IniciaHighlightQuadrante1();
        }

        private void btnQuad2_MouseEnter(object sender, EventArgs e)
        {
            //Destacar quadrante 2 na matriz
            matrizTempo.IniciaHighlightQuadrante2();
        }

        private void btnQuad3_MouseEnter(object sender, EventArgs e)
        {
            //Destacar quadrante 3 na matriz
            matrizTempo.IniciaHighlightQuadrante3();
        }

        private void btnQuad4_MouseEnter(object sender, EventArgs e)
        {
            //Destacar quadrante 4 na matriz
            matrizTempo.IniciaHighlightQuadrante4();
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

        private void btnQuad1_MouseLeave(object sender, EventArgs e)
        {
            matrizTempo.ParaHighlightQuadrante1();
        }

        private void btnQuad2_MouseLeave(object sender, EventArgs e)
        {
            matrizTempo.ParaHighlightQuadrante2();
        }

        private void btnQuad3_MouseLeave(object sender, EventArgs e)
        {
            matrizTempo.ParaHighlightQuadrante3();
        }

        private void btnQuad4_MouseLeave(object sender, EventArgs e)
        {
            matrizTempo.ParaHighlightQuadrante4();
        }

        #endregion

        #region Funções de apoio

        private void _mostraErro(string msg)
        {
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = msg;
            lblStatus.Visible = true;
        }

        private void _mostraSucesso(string msg)
        {
            lblStatus.ForeColor = Color.LimeGreen;
            lblStatus.Text = msg;
            lblStatus.Visible = true;
        }

        private void _comecaCarregar()
        {
            loader1.Active = true;
            _desabilitaTudo();
        }

        private void _paraCarregar()
        {
            loader1.Active = false;
            _habilitaTudo();
        }

        private void _desabilitaTudo()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
        }

        private void _habilitaTudo()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
        }

        #endregion

        private void FormMatrizTempo_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection forms = Application.OpenForms;
            if (forms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                bool quit = true;

                foreach (Form f in forms)
                {
                    quit = !(f.Visible == true);
                }

                if (quit)
                {
                    Application.Exit();
                }
            }
        }

    }
}
