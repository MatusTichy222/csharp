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
        public int DMGMin { get; set; } = 6;
        public int DMGMax { get; set; } = 14;

        public int Eng { get; set; } = 100;
        public int Armor { get; set; } = 15;

        public bool HeroAttack(Monster monster)
        {
            if (Eng - 20 >= 0)
            {
                Random random_damage = new Random();
                int finalDamage = random_damage.Next(DMGMin, DMGMax);
                Eng -= 20;
                monster.HP -= finalDamage;
                return true;
            }
            else

            {
                Eng = Eng + 50;
                return false;
            }
        }
        public bool HeroAttack2(MonsterSpecial monster2)
        {
            if (Eng - 20 >= 0)
            {
                Random random_damage = new Random();
                int finalDamage = random_damage.Next(DMGMin, DMGMax);
                Eng -= 20;
                monster2.HP -= finalDamage;
                return true;
            }
            else

            {
                Eng = Eng + 50;
                return false;
            }
        }
    
        public bool HeroDMG(Monster monster)
        {
            if (Eng - 20 >= 0)
            {
                Eng -= 20;
                Random random_damage = new Random();
                int finalDamage = random_damage.Next(DMGMin, DMGMax);
                return true;
            }
            else
            {
                Eng += 50;
                return false;
            }
        }

        public bool HeroDMG2(MonsterSpecial monster2)
        {
            if (Eng - 20 >= 0)
            {
                Eng -= 20;
                Random random_damage = new Random();
                int finalDamage = random_damage.Next(DMGMin, DMGMax);
                return true;
            }
            else
            {
                Eng += 50;
                return false;
            }
        }





    }
}
