namespace Cvicenie_BattleSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Random r = new Random();
            Hero ourhero = new Hero();
            Monster monster1 = new Monster("Sovik", 150, 30);
            Monster monster2 = new Monster("Mikova", 300, 50);
            Monster monster3 = new Monster("Choma", 100, 25);
            List<Monster> monsters = new List<Monster>();
            monsters.Add(monster1);
            monsters.Add(monster2);
            monsters.Add(monster3);
            while (true)
            {
                int countMonsters = monsters.Count;
                int which = r.Next(0, countMonsters);
                monsters[which].MonsterAttack(ourhero);


                if (ourhero.HP <= 0)
                {
                    Console.WriteLine(ourhero.Name + " is dead!");
                    break;
                }

                ourhero.HeroAttack(monsters[which]);
                
                {
                    Console.WriteLine(monster1 + " zautocil na " + ourhero.Name + " s damageom: " + monster1.DMG);
                    if (monsters[which].HP <= 0)
                    {
                        monsters.RemoveAt(which);
                    }
                    if (monsters.Count == 0)
                    {
                        Console.WriteLine("Zabil si vsetky prisery");
                        break;
                    }
                    Console.WriteLine("tvoj hrdina ma teraz: " + ourhero.HP + " HP");

                    foreach (Monster monster in monsters)
                    {
                        Console.WriteLine(monster.RaceType + " ma " + monster.HP);

                    }
                }


                //int heroHPafterAttack = ourhero.HP - monster1.DMG;
                //ourhero.HP = heroHPafterAttack;



                /* //ourhero.HP = ourhero.HP - monster1.DMG;
                 monster1.MonsterAttack(ourhero);
                 monster2.MonsterAttack(ourhero);
                 monster3.MonsterAttack(ourhero);
               */




                //monster1.HP = monster1.HP - ourhero.DMG;
                /*bool wasAttack = ourhero.HeroAttack(monster1);
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


                if (monster1.HP <= 0)
                {
                    Console.WriteLine(monster1.RaceType + " is dead!");
                    break;
                }


                /*MonsterSpecial monster2 = new MonsterSpecial("Sovik", 200, 15);
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
                    }*/





            }
        }
    }
}
