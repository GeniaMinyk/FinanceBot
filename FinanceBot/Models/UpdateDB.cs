using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quartz;
using Quartz.Impl;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace FinanceBot.Models
{
    public class Sheduler
    {
        // Выполение метода
        public static async void Start()
        {
            IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler();
            await scheduler.Start();

            IJobDetail job = JobBuilder.Create<UpdateDB>().Build();

            ITrigger trigger = TriggerBuilder
                .Create()
                .WithIdentity("trigger1", "group1")
                .StartAt(DateBuilder.DateOf(2, 0, 0))
                .WithSimpleSchedule(x => x
                    .WithIntervalInHours(24)
                    .RepeatForever())
                .Build();
            await scheduler.ScheduleJob(job, trigger);
        }
    }
    public class UpdateDB : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            // Добавление данных в таблицу "Ingot"
            if (DateTime.Now.DayOfWeek != DayOfWeek.Sunday && DateTime.Now.DayOfWeek != DayOfWeek.Monday)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage res = client.GetAsync("https://www.nbrb.by/api/ingots/prices?ondate=" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day).Result;
                        HttpContent content = res.Content;
                        var data = content.ReadAsStringAsync();
                        var jsondata = JsonConvert.DeserializeObject<Ingot[]>(data.Result);
                        FinanceBot.Models.ApplicationDbContext dbContext = new ApplicationDbContext();
                        dbContext.IngotPrices.AddRange(jsondata);
                        await dbContext.SaveChangesAsync();
                    }
                }
                catch { }
            }
            
        }
    }
}