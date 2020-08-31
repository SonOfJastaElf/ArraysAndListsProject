using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            var baseArray = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var evens = new List<int>();

            var odds = new List<int>();

            foreach (var num in baseArray)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            foreach (var num in evens)
            {
                Console.WriteLine(num);
            }

            foreach (var num in odds)
            {
                Console.WriteLine(num);
            }
        }
    }
}
