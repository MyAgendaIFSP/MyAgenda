using MyAgenda.Componentes.Pomodoro;
using MyAgenda.Dados;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace MyAgenda.Controladores.Pomodoro
{
    public class PomodoroController
    {
        int contadorQuadro1;
        int contadorQuadro2;
        int contadorQuadro3;
        int contadorQuadro4;

        public void PomodoroOrganizer(int tipoSessao,int tempoSessao, System.Windows.Forms.Timer tmrPomodoro, CircularProgressBar cclPbrPomodoro, TextBox txtQuadroColor1, TextBox txtQuadroColor2, TextBox txtQuadroColor3, TextBox txtQuadroColor4, ref Button btnShortBreak, ref Button btnLongBreak, ref Button btnPomodoro)
        {
            if (tempoSessao > 0)
            {
                
                tmrPomodoro.Enabled = true;
                cclPbrPomodoro.Decrement(1);
                if (cclPbrPomodoro.Value == 0)
                {
                    tmrPomodoro.Stop();
                    if (contadorQuadro1 == 0)
                    {
                        CallDataConnection(1,tipoSessao,tempoSessao);
                        AlarmePomodoro();
                        TrocarContexto(ref btnShortBreak, ref btnPomodoro, tipoSessao);
                        if (tipoSessao == 1)
                        {
                            contadorQuadro1++;
                            txtQuadroColor1.BackColor = Color.Orange;
                        }
                    }
                    else if (contadorQuadro2 == 0)
                    {
                        CallDataConnection(1, tipoSessao, tempoSessao);
                        AlarmePomodoro();
                        TrocarContexto(ref btnShortBreak, ref btnPomodoro, tipoSessao);
                        if(tipoSessao == 1)
                        {
                            contadorQuadro2++;
                            txtQuadroColor2.BackColor = Color.Orange;
                        }
                    }
                    else if (contadorQuadro3 == 0)
                    {
                        CallDataConnection(1, tipoSessao, tempoSessao);
                        AlarmePomodoro();
                        TrocarContexto(ref btnShortBreak, ref btnPomodoro, tipoSessao);
                        if(tipoSessao == 1)
                        {
                            contadorQuadro3++;
                            txtQuadroColor3.BackColor = Color.Orange;
                        }
                    }
                    else
                    {
                        CallDataConnection(1, tipoSessao, tempoSessao);
                        AlarmePomodoro();
                        TrocarContexto(ref btnPomodoro);
                        if(tipoSessao == 1)
                        {
                            contadorQuadro4++;
                            txtQuadroColor4.BackColor = Color.Orange;
                        }
                    }
                }
            }
        }

        public void CallDataConnection(int idUsuario, int tipoSessao, int tempoSessao)
        {
            try
            {
                PomodoroAPI dataConnection = new PomodoroAPI();
                
                dataConnection.GravarPomodoro(idUsuario,tipoSessao,tempoSessao,DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro ocorreu: \n" + ex);
            }
        }

        public void AlarmePomodoro()
        {
            //var file = new FileInfo(Path.Combine(Path.GetDirectoryName(
            //Assembly.GetExecutingAssembly().Location), @"Alarm.wav"));

            SoundPlayer soundPlayer = new SoundPlayer(MyAgenda.Properties.Resources.Alarm);
            try
            {
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sua sessão chegou ao fim");
            }

        }

        public void TrocarContexto(ref Button btnShortBreak, ref Button btnPomodoro, int tipoSessao)
        {
            if(tipoSessao == 1) { btnShortBreak.PerformClick(); }
            else { btnPomodoro.PerformClick(); }   
        }

        public void TrocarContexto(ref Button btnLongBreak)
        {
            btnLongBreak.PerformClick();
        }
    }
}