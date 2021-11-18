using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzzTest
{
    public class FizzBuzzTests
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

