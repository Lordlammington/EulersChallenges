using NUnit.Framework;
using Challenges;
using System;

namespace Challenges11To20
{
    [TestFixture]
    internal class TestChallenge11 {
        [Test]
        public void Test4Adjacent()
        {
            var challenge = new Challenge11 { AdjacentToFind = 4 };
            Assert.AreEqual(70600674, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge12
    {
        [Test]
        public void TriangleNumberWith5Divisors()
        {
            var challenge = new Challenge12{ _UpToDivisors = 5};
            Assert.AreEqual(28, challenge.RunChallenge());
        }

        [Test]
        public void TriangleNumberWith50Divisors()
        {
            var challenge = new Challenge12{ _UpToDivisors = 50};
            Assert.AreEqual(25200, challenge.RunChallenge());
        }

        [Test]
        public void TriangleNumberWith500Divisors()
        {
            var challenge = new Challenge12{ _UpToDivisors = 500};
            Assert.AreEqual(28, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge13
    {
        [Test]
        public void First10DigitsOfNumber()
        {
            var challenge = new Challenge13{ HowManyFirstDigits =  10};
            Assert.AreEqual(5537376230, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge14
    {
        [Test]
        public void LongestSequenceBelow10()
        {
            var challenge14 = new Challenge14{ InputNumber = 10};
            //The longest Collatz conjecture below 10 is 9, with 19 steps - Wikipedia.
            Assert.AreEqual(9, challenge14.RunChallenge());
        }

        [Test]
        public void LongestSequenceBelow1000000()
        {
            var challenge14 = new Challenge14{ InputNumber = 1000000 };
            //The longest Collatz conjecture below 1000000 is ...
            Assert.AreEqual(837799, challenge14.RunChallenge());
        }

    }

    [TestFixture]
    internal class TestChallenge15
    {
        [Test]
        public void SizeTwoSquareNavigation()
        {
            var challenge = new Challenge15{SizeOfSquare = 2};
            Assert.AreEqual(6, challenge.RunChallenge());
        }


        [Test]
        public void SizeTwentySquareNavigation()
        {
            var challenge = new Challenge15{SizeOfSquare = 20}; 
            Assert.AreEqual(137846528820, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge16
    {
        [Test]
        public void TwoToThePowerOf15()
        {
            var challenge = new Challenge16{ToThePowerOf = 15};
            Assert.AreEqual(26, challenge.RunChallenge());
        }
        [Test]
        public void TwoToThePowerOf1000()
        {
            var challenge = new Challenge16{ToThePowerOf = 1000};
            Assert.AreEqual(1366, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge17
    {
        [Test]
        public void NumberLetterCountsTo5()
        {
            var challenge = new Challenge17{CalculateInclusive = 5};
            Assert.AreEqual(19, challenge.RunChallenge());
        }
        [Test]
        public void NumberLetterCountsTo1000()
        {
            var challenge = new Challenge17{CalculateInclusive =  1000};
            Assert.AreEqual(21124, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge18
    {
        [Test]
        public void TrianglePaths()
        {
            var challenge = new Challenge18();
            Assert.AreEqual(10, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge19
    {
        [Test]
        public void SundaysIn100Years()
        {

            var challenge = new Challenge19
            {
                _StartDate = new DateTime(1901, 1, 1),
                _EndDate = new DateTime(2000, 12, 31)
            };

            Assert.AreEqual(171, challenge.RunChallenge());
        }

        [Test]
        public void SundaysIn1Year()
        {

            var challenge = new Challenge19
            {
                _StartDate = new DateTime(2020, 1, 1),
                _EndDate = new DateTime(2020, 12, 31)
            };

            Assert.AreEqual(2, challenge.RunChallenge());
        }
    }

    [TestFixture]
    internal class TestChallenge20
    {
        [Test]
        public void FactorialOf10Digits()
        {
            var challenge = new Challenge20 { _FactorialDigits = 10 };
            Assert.AreEqual(27, challenge.RunChallenge());
        }

        [Test]
        public void FactorialOf100Digits()
        {
            var challenge = new Challenge20 { _FactorialDigits = 100 };
            Assert.AreEqual(648, challenge.RunChallenge());
        }
    }

}
