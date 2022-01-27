using Challenges;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges11To20
{
    [TestFixture]
    class Challenge17Test
    {
        [Test]
        public void NumberLetterCountsTo5()
        {
            Challenge17 challenge = new Challenge17();
            challenge._CalculateInclusive = 5;
            Assert.AreEqual(19, challenge.RunChallenge());
        }
        [Test]
        public void NumberLetterCountsTo1000()
        {
            Challenge17 challenge = new Challenge17();
            challenge._CalculateInclusive = 1000;
            Assert.AreEqual(21124, challenge.RunChallenge());
        }
    }
}
