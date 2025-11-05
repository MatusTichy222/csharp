using System.Runtime.CompilerServices;

namespace cvicenie_5._11._5
{
    internal class Program
    {
        static void Main(string[] args)
        /* {
             Random number = new Random();   
             int ct = 0;
             Console.ForegroundColor = ConsoleColor.Magenta;

             for (int i = 0; i < 1000; i++)
             {
                 bool result = Prob(number);
                 if (result == true)
                 {
                     ct++;
                 }
             }
             Console.WriteLine("True bolo: "+ct+"x");
         }

         public static bool Prob(Random number)
         {
             int randomNumber = number.Next(0, 101);
             if (randomNumber < 73)
             {
                 return true;
             }
             return false;
         }*/

        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            var femaleFirstNames = new List<string>
            {

                "Anna", "Mária", "Katarína", "Zuzana", "Lucia", "Kristína", "Monika", "Veronika", "Lenka", "Petra",
                "Michaela", "Eva", "Jana", "Jarmila", "Martina", "Barbora", "Adriana", "Alexandra", "Alžbeta", "Alica",
                "Daniela", "Diana", "Dominika", "Natália", "Nikola", "Nikoleta", "Silvia", "Simona", "Ivana", "Iveta",
                "Ingrid", "Renáta", "Gabriela", "Miriam", "Pavlína", "Laura", "Karolína", "Klára", "Tatiana", "Tereza",
                "Beáta", "Bianka", "Rebeka", "Nela", "Ema", "Ela", "Tamara", "Viktória", "Zora", "Žaneta"
            };

            var maleFirstNames = new List<string>
            {
                "Peter", "Martin", "Jozef", "Tomáš", "Lukáš", "Jakub", "Michal", "Marek", "Andrej", "Anton",
                "Samuel", "Dominik", "Richard", "Róbert", "Roman", "Patrik", "Filip", "Juraj", "Karol", "Daniel",
                "Dávid", "Adam", "Erik", "Igor", "Ivan", "Ľubomír", "Pavol", "Stanislav", "Štefan", "Matej",
                "Matúš", "Vladimír", "Viliam", "Radovan", "Rastislav", "Šimon", "Sebastián", "Eduard", "Marián", "Gabriel",
                "Tobiáš", "Boris", "Alan", "Oliver", "Oskar", "Leonard", "Viktor", "Alex", "Benjamin", "Tadeáš"
            };
            var femaleSurnamesSk = new List<string>
            {
                "Nováková", "Horváthová", "Kováčová", "Vargová", "Tóthová", "Nagyová", "Molnárová", "Szabóová", "Lukáčová", "Kučerová",
                "Poláková", "Kráľová", "Urbanová", "Krajčíová", "Kováčiková", "Kubišová", "Holubová", "Benková", "Blašková", "Mareková",
                "Tomášová", "Balážová", "Farkašová", "Bartošová", "Šimková", "Pavlíková", "Michalíková", "Černáková", "Švecová", "Ševčíková",
                "Juríková", "Hrušková", "Chovancová", "Rácová", "Hudáková", "Ondrušová", "Sokolová", "Pospíšilová", "Gašparová", "Gregorová",
                "Valentová", "Ďuricová", "Ďurišová", "Vavrová", "Žáková", "Koreňová", "Červeňová", "Šramková", "Mrázová", "Mrvová"
            };

            var maleSurnamesSk = new List<string>
            {
            "Novák","Horváth","Kováč","Varga","Tóth","Nagy","Molnár","Szabó","Lukáč","Kučera",
           "Polák","Kráľ","Urban","Krajčí","Kováčik","Kubiš","Holub","Benko","Blaško","Marek",
            "Tomáš","Baláž","Farkaš","Bartoš","Šimko","Pavlík","Michalík","Černák","Švec","Ševčík",
            "Jurík","Hruška","Chovanec","Rác","Hudák","Ondruš","Sokol","Pospíšil","Gašpar","Gregor",
            "Valent","Ďurica","Ďuriš","Vavro","Žák","Koreň","Červeň","Šramko","Mráz","Mrva"
            };
            Random r  = new Random();
            string fFirst = GetRandomString(femaleFirstNames, r);
            string fLast = GetRandomString(femaleSurnamesSk, r);
            string mFirst = GetRandomString(maleFirstNames, r);
            string mLast = GetRandomString(maleSurnamesSk, r) ;

            Person zena = new Person(fFirst,fLast);
            Person muz = new Person(mFirst,mLast);

            zena.VypisSa();
            muz.VypisSa();
            
            Console.WriteLine("Ženské meno: " + fFirst +" "+fLast);
            Console.WriteLine("Mužské meno: " + mFirst + " "+mLast);
        }

        public static string GetRandomString(List<string> strings,
            Random r)
            
        {
            
            int count = strings.Count;
            int index = r.Next(count);
            string name = strings[index];
            return name;
            
        }
    }
}