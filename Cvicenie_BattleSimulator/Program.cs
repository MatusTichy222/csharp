namespace Cvicenie_BattleSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hero ourhero = new Hero();
            /* Monster monster1 = new Monster("Goblin", 150, 3);


            //int heroHPafterAttack = ourhero.HP - monster1.DMG;
            //ourhero.HP = heroHPafterAttack;

            while (true)
            {
                //ourhero.HP = ourhero.HP - monster1.DMG;
                monster1.MonsterAttack(ourhero);

                //monster1.HP = monster1.HP - ourhero.DMG;
                bool wasAttack = ourhero.HeroAttack(monster1);
                if (wasAttack)
                {
                    Console.WriteLine(monster1.HP);
                }
                else
                {
                    Console.WriteLine("Not enough energy to attack");
                    Console.WriteLine("HERO: Enegry " + ourhero.Eng);
                }


                Console.WriteLine(ourhero.HP + " Hero HP");
                Console.WriteLine(monster1.HP + " Monster HP");

                if (ourhero.HP <= 0)
                {
                    Console.WriteLine(ourhero.Name + " is dead!");
                    break;
                }

                if (monster1.HP <= 0)
                {
                    Console.WriteLine(monster1.RaceType + " is dead!");
                    break;
                }
                */

            MonsterSpecial monster2 = new MonsterSpecial("Sovik", 200, 15);
            monster2.MonsterAttack(ourhero);

            while (true)
            {

                {
                    monster2.MonsterAttack(ourhero);
                    bool wasAttack2 = ourhero.HeroAttack2(monster2);


                    if (ourhero.HP <= 0)
                    {
                        Console.WriteLine(ourhero.Name + " is dead!");
                        break;
                    }

                    if (monster2.HP <= 0)
                    {
                        Console.WriteLine(monster2.RaceType + " is dead!");
                        break;
                    }
                }
                {
                    bool wasAttack2 = ourhero.HeroAttack2(monster2);
                    if (wasAttack2)
                    {
                        Console.WriteLine(monster2.HP);
                    }
                    else
                    {
                        Console.WriteLine("Not enough energy to attack");
                        Console.WriteLine("HERO: Enegry " + ourhero.Eng);
                    }

                    Console.WriteLine(ourhero.HP + " Hero HP");
                    Console.WriteLine(monster2.HP + " Monster HP");
                }
            }


        }
    }
}
