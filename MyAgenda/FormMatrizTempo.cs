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
    public partial class FormMatrizTempo : BaseForm
    {
        private Matriz.EQuadrante _quadranteSelecionado = Matriz.EQuadrante.NENHUM;

        private UsuarioController _usuario = null;

        public FormMatrizTempo(UsuarioController u)
        {
            InitializeComponent();

            this.StatusLabel = lblStatus;

            BarraNavegacao.AddItem("Início", Properties.Resources.ic_home_white, (int)EBarraNavegacaoBotoes.INICIO);
            BarraNavegacao.AddItem("Pomodoro", (int)EBarraNavegacaoBotoes.POMODORO);
            BarraNavegacao.AddItem("Tarefas", (int)EBarraNavegacaoBotoes.TAREFAS);

            _usuario = u;

            this.WindowState = FormWindowState.Maximized;
        }

        protected override void OnBarraNavegacaoItemClick(Button btn, int itemId)
        {
            base.OnBarraNavegacaoItemClick(btn, itemId);

            switch (itemId)
            {
                case (int)EBarraNavegacaoBotoes.INICIO:
                    MessageBox.Show("botão início");
                    break;
                case (int)EBarraNavegacaoBotoes.POMODORO:
                    MessageBox.Show("botão Pomodoro");
                    break;
                case (int)EBarraNavegacaoBotoes.TAREFAS:
                    MessageBox.Show("botão Tarefas");
                    break;
            }
        }

        private void FormMatrizTempo_Load(object sender, EventArgs e)
        {
            this.ComecaCarregar();

            //Buscar no banco de dados os itens do usuário
            matrizTempo.CarregaMatriz();

            BarraNavegacao.Width = this.Width;

            this.ParaCarregar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string descricao = txtDescricao.Text;
            
            if (String.IsNullOrEmpty(titulo))
            {
                this.MostraErro("Digite um título para o item");
                return;
            }
            else if (_quadranteSelecionado == Matriz.EQuadrante.NENHUM)
            {
                this.MostraErro("Selecione um quadrante");
                return;
            }

            this.ComecaCarregar();

            ItemMatrizModel item = new ItemMatrizModel(titulo, descricao, _quadranteSelecionado);

            matrizTempo.AdicionaItem(new ItemMatrizController(item));

            this.ParaCarregar();
            this.MostraSucesso("Item adicionado.");
        }

        private void btnQuad1_Click(object sender, EventArgs e)
        {
            btnQuad1.BackColor = Color.DarkSlateGray;
            btnQuad2.BackColor = Color.LightSlateGray;
            btnQuad3.BackColor = Color.LightSlateGray;
            btnQuad4.BackColor = Color.LightSlateGray;

            _quadranteSelecionado = Matriz.EQuadrante.QUADRANTE_1;
        }

        private void btnQuad2_Click(object sender, EventArgs e)
        {
            btnQuad2.BackColor = Color.DarkSlateGray;
            btnQuad1.BackColor = Color.LightSlateGray;
            btnQuad3.BackColor = Color.LightSlateGray;
            btnQuad4.BackColor = Color.LightSlateGray;

            _quadranteSelecionado = Matriz.EQuadrante.QUADRANTE_2;
        }

        private void btnQuad3_Click(object sender, EventArgs e)
        {
            btnQuad3.BackColor = Color.DarkSlateGray;
            btnQuad1.BackColor = Color.LightSlateGray;
            btnQuad2.BackColor = Color.LightSlateGray;
            btnQuad4.BackColor = Color.LightSlateGray;

            _quadranteSelecionado = Matriz.EQuadrante.QUADRANTE_3;
        }

        private void btnQuad4_Click(object sender, EventArgs e)
        {
            btnQuad4.BackColor = Color.DarkSlateGray;
            btnQuad1.BackColor = Color.LightSlateGray;
            btnQuad2.BackColor = Color.LightSlateGray;
            btnQuad3.BackColor = Color.LightSlateGray;

            _quadranteSelecionado = Matriz.EQuadrante.QUADRANTE_4;
        }

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

        private void FormMatrizTempo_ResizeEnd(object sender, EventArgs e)
        {
            matrizTempo.Invalidate();
        }
    }
}
