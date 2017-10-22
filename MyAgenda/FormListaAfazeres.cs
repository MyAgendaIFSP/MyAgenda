using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static MyAgenda.Componentes.BarraNavegacao;

namespace MyAgenda
{
    public partial class FormListaAfazeres : Form
    {

        private CultureInfo cultureInfo = new CultureInfo("pt-BR");

        public FormListaAfazeres()
        {
            InitializeComponent();
            barraNavegacao1.MenuItemClick += _click;

            barraNavegacao1.AddItem("Início", Properties.Resources.ic_home_white, 1);
            barraNavegacao1.AddItem("Pomodoro", 2);
            barraNavegacao1.AddItem("Tarefas", 3);
            barraNavegacao1.AddItem("Sair", Properties.Resources.ic_exit_to_app_white, EPosicao.DIREITA, 4);
            barraNavegacao1.AddItem("Offline", Properties.Resources.ic_cloud_queue_white, EPosicao.DIREITA, _cloudClick, 5);
        }

        private void _cloudClick(ref Button btn, int itemId)
        {
            MessageBox.Show("botão Nuvem");

            btn.Image = Properties.Resources.ic_cloud_white;
        }

        private void _click(ref Button btn, int itemId)
        {
            switch(itemId)
            {
                case 1:
                    MessageBox.Show("botão início");
                    break;
                case 2:
                    MessageBox.Show("botão Pomodoro");
                    break;
                case 3:
                    MessageBox.Show("botão Tarefas");
                    break;
                case 4:
                    MessageBox.Show("botão sair");
                    break;
            }
        }

        private void FormListaAfazeres_Load(object sender, EventArgs e)
        {
            string dia = DateTime.Now.Day.ToString() + " de ";
            string mes = cultureInfo.TextInfo.ToTitleCase(cultureInfo.DateTimeFormat.GetMonthName(DateTime.Now.Month)) + " de ";
            string ano = DateTime.Now.Year.ToString();
            string diaDaSemana = cultureInfo.TextInfo.ToTitleCase(cultureInfo.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek));

            lblDataAtual.Text = dia + mes + ano;
            lblDiaSemana.Text = diaDaSemana;
        }
    }
}
