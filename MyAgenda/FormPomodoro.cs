using MyAgenda.Componentes.Geral;
using MyAgenda.Controladores.Geral;
using MyAgenda.Controladores.Pomodoro;
using MyAgenda.Modelos.Util;
using System;
using System.Drawing;

namespace MyAgenda
{
    public partial class FormPomodoro : BaseForm
    {
        ConversorHoras cvHoras = new ConversorHoras();
        PomodoroController pModel = new PomodoroController();
        private UsuarioController _usuario = null;
        int tipoSessao = 1;
        int tempoSessao;
        int _tempoAtual = 0;
        bool _foiPausado = false;

        private Color[] _cores = new Color[4]
        {
            Color.SkyBlue,
            Color.LightCoral,
            Color.FromArgb(128, 128, 255),
            Color.FromArgb(255, 255, 128)
        };

        public FormPomodoro(UsuarioController u)
        {
            InitializeComponent();

            BarraNavegacao.AddItem("Início", Properties.Resources.ic_home_white, (int)EBarraNavegacaoBotoes.INICIO);
            BarraNavegacao.AddItem("Pomodoro", (int)EBarraNavegacaoBotoes.POMODORO);
            BarraNavegacao.AddItem("Tarefas", (int)EBarraNavegacaoBotoes.TAREFAS);

            _usuario = u;

        }

        public FormPomodoro()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (_foiPausado)
            {
                _foiPausado = false;
                cclPbrPomodoro.Maximum = _tempoAtual;
            }
            else
            {
                tempoSessao = int.Parse(nudTempo.Value.ToString());
                _tempoAtual = tempoSessao;
                cclPbrPomodoro.Maximum = tempoSessao;
                cclPbrPomodoro.Value = tempoSessao;
            }

            tmrPomodoro.Start();        
        }

        private void nudTempo_ValueChanged(object sender, EventArgs e)
        {
            tempoSessao = int.Parse(nudTempo.Value.ToString());
            _tempoAtual = tempoSessao;
            cclPbrPomodoro.Maximum = tempoSessao;
            cclPbrPomodoro.Value = tempoSessao;
        }

        private void tmrPomodoro_Tick(object sender, EventArgs e)
        {
            tempoSessao = Convert.ToInt16(nudTempo.Value);
            _tempoAtual = Convert.ToInt16(nudTempo.Value);
            pModel.PomodoroOrganizer(tipoSessao,tempoSessao, tmrPomodoro, cclPbrPomodoro, txtQuadroColor1, txtQuadroColor2, txtQuadroColor3, txtQuadroColor4, ref btnShortBreak, ref btnLongBreak, ref btnPomodoro);
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            _foiPausado = true;
            tmrPomodoro.Stop();
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            tmrPomodoro.Stop();
            cclPbrPomodoro.Value = int.Parse(nudTempo.Value.ToString());
        }

        private void btnShortBreak_Click(object sender, EventArgs e)
        {
            tipoSessao = 2;
            nudTempo.Value = 5;
            cclPbrPomodoro.Value = 5;
            cclPbrPomodoro.Maximum = cclPbrPomodoro.Value;
        }

        private void btnLongBreak_Click(object sender, EventArgs e)
        {
            tipoSessao = 3;
            nudTempo.Value = 15;
            cclPbrPomodoro.Value = 15;
            cclPbrPomodoro.Maximum = cclPbrPomodoro.Value;
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            tipoSessao = 1;
            nudTempo.Value = 25;
            cclPbrPomodoro.Value = 25;
            cclPbrPomodoro.Maximum = cclPbrPomodoro.Value;
        }
        
        private void Pomodoro_SizeChanged(object sender, EventArgs e)
        {
            int larg = (panel2.ClientSize.Width - 15) / 4;

            txtQuadroColor1.Size = new Size(larg, panel2.ClientSize.Height);
            txtQuadroColor2.Size = new Size(larg, panel2.ClientSize.Height);
            txtQuadroColor3.Size = new Size(larg, panel2.ClientSize.Height);
            txtQuadroColor4.Size = new Size(larg, panel2.ClientSize.Height);

            txtQuadroColor1.Location = new Point(0, 0);
            txtQuadroColor2.Location = new Point(txtQuadroColor1.Bounds.Right + 5, 0);
            txtQuadroColor3.Location = new Point(txtQuadroColor2.Bounds.Right + 5, 0);
            txtQuadroColor4.Location = new Point(txtQuadroColor3.Bounds.Right + 5, 0);

            cclPbrPomodoro.Size = new Size(
                panelRelogio.Height - lblTempo.Height,
                panelRelogio.Height - lblTempo.Height
            );

            cclPbrPomodoro.Location = new Point(
                (panelRelogio.Width / 2) - (cclPbrPomodoro.Width / 2),
                lblTempo.Height
            );

            cclPbrPomodoro.Invalidate();
        }

        private void btnRelatorioPomodoro_Click(object sender, EventArgs e)
        {
            RelatorioPomodoro relatorio = new RelatorioPomodoro();
            relatorio.Show();
        }

        private void tmrAlternaCor_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            cclPbrPomodoro.ProgressColor1 = _cores[rnd.Next(0 ,4)];
            cclPbrPomodoro.ProgressColor2 = _cores[rnd.Next(0, 4)];
        }
    }

}
