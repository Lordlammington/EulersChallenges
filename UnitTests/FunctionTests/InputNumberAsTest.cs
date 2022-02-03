using Challenges;
using Functions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTests
{
    [TestFixture]
    class InputNumberAsTest
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
}
