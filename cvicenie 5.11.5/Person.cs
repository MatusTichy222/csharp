using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie_5._11._5
{
    public class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public Person(string nameParam, string surnameParam)
        {
            name = nameParam;
            surname = surnameParam;

        }
        public void VypisSa()
        {
            Console.WriteLine("Volam sa: "+name+" "+surname);
        }
    }

}

