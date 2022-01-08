using System.Linq;
using Challenges;
using NUnit.Framework;



namespace ProjectEuler.Challenge2
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestFibb()
        {
            FibonacciSequence fib = new FibonacciSequence();
            int result = fib.Take(10).Last();
            Assert.AreEqual(89,result);
        }
    }
}
