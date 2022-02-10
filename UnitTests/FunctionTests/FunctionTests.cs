using NUnit.Framework;
using ProjectEuler.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerUnitTests.FunctionTests
{
    class FunctionTests
    {

        [TestFixture]
        class AmicableNumberTest
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
    }
}
