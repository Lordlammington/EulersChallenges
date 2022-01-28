using Challenges;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges11To20
{
    [TestFixture]
    class Challenge19Test
    {
        [Test]
        public void Sundaysin100Years()
        {

        Challenge19 challenge = new Challenge19();

        challenge._StartDate = new DateTime(1901, 1, 1);
        challenge._EndDate = new DateTime(2000, 12, 31);

            Assert.AreEqual(171, challenge.RunChallenge());
        }

        [Test]
        public void Sundaysin1Year()
        {

            Challenge19 challenge = new Challenge19();

            challenge._StartDate = new DateTime(2020, 1, 1);
            challenge._EndDate = new DateTime(2020, 12, 31);

            Assert.AreEqual(2, challenge.RunChallenge());
        }
    }
}
