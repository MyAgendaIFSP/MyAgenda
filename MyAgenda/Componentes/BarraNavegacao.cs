using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda.Componentes
{
    class BarraNavegacao : Panel
    {

        public delegate void MenuItemClickEventHandler(int itemId);

        public event MenuItemClickEventHandler MenuItemClick;

        private int _ultimoX = 0;

        public BarraNavegacao()
        {
            this.Location = new System.Drawing.Point(0, 0);
            this.Dock = DockStyle.Top;
            this.Height = 40;
            this.BackColor = System.Drawing.Color.LightSlateGray;
        }

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
            btn.Location = new Point(_ultimoX, 0);
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Text = titulo;
            btn.Tag = id;

            btn.CreateControl();

            this.Controls.Add(btn);

            _ultimoX += btn.Width + 3;
            
            this.Invalidate();
        }

        private void _disparaCallback(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = (int) btn.Tag;

            MenuItemClickEventHandler handler = MenuItemClick;

            if(handler != null)
            {
                handler(id);
            }
            
        }
    }
}
