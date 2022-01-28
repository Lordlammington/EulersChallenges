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
    class Challenge14Test
    {
        [Test]
        public void LongestSequenceBelow10()
        {
            Challenge14 challenge14 = new Challenge14();
            challenge14._InputNumber = 10;
            //The longest collatz conjecture below 10 is 9, with 19 steps - Wikipedia.
            Assert.AreEqual(9, challenge14.RunChallenge());
        }

        [Test]
        public void LongestSequenceBelow1000000()
        {
            Challenge14 challenge14 = new Challenge14();
            challenge14._InputNumber = 1000000;
            //The longest collatz conjecture below 1000000 is ...
            Assert.AreEqual(837799, challenge14.RunChallenge());
        }

    }
}
