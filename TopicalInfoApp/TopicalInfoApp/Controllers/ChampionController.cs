using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopicalInfoApp.DAL;
using TopicalInfoApp.Models;

namespace TopicalInfoApp.Controllers
{
    public class ChampionController : Controller
    {
        // GET: Champion
        [HttpGet]
        public ActionResult Index(string sortOrder)
        {
            ChampionRepository championRepository = new ChampionRepository();

            ViewBag.Classes = ListOfClasses();

            IEnumerable<Champion> champions;
            using (championRepository)
            {
                champions = championRepository.GetAllChampions() as IList<Champion>;
            }

            switch (sortOrder)
            {
                case "Name":
                    champions = champions.OrderBy(champion => champion.Name);
                    break;

                case "Class":
                    champions = champions.OrderBy(champion => champion.Class);
                    break;

                case "Base Health":
                    champions = champions.OrderBy(champion => champion.BaseHealth);
                    break;

                case "Base Mana":
                    champions = champions.OrderBy(champion => champion.BaseMana);
                    break;

                default:
                    break;
            }

                return View(champions);
        }

        [HttpPost]
        public ActionResult Index(string searchBy, string classFilter)
        {
            ChampionRepository championRepository = new ChampionRepository();

            ViewBag.Classes = ListOfClasses();

            IEnumerable<Champion> champions;
            using (championRepository)
            {
                champions = championRepository.GetAllChampions() as IList<Champion>;
            }

            if(searchBy != null)
            {
                champions = champions.Where(champ => champ.Name.ToUpper().Contains(searchBy.ToUpper()));
            }

            if (classFilter != "" || classFilter ==null)
            {
                champions = champions.Where(champ => champ.Class == classFilter);
            }

            return View(champions);
        }
        
        // GET: Champion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Champion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Champion/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Champion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Champion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Champion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Champion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        private IEnumerable<string> ListOfClasses()
        {
            ChampionRepository championRepository = new ChampionRepository();

            IEnumerable<Champion> champions;

            using (championRepository)
            {
                champions = championRepository.GetAllChampions() as IList<Champion>;
            }
            var classes = champions.Select(champ => champ.Class).Distinct().OrderBy(c => c);

            return classes;
        }
    }
}
