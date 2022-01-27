using Challenges;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTemplate
{
    [TestFixture]
    class ChallengeXXTest
    {
        [Test]
        public void Template()
        {
            ChallengeXX challenge = new ChallengeXX();
            Assert.AreEqual(0, challenge.RunChallenge());
        }
    }
}
