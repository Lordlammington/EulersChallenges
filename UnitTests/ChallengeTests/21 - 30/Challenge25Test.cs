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
    class Challenge25Test
    {
        [Test]
        public void Template()
        {
            Challenge25 challenge = new Challenge25();
            Assert.AreEqual(10, challenge.RunChallenge());
        }
    }
}
