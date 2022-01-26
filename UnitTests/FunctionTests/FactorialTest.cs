using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Functions;
using NUnit.Framework;

namespace FunctionTests
{
    [TestFixture]
    class FactorialTest
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
}
