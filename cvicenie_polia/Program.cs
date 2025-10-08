using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO.Pipes;

namespace cvicenie_polia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] numbers = new int[7];

             numbers[0] = 10;
             numbers[1] = 15;
             numbers[2] = 35;
             numbers[3] = 48;
             numbers[4] = 2;
             numbers[5] = 1;
             numbers[6] = 19;

             Console.WriteLine(numbers[0]);
             Console.WriteLine(numbers[1]);
             Console.WriteLine(numbers[2]);
             Console.WriteLine(numbers[3]);
             Console.WriteLine(numbers[4]);
             Console.WriteLine(numbers[5]);
             Console.WriteLine(numbers[6]);

             int sum = 0;
             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine(numbers[i]);
                 sum += numbers[i];
             }
             Console.WriteLine(sum)
                int sum = 0;
             foreach (var number in numbers)
             {
                 sum += number;
             }
             Console.WriteLine(sum);
             //pomocou cyklu ktoreho naplnime poli cisiel cez csReadline
             int[] numbers = new int[5];
             for (int i = 0; i < numbers.Length; i++)
             {
                 numbers[i] = 8;
             }
             //spocitanie vsetkych cisel v poli a vypiseme na konzolu
             int sum = 0;
             foreach (var number in numbers)
             {
                 sum += number;
             }
             Console.WriteLine(sum);

             Console.WriteLine("KOlko cisel chces?");
             int count = int.Parse(Console.ReadLine());


             int[] numbers = new int[count];
             int sum = 0;
             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine("Zadaj cislo");
                 string input = Console.ReadLine();
                 numbers[i] = int.Parse(input);
                 sum += numbers[i];
             }

             Console.WriteLine("Súčet vsetkych cisel je: " + sum);*/

            int[] numbers = new int[10];
            Console.WriteLine("Dlzka pola je: " + numbers.Length);
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = i * 10;
            }

            int[] numbersNew = new int[numbers.Length + 1];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersNew[i] = numbers[i];
            }
            numbersNew[10] = 10000;
            foreach (int i in numbersNew)
            {
                Console.WriteLine();
            }

            string[] names = { "´Janko", "Fero", "MIsko", "Jozef" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

           



    
        }
    }
}
