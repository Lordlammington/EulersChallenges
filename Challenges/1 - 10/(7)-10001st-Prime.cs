using System.Linq;
using System.Numerics;
using Enumerators;
using ProjectEuler;

namespace Challenges
{
    public class Challenge7 : IRunChallenge
    {
        public BigInteger RunChallenge()
        {
            return PrimeNumbers.Sequence().Skip(10000).First();
        }
    }
}
