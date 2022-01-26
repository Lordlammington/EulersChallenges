using NUnit.Framework;
using Challenges;

namespace ChallengeTests
{
    [TestFixture]
    class Challenge11Test
    {
        [Test]
        public void Test4Adjacent()
        {
            Challenge11 challenge11 = new Challenge11();
            challenge11._AdjacentsToFind = 4;
            Assert.AreEqual(70600674, challenge11.RunChallenge());
        }
    }
}
