using MyAgenda.Componentes.Geral;
using MyAgenda.Controladores.Geral;
using MyAgenda.Dados;
using System;
using System.ComponentModel;
using System.Data;

namespace MyAgenda
{
    public partial class RelatorioPomodoro : BaseForm
    {


        public RelatorioPomodoro()
        {
            InitializeComponent();
        }
        
        private void RelatorioPomodoro_Shown(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;

            ComecaCarregar();
            worker.RunWorkerAsync();
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView1.DataSource = (DataTable) e.Result;
            ParaCarregar();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            PomodoroAPI api = new PomodoroAPI();
            DataTable dt = api.GetRelatorio();
            if (dt != null)
            {
                e.Result = dt;
            }
        }
    }
}
