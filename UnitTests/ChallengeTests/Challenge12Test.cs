using NUnit.Framework;
using ProjectEuler.Challenges;


namespace ChallengeTests
{
    [TestFixture]
    public class Challenge12Test
    {
        [Test]
        public void TriangleNumberWith5Divisors()
        {
            Challenge12 challenge12 = new Challenge12();
            challenge12._UpToDivisors = 5;
            Assert.AreEqual(28, challenge12.RunChallenge());
        }

        [Test]
        public void TriangleNumberWith50Divisors()
        {
            Challenge12 challenge12 = new Challenge12();
            challenge12._UpToDivisors = 50;
            Assert.AreEqual(25200, challenge12.RunChallenge());
        }

        [Test]
        public void TriangleNumberWith500Divisors()
        {
            Challenge12 challenge12 = new Challenge12();
            challenge12._UpToDivisors = 500;
            Assert.AreEqual(28, challenge12.RunChallenge());
        }
    }
}