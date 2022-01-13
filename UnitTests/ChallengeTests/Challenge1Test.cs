using NUnit.Framework;
using Challenges;

namespace Challenges
{
    [TestFixture]
    class Challenge1Test
    {
        [Test]
        public void TestMultiples()
        {

            Challenge1 challenge1 = new Challenge1();
            challenge1.CalculateUntilNotIncluding = 10;

            long result = challenge1.RunChallenge();

            Assert.AreEqual(23, result);
        }

        [Test]
        public void TestResult()
        {

            Challenge1 challenge1 = new Challenge1();
            challenge1.CalculateUntilNotIncluding = 1000;

            long result = challenge1.RunChallenge();

            Assert.AreEqual(233168, result);
        }

    }
}
