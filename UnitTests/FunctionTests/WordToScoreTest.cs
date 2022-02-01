using Functions;
using NUnit.Framework;

namespace FunctionTests
{
    [TestFixture]
    public class WordToScoreTest
    {
        [Test]
        public void TestColin()
        {
            Assert.AreEqual(53, Word.wordToScore("COLIN"));
        }
    }
}