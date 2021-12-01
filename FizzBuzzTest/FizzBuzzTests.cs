using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzTest
{
    public class FizzBuzzTests
    {
        private List<string> _fizzBuzzList;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzList = FizzBuzz.FizzBuzz.CreateFizzBuzzList();
        }

        [Test]
        public void MatchesSquence_GivenFirst15IndexesOfFizzBuzzSequence_ReturnsTrue()
        {
            var sequenceToCheck = _fizzBuzzList.GetRange(0, 15);
            var result = MatchesSequence(sequenceToCheck);
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsCorrectLength_GivenFizzBuzzSequenceOfZeroToOneHundred_ReturnsTrue()
        {
            var result = IsCorrectLength(_fizzBuzzList);
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

        private static bool MatchesSequence(List<string> list)
        {
            var correctFizzBuzzSequenceTo15 = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            if (list.SequenceEqual(correctFizzBuzzSequenceTo15))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsCorrectLength(List<string> list)
        {
            var correctLength = 100;

            if (list.Count == correctLength)
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

