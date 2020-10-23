using System;
using System.Collections.Generic;
namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO:

            // Create an int Array and populate numbers 1-10
            var newArr = new int[10];
            for (var i = 0; i<newArr.Length; i++) {
                newArr[i] = i+1;
            }
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (var num in newArr) {
                if (num % 2 != 0) {
                    odds.Add(num);
                } else
                {
                    evens.Add(num);
                }
            }
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            foreach(var number in odds)
            {
                Console.WriteLine(number);
            }
            foreach (var number in evens)
            {
                Console.WriteLine(number);
            }
        }
    }
}
