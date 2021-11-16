using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var FizzBuzzDict = FizzBuzz.CreateFizzBuzzList();

            foreach(var item in FizzBuzzDict)
            {
                Console.WriteLine($"{item} ");
            }
        }
    }
}

