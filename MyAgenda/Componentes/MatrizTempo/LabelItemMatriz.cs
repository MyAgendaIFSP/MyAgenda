using MyAgenda.Controladores.MatrizTempo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda.Componentes.MatrizTempo
{
    class LabelItemMatriz : Label
    {

        public delegate void ItemClickedEventHandler(object sender, ItemMatrizController item);

        public event ItemClickedEventHandler QuadranteItemClick;

        private ItemMatrizController _matrizItem;
        public ItemMatrizController MatrizItem
        {
            get
            {
                return _matrizItem;
            }

            set
            {
                _matrizItem = value;
            }
        }
        
        public LabelItemMatriz(ItemMatrizController item)
        {
            MatrizItem = item;
        }
        
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
                        
            if (QuadranteItemClick != null)
            {
                QuadranteItemClick(this, _matrizItem);
            }

            this.Invalidate();
        }
        
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            this.BackColor = Color.FromArgb(255, 230, 230, 230);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            this.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Size txt = e.Graphics.MeasureString(this.Text, this.Font).ToSize();
            txt.Width += txt.Height + 10;

            if (txt.Width > this.Width)
            {
                this.Size = txt;
            }

            if (MatrizItem.GetModel().Ativo)
            {
                e.Graphics.DrawImage(Properties.Resources.ic_turned_in_black, 0, 0, this.Height, this.Height);
            }
            else
            {
                e.Graphics.DrawImage(Properties.Resources.ic_turned_in_not_black, 0, 0, this.Height, this.Height);
                e.Graphics.DrawLine(new Pen(this.ForeColor), new Point(this.Height, this.Height / 2), new Point(this.Width, this.Height / 2));
            }

            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.Height + 1, 0);

        }

    }
}
