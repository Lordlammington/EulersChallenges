using Challenges;
using NUnit.Framework;

namespace Challenges1To10
{
    [TestFixture]
    class Challenge1Tests
    {
        [Test]
        public void TestMultiples()
        {

            Challenge1 challenge1 = new Challenge1();
            challenge1.CalculateUntilNotIncluding = 10;

            long result = challenge1.RunChallenge();

            Assert.AreEqual(23, result);
        }

        [Test]
        public void TestResult()
        {

            Challenge1 challenge1 = new Challenge1();
            challenge1.CalculateUntilNotIncluding = 1000;

            long result = challenge1.RunChallenge();

            Assert.AreEqual(233168, result);
        }

    }

    [TestFixture]
    class Challenge2Tests
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

    [TestFixture]
    class Challenge3Tests
    {
        //13195 are 5, 7, 13 and 29.
        [Test]
        public void FactorOfFirst10Primes()
        {
            Challenge3 challenge3 = new Challenge3();
            challenge3.InputNumber = 13195;
            Assert.AreEqual(29, challenge3.RunChallenge());
        }
    }

    [TestFixture]
    class Challenge4Tests
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

    [TestFixture]
    class Challenge5Tests
    {
        //13195 are 5, 7, 13 and 29.
        [Test]
        public void LargestDivisorOf10natNums()
        {

            Challenge5 challenge = new Challenge5();
            challenge._Divisors = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

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
            Challengex10 challenge10 = new Challengex10();
            challenge10._CountUpTo = 10;
            Assert.AreEqual(17, challenge10.RunChallenge());
        }

        [Test]
        public void SumOfPrimesBelow2Million()
        {
            Challengex10 challenge10 = new Challengex10();
            challenge10._CountUpTo = 2000000;
            Assert.AreEqual(142913828922, challenge10.RunChallenge());
        }


    }
}
