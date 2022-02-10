using System.Linq;
using NUnit.Framework;
using Enumerators;
using Challenges;
using ProjectEuler;

namespace EnumeratorTests
{
    [TestFixture]
    class NaturalNumberEnumTest
    {
        [Test]
        public void TestMultiples()
        { 

            long the123rdnumber = NaturalNumbers.Sequence().Skip(122).First();
            
            Assert.AreEqual(123, the123rdnumber);

        }
    }
}
