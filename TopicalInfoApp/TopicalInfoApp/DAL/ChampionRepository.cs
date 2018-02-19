using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopicalInfoApp.Models;

namespace TopicalInfoApp.DAL
{
    public class ChampionRepository : IDisposable
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

        public void Save()
        {
            ChampionXmlData championXmlData = new ChampionXmlData();

            using (championXmlData)
            {
                championXmlData.Write(_champions);
            }
        }

        public void Dispose()
        {
            _champions = null;
        }
    }
}