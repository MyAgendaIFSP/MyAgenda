using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda.Componentes.Geral
{
    public class BarraNavegacao : Panel
    {

        public delegate void MenuItemClickEventHandler(Button btn, int itemId);

        public event MenuItemClickEventHandler MenuItemClick;

        private Dictionary<int, MenuItemClickEventHandler> _callbacksEspecificos = new Dictionary<int, MenuItemClickEventHandler>();

        public enum EPosicao { ESQUERDA, DIREITA }

        private int _ultimoxEsquerda = 13;
        private int _ultimoxDireita = 0;

        public BarraNavegacao()
        {
            this.Location = new System.Drawing.Point(0, 0);
            this.Dock = DockStyle.Top;
            this.Height = 40;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);

            _ultimoxEsquerda = 13;
            _ultimoxDireita = this.ClientSize.Width - 30;

            foreach (Button btn in this.Controls)
            {
                EPosicao posicao = (EPosicao)btn.Tag;

                if (posicao == EPosicao.ESQUERDA)
                {
                    btn.Location = new Point(_ultimoxEsquerda, 0);
                    _ultimoxEsquerda += btn.PreferredSize.Width + 3;
                }
                else
                {
                    btn.Location = new Point(_ultimoxDireita - btn.PreferredSize.Width, 0);
                    _ultimoxDireita -= btn.PreferredSize.Width + 3;
                }
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate();
        }

        /// <summary>
        /// Adiciona um botão na barra.
        /// </summary>
        /// <param name="titulo">Texto so botão</param>
        /// <param name="id">Id único para o botão</param>
        public void AddItem(string titulo, int id)
        {
            Button btn = new Button();
            btn.Height = this.Height;
            btn.AutoSize = true;
            btn.Font = this.Font;
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.MouseDownBackColor = Color.SlateGray;
            btn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += _disparaCallback;
            btn.Location = new Point(_ultimoxEsquerda, 0);
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Text = titulo;
            btn.Name = id.ToString();
            btn.Tag = EPosicao.ESQUERDA;

            btn.CreateControl();

            this.Controls.Add(btn);

            this.Invalidate();
        }

        /// <summary>
        /// Adiciona um botão na barra
        /// </summary>
        /// <param name="titulo">Texto do botão</param>
        /// <param name="icon">Ícone que será mostrado na parte direita do botão</param>
        /// <param name="id">Id único para o botão</param>
        public void AddItem(string titulo, Bitmap icon, int id)
        {
            Button btn = new Button();
            btn.Height = this.Height;
            btn.AutoSize = true;
            btn.Font = this.Font;
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.MouseDownBackColor = Color.SlateGray;
            btn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += _disparaCallback;
            btn.Location = new Point(_ultimoxEsquerda, 0);
            btn.Image = icon;
            btn.Text = titulo;
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn.Name = id.ToString();
            btn.Tag = EPosicao.ESQUERDA;

            btn.CreateControl();

            this.Controls.Add(btn);

            this.Invalidate();
        }

        /// <summary>
        /// Adiciona um botão na barra
        /// </summary>
        /// <param name="titulo">Texto do botão</param>
        /// <param name="icon">Ícone que será mostrado na parte direita do botão</param>
        /// <param name="posicao">Posição do botão: lado esquerdo da barra ou lado direito da barra</param>
        /// <param name="id">Id único para o botão</param>
        public void AddItem(string titulo, Bitmap icon, EPosicao posicao, int id)
        {
            Button btn = new Button();
            btn.Height = this.Height;
            btn.AutoSize = true;
            btn.Font = this.Font;
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.MouseDownBackColor = Color.SlateGray;
            btn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += _disparaCallback;
            btn.Image = icon;
            btn.Text = titulo;
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn.Name = id.ToString();
            btn.Tag = posicao;

            btn.CreateControl();

            this.Controls.Add(btn);

            this.Invalidate();
        }

        /// <summary>
        /// Adiciona um botão na barra
        /// </summary>
        /// <param name="titulo">Texto do botão</param>
        /// <param name="icon">Ícone que será mostrado na parte direita do botão</param>
        /// <param name="posicao">Posição do botão: lado esquerdo da barra ou lado direito da barra</param>
        /// <param name="id">Id único para o botão</param>
        /// <param name="handler">Método de callback para o clique do botão</param>
        public void AddItem(string titulo, Bitmap icon, EPosicao posicao, MenuItemClickEventHandler handler, int id)
        {
            Button btn = new Button();
            btn.Height = this.Height;
            btn.AutoSize = true;
            btn.Font = this.Font;
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.MouseDownBackColor = Color.SlateGray;
            btn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btn.FlatAppearance.BorderSize = 0;
            _callbacksEspecificos.Add(id, handler);
            btn.Click += _disparaCallback;
            btn.Image = icon;
            btn.Text = titulo;
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn.Name = id.ToString();
            btn.Tag = posicao;

            btn.CreateControl();

            this.Controls.Add(btn);

            this.Invalidate();
        }

        private void _disparaCallback(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = Int32.Parse(btn.Name);
            MenuItemClickEventHandler handler;

            try
            {
                handler = (_callbacksEspecificos[id] != null) ? _callbacksEspecificos[id] : MenuItemClick;
            }
            catch
            {
                handler = MenuItemClick;
            }

            if(handler != null)
            {
                handler(btn, id);
            }
            
        }
    }
}
