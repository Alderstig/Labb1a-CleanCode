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
            var firstIndexOfFizz = 2;
            Assert.Equals(_fizzBuzzList[firstIndexOfFizz], "Fizz");
        }

        [Test]
        public void CreateFizzBuzzList_GivenFizzBuzzSequenceOfZeroToOneHundred_ReturnsTrueIfBuzz()
        {
            var firstIndexOfBuzz = 4;
            Assert.Equals(_fizzBuzzList[firstIndexOfBuzz], "Buzz");
        }

        [Test]
        public void CreateFizzBuzzList_GivenFizzBuzzSequenceOfZeroToOneHundred_ReturnsTrueIfFizzBuzz()
        {
            var firstIndexOfFizzBuzz = 14;
            Assert.Equals(_fizzBuzzList[firstIndexOfFizzBuzz], "FizzBuzz");
        }

        [Test]
        public void CreateFizzBuzzList_GivenFizzBuzzSequenceOfZeroToOneHundred_ReturnsTrueIfNumber()
        {
            var firstIndexOfNUmber = 0;
            var extractedIndex = _fizzBuzzList[firstIndexOfNUmber];
            var IsNumber = int.TryParse(extractedIndex, out _); 
            Assert.IsTrue(IsNumber);
        }
    }
}

