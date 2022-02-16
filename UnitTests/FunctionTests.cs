using NUnit.Framework;
using System;
using System.Numerics;
using Enumerators;
using Functions;

namespace FunctionTests
{
    [TestFixture]
    internal class AmicableNumberTest
    {
        [Test]
        public static void FirstAmicableNumber()
        {
            Assert.AreEqual(true, AmicableNumbers.IsAmicable(220, 284));
        }

        [Test]
        public static void SecondAmicableNumber()
        {
            Assert.AreEqual(true, AmicableNumbers.IsAmicable(1184, 1210));
        }

        [Test]
        public static void ImpostorNumber()
        {
            Assert.AreEqual(false, AmicableNumbers.IsAmicable(4849, 3822));
        }
    }

    [TestFixture]
    internal class DivisorTest
    {
        [Test]
        public void DivisorsOf10()
        {
            Assert.AreEqual(4, Divisors.Count(10));
        }

        [Test]
        public void DivisorsOf800()
        {
            Assert.AreEqual(18, Divisors.Count(800));
        }

        [Test]
        public void DivisorsOf97() //Prime Number
        {
            Assert.AreEqual(2, Divisors.Count(97));
        }

        [Test]
        public void DivisorListOf10()
        {
            var divlist = Divisors.List(10);
            Assert.AreEqual(4, divlist.Count);
        }

        [Test]
        public void DivisorListOf800()
        {
            var divlist = Divisors.List(800);
            Assert.AreEqual(18, divlist.Count);
        }

        [Test]
        public void DivisorListOf97() //Prime Number
        {
            var divlist = Divisors.List(97);
            Assert.AreEqual(2, divlist.Count);
        }

        [Test]
        public void TestForPerfectNumberTrue() //Prime Number
        {
            Assert.AreEqual(true, Divisors.IsPerfectNumber(28));
        }

        [Test]
        public void TestForPerfectNumberFalse() //Prime Number
        {
            Assert.AreEqual(false, Divisors.IsPerfectNumber(37));
        }
    }

    [TestFixture]
    internal class FactorialTest
    {
        [Test]
        public void FiveFactorial()
        {
            Assert.AreEqual(120, (long)Factorial.FactorialOf(5));
        }

        [Test]
        public void ZeroFactorial()
        {
            Assert.AreEqual(1, (long)Factorial.FactorialOf(0));
        }

        [Test]
        public void NegativeFactorial()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Factorial.FactorialOf(-1));

        }


    }

    [TestFixture]
    internal class InputNumberAsTest
    {
        [Test]
        public void HowManyDigitsin100()
        {
            Assert.AreEqual(3, InputNumberAs.CountOfDigits(100));
        }

        [Test]
        public void HowManyDigitsin185698590()
        {
            Assert.AreEqual(9, InputNumberAs.CountOfDigits(185698590));
        }
    }

    [TestFixture]
    internal class AsAFullWordTest
    {
        [Test]
        public void WhatIs17()
        {
            Assert.AreEqual("Seventeen", NumberToWord.AsAFullWord(17));
        }

        [Test]
        public void WhatIs89()
        {
            Assert.AreEqual("Eighty Nine", NumberToWord.AsAFullWord(89));
        }

        [Test]
        public void WhatIs165()
        {
            Assert.AreEqual("One Hundred and Sixty Five", NumberToWord.AsAFullWord(165));
        }
    }

    [TestFixture]
    internal class NumberOfCharactersTest
    {
        [Test]
        public void WhatIs17Length()
        {
            Assert.AreEqual(9, NumberToWord.NumberOfCharacters(17));
        }
        [Test]
        public void WhatIs89Length()
        {
            Assert.AreEqual(10, NumberToWord.NumberOfCharacters(89));
        }

        [Test]
        public void WhatIs165Length()
        {
            Assert.AreEqual(22, NumberToWord.NumberOfCharacters(165));
        }
    }

    [TestFixture]
    internal class PermutationsTest
    {
        [Test]
        public void Test012()
        {
            string str = "012";

            Permutations.Start(str);
            var allcomb = Permutations._Combinations;

            Assert.AreEqual(6, allcomb.Count);
        }
    }

    [TestFixture]
    internal class WordToScoreTest
    {
        [Test]
        public void TestColin()
        {
            Assert.AreEqual(53, Word.WordToScore("COLIN"));
        }
    }

    [TestFixture]
    internal class ExponentTest
    {
        [Test]
        public static void SquareOf2()
        {
            Assert.AreEqual((BigInteger)4, Exponents.Square(2));
        }

        [Test]
        public static void CubeOf16()
        {
            Assert.AreEqual((BigInteger)4096, Exponents.Cube(16));
        }

        [Test]
        //Current population of earth BTW 
        public static void SquareOf7927059129()
        {
            var expected = BigInteger.Parse("62838266434662238641");
            Assert.AreEqual(expected, Exponents.Square(7927059129));
        }

        [Test]
        public static void ThreeToThePowerOf5()
        {
            Assert.AreEqual((BigInteger)243, Exponents.Solve(3, 5));
        }

        [Test]
        public static void BigCalculation()
        {
            //This is a very big number.
            var expected = BigInteger.Parse("15903294255828311271423845505393160821806695428583614352106288981387880656772632026018897226366976");
            Assert.AreEqual(expected, Exponents.Solve(72456, 20));
        }
    }
}

