using NUnit.Framework;
using Challenges;

namespace ChallengeTests
{
    [TestFixture]
    class Challenge8Test
    {
        [Test]
        public void Test4Adjacents()
        {
            Challenge8 challenge8 = new Challenge8();
            challenge8._NumberOfAdjacents = 4;
            Assert.AreEqual(5832, challenge8.RunChallenge());
        }

        [Test]
        public void Test13Adjacents()
        {
            Challenge8 challenge8 = new Challenge8();
            challenge8._NumberOfAdjacents = 13;
            Assert.AreEqual(100, challenge8.RunChallenge());
        }
    }
}
