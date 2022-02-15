using System.Numerics;
using Challenges;
using NUnit.Framework;

namespace Challenges1To10
{
    [TestFixture]
    class Challenge1Tests
    {
        [Test]
        public void Til10()
        {
            var challenge = new Challenge1 { CalculateUntilNotIncluding = 10 };
            Assert.AreEqual(23, challenge.RunChallenge());
        }

        [Test]
        public void Til1000()
        {
            var challenge = new Challenge1 { CalculateUntilNotIncluding = 1000 };
            Assert.AreEqual(233168, challenge.RunChallenge());
        }

    }

    [TestFixture]
    class Challenge2Tests
    {
        [Test]
        public void SumOfFirst10TermsEven()
        {
            var challenge = new Challenge2() { MaxFibValue = 90};
            Assert.AreEqual(44, challenge.RunChallenge());

        }

        [Test]
        public void SumOfevenbelow4000000()
        {
            var challenge = new Challenge2() { MaxFibValue = 4000000 };
            Assert.AreEqual(4613732, challenge.RunChallenge());

        }

    }

    [TestFixture]
    class Challenge3Tests
    {
        //13195 are 5, 7, 13 and 29.
        [Test]
        public void LargestFactorOf13195()
        {
            var challenge = new Challenge3() { InputNumber = 13195 };
            Assert.AreEqual(29, challenge.RunChallenge());
        }

        [Test]
        public void LargestFactorOf600851475143()
        {
            var challenge = new Challenge3() { InputNumber = 600851475143 };
            Assert.AreEqual(6857, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge4Tests
    {
        [Test]
        public void Largest3DigitPalindrome()
        {
            var challenge = new Challenge4();
            Assert.AreEqual(906609, challenge.RunChallenge());
        }


    }

    [TestFixture]
    class Challenge5Tests
    {
        //13195 are 5, 7, 13 and 29.
        [Test]
        public void LargestDivisorOf10natNums()
        {

            var challenge = new Challenge5() { Divisors = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } } ;

            Assert.AreEqual(2520, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge6Tests
    {
        [Test]
        public void Challenge6()
        {

            Challenge6 challenge = new Challenge6();
            Assert.AreEqual(10, challenge.RunChallenge());
        }
    }
    
    [TestFixture]
    class Challenge7Tests
    {
        [Test]
        public void Challenge7()
        {

            Challenge7 challenge = new Challenge7();
            Assert.AreEqual(10, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge8Tests
    {
        [Test]
        public void Test4Adjacents()
        {
            Challenge8 challenge8 = new Challenge8();
            challenge8.NumberOfAdjacent = 4;
            Assert.AreEqual(5832, challenge8.RunChallenge());
        }

        [Test]
        public void Test13Adjacents()
        {
            Challenge8 challenge8 = new Challenge8();
            challenge8.NumberOfAdjacent = 13;
            Assert.AreEqual(23514624000, challenge8.RunChallenge());
        }

        [Test]
        public void Test20Adjacents()
        {
            Challenge8 challenge8 = new Challenge8();
            challenge8.NumberOfAdjacent = 20;
            Assert.AreEqual(240789749760000, challenge8.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge9Tests
    {
        [Test]
        public void Challenge9()
        {

            Challenge9 challenge = new Challenge9();
            Assert.AreEqual(10, challenge.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge10Test
    {
        [Test]
        public void SumOfPrimesBelow10()
        {
            Challenge10 challenge10 = new Challenge10();
            challenge10.CountUpTo = 10;
            Assert.AreEqual(17, challenge10.RunChallenge());
        }

        [Test]
        public void SumOfPrimesBelow2Million()
        {
            Challenge10 challenge10 = new Challenge10();
            challenge10.CountUpTo = 2000000;
            Assert.AreEqual(142913828922, challenge10.RunChallenge());
        }


    }
}
