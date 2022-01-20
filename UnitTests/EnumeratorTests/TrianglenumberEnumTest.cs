using System.Linq;
using Enumerators;
using NuGet.Frameworks;
using NUnit.Framework;

namespace EnumeratorTests
{
    [TestFixture]
    public class TrianglenumberEnum
    {
        [Test]
        public void SeventhTriangleNumber()
        {
            TriangleNumbers triangleNumbers = new TriangleNumbers();
            Assert.AreEqual(28, triangleNumbers.Take(7).Last());
        }

        [Test]
        public void EightiethTriangleNumber()
        {
            TriangleNumbers triangleNumbers = new TriangleNumbers();
            Assert.AreEqual(3240, triangleNumbers.Take(80).Last());
        }
    }
}