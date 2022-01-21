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

        [Test]
        public void TriangleNumberThatEquals76576500()
        {
            TriangleNumbers triangleNumbers = new TriangleNumbers();
            long foo = triangleNumbers.TakeWhile(x => x <= 76576500).Count();
            Assert.AreEqual(3240, foo);
        }
    }
}