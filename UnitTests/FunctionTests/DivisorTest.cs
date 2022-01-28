using Functions;
using NUnit.Framework;


namespace FunctionTests
{
    [TestFixture]
    public class DivisorTest
    {
        [Test]
        public void DivisorsOf10()
        {
            Assert.AreEqual(4, Divisors.Count(10));
        }

        [Test]
        public void DivisorsOf800()
        {
            Assert.AreEqual(18, Divisors.Count(800));
        }

        [Test]
        public void DivisorsOf97() //Prime Number
        {
            Assert.AreEqual(2, Divisors.Count(97));
        }

        [Test]
        public void DivisorListOf10()
        {
            var divlist = Divisors.List(10);
            Assert.AreEqual(4, divlist.Count);
        }

        [Test]
        public void DivisorListOf800()
        {
            var divlist = Divisors.List(800);
            Assert.AreEqual(18, divlist.Count);
        }

        [Test]
        public void DivisorListOf97() //Prime Number
        {
            var divlist = Divisors.List(97);
            Assert.AreEqual(2, divlist.Count);
        }
    }
}