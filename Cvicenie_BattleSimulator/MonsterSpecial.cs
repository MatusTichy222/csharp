using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_BattleSimulator
{
    internal class MonsterSpecial
    {
        public string RaceType { get; set; }
        public int HP { get; set; }
        public int MinDMG2 { get; set; } = 13;  
        public int MaxDMG2 { get; set; } = 26;  

        public MonsterSpecial(string raceType, int hp, int dmg)
        {
            RaceType = raceType;
            HP = hp;
        }

        public void MonsterAttack(Hero hero)
        {
            List<int> damage = new List<int>();
            damage.Add(MinDMG2);
            damage.Add(MaxDMG2);
            Random r = new Random();
            int count = damage.Count;
            int index = r.Next(count);
            int DMG2 = damage[index];

            if (hero.Armor > DMG2)
            {
                hero.HP = hero.HP - 0;

            }
            else if (hero.Armor < DMG2)
            {
                hero.HP = (hero.Armor + hero.HP) - DMG2;

            }
            DMG2++;
        }
    }

}

