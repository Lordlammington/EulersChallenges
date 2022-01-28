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
    class Challenge18Test
    {
        [Test]
        public void TrianglePaths()
        {
            Challenge18 challenge = new Challenge18();
            Assert.AreEqual(10, challenge.RunChallenge());
        }
    }
}