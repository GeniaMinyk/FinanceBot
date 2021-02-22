namespace FinanceBot.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Newtonsoft.Json;
    using System.Net.Http;
    using FinanceBot.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<FinanceBot.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FinanceBot.Models.ApplicationDbContext";
        }

        protected override void Seed(FinanceBot.Models.ApplicationDbContext context)
        {
            //// Металл
            //using (HttpClient client = new HttpClient())
            //{
            //    HttpResponseMessage res = client.GetAsync("https://www.nbrb.by/api/metals").Result;
            //    HttpContent content = res.Content;
            //    var data = content.ReadAsStringAsync();
            //    var jsondata = JsonConvert.DeserializeObject<Metal[]>(data.Result);
            //    context.Metals.AddRange(jsondata);
            //}
            ////Стоимость слитков
            //using (HttpClient client = new HttpClient())
            //{
            //    HttpResponseMessage res = client.GetAsync("https://www.nbrb.by/api/ingots/prices?ondate=2021-02-15").Result;
            //    HttpContent content = res.Content;
            //    var data = content.ReadAsStringAsync();
            //    var jsondata = JsonConvert.DeserializeObject<Ingot[]>(data.Result);
            //    context.IngotPrices.AddRange(jsondata);
            //}

        }
    }
}
