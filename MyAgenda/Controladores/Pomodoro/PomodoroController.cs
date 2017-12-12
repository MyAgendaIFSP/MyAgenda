using MyAgenda.Componentes.Pomodoro;
using MyAgenda.Controladores.Geral;
using MyAgenda.Dados;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace MyAgenda.Controladores.Pomodoro
{
    public class PomodoroController
    {
        int contadorQuadro1;
        int contadorQuadro2;
        int contadorQuadro3;
        int contadorQuadro4;

        public void PomodoroOrganizer(int tipoSessao,int tempoSessaoTotal, int tempoSessaoAtual, System.Windows.Forms.Timer tmrPomodoro, CircularProgressBar cclPbrPomodoro, TextBox txtQuadroColor1, TextBox txtQuadroColor2, TextBox txtQuadroColor3, TextBox txtQuadroColor4, ref Button btnShortBreak, ref Button btnLongBreak, ref Button btnPomodoro)
        {
            if (tempoSessaoTotal / 60 > 0)
            {
                cclPbrPomodoro.Value = (int)Math.Floor((double)(tempoSessaoAtual * 100) / tempoSessaoTotal);

                if (cclPbrPomodoro.Value == 0)
                {
                    tmrPomodoro.Stop();

                    CallDataConnection(UsuarioController.GetInstance().GetModelo().Id, tipoSessao, tempoSessaoTotal / 60);

                    if (tipoSessao == 1)
                    {
                        if (contadorQuadro1 == 0)
                        {
                            contadorQuadro1++;
                            AlarmePomodoro("Sua sessão de trabalho acabou. Hora da pausa!");
                            TrocarContexto(ref btnShortBreak, ref btnPomodoro, tipoSessao);
                            txtQuadroColor1.BackColor = Color.Orange;
                        }
                        else if (contadorQuadro2 == 0)
                        {
                            contadorQuadro2++;
                            AlarmePomodoro("Sua sessão de trabalho acabou. Hora da pausa!");
                            TrocarContexto(ref btnShortBreak, ref btnPomodoro, tipoSessao);
                            txtQuadroColor2.BackColor = Color.Orange;
                        }
                        else if (contadorQuadro3 == 0)
                        {
                            contadorQuadro3++;
                            AlarmePomodoro("Sua sessão de trabalho acabou. Hora da pausa!");
                            TrocarContexto(ref btnShortBreak, ref btnPomodoro, tipoSessao);
                            txtQuadroColor3.BackColor = Color.Orange;
                        }
                        else
                        {
                            contadorQuadro4++;
                            AlarmePomodoro("Sua sessão de trabalho acabou. Hora da pausa!");
                            TrocarContexto(ref btnLongBreak);
                            txtQuadroColor4.BackColor = Color.Orange;
                        }
                    }
                    else if (tipoSessao == 2)
                    {
                        AlarmePomodoro("Fim da pausa. De volta ao trabalho!");
                        btnPomodoro.PerformClick();
                    }
                    else if (tipoSessao == 3)
                    {
                        if (contadorQuadro1 >= 0 &&
                            contadorQuadro2 >= 0 &&
                            contadorQuadro3 >= 0 &&
                            contadorQuadro4 >= 0)
                        {
                            txtQuadroColor1.BackColor = Color.WhiteSmoke;
                            txtQuadroColor2.BackColor = Color.WhiteSmoke;
                            txtQuadroColor3.BackColor = Color.WhiteSmoke;
                            txtQuadroColor4.BackColor = Color.WhiteSmoke;

                            contadorQuadro1 = 0;
                            contadorQuadro2 = 0;
                            contadorQuadro3 = 0;
                            contadorQuadro4 = 0;

                            btnPomodoro.PerformClick();
                            AlarmePomodoro("Parabéns, você concluiu um clico pomodoro!");
                        }
                        else
                        {
                            AlarmePomodoro("Fim da pausa. De volta ao trabalho!");
                            btnPomodoro.PerformClick();
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

        public void AlarmePomodoro(string msg)
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
                MessageBox.Show(msg);
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