using System;
using System.Windows.Forms;

namespace MyAgenda
{
    public partial class FormMatrizTempo : Form
    {
        public FormMatrizTempo()
        {
            InitializeComponent();
            barraNavegacao1.MenuItemClick += _click;

            barraNavegacao1.AddItem("Início", 1);
            barraNavegacao1.AddItem("Pomodoro", 2);
            barraNavegacao1.AddItem("Tarefas", 3);
            barraNavegacao1.AddItem("Sair", 4);

        }

        private void _click(int itemId)
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
                    MessageBox.Show("botão Sair");
                    break;

            }
        }
    }
}
