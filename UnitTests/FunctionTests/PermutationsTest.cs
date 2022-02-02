using NUnit.Framework;
using ProjectEuler.Enumerators;
using Functions;

namespace EnumeratorTests
{
    [TestFixture]
    public class PermutationsTest
    {
        [Test]
        public void Test012()
        {
            Permutations.SequenceOfAll("012");
        }
    }
}