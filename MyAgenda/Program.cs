using System;
using System.Windows.Forms;
using Quartz;
using Quartz.Impl;
using MyAgenda.Agendamentos;

namespace MyAgenda
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Constrói um agendador
            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();

            //Starta o agendador
            IScheduler scheduler = schedulerFactory.GetScheduler();
            scheduler.Start();

            //Cria o job
            IJobDetail job = JobBuilder.Create<JobEmiteAlertaParaEventos>()
                                   .WithIdentity("job1", "group1")
                                   .Build();

            //Cria a trigger
            ITrigger trigger = TriggerBuilder.Create()
                               .WithIdentity("trigger1", "group1")
                               .WithSimpleSchedule(x => x.WithIntervalInSeconds(60).RepeatForever())
                               .Build();

            //Agenda o job com base na trigger
            scheduler.ScheduleJob(job, trigger);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());          
        }
    }
}
