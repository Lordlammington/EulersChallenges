using NUnit.Framework;
using Enumerators;
using System.Linq;
using System.Numerics;

namespace EnumeratorTests
{
    [TestFixture]
    public class TestCollatzSequence
    {
        [Test]
        public void Thirteen()
        {
            // A Collatz Sequence with input number 13 should result in 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
            BigInteger[] collatzSequence = CollatzSeries.Sequence(13).ToArray();
            BigInteger[] referenceSequence = { 13, 40, 20, 10, 5, 16, 8, 4, 2, 1 };

            Assert.AreEqual(referenceSequence, collatzSequence);
        }
    }

    [TestFixture]
    public class TestOneDigitProduct
    {
        [Test]
        public void TestFirstNumber()
        {
            //First Number should be 10000 ( 100 * 100 )
            Assert.AreEqual(1, AllProducts.OneDigitProducts().Min());
        }

        [Test]
        public void TestLastNumber()
        {
            //First Number should be 99801 ( 999 * 999 )
            Assert.AreEqual(81, AllProducts.OneDigitProducts().Max());
        }
    }

    [TestFixture]
    public class TestTwoDigitProduct
    {
        [Test]
        public void TestFirstNumber()
        {
            //First Number should be 10000 ( 100 * 100 )
            Assert.AreEqual(100, AllProducts.TwoDigitProducts().Min());
        }

        [Test]
        public void TestLastNumber()
        {
            //First Number should be 99801 ( 999 * 999 )
            Assert.AreEqual(9801, AllProducts.TwoDigitProducts().Max());
        }
    }

    [TestFixture]
    public class TestThreeDigitProduct
    {
        [Test]
        public void TestFirstNumber()
        {
            //First Number should be 10000 ( 100 * 100 )
            Assert.AreEqual(10000, AllProducts.ThreeDigitProducts().Min());
        }

        [Test]
        public void TestLastNumber()
        {
            //First Number should be 99801 ( 999 * 999 )
            Assert.AreEqual(998001, AllProducts.ThreeDigitProducts().Max());
        }

    }

    [TestFixture]
    public class TestFibonacci
    {
        [Test]
        public void Test50thFibonacci()
        {
            var result = Fibonacci.Sequence().Take(50).Last();
            Assert.AreEqual(12586269025, result);
        }

        [Test]
        public void Test20thFibonacci()
        {
            var result = Fibonacci.Sequence().Take(20).Last();
            Assert.AreEqual(6765, result);
        }

        [Test]
        public void First12Fibonacci()
        {
            var expected = new BigInteger[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            var result = Fibonacci.Sequence().Take(12);

            Assert.AreEqual(expected, result);
        }
    }

    [TestFixture]
    public class TestNaturalNumber
    {
        [Test]
        public void OneHundred()
        {
            Assert.AreEqual(100, NaturalNumbers.Sequence().Skip(99).First());
        }

        [Test]
        public void SixtyNinth()
        {
            Assert.AreEqual(69, NaturalNumbers.Sequence().Skip(68).First());
            //Nice
        }
    }

    [TestFixture]
    public class TestPrimeNumber
    {
        [Test]
        public void Fifth()
        {
            Assert.AreEqual(11, PrimeNumbers.Sequence().Take(5).Last());
        }

        [Test]
        public void Sixtieth()
        {
            Assert.AreEqual(281, PrimeNumbers.Sequence().Take(60).Last());
        }
    }

    [TestFixture]
    public class TestSpiralNumber
    {
        [Test]
        public void SpiralSequence()
        {
            var SpiralSequence = SpiralNumberCorners.Sequence().Take(10).ToArray();
            var referenceSequence = new long[]{ 1, 3, 5, 7, 9, 13, 17, 21, 25, 31 };

            Assert.AreEqual(referenceSequence, SpiralSequence);
        }
    }

    [TestFixture]
    public class TestTriangleNumber
    {
        [Test]
        public void Seventh()
        {
            Assert.AreEqual(28, TriangleNumbers.Sequence().Take(7).Last());
        }

        [Test]
        public void Eightieth()
        {
            Assert.AreEqual(3240, TriangleNumbers.Sequence().Take(80).Last());
        }
    }

}