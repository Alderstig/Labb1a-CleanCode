using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class ThrowSampleTests
    {
        [Test]
        public void MethodThatThrowsException_Runs_ThrowsArgumentException()
        {
            ClassForTesting throwSample = new();

            Assert.Throws<ArgumentException>(throwSample.MethodThatThrowsException);
        }
    }
}