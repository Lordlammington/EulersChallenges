using NUnit.Framework;
using Challenges;
using ProjectEuler.Challenges;

namespace Challenges1To10
{
    [TestFixture]
    class Challenge3Test
    {
        //13195 are 5, 7, 13 and 29.
        [Test]
        public void FactorOfFirst10Primes()
        {
            Challenge3 challenge3 = new Challenge3();
            challenge3.InputNumber = 13195;
            Assert.AreEqual(29, challenge3.RunChallenge());
        }
    }
}
