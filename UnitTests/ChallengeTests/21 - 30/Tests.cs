using Challenges;
using NUnit.Framework;

namespace Challenges21To30
{
    [TestFixture]
    class Challenge21Test
    {
        [Test]
        public void Amicable()
        {
            Challenge21 challenge = new Challenge21();
            Assert.AreEqual(31626, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge22Test
    {
        [Test]
        public void NameScores()
        {
            Challenge22 challenge = new Challenge22();
            Assert.AreEqual(871198282, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge23Test
    {
        [Test]
        public void NonAbundantSums()
        {
            Challenge23 challenge = new Challenge23();
            Assert.AreEqual(4179871, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge24Test
    {
        [Test]
        public void Template()
        {
            Challenge24 challenge = new Challenge24();
            Assert.AreEqual(10, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge25Test
    {
        [Test]
        public void Template()
        {
            Challenge25 challenge = new Challenge25();
            Assert.AreEqual(4782, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge26Test
    {
        [Test]
        public void ReciprocalCycles()
        {
            Challenge26 challenge = new Challenge26();
            Assert.AreEqual(983, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge27Test
    {
        [Test]
        public void ABNThing()
        {
            Challenge27 challenge = new Challenge27();
            Assert.AreEqual(-59231, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge28Test
    {

        [Test]
        public void FiveGridSize()
        {
            Challenge28 challenge = new Challenge28();
            challenge.sizeofGrid = 5;
            Assert.AreEqual(101, challenge.RunChallenge());
        }

        [Test]
        public void OneThousandGridsize()
        {
            Challenge28 challenge = new Challenge28();
            challenge.sizeofGrid = 1001;
            Assert.AreEqual(669171001, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge30Test
    {
        [Test]
        public void ExponentisFour()
        {
            Challenge30 challenge = new Challenge30();
            challenge._exponent = 4;
            Assert.AreEqual(19316, challenge.RunChallenge());
        }

        [Test]
        public void ExponentisFive()
        {
            Challenge30 challenge = new Challenge30();
            challenge._exponent = 5;
            Assert.AreEqual(443839, challenge.RunChallenge());
        }
    }

}

