using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Componentes.Geral
{
    public partial class Notification : Form
    {
        public bool IsShown { get; set; }

        public Notification()
        {
            InitializeComponent();
            this.MaximumSize = new Size(370, Screen.GetWorkingArea(new Point(0, 0)).Size.Height);
            IsShown = false;
        }

        public void Show(string titulo, string mensagem)
        {
            lblTitulo.Text = titulo;
            lblMensagem.Text = mensagem;

            this.Size = new Size(this.MaximumSize.Width, lblTitulo.Height + lblMensagem.Height + 33);

            this.Location = _getPosicao();

            this.Show();
            IsShown = true;
            timerDispensa.Start();
        }

        private Point _getPosicao()
        {
            Size tela = Screen.GetWorkingArea(new Point(0, 0)).Size;

            Point posicao = new Point(
                    tela.Width - this.Width - 15,
                    tela.Height - this.Height - 15
                );

            return posicao;
        }

        private void timerDispensa_Tick(object sender, EventArgs e)
        {
            timerDispensa.Stop();
            this.Close();
            IsShown = false;
        }

        private void btnDispensar_Click(object sender, EventArgs e)
        {
            timerDispensa.Stop();
            this.Close();
            IsShown = false;
        }
    }
}
