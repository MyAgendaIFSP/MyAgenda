using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAgenda.Modelos.MatrizTempo;

namespace MyAgenda.Componentes.MatrizTempo
{
    public partial class Matriz : UserControl
    {
        public List<ItemMatriz> Itens { get; private set; } = new List<ItemMatriz>();

        public enum EQuadrante { QUADRANTE_1, QUADRANTE_2, QUADRANTE_3, QUADRANTE_4, NENHUM }

        /// <summary>
        /// Indica a próxima coordenada item do item a ser adicionado
        /// indice 0: quadrante 1
        /// indice 1: quadrante 2
        /// indice 2: quadrante 3
        /// indice 3: quadrante 4
        /// </summary>
        private int[] _ultimosY = new int[4] { 0, 0, 0, 0};

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

        #region Métodos de highlight dos quadrantes

        public void IniciaHighlightQuadrante1()
        {
            gbxQuad1.BackColor = Color.AliceBlue;
        }

        public void IniciaHighlightQuadrante2()
        {
            gbxQuad2.BackColor = Color.AliceBlue;
        }

        public void IniciaHighlightQuadrante3()
        {
            gbxQuad3.BackColor = Color.AliceBlue;
        }

        public void IniciaHighlightQuadrante4()
        {
            gbxQuad4.BackColor = Color.AliceBlue;
        }

        public void ParaHighlightQuadrante1()
        {
            gbxQuad1.BackColor = Color.White;
        }

        public void ParaHighlightQuadrante2()
        {
            gbxQuad2.BackColor = Color.White;
        }

        public void ParaHighlightQuadrante3()
        {
            gbxQuad3.BackColor = Color.White;
        }

        public void ParaHighlightQuadrante4()
        {
            gbxQuad4.BackColor = Color.White;
        }

        #endregion

        public void AdicionaItem(ItemMatriz item)
        {
            LabelItemMatriz lbl = new LabelItemMatriz();
            lbl.Location = new Point(6, _ultimosY[(int)item.Quadrante]);
            lbl.Ativo = item.Ativo;
            lbl.Text = item.Titulo + ((String.IsNullOrEmpty(item.Descricao)) ? "" : " - " + item.Descricao);
            lbl.Font = new Font(this.Font.Name, 11);
            lbl.CreateControl();

            _ultimosY[(int)item.Quadrante] += lbl.Height + 2;

            switch (item.Quadrante)
            {
                case EQuadrante.QUADRANTE_1:
                    panelQuad1.Controls.Add(lbl);
                    break;

                case EQuadrante.QUADRANTE_2:
                    panelQuad2.Controls.Add(lbl);
                    break;

                case EQuadrante.QUADRANTE_3:
                    panelQuad3.Controls.Add(lbl);
                    break;

                case EQuadrante.QUADRANTE_4:
                    panelQuad4.Controls.Add(lbl);
                    break;
            }

            Itens.Add(item);
        }
    }
}
