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
            string str = "012";

            Permutations.Start(str);
            var allcomb = Permutations._Combinations;

            Assert.AreEqual(6, allcomb.Count);
        }
    }
}