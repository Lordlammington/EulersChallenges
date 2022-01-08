using NUnit.Framework;
using Challenges;

namespace ProjectEuler.Challenge1
{
    [TestFixture]
    class Challenge1Test
    {
        [Test]
        public void TestMultiples()
        {

            Challenges.Challenge1 challenge1 = new Challenges.Challenge1();
            challenge1.CalculateUntilNotIncluding = 10;

            int result = challenge1.RunChallenge();

            Assert.AreEqual(23, result);
        }

        [Test]
        public void TestResult()
        {

            Challenges.Challenge1 challenge1 = new Challenges.Challenge1();
            challenge1.CalculateUntilNotIncluding = 1000;

            int result = challenge1.RunChallenge();

            Assert.AreEqual(233168, result);
        }

    }
}
