using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enumerators;
using ProjectEuler;

namespace Challenges
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// Find the sum of all the primes below two million.
    /// </summary>
    public class Challengex10 : IRunChallenge
    {
        public long _CountUpTo;
        public long RunChallenge()
        {
            return PrimeNumbers.Sequence().TakeWhile(x => x < (int)_CountUpTo).Sum();
        }
    }
}
