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
    class Challenge21Test
    {
        [Test]
        public void Amicable()
        {
            Challenge21 challenge = new Challenge21();
            Assert.AreEqual(10, challenge.RunChallenge());
        }
    }
}
