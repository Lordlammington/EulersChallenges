using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using NUnit.Framework;
using Challenges;
using ProjectEuler;
using Enumerators;

namespace EnumeratorTests
{
    [TestFixture]
    public class FibbonacciEnumTest
    {
        [Test]
        public void Test50thFibonacci()
        {
            long result = (long)Fibonacci.Sequence().Take(50).Last();
            Assert.AreEqual(12586269025, result);
        }

        [Test]
        public void Test20thFibonacci()
        {
            long result = (long)Fibonacci.Sequence().Take(20).Last();
            Assert.AreEqual(6765, result);
        }

        [Test]
        public void First12Fibonacci()
        {
            IEnumerable<BigInteger> expected = new BigInteger[] {1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144};
            IEnumerable<BigInteger> result = Fibonacci.Sequence().Take(12);

            Assert.AreEqual(expected, result);
        }
    }
}
