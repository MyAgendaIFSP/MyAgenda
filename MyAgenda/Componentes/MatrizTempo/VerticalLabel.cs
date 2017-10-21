using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda.Componentes.MatrizTempo
{
    public class VerticalLabel : Label
    {

        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = base.AutoSize; }
        
        public VerticalLabel()
        {
            this.AutoSize = false;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Size txt = e.Graphics.MeasureString(this.Text, this.Font).ToSize();
            e.Graphics.TranslateTransform(0, this.Height);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), (this.Height / 2) - (txt.Width / 2), (this.Width / 2) - (txt.Height / 2));
            
        }

    }
    
}
