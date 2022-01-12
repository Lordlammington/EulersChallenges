using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Challenges;
using ProjectEuler;

namespace ProjectEuler
{
    [TestFixture]
    class NaturalNumberEnumTest
    {
        [Test]
        public void TestMultiples()
        {
            NaturalNumbers natNum = new NaturalNumbers();

            int the123rdnumber = natNum.Skip(122).First();
            
            Assert.AreEqual(123, the123rdnumber);

        }
    }
}
