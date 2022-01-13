using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Challenges
{
    [TestFixture]
    class Challenge8Test
    {
        [Test]
        public void Test4Adjacents()
        {
            Challenge8 challenge8 = new Challenge8();
            challenge8._NumberOfAdjacents = 4;
            Assert.AreEqual(5832, challenge8.RunChallenge());
        }
    }
}
