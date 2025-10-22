using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace cvicenie_subor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> teploty = new List<int> { 3, -1, 12, 7, -3, 0, 19, 14, 2, 5, -5, 8 };

            List<int> kladneTeploty = new List<int>();
            foreach (int teplota in teploty)
            {
                if (teplota >= 0)
                {
                    kladneTeploty.Add(teplota);
                }
            }
            Console.WriteLine("Kladne: ");
           foreach (var i in kladneTeploty)
            {
                Console.Write(i);
            }

            int max = int.MinValue;
            foreach (int teplota in teploty)
            {
                if (teplota > max)
                {
                    max = teplota;
                }
            }
            Console.WriteLine("maximalna teplota je " + max);

            int min = int.MaxValue;
            foreach (int teplota in teploty)
            {
                if (teplota < min)
                {
                    min = teplota;
                }
            }
            Console.WriteLine("minimalna teplota je " + min);

            int sum = 0;
            foreach (int teplota in teploty)
            {
                sum += teplota;
            }
            int pocet = teploty.Count;
            double priemer = (double)sum / pocet;
            Console.WriteLine("priemer: " + priemer);



            string riadok = "";
            foreach (int teplota in teploty)
            {
                riadok += teplota + ", ";
            }

            int pocetNad = 0;
            foreach (int teplota in teploty)
            {
                if (teplota > priemer)
                {
                    pocetNad++;
                }
            }
            Console.WriteLine("Nad priemerom je " + pocetNad + " cisel");









            /* Console.Write("Zadaj frazu: ");
             string fraza = Console.ReadLine();
            //min
            if (fraza == "min")
            {
                int min = teploty.Min();
                Console.WriteLine("Minimálna teplota je: " + min);
            }
            //max
            else if (fraza == "max")
            {
                int max = teploty.Max();
                Console.WriteLine("Maximálna teplota je: " + max);
            }
            //priemer
            else if (fraza == "priemer")
            {
                double avg = teploty.Average();
                Console.WriteLine("Priemerná teplota je: " + avg);

            }
            //nad priemerom
            else if (fraza == "nad priemerom")
            {
                int AvgUp = 0;
                for (int i = 0; i < teploty.Count; i++)
                {
                    int avg = (int)teploty.Average();
                    if (teploty[i] > avg)
                        AvgUp++;
                }
                Console.WriteLine("Pocet teplot nad priemerom: " + AvgUp);
            }
            //bez zapornych
            else if (fraza == "odstran zaporne")
            {
                List<int> PositiveD = new List<int>();
                for (int i = 0; i < teploty.Count; i++)
                {
                    if (teploty[i] > 0)
                    {
                        PositiveD.Add(teploty[i]);
                    }
                }
                Console.WriteLine("Teploty bez zapornych su: " + teploty);
            }
            */
       




        }
    }
}