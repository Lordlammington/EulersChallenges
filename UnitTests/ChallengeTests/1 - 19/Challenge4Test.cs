using NUnit.Framework;
using Challenges;

namespace Challenges1To10
{
    [TestFixture]
    class Challenge4Test
    {
        [Test]
        public void TestPallindromeTrue()
        {
            Challenge4 challenge4 = new Challenge4();
            Assert.IsTrue(challenge4.IsPalindrome(10001));
        }

        [Test]
        public void TestPallindromeFalse()
        {
            Challenge4 challenge4 = new Challenge4();
            Assert.IsFalse(challenge4.IsPalindrome(10002));
        }
    }
}
