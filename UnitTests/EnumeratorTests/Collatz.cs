using System.Linq;
using NUnit.Framework;
using Enumerators;
using NuGet.Frameworks;

namespace EnumeratorTests
{
    [TestFixture]
    public class Collatz
    {
        [Test]
        public void CollatzSequence()
        {
            // A Collatz Sequence with input number 13 should result in 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
            long[] collatzSequence = CollatzSeries.Sequence(13).ToArray();
            long[] referenceSequence = { 13, 40, 20, 10, 5, 16, 8, 4, 2, 1 };

            Assert.AreEqual(referenceSequence, collatzSequence);
        }

    }
}