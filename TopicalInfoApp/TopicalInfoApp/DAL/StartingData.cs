using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopicalInfoApp.Models;

namespace TopicalInfoApp.DAL
{
    public class StartingData
    {
        public static IEnumerable<Champion> GetAllChampion()
        {
            IList<Champion> champions = new List<Champion>();

            champions.Add(new Champion
            {
                Id = 1,
                Name = "Ashe",
                Class = "Marksman",
                BaseHealth = 527.7,
                BaseMana = 280,
                BaseArmor = 30,
                BaseMagicResist = 30,
                BaseAttackDamage = 65,
                ImagePath = "~/Content/Images/ProfilePics/Ashe.png"

            });

            champions.Add(new Champion
            {
                Id = 2,
                Name = "Cho'Gath",
                Class = "Specialist",
                BaseHealth = 574.4,
                BaseMana = 272.2,
                BaseArmor = 38,
                BaseMagicResist = 32,
                BaseAttackDamage = 69,
                ImagePath = "~/Content/Images/ProfilePics/Chogath.png"

            });

            champions.Add(new Champion
            {
                Id = 3,
                Name = "Ekko",
                Class = "Assassin",
                BaseHealth = 585,
                BaseMana = 280,
                BaseArmor = 32,
                BaseMagicResist = 32,
                BaseAttackDamage = 55,
                ImagePath = "~/Content/Images/ProfilePics/Ekko.png"

            });

            champions.Add(new Champion
            {
                Id = 4,
                Name = "Galio",
                Class = "Warden",
                BaseHealth = 562,
                BaseMana = 400,
                BaseArmor = 24,
                BaseMagicResist = 32,
                BaseAttackDamage = 59,
                ImagePath = "~/Content/Images/ProfilePics/Galio.png"

            });

            champions.Add(new Champion
            {
                Id = 5,
                Name = "Jhin",
                Class = "Marksman",
                BaseHealth = 540,
                BaseMana = 300,
                BaseArmor = 29,
                BaseMagicResist = 30,
                BaseAttackDamage = 61,
                ImagePath = "~/Content/Images/ProfilePics/Jhin.png"

            });

            champions.Add(new Champion
            {
                Id = 6,
                Name = "Kayn",
                Class = "Skirmisher",
                BaseHealth = 585,
                BaseMana = 410,
                BaseArmor = 38,
                BaseMagicResist = 32,
                BaseAttackDamage = 68,
                ImagePath = "~/Content/Images/ProfilePics/Kayn.png"

            });

            champions.Add(new Champion
            {
                Id = 7,
                Name = "Lux",
                Class = "Burst",
                BaseHealth = 490,
                BaseMana = 384,
                BaseArmor = 18,
                BaseMagicResist = 30,
                BaseAttackDamage = 53,
                ImagePath = "~/Content/Images/ProfilePics/Lux.png"

            });

            champions.Add(new Champion
            {
                Id = 8,
                Name = "Nasus",
                Class = "Juggernaut",
                BaseHealth = 561.2,
                BaseMana = 325.6,
                BaseArmor = 34,
                BaseMagicResist = 32,
                BaseAttackDamage = 67,
                ImagePath = "~/Content/Images/ProfilePics/Nasus.png"

            });

            champions.Add(new Champion
            {
                Id = 9,
                Name = "Ryze",
                Class = "Battlemage",
                BaseHealth = 570.5,
                BaseMana = 400,
                BaseArmor = 21,
                BaseMagicResist = 30,
                BaseAttackDamage = 55,
                ImagePath = "~/Content/Images/ProfilePics/Ryze.png"

            });

            champions.Add(new Champion
            {
                Id = 10,
                Name = "Taric",
                Class = "Warden",
                BaseHealth = 575,
                BaseMana = 300,
                BaseArmor = 40,
                BaseMagicResist = 32,
                BaseAttackDamage = 55,
                ImagePath = "~/Content/Images/ProfilePics/Taric.png"

            });

            champions.Add(new Champion
            {
                Id = 11,
                Name = "Veigar",
                Class = "Burst",
                BaseHealth = 505,
                BaseMana = 392,
                BaseArmor = 22,
                BaseMagicResist = 30,
                BaseAttackDamage = 50,
                ImagePath = "~/Content/Images/ProfilePics/Veigar.png"

            });

            champions.Add(new Champion
            {
                Id = 12,
                Name = "Yorick",
                Class = "Juggernaut",
                BaseHealth = 580,
                BaseMana = 300,
                BaseArmor = 39,
                BaseMagicResist = 32,
                BaseAttackDamage = 62,
                ImagePath = "~/Content/Images/ProfilePics/Yorick.png"

            });

            champions.Add(new Champion
            {
                Id = 13,
                Name = "Zed",
                Class = "Assassin",
                BaseHealth = 584,
                BaseMana = 0,
                BaseArmor = 32,
                BaseMagicResist = 32,
                BaseAttackDamage = 63,
                ImagePath = "~/Content/Images/ProfilePics/Zed.png"

            });

            champions.Add(new Champion
            {
                Id = 14,
                Name = "Zilean",
                Class = "Specialist",
                BaseHealth = 504,
                BaseMana = 360,
                BaseArmor = 24,
                BaseMagicResist = 30,
                BaseAttackDamage = 51,
                ImagePath = "~/Content/Images/ProfilePics/Zilean.png"

            });

            champions.Add(new Champion
            {
                Id = 15,
                Name = "Zoe",
                Class = "Burst",
                BaseHealth = 526,
                BaseMana = 340,
                BaseArmor = 20,
                BaseMagicResist = 30,
                BaseAttackDamage = 56,
                ImagePath = "~/Content/Images/ProfilePics/Zoe.png"

            });

            return champions;
        }
    }
}