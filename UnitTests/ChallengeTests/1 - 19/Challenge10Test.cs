using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Challenges;

namespace ChallengeTests
{
    [TestFixture]
    class Challenge10Test
    {
        [Test]
        public void SumOfPrimesBelow10()
        {
            Challenge10 challenge10 = new Challenge10();
            challenge10._CountUpTo = 10;
            Assert.AreEqual(17, challenge10.RunChallenge());
        }

        [Test]
        public void SumOfPrimesBelow2Million()
        {
            Challenge10 challenge10 = new Challenge10();
            challenge10._CountUpTo = 2000000;
            Assert.AreEqual(142913828922, challenge10.RunChallenge());
        }


    }
}
