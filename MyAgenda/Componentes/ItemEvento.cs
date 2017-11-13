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
    public partial class ItemEvento : UserControl
    {
        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        public string Descricao
        {
            get { return lblDescricao.Text; }
            set { lblDescricao.Text = value; }
        }

        public string DataHoraTermino
        {
            get { return lblDataHoraTermino.Text; }
            set { lblDataHoraTermino.Text = value; }
        }

        public ItemEvento()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditarEvento formEditarEvento = new FormEditarEvento();
            formEditarEvento.Show();
        }
    }
}
