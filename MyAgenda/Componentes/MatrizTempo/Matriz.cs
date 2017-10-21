using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Componentes.MatrizTempo
{
    public partial class Matriz : UserControl
    {
        public Matriz()
        {
            InitializeComponent();
        }

        private void Matriz_Paint(object sender, PaintEventArgs e)
        {
            //Reposiciona os quadrantes na tela
            Size tamPadrao = new Size(this.Width / 2, this.Height / 2);

            panel1.Location = new Point(0, 0);
            panel1.Size = tamPadrao;

            panel2.Location = new Point(tamPadrao.Width, 0);
            panel2.Size = tamPadrao;

            panel3.Location = new Point(0, tamPadrao.Height);
            panel3.Size = tamPadrao;

            panel4.Location = new Point(tamPadrao.Width, tamPadrao.Height);
            panel4.Size = tamPadrao;
        }

        public void IniciaHighlightQuadrante1()
        {
            gpQuad1.BackColor = Color.AliceBlue;
        }

        public void IniciaHighlightQuadrante2()
        {
            gpQuad2.BackColor = Color.AliceBlue;
        }

        public void IniciaHighlightQuadrante3()
        {
            gpQuad3.BackColor = Color.AliceBlue;
        }

        public void IniciaHighlightQuadrante4()
        {
            gpQuad4.BackColor = Color.AliceBlue;
        }

        public void ParaHighlightQuadrante1()
        {
            gpQuad1.BackColor = Color.White;
        }

        public void ParaHighlightQuadrante2()
        {
            gpQuad2.BackColor = Color.White;
        }

        public void ParaHighlightQuadrante3()
        {
            gpQuad3.BackColor = Color.White;
        }

        public void ParaHighlightQuadrante4()
        {
            gpQuad4.BackColor = Color.White;
        }
    }
}
