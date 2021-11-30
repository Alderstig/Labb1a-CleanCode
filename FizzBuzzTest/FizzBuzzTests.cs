using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzzTest
{
    public class FizzBuzzTests
    {
        private readonly List<string> _fizzBuzzList;

        public FizzBuzzTests()
        {
            _fizzBuzzList = FizzBuzz.FizzBuzz.CreateFizzBuzzList();
        }

        [Test]
        public void MatchesSquence_GivenFirst15IndexesOfFizzBuzzSequence_ReturnsTrue()
        {
            var sequenceToCheck = _fizzBuzzList.GetRange(0, 15);
            var result = FizzBuzz.FizzBuzz.MatchesSequence(sequenceToCheck);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsCorrectLength_GivenFizzBuzzSequenceOfZeroToOneHundred_ReturnsTrue()
        {
            var result = FizzBuzz.FizzBuzz.IsCorrectLength(_fizzBuzzList);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CreateFizzBuzzList_GivenFizzBuzzSequenceOfZeroToOneHundred_ReturnsTrueIfFizz()
        {
            var firstInstanceOfFizzAtIndex = 2;
            Assert.Equals(_fizzBuzzList[firstInstanceOfFizzAtIndex], "Fizz");
        }

        [Test]
        public void CreateFizzBuzzList_GivenFizzBuzzSequenceOfZeroToOneHundred_ReturnsTrueIfBuzz()
        {
            var firstInstanceOfBuzzAtIndex = 4;
            Assert.Equals(_fizzBuzzList[firstInstanceOfBuzzAtIndex], "Buzz");
        }

        [Test]
        public void CreateFizzBuzzList_GivenFizzBuzzSequenceOfZeroToOneHundred_ReturnsTrueIfFizzBuzz()
        {
            var firstInstanceOfFizzBuzzAtIndex = 14;
            Assert.Equals(_fizzBuzzList[firstInstanceOfFizzBuzzAtIndex], "FizzBuzz");
        }

        [Test]
        public void CreateFizzBuzzList_GivenFizzBuzzSequenceOfZeroToOneHundred_ReturnsTrueIfFirstIndexIsNumber()
        {
            var firstInstanceOfNumberAtIndex = 0;
            var extractedIndex = _fizzBuzzList[firstInstanceOfNumberAtIndex];
            var IsNumber = int.TryParse(extractedIndex, out _); 
            Assert.IsTrue(IsNumber);
        }
    }
}

