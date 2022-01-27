using NUnit.Framework;
using Challenges;

namespace Challenges1To10
{
    [TestFixture]
    class Challenge2Test
    {
        [Test]
        public void SumOfFirst10FibbOnlyEven()
        {
            Challenge2 challenge2 = new Challenge2();
            //does not Exceed
            challenge2.MaxFibbValue = 90;

            Assert.AreEqual(44, challenge2.RunChallenge());

        }

    }
    
}
