using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Componentes
{
    public partial class ItemTarefa : UserControl
    {
        public string DescricaoTarefa
        {
            get { return lblDescricaoTarefa.Text; }
            set { lblDescricaoTarefa.Text = value; }
        }

        public ItemTarefa()
        {
            this.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            lblDescricaoTarefa.Font = new Font(lblDescricaoTarefa.Font, FontStyle.Strikeout);
        }

        private void ItemTarefa_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            btnChecar.BackColor = Color.LightGray;
            btnEditar.BackColor = Color.LightGray;
            btnExcluir.BackColor = Color.LightGray;
        }

        private void ItemTarefa_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnChecar.BackColor = Color.White;
            btnEditar.BackColor = Color.White;
            btnExcluir.BackColor = Color.White;
        }

        private void btnExcluir_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            btnChecar.BackColor = Color.LightGray;
            btnEditar.BackColor = Color.LightGray;
            btnExcluir.BackColor = Color.LightGray;
        }

        private void btnExcluir_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnChecar.BackColor = Color.White;
            btnEditar.BackColor = Color.White;
            btnExcluir.BackColor = Color.White;
        }

        private void btnEditar_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            btnChecar.BackColor = Color.LightGray;
            btnEditar.BackColor = Color.LightGray;
            btnExcluir.BackColor = Color.LightGray;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnChecar.BackColor = Color.White;
            btnEditar.BackColor = Color.White;
            btnExcluir.BackColor = Color.White;
        }

        private void btnChecar_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            btnChecar.BackColor = Color.LightGray;
            btnEditar.BackColor = Color.LightGray;
            btnExcluir.BackColor = Color.LightGray;
        }

        private void btnChecar_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnChecar.BackColor = Color.White;
            btnEditar.BackColor = Color.White;
            btnExcluir.BackColor = Color.White;
        }
    }
}
