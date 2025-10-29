using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie_objekty
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Bydlisko { get; set; }

        public char Sex { get; set; }

        public bool IsAdult()
        {
            if (Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddName(string surname)
        {
            Name += surname;
        }

        public string VypisInfo()
        {

            string vypis = Name + " " + Age + " " + Bydlisko + " " + Sex + " " + IsAdult;

            return vypis;
            

        }


    }
}
