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
    class Challenge20Test
    {
        [Test]
        public void FalctorialOf10Digits()
        {
            Challenge20 challenge = new Challenge20();
            challenge._FactorialDigits = 10;
            Assert.AreEqual(27, challenge.RunChallenge());
        }

        [Test]
        public void FalctorialOf100Digits()
        {
            Challenge20 challenge = new Challenge20();
            challenge._FactorialDigits = 100;
            Assert.AreEqual(648, challenge.RunChallenge());
        }
    }
}
