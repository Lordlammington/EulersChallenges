using System.Linq;
using NUnit.Framework;

namespace ProjectEuler
{
    [TestFixture]
    class PrimeNumberEnumTest
    {
        [Test]
        public void FifthPrimeNumber()
        {
            PrimeNumbers prime = new PrimeNumbers();
            Assert.AreEqual(11, prime.Take(5).Last());
        }
    }
}
