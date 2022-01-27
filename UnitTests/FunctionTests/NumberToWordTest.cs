using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Functions;
using NUnit.Framework;
using Functions;
using Xunit.Sdk;


namespace FunctionTests
{
    [TestFixture]
    public class AsAFullWordTest
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
    public class NumberOfCharactersTest
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

}