using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_BattleSimulator
{
    internal class Monster
    {

        public string RaceType { get; set; }
        public int HP { get; set; }
        public int MinDMG { get; set; } = 15;
        public int MaxDMG { get; set; } = 35;

        public Monster(string raceType, int hP)
        {
            RaceType = raceType;
            HP = hP;

        }

        public void MonsterAttack(Hero hero)
        {
            List<int> damage = new List<int>();
            damage.Add(MinDMG);
            damage.Add(MaxDMG);
            Random r = new Random();
            int count = damage.Count;
            int index = r.Next(count);
            int DMG = damage[index];

            if (hero.Armor > DMG)
            {

                hero.HP = hero.HP - 0;
            }
            else if (hero.Armor < DMG)
            {
                hero.HP = (hero.Armor + hero.HP) - DMG;
            }


        }
    }
}
