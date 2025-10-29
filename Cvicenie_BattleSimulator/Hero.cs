using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_BattleSimulator
{
    internal class Hero
    {
        public string Name { get; set; } = "Gumkac";
        public int HP { get; set; } = 100;
        public int DMG { get; set; } = 10;

        public int Eng { get; set; } = 100;

        public bool HeroAttack(Monster monster)
        {
            if (Eng - 20 >= 0)
            {
                Eng -= 20;
                monster.HP -= this.DMG;
                return true;
            }
            else

            {
                Eng = Eng + 50;
                return false;
            }
        }



     





    }
}
