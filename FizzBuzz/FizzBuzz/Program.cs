using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        // creating a function to produce random numebrs
        public static List<int> GetInt()
        {
            var List = new List<int>();

            // creating the for loop that will count from 1 - 100 to build the list
            for(var i = 1; i <= 100; i++)
            {
                List.Add(i);
            }
            return List;
        }

        public static void FizzBuzz(List<int> List) // public means its publicly available. Static means we can refernce this method. Void means we wont return anything. 
        {
            foreach(var item in List)
            {
                if (item % 3 == 0 && item % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (item % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (item % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                    Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            var List = GetInt();
            FizzBuzz(List);
        }
    }
}
