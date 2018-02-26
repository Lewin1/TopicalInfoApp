using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopicalInfoApp.Models;

namespace TopicalInfoApp.DAL
{
    public interface IChampionDataServices
    {
        List<Champion> Read();

        void Write(List<Champion> Champions);
    }
}