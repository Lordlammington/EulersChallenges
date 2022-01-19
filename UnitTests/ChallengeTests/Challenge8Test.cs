using System;
using NUnit.Framework;
using Challenges;
using ProjectEuler.Challenges;

namespace ChallengeTests
{
    [TestFixture]
    class Challenge8Test
    {
        [Test]
        public void Test4Adjacents()
        {
            Challenge8 challenge8 = new Challenge8();
            challenge8.NumberOfAdjacent = 4;
            Assert.AreEqual(5832, challenge8.RunChallenge());
        }

        [Test]
        public void Test13Adjacents()
        {
            Challenge8 challenge8 = new Challenge8();
            challenge8.NumberOfAdjacent = 13;
            Assert.AreEqual(23514624000, challenge8.RunChallenge());
        }

        [Test]
        public void Test20Adjacents()
        {
            Challenge8 challenge8 = new Challenge8();
            challenge8.NumberOfAdjacent = 20;
            Assert.AreEqual(240789749760000, challenge8.RunChallenge());
        }
    }
}
