﻿using Ifalj.Modelos.Util;
using Ifalj.View.Pomodoro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ifalj.View.TelaCadastro
{
    public partial class Pomodoro : Form
    {
        ConversorHoras cvHoras = new ConversorHoras();
        PomodoroController pModel = new PomodoroController();
        int tipoSessao = 1;
        int tempoSessao;

        public Pomodoro()
        {
            InitializeComponent();
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tmrPomodoro_Tick(sender, e);        
        }

        private void nudTempo_ValueChanged(object sender, EventArgs e)
        {
            //String tempoView = cvHoras.MinuteToHour(Convert.ToInt16(nudTempo.Value));
            cclPbrPomodoro.Value = int.Parse(nudTempo.Value.ToString());
        }

        private void tmrPomodoro_Tick(object sender, EventArgs e)
        {
            if (tipoSessao == 1) tempoSessao = Convert.ToInt16(nudTempo.Value);
            else if (tipoSessao == 2) tempoSessao = Convert.ToInt16(nudTempoShort.Value);
            else if(tipoSessao == 3)tempoSessao = Convert.ToInt16(nudTempoLong.Value);
            pModel.PomodoroOrganizer(tipoSessao,tempoSessao, tmrPomodoro, cclPbrPomodoro, txtQuadroColor1, txtQuadroColor2, txtQuadroColor3, txtQuadroColor4, ref btnShortBreak, ref btnLongBreak, ref btnPomodoro);
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            tmrPomodoro.Stop();
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            cclPbrPomodoro.Value = int.Parse(nudTempo.Value.ToString());
        }

        private void btnShortBreak_Click(object sender, EventArgs e)
        {
            tipoSessao = 2;
            nudTempo.Visible = false;
            nudTempoLong.Visible = false;
            nudTempoShort.Visible = true;
            cclPbrPomodoro.Value = long.Parse(nudTempoShort.Value.ToString());
        }

        private void btnLongBreak_Click(object sender, EventArgs e)
        {
            tipoSessao = 3;
            nudTempo.Visible = false;
            nudTempoShort.Visible = false;
            nudTempoLong.Visible = true;
            cclPbrPomodoro.Value = long.Parse(nudTempoLong.Value.ToString());
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            tipoSessao = 1;
            nudTempoShort.Visible = false;
            nudTempoLong.Visible = false;
            nudTempo.Visible = true;
            cclPbrPomodoro.Value = long.Parse(nudTempo.Value.ToString());
        }

        private void nudTempoLong_ValueChanged(object sender, EventArgs e)
        {
            //cclPbrPomodoro.Maximum = (int)Math.Round(nudTempo.Value);
            //cclPbrPomodoro.Value = long.Parse(nudTempo.Value.ToString());
            cclPbrPomodoro.Value = int.Parse(nudTempoLong.Value.ToString());
        }

        private void nudTempoShort_ValueChanged(object sender, EventArgs e)
        {
            cclPbrPomodoro.Value = int.Parse(nudTempoShort.Value.ToString());
        }

        private void Pomodoro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_IFALJDataSet.vw_pomodoro' table. You can move, or remove it, as needed.
            this.vw_pomodoroTableAdapter.Fill(this.bD_IFALJDataSet.vw_pomodoro);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Pomodoro_SizeChanged(object sender, EventArgs e)
        {
            cclPbrPomodoro.Invalidate();
            cclPbrPomodoro.MaximumSize = new Size(this.Size.Height, this.Size.Height);

        }

        private void btnRelatorioPomodoro_Click(object sender, EventArgs e)
        {
            RelatorioPomodoro relatorio = new RelatorioPomodoro();
            RecuperadorSenha recuperador = new RecuperadorSenha();
            recuperador.Show();
            //relatorio.Show();
        }
    }

}