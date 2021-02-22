using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinanceBot.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace FinanceBot.Controllers
{
    public class HomeController : Controller
    {
        List<Ingot> ingots = new List<Ingot>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MetalIngot()
        {
            ViewBag.Message = "";
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                ingots = db.IngotPrices.ToList();
                return View(ingots);
            }
            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}