using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopicalInfoApp.Models;

namespace TopicalInfoApp.DAL
{
    interface IChampionRepository
    {
        IEnumerable<Champion> GetAllChampions();
        Champion GetOneChampion(int id);
        void Insert(Champion champion);
        void Update(Champion champion);
        void Delete(int id);
    }
}
