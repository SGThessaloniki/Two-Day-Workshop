using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            double d = 3.14;
            Console.WriteLine("Hello World!");
            Console.WriteLine(i);
            Console.WriteLine(d);
            Console.WriteLine("This is i: " + i + "this is our double: " + d);
            PrintSum();
            Multiply(3.14, 5.6);
            PrintSum(5, 7);

            //int[] numbers = { 1, 2, 3 };

            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            //numbers[3] = 5;


            Console.WriteLine(numbers[1]);

            Console.WriteLine("This output is after the array of numbers");

            List<int> numbersList = new List<int>();

            numbersList.Add(5);
            Console.WriteLine(numbersList[0]);
            numbersList[0] = 10;
            Console.WriteLine(numbersList[0]);

            int listCount = numbersList.Count;
            Console.WriteLine(listCount);

            numbersList.Add(15);
            listCount = numbersList.Count;
            Console.WriteLine(listCount);

            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine(numbersList[0]);
            }

            foreach (int item in numbersList)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();
        }

        static void PrintSum()
        {
            Console.WriteLine(5 + 10);
        }

        static void PrintSum(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        static void Multiply(double a, double b)
        {
            Console.WriteLine(a * b);
        }
    }
}
