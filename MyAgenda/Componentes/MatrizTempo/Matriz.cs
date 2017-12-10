﻿using MyAgenda.Controladores.MatrizTempo;
using MyAgenda.Dados;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda.Componentes.MatrizTempo
{
    public partial class Matriz : UserControl
    { 
        private MatrizController _controlador;

        private LabelItemMatriz _itemClicado;

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

            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        public bool CarregaMatriz(int usuario)
        {
            MatrizTempoAPI api = MatrizTempoAPI.GetInstance();
            _controlador = api.GetMatriz(usuario);

            _controlador.VerificaMatriz();

            _controlador.AlteraUltimoAcesso();

            if (_controlador != null)
            {
                _carregaQuadrante(EQuadrante.QUADRANTE_1, panelQuad1);
                _carregaQuadrante(EQuadrante.QUADRANTE_2, panelQuad2);
                _carregaQuadrante(EQuadrante.QUADRANTE_3, panelQuad3);
                _carregaQuadrante(EQuadrante.QUADRANTE_4, panelQuad4);
            }

            return _controlador != null;
        }

        private void Matriz_Paint(object sender, PaintEventArgs e)
        {
            //Reposiciona os quadrantes na tela
            Size tamPadrao = new Size(this.ClientSize.Width / 2, this.ClientSize.Height / 2);

            panel1.Location = new Point(0, 0);
            panel1.Size = tamPadrao;

            panel2.Location = new Point(tamPadrao.Width, 0);
            panel2.Size = tamPadrao;

            panel3.Location = new Point(0, tamPadrao.Height);
            panel3.Size = tamPadrao;

            panel4.Location = new Point(tamPadrao.Width, tamPadrao.Height);
            panel4.Size = tamPadrao;
            
        }

        /// <summary>
        /// Adiciona um item na matriz
        /// </summary>
        /// <param name="item">Item da matriz que será adicionado</param>
        public void AdicionaItem(ItemMatrizController item)
        {
            _controlador.AddItem(item);

            switch (item.GetModel().Quadrante)
            {
                case EQuadrante.QUADRANTE_1:
                    _addItemQuadrante(panelQuad1, item);
                    break;

                case EQuadrante.QUADRANTE_2:
                    _addItemQuadrante(panelQuad2, item);
                    break;

                case EQuadrante.QUADRANTE_3:
                    _addItemQuadrante(panelQuad3, item);
                    break;

                case EQuadrante.QUADRANTE_4:
                    _addItemQuadrante(panelQuad4, item);
                    break;
            }
            
        }

        private void _quadranteItemClick(object sender, ItemMatrizController item)
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
        
        private void _addItemQuadrante(Panel panel, ItemMatrizController item)
        {
            LabelItemMatriz lbl = new LabelItemMatriz(item);
            lbl.Location = new Point(6, _ultimosY[(int)item.GetModel().Quadrante]);
            lbl.Text = item.GetModel().Titulo + ((String.IsNullOrEmpty(item.GetModel().Descricao)) ? "" : " - " + item.GetModel().Descricao);
            lbl.Font = new Font(this.Font.Name, 11);
            lbl.Cursor = Cursors.Hand;
            lbl.QuadranteItemClick += _quadranteItemClick;
            lbl.ContextMenuStrip = cmsItemMatrizOpcoes;
            lbl.CreateControl();

            lbl.Size = new Size(panel.ClientSize.Width - 12, lbl.Font.Height);
            panel.Controls.Add(lbl);

            _ultimosY[(int)item.GetModel().Quadrante] += lbl.Height + 2;
        }
        
        private void _atualizarQuadrante(Panel quadrante, Point location)
        {
            Point ultimaPosicao = new Point();

            for(int i = 0; i < quadrante.Controls.Count; i++)
            {
                if (quadrante.Controls[i].Location.Y > location.Y)
                {
                    if (ultimaPosicao.Y == 0) {
                        ultimaPosicao = quadrante.Controls[i].Location;
                        quadrante.Controls[i].Location = location;
                    }
                    else
                    {
                        location = ultimaPosicao;
                        ultimaPosicao = quadrante.Controls[i].Location;
                        quadrante.Controls[i].Location = location;
                    }
                }
            }
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

        private void _carregaQuadrante(EQuadrante quadrante, Panel panel)
        {
            try
            {
                List<ItemMatrizController> itens = _controlador.GetModelo().Itens;

                panel.Controls.Clear();

                _ultimosY[(int)quadrante] = 0;

                for (int i = 0; i < itens.Count; i++)
                {
                    if (itens[i].GetModel().Quadrante != quadrante)
                    {
                        continue;
                    }

                    LabelItemMatriz lbl = new LabelItemMatriz(itens[i]);
                    lbl.Location = new Point(6, _ultimosY[(int)quadrante]);
                    lbl.Text = itens[i].GetModel().Titulo + ((String.IsNullOrEmpty(itens[i].GetModel().Descricao)) ? "" : " - " + itens[i].GetModel().Descricao);
                    lbl.Font = new Font(this.Font.Name, 11);
                    lbl.Cursor = Cursors.Hand;
                    lbl.QuadranteItemClick += _quadranteItemClick;
                    lbl.ContextMenuStrip = cmsItemMatrizOpcoes;
                    lbl.CreateControl();

                    lbl.Size = new Size(panel.ClientSize.Width - 12, lbl.Font.Height);
                    panel.Controls.Add(lbl);

                    _ultimosY[(int)quadrante] += lbl.Height + 2;

                }

            }
            catch { }
        }

        private void tsmiDeletar_Click(object sender, EventArgs e)
        {
            if (_controlador.DeletarItem(_itemClicado.MatrizItem))
            {
                Panel quadrante = (Panel)_itemClicado.Parent;
                quadrante.Controls.Remove(_itemClicado);
                _ultimosY[((int)_itemClicado.MatrizItem.GetModel().Quadrante)] = quadrante.Controls.Count * (_itemClicado.Height + 2);
                _atualizarQuadrante(quadrante, _itemClicado.Location);
            }
            else
            {
                MessageBox.Show("Não foi possível remover o item.", "Erro ao remover item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cmsItemMatrizOpcoes_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _itemClicado = (LabelItemMatriz) ((ContextMenuStrip) sender).SourceControl;
        }

        private void _moveItem(LabelItemMatriz item, EQuadrante quadrante)
        {
            ItemMatrizController controller = item.MatrizItem;
            if (controller.MoveItem(quadrante))
            {
                Panel panQuadrante = (Panel)_itemClicado.Parent;
                Point p = item.Location;
                item.Parent.Controls.Remove(item);
                _atualizarQuadrante(panQuadrante, p);
                _carregaQuadrante(quadrante, _getPanelQuadrante(quadrante));
            }
        }

        private Panel _getPanelQuadrante(EQuadrante quadrante)
        {
            switch (quadrante)
            {
                case EQuadrante.QUADRANTE_1:
                    return panelQuad1;

                case EQuadrante.QUADRANTE_2:
                    return panelQuad2;

                case EQuadrante.QUADRANTE_3:
                    return panelQuad3;

                case EQuadrante.QUADRANTE_4:
                    return panelQuad4;
            }

            return null;
        }

        private void quadrante1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_itemClicado.MatrizItem.GetModel().Quadrante == EQuadrante.QUADRANTE_1)
            {
                return;
            }

            _moveItem(_itemClicado, EQuadrante.QUADRANTE_1);
        }

        private void quadrante2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_itemClicado.MatrizItem.GetModel().Quadrante == EQuadrante.QUADRANTE_2)
            {
                return;
            }

            _moveItem(_itemClicado, EQuadrante.QUADRANTE_2);
        }

        private void quadrante3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_itemClicado.MatrizItem.GetModel().Quadrante == EQuadrante.QUADRANTE_3)
            {
                return;
            }

            _moveItem(_itemClicado, EQuadrante.QUADRANTE_3);
        }

        private void quadrante4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_itemClicado.MatrizItem.GetModel().Quadrante == EQuadrante.QUADRANTE_4)
            {
                return;
            }

            _moveItem(_itemClicado, EQuadrante.QUADRANTE_4);
        }
        
    }
}