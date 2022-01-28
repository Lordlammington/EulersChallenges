using NUnit.Framework;
using ProjectEuler.Challenges;

namespace Challenges11To20
{
    [TestFixture]
    public class Challenge13Test
    {
        [Test]
        public void First10DigitsOfNumber()
        {
            Challenge13 challenge13 = new Challenge13();
            challenge13._howManyFirstDigits = 10;
            Assert.AreEqual(5537376230, challenge13.RunChallenge());
        }
    }
}