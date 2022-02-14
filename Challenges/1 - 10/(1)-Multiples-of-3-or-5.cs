using System;
using System.Linq;
using System.Numerics;
using ProjectEuler;
using Enumerators;

namespace Challenges
{
    public class Challenge1 : IRunChallenge
    {
        public int CalculateUntilNotIncluding { get; set; }
        public BigInteger RunChallenge()
        {
            return NaturalNumbers.Sequence()
                .TakeWhile(x => x < CalculateUntilNotIncluding)
                .Where(x => (x % 3 == 0) || x % 5 == 0)
                .Aggregate(BigInteger.Add); ;
        }
    }
}
