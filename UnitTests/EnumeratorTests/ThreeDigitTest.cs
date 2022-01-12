using System.Linq;
using Challenges;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEuler
{
    [TestFixture]
    class ThreeDigitProductsTest
    {
        [Test]
        public void TestFirstNumber()
        {
            //First Number should be 10000 ( 100 * 100 )
            ThreeDigitMultiplyProducts threeDigitMultiply = new ThreeDigitMultiplyProducts();
            Assert.AreEqual(10000, threeDigitMultiply.First());
        }

        [Test]
        public void TestLastNumber()
        {
            //First Number should be 99801 ( 999 * 999 )
            ThreeDigitMultiplyProducts threeDigitMultiply = new ThreeDigitMultiplyProducts();
            Assert.AreEqual(998001, threeDigitMultiply.Last());
        }
    }
}