using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Challenges
{
    [TestFixture]
    class Challenge2Test
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
    
}
