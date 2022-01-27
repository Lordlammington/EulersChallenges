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
    class Challenge15Test
    {
        [Test]
        public void SizeTwoSquareNavigation()
        {
            Challenge15 challenge = new Challenge15();
            challenge._SizeOfSquare = 2;
            Assert.AreEqual(6, challenge.RunChallenge());
        }


        [Test]
        public void SizeTwentySquareNavigation()
        {
            Challenge15 challenge = new Challenge15();
            challenge._SizeOfSquare = 20;
            Assert.AreEqual(137846528820, challenge.RunChallenge());
        }
    }
}
