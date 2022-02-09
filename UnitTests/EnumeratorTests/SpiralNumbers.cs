using System.Linq;
using NUnit.Framework;
using Enumerators;
using NuGet.Frameworks;
using ProjectEuler.Enumerators;

namespace EnumeratorTests
{
    [TestFixture]
    public class SpiralNumberTest
    {
        [Test]
        public void SpiralSequence()
        {
            //Corners of a spiral sequence should be 1, 3, 5, 7, 9, 13, 17, 21, 25, 31
            long[] SpiralSequence = SpiralNumberCorners.Sequence().Take(10).ToArray();
            long[] referenceSequence = { 1, 3, 5, 7, 9, 13, 17, 21, 25, 31 };

            Assert.AreEqual(referenceSequence, SpiralSequence);
        }

    }
}