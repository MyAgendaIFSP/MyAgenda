using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyAgenda.Componentes
{
    class ItemTarefa : Panel
    {
        private Button btnChecar;

        private Label lblDescricaoTarefa;

        public ItemTarefa()
        {
            this.Location = new System.Drawing.Point(0, 0);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Height = 30;
            this.Dock = DockStyle.Top;

            btnChecar = new Button();
            btnChecar.Height = 18;
            btnChecar.Width = 18;
            btnChecar.AutoSize = true;
            btnChecar.Dock = DockStyle.Left;
            btnChecar.Image = MyAgenda.Properties.Resources.ic_checked_black;
            btnChecar.FlatStyle = FlatStyle.Flat;
            btnChecar.FlatAppearance.BorderSize = 0;
            btnChecar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnChecar.CreateControl();

            lblDescricaoTarefa = new Label();
            lblDescricaoTarefa.Text = "Testeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee";
            lblDescricaoTarefa.TextAlign = ContentAlignment.MiddleCenter;
            lblDescricaoTarefa.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            lblDescricaoTarefa.Location = new System.Drawing.Point(35, 0);
            int locationX = (this.Size.Width - lblDescricaoTarefa.Size.Width) / 2;
            lblDescricaoTarefa.Location = new Point(locationX, lblDescricaoTarefa.Location.Y);
            lblDescricaoTarefa.CreateControl();


            this.Controls.Add(btnChecar);
            this.Controls.Add(lblDescricaoTarefa);

            this.Invalidate();
        }

        public void AddItem(string descricao)
        {
            Button btnChecar = new Button();
            btnChecar.Height = 18;
            btnChecar.Width = 18;
            btnChecar.AutoSize = true;
            btnChecar.Text = "OI";
            btnChecar.CreateControl();

            Label lblDescricaoTarefa = new Label();
            lblDescricaoTarefa.Text = "Teste";
            lblDescricaoTarefa.Height = 18;
            lblDescricaoTarefa.AutoSize = true;
            lblDescricaoTarefa.CreateControl();

            this.Controls.Add(btnChecar);
            this.Controls.Add(lblDescricaoTarefa);

            this.Invalidate();
        }
    }
}
