using MyAgenda.Controladores.MatrizTempo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda.Componentes.MatrizTempo
{
    public partial class Matriz : UserControl
    { 
        private MatrizController _controlador;

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

        public bool CarregaMatriz()
        {
            _controlador = MatrizController.GetInstance();
            return true;
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

        /// <summary>
        /// Adiciona um item na matriz
        /// </summary>
        /// <param name="item">Item da matriz que será adicionado</param>
        public void AdicionaItem(ItemMatrizController item)
        {
            LabelItemMatriz lbl = new LabelItemMatriz(ref item);
            lbl.Location = new Point(6, _ultimosY[(int)item.GetModel().Quadrante]);
            lbl.Text = item.GetModel().Titulo + ((String.IsNullOrEmpty(item.GetModel().Descricao)) ? "" : " - " + item.GetModel().Descricao);
            lbl.Font = new Font(this.Font.Name, 11);
            lbl.Cursor = Cursors.Hand;
            lbl.QuadranteItemClick += _quadranteItemClick;
            lbl.CreateControl();

            //Determina a qual quadrante o item pertence e adiciona-o nele
            switch (item.GetModel().Quadrante)
            {
                case EQuadrante.QUADRANTE_1:
                    lbl.Size = new Size(panelQuad1.ClientSize.Width - 12, lbl.Font.Height);
                    panelQuad1.Controls.Add(lbl);
                    break;

                case EQuadrante.QUADRANTE_2:
                    lbl.Size = new Size(panelQuad2.ClientSize.Width - 12, lbl.Font.Height);
                    panelQuad2.Controls.Add(lbl);
                    break;

                case EQuadrante.QUADRANTE_3:
                    lbl.Size = new Size(panelQuad3.ClientSize.Width - 12, lbl.Font.Height);
                    panelQuad3.Controls.Add(lbl);
                    break;

                case EQuadrante.QUADRANTE_4:
                    lbl.Size = new Size(panelQuad4.ClientSize.Width - 12, lbl.Font.Height);
                    panelQuad4.Controls.Add(lbl);
                    break;
            }
            
            _ultimosY[(int)item.GetModel().Quadrante] += lbl.Height + 2;

            _controlador.AddItem(item);
        }

        private void _quadranteItemClick(object sender, ref ItemMatrizController item, bool removePermanente)
        {
            if (removePermanente)
            {
                //Deletar o item do banco de dados
                LabelItemMatriz lbl = (LabelItemMatriz)sender;
                Panel quadrante = (Panel) lbl.Parent;
                quadrante.Controls.Remove(lbl);

                _controlador.DeletarItem(item);
            }
            else
            {
                if (item.GetModel().Ativo)
                {
                    //Marcar o item como inativo no banco de dados
                    item.MarcarItemInativo();
                }
                else
                {
                    //Marcar o item como ativo no banco de dados
                    item.MarcarItemAtivo();
                }
            }
        }

    }
}
