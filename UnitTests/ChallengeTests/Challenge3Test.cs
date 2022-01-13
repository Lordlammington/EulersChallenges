using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace Challenges
{
    [TestFixture]
    class Challenge3Test
    {
        //13195 are 5, 7, 13 and 29.
        [Test]
        public void FactorOfFirst10Primes()
        {
            Challenge3 challenge3 = new Challenge3();
            challenge3.InputNumber = 13195;
            Assert.AreEqual(29, challenge3.RunChallenge());
        }
    }
}
