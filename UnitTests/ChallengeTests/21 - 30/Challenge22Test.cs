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
    class Challenge22Test
    {
        [Test]
        public void Amicable()
        {
            Challenge22 challenge = new Challenge22();
            Assert.AreEqual(10, challenge.RunChallenge());
        }
    }
}
