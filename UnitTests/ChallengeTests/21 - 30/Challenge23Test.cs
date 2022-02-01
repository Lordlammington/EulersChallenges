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
    class Challenge23Test
    {
        [Test]
        public void NonAbundantSums()
        {
            Challenge23 challenge = new Challenge23();
            Assert.AreEqual(10, challenge.RunChallenge());
        }
    }
}
