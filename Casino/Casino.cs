using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Casino
{
    public class Casino
    {
       
        public void StartCasino()
        {
            Console.WriteLine("Zadaj svoje Meno");
            string name = Console.ReadLine();
            Console.WriteLine("Vitaj " + name + " zadaj svoj vek");
            string ageTxt = Console.ReadLine();
            int age = int.Parse(ageTxt);
            if (age < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nemáš dostatočný vek na to hrať hazardné hry");
                return;
            }
            else if (age > 100 )
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Pravdepodobne uz nezijes"); 
                return;
            }
            else
            {
                Player MyPlayer = new Player(10, name, age);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(name + @" vitaj v Kasínku Admiral Kysucké Nové Mesto!");
                Console.ResetColor();
                    Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1.Slot Machine");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" 2. Hod Mincou");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("9. Ukončiť hru");
                Console.ResetColor();
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Tvoj KREDIT: " + MyPlayer.Kredit);
                Console.ResetColor();










            }


           
        }
    }
}
