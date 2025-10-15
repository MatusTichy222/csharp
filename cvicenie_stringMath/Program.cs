using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace cvicenie_stringMath
{
    internal class Program
    {
        static void Main()
        {
           /* Console.WriteLine("zadaj cislo");
            string numberT = Console.ReadLine();
            int number = int.Parse(numberT);
            Console.WriteLine("zadaj cislo 2");
            string number2T = Console.ReadLine();
            int number2 = int.Parse(number2T);
            int sum = Scitanie(1, 2, 3, number, number2);
            Console.WriteLine(sum);*/
        }
         

       /* public static int Scitanie(int a , int b, int c, int d, int e)
        { 
        
            int f = a + b + c + d + e;
            return f;
        }*/

        public static void RodneCislo(string[] text)
        {
            
            foreach (string line in text.Skip(1))
            {
                string[] splitsT = line.Split(";");
                int splits = int.Parse(splitsT[2]);
                Console.WriteLine(splits);

            }


        



        }
}
