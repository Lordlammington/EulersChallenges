using System.Linq;
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
        public void Test10thFibbonacci()
        {
            FibonacciSequence fib = new FibonacciSequence();
            int result = fib.Take(9).Last();
            Assert.AreEqual(55, result);
        }

        [Test]
        public void Test20thFibbonacci()
        {
            FibonacciSequence fib = new FibonacciSequence();
            int result = fib.Take(19).Last();
            Assert.AreEqual(6765, result);
        }


    }
}
