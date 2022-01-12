﻿using System.Linq;
using Challenges;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEuler
{
    [TestFixture]
    public class FibbonacciEnumTest
    {
        [Test]
        public void Test10thFibbonacci()
        {
            FibonacciSequence fib = new FibonacciSequence();
            int result = fib.Take(9).Last();
            Assert.AreEqual(55, result);
        }

        [Test]
        public void Test20thFibbonacci()
        {
            FibonacciSequence fib = new FibonacciSequence();
            int result = fib.Take(19).Last();
            Assert.AreEqual(6765, result);
        }


    }
}
