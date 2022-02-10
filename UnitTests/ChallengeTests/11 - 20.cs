using NUnit.Framework;
using Challenges;
using System;

namespace Challenges11To20
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

    [TestFixture]
    public class Challenge12Test
    {
        [Test]
        public void TriangleNumberWith5Divisors()
        {
            Challenge12 challenge12 = new Challenge12();
            challenge12._UpToDivisors = 5;
            Assert.AreEqual(28, challenge12.RunChallenge());
        }

        [Test]
        public void TriangleNumberWith50Divisors()
        {
            Challenge12 challenge12 = new Challenge12();
            challenge12._UpToDivisors = 50;
            Assert.AreEqual(25200, challenge12.RunChallenge());
        }

        [Test]
        public void TriangleNumberWith500Divisors()
        {
            Challenge12 challenge12 = new Challenge12();
            challenge12._UpToDivisors = 500;
            Assert.AreEqual(28, challenge12.RunChallenge());
        }
    }

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

    [TestFixture]
    class Challenge14Test
    {
        [Test]
        public void LongestSequenceBelow10()
        {
            Challenge14 challenge14 = new Challenge14();
            challenge14._InputNumber = 10;
            //The longest collatz conjecture below 10 is 9, with 19 steps - Wikipedia.
            Assert.AreEqual(9, challenge14.RunChallenge());
        }

        [Test]
        public void LongestSequenceBelow1000000()
        {
            Challenge14 challenge14 = new Challenge14();
            challenge14._InputNumber = 1000000;
            //The longest collatz conjecture below 1000000 is ...
            Assert.AreEqual(837799, challenge14.RunChallenge());
        }

    }

    [TestFixture]
    class Challenge15Test
    {
        [Test]
        public void SizeTwoSquareNavigation()
        {
            Challenge15 challenge = new Challenge15();
            challenge._SizeOfSquare = 2;
            Assert.AreEqual(6, challenge.RunChallenge());
        }


        [Test]
        public void SizeTwentySquareNavigation()
        {
            Challenge15 challenge = new Challenge15();
            challenge._SizeOfSquare = 20;
            Assert.AreEqual(137846528820, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge16Test
    {
        [Test]
        public void TwoToThePowerOf15()
        {
            Challenge16 challenge = new Challenge16();
            challenge._ToThePowerOf = 15;
            Assert.AreEqual(26, challenge.RunChallenge());
        }
        [Test]
        public void TwoToThePowerOf1000()
        {
            Challenge16 challenge = new Challenge16();
            challenge._ToThePowerOf = 1000;
            Assert.AreEqual(1366, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge17Test
    {
        [Test]
        public void NumberLetterCountsTo5()
        {
            Challenge17 challenge = new Challenge17();
            challenge._CalculateInclusive = 5;
            Assert.AreEqual(19, challenge.RunChallenge());
        }
        [Test]
        public void NumberLetterCountsTo1000()
        {
            Challenge17 challenge = new Challenge17();
            challenge._CalculateInclusive = 1000;
            Assert.AreEqual(21124, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge18Test
    {
        [Test]
        public void TrianglePaths()
        {
            Challenge18 challenge = new Challenge18();
            Assert.AreEqual(10, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge19Test
    {
        [Test]
        public void Sundaysin100Years()
        {

            Challenge19 challenge = new Challenge19();

            challenge._StartDate = new DateTime(1901, 1, 1);
            challenge._EndDate = new DateTime(2000, 12, 31);

            Assert.AreEqual(171, challenge.RunChallenge());
        }

        [Test]
        public void Sundaysin1Year()
        {

            Challenge19 challenge = new Challenge19();

            challenge._StartDate = new DateTime(2020, 1, 1);
            challenge._EndDate = new DateTime(2020, 12, 31);

            Assert.AreEqual(2, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge20Test
    {
        [Test]
        public void FalctorialOf10Digits()
        {
            Challenge20 challenge = new Challenge20();
            challenge._FactorialDigits = 10;
            Assert.AreEqual(27, challenge.RunChallenge());
        }

        [Test]
        public void FalctorialOf100Digits()
        {
            Challenge20 challenge = new Challenge20();
            challenge._FactorialDigits = 100;
            Assert.AreEqual(648, challenge.RunChallenge());
        }
    }

}
