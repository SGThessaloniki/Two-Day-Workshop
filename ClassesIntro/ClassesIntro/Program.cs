using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIntro
{

    class Program
    {
        static void Main(string[] args)
        {

            List<int> al = new List<int>();
            al.Add(4);
            al.Add(5);
            al.Add(4);
            
            int sum = 0;
            for (int i = 0; i < al.Count; i++)
            {
                sum += al[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }

        //static IEnumerable<int> Lala()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {

        //        yield return i * 2;
        //    }
        //}

        private static void NewMethod()
        {
            string name = "Orfeas";
            int age = 20;

            Console.WriteLine("The name of the person is: " + name + " the age of the person is " + age);

            Person myPerson = new Person();
            int x = myPerson.Age;
            Console.WriteLine("The age is: " + x);

            Person secondPerson = new Person("Kwstas", 20);

            Console.WriteLine(secondPerson.Age);

            secondPerson.Talk();

            Person.DoSomething();
        }

        class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }


            private string job = "Developer";


            public Person()
            {
                Age = 10;
            }

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public void Talk()
            {
                Console.WriteLine("Person is now talking");
            }

            public static void DoSomething()
            {
                Console.WriteLine("Doing something...");
            }

        }
    }
}
