using NUnit.Framework;
using FizzBuzz;
using System.Collections.Generic;

namespace FizzBuzzTest
{
    public class Tests
    {
        private readonly List<string> fizzBuzzList = FizzBuzz.FizzBuzz.CreateFizzBuzzList();

        [Test]
        public void MatchesSquence_GivenFirst15IndexesOfFizzBuzzSequence_ReturnsTrue()
        {
            var sequenceToCheck = fizzBuzzList.GetRange(0, 15);
            var result = FizzBuzz.FizzBuzz.MatchesSequence(sequenceToCheck);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsCorrectLength_GivenFullFizzBuzzSequence_ReturnsTrue()
        {
            var result = FizzBuzz.FizzBuzz.IsCorrectLength(fizzBuzzList);
            Assert.That(result, Is.True);
        }
    }
}
