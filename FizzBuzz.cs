using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static List<string> CreateFizzBuzzList()
        {
            var fizzBuzzList = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzBuzzList.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    fizzBuzzList.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    fizzBuzzList.Add("Buzz");
                }
                else
                {
                    fizzBuzzList.Add(i.ToString());
                }

                continue;
            }

            return fizzBuzzList;
        }
    }
}

