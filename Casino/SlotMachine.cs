using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class SlotMachine
    {

        public void SlotMachineGame(Player player)
        {
            Console.WriteLine("Kolko chces stavit?");
            string stavkaTxt = Console.ReadLine();
            int stavka = int.Parse(stavkaTxt);
            if (stavka > player.Kredit)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nemas dostatok kreditov na hranie!");
                Console.ResetColor();
                return;
            }
            else 
            {
                List<SlotMSymbols> Symbols = new List<SlotMSymbols>();  // Pridanie symbolov
                Symbols.Add(new SlotMSymbols('7', 3));
                Symbols.Add(new SlotMSymbols('§', 7));
                Symbols.Add(new SlotMSymbols('%', 20));



            }
        }

    }
}
