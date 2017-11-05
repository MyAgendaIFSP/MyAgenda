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
