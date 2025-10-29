using System.Threading.Channels;

namespace cvicenie_objekty
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int vek = 20;


            Student student1 = new Student();
            Student student2 = new Student();
            student1.Age = vek;
            student1.Name = "Hugo Gasiorik";
            student1.Bydlisko = "Čadca";
            student1.Sex = 'F';

            student2.Name = "Daniel Cipko";
            student2.Age = 15;
            student2.Bydlisko = "Kysucke Nove Mesto";
            student2.Sex = 'M';

            Student starystudent = student1;
            starystudent.Name = "Peter Novak";
            Console.WriteLine(starystudent.Name);
            Console.WriteLine(student1.IsAdult());

            student2.AddName(" Novak ");
            Console.WriteLine(student2.AddName);

            student1.VypisInfo();
            Console.WriteLine(student1.VypisInfo());






        }
    }
}


