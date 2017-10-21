using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Componentes.MatrizTempo
{
    class LabelItemMatriz : Label
    {

        public bool Ativo { get; set; } = true;

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Size txt = e.Graphics.MeasureString(this.Text, this.Font).ToSize();
            txt.Width += txt.Height + 10;

            this.Size = txt;

            if (Ativo)
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
