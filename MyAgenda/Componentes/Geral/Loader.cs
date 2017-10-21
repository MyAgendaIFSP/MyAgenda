using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Componentes.Geral
{
    public class Loader : PictureBox
    {
        /// <summary>
        /// Determina se o loader estará ativo (ligado) ou não.
        /// </summary>
        private bool _active;
        public bool Active
        {
            get
            {
                return _active;
            }

            set
            {
                _active = value;
                this.Invalidate();
            }
        }

        private double _xAtual = 0;
        private bool _indo = true;

        public Loader()
        {
            this.Height = 7;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (Active)
            {
                _desenhaLinha(pe.Graphics);
                this.Invalidate();
            }
        }

        private void _desenhaLinha(Graphics e)
        {
            e.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;

            int largura = this.ClientSize.Width;
            int altura = this.ClientSize.Height;
            int corredorLargura = (int)Math.Round(largura * 0.2);
                
            if (_xAtual >= largura - corredorLargura)
            {
                _indo = false;
            }
            else if(_xAtual <= 0)
            {
                _indo = true;
            }

            if (_indo)
            {
                _xAtual += 0.1;
            }
            else
            {
                _xAtual -= 0.1;
            }

            e.FillRectangle(
                new SolidBrush(Color.RoyalBlue),
                new Rectangle(
                    new Point((int)Math.Floor(_xAtual), 0),
                    new Size(corredorLargura, altura)
                )
            );
        }

    }
}
