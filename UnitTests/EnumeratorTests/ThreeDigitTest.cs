using System.Linq;
using Challenges;
using NUnit.Framework;

namespace ProjectEuler.Challenge3
{
    [TestFixture]
    class C3_Unit_Test
    {
        [Test]
        public void TestFactor()
        {
            Challenge7 challenge3 = new Challenge7();
            //Call Function with an input of 13195 i expect an output of 29

            challenge3.InputNumber = 13195;
            Assert.AreEqual(29, challenge3.RunChallenge());
        }
    }
}