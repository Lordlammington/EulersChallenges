using Challenges;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges21To30
{
    [TestFixture]
    class Challenge28Test
    {

        [Test]
        public void FiveGridSize()
        {
            Challenge28 challenge = new Challenge28();
            challenge.sizeofGrid = 5;
            Assert.AreEqual(101, challenge.RunChallenge());
        }

        [Test]
        public void OneThousandGridsize()
        {
            Challenge28 challenge = new Challenge28();
            challenge.sizeofGrid = 1001;
            Assert.AreEqual(669171001, challenge.RunChallenge());
        }
    }
}
