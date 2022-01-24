using System.Linq;
using NUnit.Framework;
using Challenges;
using ProjectEuler;
using Enumerators;

namespace EnumeratorTests
{
    [TestFixture]
    class ThreeDigitProductsTest
    {
        [Test]
        public void TestFirstNumber()
        {
            //First Number should be 10000 ( 100 * 100 )
            Assert.AreEqual(10000, ThreeDigitProducts.Sequence().Min());
        }

        [Test]
        public void TestLastNumber()
        {
            //First Number should be 99801 ( 999 * 999 )
            Assert.AreEqual(998001, ThreeDigitProducts.Sequence().Max());
        }
    }
}