namespace Cvicenie_cykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {  //vypisanie od 1 po 10
                /* for (int i = 0; i <= 10; i++)
                 {
                     Console.WriteLine(i);
                 }*/

                //od 50 po 100
                /*for (int i = 0; i <= 50; i++)
                 {
                     Console.WriteLine(50+i);
                 }*/
                //od 100 po 0
                /*  for (int i = 100; i >= 0; i--)
                  {
                      Console.WriteLine(i);
                  }*/


                /*  int i = 0;
                  while (i <= 100)
                  {
                      Console.WriteLine(i);
                      i++;
                  }
                */
                //cyklus pre ahoj napis pozdrav pre ukoncenie exit alebo koniec
                /* while (true)
                 {
                     string input = Console.ReadLine();

                     if (input == "pozdrav")
                     {
                         Console.WriteLine("Ahoj");
                     }
                     else if (input == "exit")
                     {
                         break;
                     }

                     else if (input == "koniec")

                     {
                         break;
                     }
                 }*/
                //cyklus v cykle pre ukoncenie vnutorneho cyklu EXIT
                //pre ukoncenie vonkajsieho KONIEC
                /* while (true)
                 {
                     while (true)
                     {
                         Console.WriteLine("Zadajte exit pre ukoncenie");
                         string input = Console.ReadLine();

                         if (input == "exit")
                         {
                             break;
                         }

                         Console.WriteLine("Michal");

                     }
                     Console.WriteLine("Zadajte koniec pre ukoncenie");
                     string inputDva = Console.ReadLine();
                     if (inputDva == "koniec")

                     {
                         break;
                     }
                     Console.WriteLine("Igor");
                 }
                */

                /* for (int i = 1; i <= 7; i++)
                 {
                     string row = "";
                     for (int j = 1; j <= i; j++)
                     {
                         row += "*";
                     }
                     Console.WriteLine(row);
                 }*/
                Console.WriteLine("Zadaj pocet riadkov");
                string cisloText = Console.ReadLine();
                Console.WriteLine("Napis aky chces symbol");
                string znak = Console.ReadLine();
                int cislo = int.Parse(cisloText);
                for (int i = 1; i <= cislo; i++)
                   
                {
                   
                    string row = "";
                    for (int j = 1; j <= i; j++)
                    {
                        row += znak;
                    }
                    Console.WriteLine(row);
                }



























            }
        }
    }
}
