using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static List<string> CreateFizzBuzzList()
        {
            var FizzBuzzList = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    FizzBuzzList.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    FizzBuzzList.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    FizzBuzzList.Add("Buzz");
                }
                else
                {
                    FizzBuzzList.Add(i.ToString());
                }

                continue;
            }

            return FizzBuzzList;
        }

        public static bool MatchesSequence(List<string> list)
        {
            var correctFizzBuzzSequenceTo15 = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            if(list.SequenceEqual(correctFizzBuzzSequenceTo15))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsCorrectLength(List<string> list)
        {
            var correctLength = 100;

            if(list.Count == correctLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

