using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Challenges;
using ProjectEuler.Challenge1;


namespace EulerChallengeUnitTests.C1_UnitTest
{
    [TestFixture]
    class EnumeratorTest
    {
        [Test]
        public void TestMultiples()
        {
            NaturalNumbers shanes = new NaturalNumbers();

            int shanes123rdnumber = shanes.Skip(4).First();
            
            Assert.AreEqual(123, shanes123rdnumber);

        }
    }
}
