using Challenges;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTests
{
    [TestFixture]
    class Challenge16Test
    {
        [Test]
        public void TwoToThePowerOf15()
        {
            Challenge16 challenge = new Challenge16();
            challenge._ToThePowerOf = 15;
            Assert.AreEqual(26, challenge.RunChallenge());
        }
        [Test]
        public void TwoToThePowerOf1000()
        {
            Challenge16 challenge = new Challenge16();
            challenge._ToThePowerOf = 1000;
            Assert.AreEqual(1366, challenge.RunChallenge());
        }
    }
}
