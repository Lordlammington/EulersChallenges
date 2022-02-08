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
    class Challenge27Test
    {
        [Test]
        public void ABNThing()
        {
            Challenge27 challenge = new Challenge27();
            Assert.AreEqual(-59231, challenge.RunChallenge());
        }
    }
}
