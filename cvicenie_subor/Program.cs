using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace cvicenie_subor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] text = File.ReadAllLines("People_100.csv");
            // MinMoneyCountAvg(text);
            Under05M(text);
            // RodneCislo(text);
            MoneyCountAvg(text);
            MoneyCountAvg(text);
            MoneyCountAvg(text);
            MoneyCountAvg(text);
            MoneyCountAvg(text);
            MoneyCountAvg(text);

        }


        public static void MoneyCountAvg(string[] text)
        {
            int sum = 0;
            foreach (string line in text.Skip(1))
            {
                string[] splitsT = line.Split(";");
                int splits = int.Parse(splitsT[4]);
                sum += splits;

            }


            Console.WriteLine(sum / (text.Count() - 1));
        }


        public static void RodneCislo(string[] text)
        {

            foreach (string line in text.Skip(1))
            {
                string[] splitsT = line.Split(";");

                Console.WriteLine(splitsT[2]);

            }

        }

        public static void MinMoneyCountAvg(string[] text)
        {
            int minValue = 99999999;
            string minValuePerson = "";
            foreach (string line in text.Skip(1))
            {
                string[] splitsT = line.Split(";");
                int accountValue = int.Parse(splitsT[4]);
                if (accountValue < minValue)
                {
                    minValue = accountValue;
                    minValuePerson = splitsT[0] + " " + splitsT[1];
                }

            }


            Console.WriteLine(minValuePerson);
        }

        //vsetkych ktory maju pod pol miliona na ucte
        //posleme tam text a ona nam musi vratit polie vsetkych mien


        //domaca uloha
        public static void Under05M(string[] text)
        {
            List<string> peopleWithUnder05M = new List<string>();
            foreach (string line in text.Skip(1))
            {
                string[] splits = line.Split(";");
                int accountvalue = int.Parse(splits[4]);
                if (accountvalue < 5000000)
                    peopleWithUnder05M.Add(splits[0] + " " + splits[1]);
            }
            foreach (string under05m in peopleWithUnder05M)
            {
                Console.WriteLine(under05m);
            }
        }
    }
}











