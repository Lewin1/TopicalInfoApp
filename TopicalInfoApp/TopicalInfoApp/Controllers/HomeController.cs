using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopicalInfoApp.DAL;
using TopicalInfoApp.Models;

namespace TopicalInfoApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //Temp code so that the xml file would write itself
            List<Champion> champions = new List<Champion>();
            champions = StartingData.GetAllChampion() as List<Champion>;
            ChampionRepository championRepository = new ChampionRepository();

            championRepository._champions = champions;
            championRepository.Save();
            //End of temp code block

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}