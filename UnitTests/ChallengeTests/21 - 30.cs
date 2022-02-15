using Challenges;
using NUnit.Framework;

namespace Challenges21To30
{
    [TestFixture]
    internal class TestChallenge21
    {
        [Test]
        public void Amicable()
        {
            var challenge = new Challenge21();
            Assert.AreEqual(31626, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge22
    {
        [Test]
        public void NameScores()
        {
            var challenge = new Challenge22();
            Assert.AreEqual(871198282, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge23
    {
        [Test]
        public void NonAbundantSums()
        {
            var challenge = new Challenge23();
            Assert.AreEqual(4179871, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge24
    {
        [Test]
        public void Template()
        {
            var challenge = new Challenge24();
            Assert.AreEqual(10, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge25
    {
        [Test]
        public void Template()
        {
            var challenge = new Challenge25();
            Assert.AreEqual(4782, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge26
    {
        [Test]
        public void ReciprocalCycles()
        {
            var challenge = new Challenge26();
            Assert.AreEqual(983, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge27
    {
        [Test]
        public void QuadraticPrimes()
        {
            var challenge = new Challenge27();
            Assert.AreEqual(-59231, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge28
    {

        [Test]
        public void FiveGridSize()
        {
            var challenge = new Challenge28
            {
                sizeofGrid = 5
            };
            Assert.AreEqual(101, challenge.RunChallenge());
        }

        [Test]
        public void OneThousandGridSize()
        {
            var challenge = new Challenge28
            {
                sizeofGrid = 1001
            };
            Assert.AreEqual(669171001, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge29
    {
        [Test]
        public void OneHundred()
        {
            var challenge = new Challenge29 { Ceiling = 100 };
            Assert.AreEqual(9183, challenge.RunChallenge());
        }

        [Test]
        public void Five()
        {
            var challenge = new Challenge29 { Ceiling = 5 };
            Assert.AreEqual(15, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge30
    {
        [Test]
        public void ExponentIs4()
        {
            var challenge = new Challenge30 { Exponent = 4 };
            Assert.AreEqual(19316, challenge.RunChallenge());
        }

        [Test]
        public void ExponentIs5()
        {
            var challenge = new Challenge30 { Exponent = 5 };
            Assert.AreEqual(443839, challenge.RunChallenge());
        }
    }
}