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
            long result = Fibonacci.Sequence().Take(9).Last();
            Assert.AreEqual(55, result);
        }

        [Test]
        public void Test20thFibbonacci()
        {
            long result = Fibonacci.Sequence().Take(19).Last();
            Assert.AreEqual(6765, result);
        }
    }
}
