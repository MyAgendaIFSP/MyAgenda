
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda.Componentes
{
    class VerticalLabel : Label
    {

        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = base.AutoSize; }
        public override string Text { get => base.Text; set => base.Text = ""; }

        public string NewText { get; set; }

        public VerticalLabel()
        {
            this.Text = "";
            this.AutoSize = false;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Brush b = new SolidBrush(this.ForeColor);
            e.Graphics.TranslateTransform(0, this.Height);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString(this.NewText, this.Font, b, 0f, 0f);

            base.OnPaint(e);
        }

    }
    
}
