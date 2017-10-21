using System;
using System.Windows.Forms;
using static MyAgenda.Componentes.Geral.BarraNavegacao;

namespace MyAgenda
{
    public partial class FormMatrizTempo : Form
    {
        public FormMatrizTempo()
        {
            InitializeComponent();
            barraNavegacao1.MenuItemClick += _click;
            
            barraNavegacao1.AddItem("Início", Properties.Resources.ic_home_white, 1);
            barraNavegacao1.AddItem("Pomodoro", 2);
            barraNavegacao1.AddItem("Tarefas", 3);
            barraNavegacao1.AddItem("Sair", Properties.Resources.ic_exit_to_app_white, EPosicao.DIREITA, 4);
            barraNavegacao1.AddItem("Offline", Properties.Resources.ic_cloud_queue_white, EPosicao.DIREITA, _cloudClick, 5);

        }

        private void _cloudClick(ref Button btn, int itemId)
        {
            MessageBox.Show("botão Nuvem");

            //Realizar aqui a sincronização dos dados do usuário

            btn.Image = Properties.Resources.ic_cloud_white;
        }

        private void _click(ref Button btn, int itemId)
        {            
            switch(itemId)
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

        private void btnQuad1_MouseEnter(object sender, EventArgs e)
        {
            //Destacar quadrante 1 na matriz
        }

        private void btnQuad2_MouseEnter(object sender, EventArgs e)
        {
            //Destacar quadrante 2 na matriz
        }

        private void btnQuad3_MouseEnter(object sender, EventArgs e)
        {
            //Destacar quadrante 3 na matriz
        }

        private void btnQuad4_MouseEnter(object sender, EventArgs e)
        {
            //Destacar quadrante 4 na matriz
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
    }
}
