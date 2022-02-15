using System;
using System.Linq;
using System.Numerics;
using Enumerators;
using ProjectEuler;

namespace Challenges
{
    public class Challenge3 : IRunChallenge
    {
        public long InputNumber { get; set; }
        public BigInteger RunChallenge()
        {
            return NaturalNumberCountdown
                .Sequence((long)Math.Ceiling(Math.Sqrt(InputNumber)))
                    .Where(x => InputNumber % x == 0)
                    .Where(PrimeNumbers.CheckForPrime)
                    .First();

        }
    }
}
