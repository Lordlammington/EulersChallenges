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
    class Challenge26Test
    {
        [Test]
        public void ReciprocalCycles()
        {
            Challenge26 challenge = new Challenge26();
            Assert.AreEqual(983, challenge.RunChallenge());
        }
    }
}
