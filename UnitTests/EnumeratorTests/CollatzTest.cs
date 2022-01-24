using System.Linq;
using NUnit.Framework;
using Enumerators;
using NuGet.Frameworks;

namespace EnumeratorTests
{
    [TestFixture]
    public class CollatzTest
    {
        [Test]
        public void CollatzSequenceWith13()
        {
            // The Expected Collatz Sequence Should Be 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
            Assert.AreEqual(10, CollatzSeries.Sequence(13).Count());
        }

    }
}