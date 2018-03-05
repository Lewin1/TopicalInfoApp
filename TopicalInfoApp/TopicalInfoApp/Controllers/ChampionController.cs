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

        #region Index
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

        #endregion

        #region Details
        // GET: Champion/Details/5
        public ActionResult Details(int id)
        {
            Champion champ = GetChampionById(id);
            
            return View(champ);
        }

        #endregion

        #region Create
        // GET: Champion/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Champion newChamp)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                ChampionRepository championRepository = new ChampionRepository();

                using (championRepository)
                {
                    championRepository.Insert(newChamp);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion

        #region Edit
        // GET: Champion/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Champion champ = GetChampionById(id);

            return View(champ);
        }

        // POST: Champion/Edit/5
        [HttpPost]
        public ActionResult Edit(Champion champ)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                ChampionRepository championRepository = new ChampionRepository();

                using (championRepository)
                {
                    championRepository.Update(champ);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion

        #region Delete
        [HttpGet]
        // GET: Champion/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(GetChampionById(id));
        }

        // POST: Champion/Delete/5
        [HttpPost]
        public ActionResult Delete(Champion champ)
        {
            try
            {
                ChampionRepository championRepository = new ChampionRepository();

                using (championRepository)
                {
                    championRepository.Delete(champ.Id);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion

        #region Helper Methods
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

        private Champion GetChampionById (int id)
        {
            Champion champ = new Champion();


            ChampionRepository championRepository = new ChampionRepository();

            IEnumerable<Champion> champions;
            using (championRepository)
            {
                champions = championRepository.GetAllChampions() as IList<Champion>;
            }

            champ = champions.Where(c => c.Id == id).FirstOrDefault();

            return champ;
        }

        #endregion
    }
}
