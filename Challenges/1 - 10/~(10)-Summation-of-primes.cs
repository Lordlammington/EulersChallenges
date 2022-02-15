using System.Linq;
using System.Numerics;
using Enumerators;
using ProjectEuler;

namespace Challenges
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// Find the sum of all the primes below two million.
    /// </summary>
    public class Challenge10 : IRunChallenge
    {
        public long CountUpTo;
        public BigInteger RunChallenge()
        {
            return PrimeNumbers.Sequence().TakeWhile(x => x < (int) CountUpTo).Aggregate(BigInteger.Add);
        }
    }
}
    