using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_IdleFarmer
{
    public class IdleFarmer
    {
        public int Money { get; set; } = 15;
        public Random RandomGenerator { get; set; } = new Random();
        public int Day { get; set; }
        public List<Plant> Field { get; set; } = new List<Plant>();
        public List<Plant> Sklad { get; set; } = new List<Plant>();
        public int PriceOfPlant { get; set; } = 5;

        public void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Plant cibula = new Plant("cibula", 5, 10);
            Plant pomaranc = new Plant("pomaranc", 40, 8);
            Plant jahoda = new Plant("jahodad", 20, 5);

            Field.Add(cibula);
            Field.Add(pomaranc);
            Field.Add(jahoda);


            while (true)
            {
                Day++;
                //Na konci dna vyrastie rastlina o jednu hodnotu
                foreach (Plant plant in Field)
                {
                    plant.TimeInGround++;
                }

                foreach (Plant plant in Field)
                {
                    Console.WriteLine(plant);
                }
                List<Plant> harvestedP = new List<Plant>();
                foreach (Plant plant in Field)
                {
                    if (plant.TimeInGround >= plant.TimeForHarvest)
                    {
                        Console.WriteLine("Rastlinka nam vyrastla " + plant);
                        harvestedP.Add(plant);
                    }
                }
                foreach (Plant plant in harvestedP)
                {
                    Field.Remove(plant);
                    Sklad.Add(plant);
                }


                Console.WriteLine("Koniec dna" + " " + Day);
                Console.WriteLine("penazenka: " + Money);
                Console.WriteLine("Menu: ");
                Console.WriteLine("Enter Novy den");
                Console.WriteLine("1 pre pridanie rastlinky");
                Console.WriteLine("2 pre zobrazenie skladu");
                Console.WriteLine("3 pre predanie celeho skladu a pridat do penazenky");
                Console.WriteLine("9 pre zatvorenie");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        if (Money < PriceOfPlant)
                        {
                            Console.WriteLine("Nemas love na planty");
                            break;
                        }
                        else
                        {
                            int dobaRastu = RandomGenerator.Next(10, 30);
                            int finalPrice = RandomGenerator.Next(5, 15);
                            Plant newPlant = new Plant("zelenina", dobaRastu, finalPrice);
                            Money -= PriceOfPlant;
                            Field.Add(newPlant);
                            break;
                        }
                    default:
                        break;
                    case "2":
                        foreach (Plant plant in Sklad)
                        {
                            Console.WriteLine(plant);
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        int sum = 0;

                        foreach (Plant plant in Sklad)
                        {
                            sum += plant.Price;
                        }
                        Money += sum * Sklad.Count;
                        Sklad.Clear();
                        break;
                        
                    case "9":
                        return;
                }
                Console.Clear();


            }
        }
    }
}
