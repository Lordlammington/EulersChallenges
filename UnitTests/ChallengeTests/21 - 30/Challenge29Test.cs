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
    class Challenge29Test
    {
        [Test]
        public void OneHundred()
        {
            Challenge29 challenge = new Challenge29();
            challenge.Ceiling = 100;
            Assert.AreEqual(9183, challenge.RunChallenge());
        }

        [Test]
        public void Five()
        {
            Challenge29 challenge = new Challenge29();
            challenge.Ceiling = 5;
            Assert.AreEqual(15, challenge.RunChallenge());
        }
    }
}