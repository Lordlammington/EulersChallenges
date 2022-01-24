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
            Assert.AreEqual(28, TriangleNumbers.Sequence().Take(7).Last());
        }

        [Test]
        public void EightiethTriangleNumber()
        {
            Assert.AreEqual(3240, TriangleNumbers.Sequence().Take(80).Last());
        }

        [Test]
        public void TriangleNumberThatEquals76576500()
        {
            Assert.AreEqual(3240, TriangleNumbers.Sequence().TakeWhile(x => x <= 76576500).Count());
        }
    }
}