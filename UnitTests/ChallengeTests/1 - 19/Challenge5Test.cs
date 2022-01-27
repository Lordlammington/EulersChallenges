using NUnit.Framework;
using Challenges;

namespace Challenges1To10
{
    [TestFixture]
    class Challenge5Test
    {
        //13195 are 5, 7, 13 and 29.
        [Test]
        public void LargestDivisorOf10natNums()
        {

            Challenge5 challenge = new Challenge5();
            challenge._Divisors = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.AreEqual(2520, challenge.RunChallenge());
        }
    }
}
