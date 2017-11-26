using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAgenda.Entidades;

namespace MyAgenda
{
    public partial class FormAlertaEvento : Form
    {

        public Evento Evento;

        public FormAlertaEvento()
        {
            InitializeComponent();
        }

        public FormAlertaEvento(Evento evento, double minutos)
        {
            InitializeComponent();

            Evento = evento;

            string alerta = string.Format("O evento {0} começará em {1} minutos", Evento.Titutlo, minutos); 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
