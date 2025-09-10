using System;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //true/false
             bool isAdult = false;
             Console.WriteLine(isAdult);

             // cele cislo
             int myAge = 15;
             Console.WriteLine(myAge);

             //desatinne cislo
             float pi = 3.14f;
             Console.WriteLine(pi);

             //viac znakov hociakych
             string name = "Matus";
             Console.WriteLine(name);

             //jeden znak
             char gender = 'm';
             Console.WriteLine(gender);*/


            /* int a = 10;
           int b = 20 + 30 + 600 + 6000 + 5 ;

           //scitavanie cisel A a B
           int sum = a + b;
           Console.WriteLine(sum);
           Console.WriteLine(a + b);
           Console.WriteLine(10 + 5);

           //cervena gulicka uplne nalavo znamena pokial pojde kod



           //odcitavanie cisla A a B
           Console.WriteLine(a - b);

           int sum2 = a - b;
           Console.WriteLine(sum2);


           //nasobenie A a B
           int sum3 = a * b;
           Console.WriteLine(sum3);
           Console.WriteLine(a * b);
           Console.WriteLine(10 * 5);

           //delenie A a B

           int sum4 = a / b;
           Console.WriteLine(sum4);
           Console.WriteLine(a / b);
           Console.WriteLine(10 / 5);

           Console.WriteLine("Volam sa Jano");  */


            /////////////////
            int birthDay = 29;
            int birthMonth = 7;
            int birthYear = 2010;

/*
            //scitanie datumu mesiaca a roku narodenia
            int birthSum = birthDay + birthMonth + birthYear;
            //vypisanie na konzol
            Console.WriteLine(birthSum);


            //vynasobenie birthSum x 10 a vypisat na kozolu
            Console.WriteLine(birthSum * 10);

            //scitat datum a mesiac narodenia a prenasobit rokom
            int birthSum2 = birthDay + birthMonth;
            Console.WriteLine(birthSum2 * birthYear);
            // druha moznost
            Console.WriteLine((birthMonth + birthDay) * birthYear);


            //vzdy to zaokruhkuje
            //vzdy float (3f) ked chces desatinne cisla
            Console.WriteLine(5 / 3);
            Console.WriteLine(5 / 3f);

            string Name2 = "Matus";
            Console.WriteLine(Name2 + birthYear);

            //vypisat meno a sucet dna a mesiaca narodenia

            Console.WriteLine("Matus" + (birthDay + birthYear));*/


            bool result = 6 != 3;
            Console.WriteLine(result);

            bool result2 = 7 == 3;
            bool result3 = 3 < 10;

            string Igor = "Igor";
            string Michal = "Michal";
            Console.WriteLine(Igor == Michal);

            string igor = "Igor";
            string michal = igor;
            Console.WriteLine(Igor == Michal);


            string krabickaA = "Igor";
            string krabickaB = krabickaA;
            krabickaA = "Michal";
            Console.WriteLine(krabickaB == krabickaA);




        }
    }
}

