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
    class Challenge24Test
    {
        [Test]
        public void Template()
        {
            Challenge24 challenge = new Challenge24();
            Assert.AreEqual(10, challenge.RunChallenge());
        }
    }
}
