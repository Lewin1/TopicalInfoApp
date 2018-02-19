using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopicalInfoApp.Models
{
    public class Champion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public double BaseHealth { get; set; }
        public double BaseMana { get; set; }
        public int BaseArmor { get; set; }
        public int BaseMagicResist { get; set; }
        public int BaseAttackDamage { get; set; }
    }
}