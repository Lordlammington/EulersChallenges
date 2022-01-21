using NUnit.Framework;
using ProjectEuler.Challenges;

namespace ChallengeTests
{
    [TestFixture]
    public class Challenge13Test
    {
        [Test]
        public void TriangleNumberWith5Divisors()
        {
            Challenge13 challenge13 = new Challenge13();
            challenge13._howManyFirstDigits = 10;
            Assert.AreEqual(10, challenge13.RunChallenge());
        }
    }
}