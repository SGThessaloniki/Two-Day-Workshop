using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCS
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> persons = Person.GetPersons();

            //IEnumerable<Person>
            //    persons2 =
            //    persons.Where(x => x.Age < 40);

            IEnumerable<Person> persons2 = from x in persons
                                           where x.Age < 40
                                           select x;

            foreach (Person item in persons2)
            {
                Console.WriteLine(item.Name);
            }



            var persons3 = from x in persons
                           where x.Age < 40
                           select new
                           {
                               Name = x.Name.ToUpper(),
                               DOB =
                               DateTime.Now.Subtract
                               (TimeSpan.FromDays(365 * x.Age))
                           };

            foreach (var item in persons3)
            {
                Console.WriteLine(item.DOB);
            }

            Console.ReadLine();
        }



        private static void NewMethod1()
        {
            Car car = new Car();
            //car.CarSpeedLimitReached += car_CarSpeedLimitReached;

            //car.CarSpeedLimitReached +=
            //    delegate(string x)
            //    { Console.WriteLine(x); };


            car.CarSpeedLimitReached +=
                x => Console.WriteLine(x);

            for (int i = 0; i < 11; i++)
            {
                car.Accelerate();
                Console.WriteLine(car.Speed);
            }
        }

        static void car_CarSpeedLimitReached(string msg)
        {
            Console.WriteLine(msg);
        }

        private static void NewMethod()
        {
            MyDel mydel = new MyDel(Sum);
            int w = mydel(3, 2);
            mydel += Subtract;
            int y = mydel(4, 5);
            Console.WriteLine(y);

            Lala("asasa", mydel);
        }

        static void Lala(string msg, MyDel del)
        {
            Console.WriteLine(msg);
            del(1, 2);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }


    delegate int MyDel(int x, int y);
}
