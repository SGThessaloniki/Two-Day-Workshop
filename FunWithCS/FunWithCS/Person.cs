using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCS
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }


        public static List<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person()
                { Age = 30, Name="Dimitris"},
                new Person()
                { Age = 21, Name="Hlektra"},
                new Person()
                { Age = 32, Name="Kostas"},
                new Person()
                { Age = 54, Name="Orfeas"}
            };
            
        }
    }
}
