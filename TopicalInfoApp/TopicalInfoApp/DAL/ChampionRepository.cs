using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopicalInfoApp.Models;

namespace TopicalInfoApp.DAL
{
    public class ChampionRepository : IChampionRepository, IDisposable
    {
        public List<Champion> _champions;

        public ChampionRepository()
        {
            ChampionXmlData championXmlData = new ChampionXmlData();

            using (championXmlData)
            {
                _champions = championXmlData.Read() as List<Champion>;
            }
        }

        public IEnumerable<Champion> GetAllChampions()
        {
            return _champions;
        }

        public Champion GetOneChampion(int id)
        {
            Champion selectedChamp = _champions.Where(c => c.Id == id).FirstOrDefault();

            return selectedChamp;
        }

        public void Save()
        {
            ChampionXmlData championXmlData = new ChampionXmlData();

            using (championXmlData)
            {
                championXmlData.Write(_champions);
            }
        }

        public void Insert(Champion champion)
        {
            champion.Id = getNextId();
            _champions.Add(champion);

            Save();
        }

        public void Update(Champion champion)
        {
            Champion oldChamp = _champions.Where(c => c.Id == champion.Id).FirstOrDefault();

            if (oldChamp != null)
            {
                _champions.Remove(oldChamp);
                _champions.Add(champion);
            }

            Save();
        }

        public void Delete(int id)
        {
            Champion champ = _champions.Where(c => c.Id == id).FirstOrDefault();

            if (champ != null)
            {
                _champions.Remove(champ);
            }

            Save();
        }

        public void Dispose()
        {
            _champions = null;
        }

        #region Helper Method(s)
        private int getNextId()
        {
            int currentMax = _champions.Last().Id;
            return currentMax + 1;
        }
        #endregion
    }
}