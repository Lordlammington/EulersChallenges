using System.Linq;
using System.Numerics;
using ProjectEuler;
using Enumerators;

namespace Challenges
{
    public class Challenge2 : IRunChallenge
    {
        public int MaxFibValue { get; set; }
        public BigInteger RunChallenge()
        {
            return Fibonacci.Sequence()
                            .TakeWhile(number => number < MaxFibValue)
                            .Where(x => x % 2 == 0)
                            .Aggregate(BigInteger.Add); ;
        }
    }
}
