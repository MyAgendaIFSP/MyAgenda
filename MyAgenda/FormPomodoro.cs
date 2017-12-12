﻿using MyAgenda.Componentes.Geral;
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
        int _tempoAtual = 0;
        int _tempoSessaoParaLabel = 0;
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
            }
            else
            {
                lblTempo.Text = "00:00";
                int tempoSessao = int.Parse(nudTempo.Value.ToString());
                _tempoSessaoParaLabel = tempoSessao * 60;
                _tempoAtual = _tempoSessaoParaLabel;
                cclPbrPomodoro.Value = 100;
            }

            tmrPomodoro.Start();
            //tmrView.Start();
        }

        private void nudTempo_ValueChanged(object sender, EventArgs e)
        {
            int tempoSessao = int.Parse(nudTempo.Value.ToString());
            _tempoSessaoParaLabel = tempoSessao * 60;
            _tempoAtual = _tempoSessaoParaLabel;
            cclPbrPomodoro.Value = 100;
        }

        private void tmrPomodoro_Tick(object sender, EventArgs e)
        {
            _tempoAtual--;
            lblTempo.Text = cvHoras.SecondsToMinute(_tempoAtual);
            pModel.PomodoroOrganizer(tipoSessao, _tempoSessaoParaLabel, _tempoAtual, tmrPomodoro, cclPbrPomodoro, txtQuadroColor1, txtQuadroColor2, txtQuadroColor3, txtQuadroColor4, ref btnShortBreak, ref btnLongBreak, ref btnPomodoro);
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            _foiPausado = true;
            tmrPomodoro.Stop();
            tmrView.Stop();
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            tmrPomodoro.Stop();
            cclPbrPomodoro.Value = 100;
            lblTempo.Text = cvHoras.SecondsToMinute((int)nudTempo.Value * 60);
        }

        private void btnShortBreak_Click(object sender, EventArgs e)
        {
            tipoSessao = 2;
            nudTempo.Value = 5;
            lblTempo.Text = cvHoras.SecondsToMinute((int) nudTempo.Value * 60);
        }

        private void btnLongBreak_Click(object sender, EventArgs e)
        {
            tipoSessao = 3;
            nudTempo.Value = 15;
            lblTempo.Text = cvHoras.SecondsToMinute((int)nudTempo.Value * 60);
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            tipoSessao = 1;
            nudTempo.Value = 25;
            lblTempo.Text = cvHoras.SecondsToMinute((int)nudTempo.Value * 60);
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

        private void tmrView_Tick(object sender, EventArgs e)
        {
            _tempoSessaoParaLabel--;
            lblTempo.Text = cvHoras.SecondsToMinute(_tempoSessaoParaLabel);
        }
    }

}
