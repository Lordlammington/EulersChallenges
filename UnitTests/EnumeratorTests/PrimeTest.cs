using System.Linq;
using NUnit.Framework;
using Challenges;
using ProjectEuler;
using Enumerators;

namespace EnumeratorTests
{
    [TestFixture]
    class PrimeNumberEnumTest
    {
        [Test]
        public void FifthPrimeNumber()
        {
            Assert.AreEqual(11, PrimeNumbers.Sequence().Take(5).Last());
        }
    }
}
