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
            else if (age > 100)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Pravdepodobne uz nezijes");
                return;
            }
            else if (age == 67)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HAHAHAAHAHA VTIPNY SI");
                Console.ResetColor();
                return;
            }
            else
            {
                Console.Clear();
                Player MyPlayer = new Player(10, name, age, 0);

                while (true)
                {
                    HodMincou hodMincou = new HodMincou();
                    SlotMachine slotMachine = new SlotMachine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(@" __          __  _                            _           _____          _             
 \ \        / / | |                          | |         / ____|        (_)            
  \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___   | |     __ _ ___ _ _ __   ___  
   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  | |    / _` / __| | '_ \ / _ \ 
    \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |___| (_| \__ \ | | | | (_) |
     \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/   \_____\__,_|___/_|_| |_|\___/ 
                                                                                       
                                                                                       ");
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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tvoje kredit: " + MyPlayer.Kredit);
                    Console.ResetColor();
                    string commandTxt = Console.ReadLine();
                    int command = int.Parse(commandTxt);

                    switch (command)
                    {
                        case 1:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(@"   _____ _       _     __  __            _     _             
  / ____| |     | |   |  \/  |          | |   (_)            
 | (___ | | ___ | |_  | \  / | __ _  ___| |__  _ _ __   ___  
  \___ \| |/ _ \| __| | |\/| |/ _` |/ __| '_ \| | '_ \ / _ \ 
  ____) | | (_) | |_  | |  | | (_| | (__| | | | | | | |  __/ 
 |_____/|_|\___/ \__| |_|  |_|\__,_|\___|_| |_|_|_| |_|\___| 
                                                             
                                                             ");
                            slotMachine.SlotMachineGame(MyPlayer);
                            Console.ResetColor();
                            break;
                        case 2:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(@"  _    _           _   __  __ _                       
 | |  | |         | | |  \/  (_)                      
 | |__| | ___   __| | | \  / |_ _ __   ___ ___  _   _ 
 |  __  |/ _ \ / _` | | |\/| | | '_ \ / __/ _ \| | | |
 | |  | | (_) | (_| | | |  | | | | | | (_| (_) | |_| |
 |_|  |_|\___/ \__,_| |_|  |_|_|_| |_|\___\___/ \__,_|
                                                      
                                                      ");
                            Console.ResetColor();
                            hodMincou.HodMincouGame(MyPlayer);
                            break;
                        case 9:
                            return;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Neplatný príkaz, skús znova.");
                            Console.ResetColor();
                            break;
                    }

                }

            }

        }
    }
}
