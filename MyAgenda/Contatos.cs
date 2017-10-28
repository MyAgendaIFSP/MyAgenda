using MyAgenda.Componentes.Geral;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda
{
    public partial class Contatos : Form
    {
        public Contatos()
        {
            InitializeComponent();
            
        }

        private void btnAddContato_MouseEnter(object sender, EventArgs e)
        {
            btnAddContato.Image = Properties.Resources.ic_person_add_white_24dp;
        }

        private void btnAddContato_MouseLeave(object sender, EventArgs e)
        {
            btnAddContato.Image = Properties.Resources.ic_person_add_black_24dp;
        }
    }
}
