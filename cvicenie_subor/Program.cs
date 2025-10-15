using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace cvicenie_subor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ;
            string[] text = File.ReadAllLines("People_100.csv");
            // MinMoneyCountAvg(text);
            UndHalfMilion(text);
            // RodneCislo(text);
            /*MoneyCountAvg(text);
            MoneyCountAvg(text);
            MoneyCountAvg(text);
            MoneyCountAvg(text);
            MoneyCountAvg(text);
            MoneyCountAvg(text);
           */
        }


        /* public static void MoneyCountAvg(string[] text)
     {
         int sum = 0;
         foreach (string line in text.Skip(1))
         {
             string[] splitsT = line.Split(";");
             int splits = int.Parse(splitsT[4]);
             sum += splits;

         }


         Console.WriteLine(sum / (text.Count() - 1));*/


        /*  public static void RodneCislo(string[] text)
          {

              foreach (string line in text.Skip(1))
              {
                  string[] splitsT = line.Split(";");

                  Console.WriteLine(splitsT[2]);

              }

          }*/

        /*  public static void MinMoneyCountAvg(string[] text)
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


              Console.WriteLine(minValuePerson);*/

        //vsetkych ktory maju pod pol miliona na ucte
        //posleme tam text a ona nam musi vratit polie vsetkych mien


        public static void UndHalfMilion(string[] text)
        {
            int minValue = 500000;
            string minValuePerson = "";
            foreach (string line in text.Skip(1))
            {
                string[] splitsT = line.Split(";");
                int accountValue = int.Parse(splitsT[4]);
                if (accountValue < minValue)
                {
                    minValue = accountValue;
                    minValuePerson = splitsT[0] + " " + splitsT[1];
                    Console.WriteLine(minValuePerson);
                }
            }








        }
    }
}